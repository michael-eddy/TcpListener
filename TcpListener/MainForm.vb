Imports System.IO
Imports System.Net
Imports System.Text
Imports System.Threading
Imports Newtonsoft.Json

Public Class MainForm
    Public ListenerUri As String
    Public Listener As HttpListener
    Public Sub New()
        InitializeComponent()
        CheckForIllegalCrossThreadCalls = False
    End Sub
    Private Sub buttonStart_Click(sender As Object, e As EventArgs) Handles buttonStart.Click
        Try
            If String.IsNullOrEmpty(textBoxUrl.Text) = False Then
                ListenerUri = $"http://*:{textBoxUrl.Text}/"
                If NetSh.IsUsed(textBoxUrl.Text) Then
                    textBoxOutput.Text += $"{textBoxUrl.Text}端口已被占用！{Environment.NewLine}"
                    textBoxUrl.Text = "0"
                Else
                    If IsNothing(Listener) = False Then
                        NetSh.RegistRemove(ListenerUri)
                        Listener.Close()
                    End If
                    Listener = New HttpListener()
                    If NetSh.RegistAddress(ListenerUri) = True Then
                        Thread.Sleep(200)
                        Listener.AuthenticationSchemes = AuthenticationSchemes.Anonymous
                        Listener.Prefixes.Add(ListenerUri)
                        Listener.Start()
                        Dim CallBackDelegate As AsyncCallback = AddressOf ListenerHandle
                        Listener.BeginGetContext(CallBackDelegate, Listener)
                        textBoxOutput.Text += $"监听中....{Environment.NewLine}"
                    Else
                        textBoxOutput.Text += $"注册URL失败！{Environment.NewLine}"
                    End If
                End If
            End If
        Catch ex As Exception
            textBoxOutput.Text += $"连接失败，{ex.Message}{Environment.NewLine}"
        End Try
    End Sub
    Private Sub ListenerHandle(result As IAsyncResult)
        Try
            If String.Equals(result.AsyncState.GetType().Name, "HttpListener", StringComparison.CurrentCultureIgnoreCase) Then
                Listener = CType(result.AsyncState, HttpListener)
                If Listener.IsListening Then
                    Dim CallBackDelegate As AsyncCallback = AddressOf ListenerHandle
                    Listener.BeginGetContext(CallBackDelegate, Listener)
                    Dim context = Listener.EndGetContext(result)
                    Dim request = context.Request
                    Select Case request.HttpMethod
                        Case "POST"
                            Dim stream = context.Request.InputStream
                            Dim reader = New StreamReader(stream, Encoding.UTF8)
                            Dim content = reader.ReadToEnd()
                            textBoxOutput.Text += $"POST收到数据：{content}{Environment.NewLine}"
                        Case "GET"
                            Dim Data = request.QueryString
                            Dim Json = JsonConvert.SerializeObject(Data)
                            textBoxOutput.Text += $"GET收到数据:{Json}{Environment.NewLine}"
                    End Select
                    Dim form = New ResponeForm()
                    form.Respone = context.Response
                    If form.ShowDialog() = DialogResult.OK Then
                        textBoxOutput.Text += $"已回复{Environment.NewLine}"
                    Else
                        textBoxOutput.Text += $"{form.ErrMessage}{Environment.NewLine}"
                    End If
                End If
            End If
        Catch ex As Exception
            textBoxOutput.Text += $"异常:{ex.Message}{Environment.NewLine}"
        End Try
    End Sub
    Private Sub MainForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        CloseListener()
    End Sub
    Private Sub ButtonStop_Click(sender As Object, e As EventArgs) Handles ButtonStop.Click
        CloseListener()
    End Sub
    Private Sub CloseListener()
        Try
            textBoxOutput.Text = String.Empty
            If IsNothing(Listener) = False Then
                NetSh.RegistRemove(ListenerUri)
                Listener.Close()
            End If
        Catch ex As Exception
            textBoxOutput.Text += $"异常:{ex.Message}{Environment.NewLine}"
        End Try
    End Sub
    Private Sub textBoxUrl_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textBoxUrl.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = Chr(8) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub textBoxUrl_TextChanged(sender As Object, e As EventArgs) Handles textBoxUrl.TextChanged
        If String.IsNullOrEmpty(textBoxUrl.Text) = False Then
            Dim port = Convert.ToInt32(textBoxUrl.Text)
            If port < 0 Or port > 65535 Then
                textBoxOutput.Text += $"端口号必须在0-65535的范围内！{Environment.NewLine}"
                textBoxUrl.Text = "0"
            End If
        End If
    End Sub
End Class