Imports System.Net
Imports System.Text

Public Class ResponeForm
    Public ErrMessage As String
    Public Respone As HttpListenerResponse
    Private Sub ButtonOK_Click(sender As Object, e As EventArgs) Handles ButtonOK.Click
        Try
            Respone.StatusCode = Convert.ToInt32(ComboBoxStatusCode.Text)
            Respone.ContentType = ComboBoxContentType.Text
            Dim encoding As Encoding
            Select Case ComboBoxEncoding.Text
                Case "utf8"
                    encoding = Encoding.UTF8
                Case "utf16"
                    encoding = Encoding.BigEndianUnicode
                Case "utf32"
                    encoding = Encoding.UTF32
                Case "ascii"
                    encoding = Encoding.ASCII
                Case Else
                    encoding = Encoding.GetEncoding(ComboBoxEncoding.Text.Trim())
            End Select
            Respone.ContentEncoding = encoding
            Select Case ComboBoxBody.SelectedIndex
                Case 0
                    Dim byteChars = TextBoxBody.Text.Replace("，", ",").Split(",")
                    Dim idx As Long, length = byteChars.Length - 1
                    Dim bytes = New Byte(length) {}
                    For idx = 0 To length
                        Dim byteChar = byteChars(idx)
                        Dim byteValue = CInt(byteChar)
                        bytes(idx) = byteValue
                    Next
                    Respone.OutputStream.Write(bytes)
                Case 1
                    Dim bytes = encoding.GetBytes(TextBoxBody.Text)
                    Respone.OutputStream.Write(bytes)
            End Select
            Respone.Close()
            DialogResult = DialogResult.OK
        Catch ex As Exception
            DialogResult = DialogResult.Cancel
            ErrMessage = "操作失败," + ex.Message
        End Try
        Close()
    End Sub
    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        DialogResult = DialogResult.Cancel
        Close()
    End Sub
    Private Sub ResponeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBoxBody.SelectedIndex = 0
        ComboBoxEncoding.SelectedIndex = 0
        ComboBoxStatusCode.SelectedIndex = 2
        ComboBoxContentType.SelectedIndex = 4
    End Sub
End Class