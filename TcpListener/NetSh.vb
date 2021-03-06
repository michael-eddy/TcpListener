Imports System.Net.NetworkInformation
Imports System.Runtime.CompilerServices

Module NetSh
    <Extension()>
    Public Function RegistAddress(ip As String) As Boolean
        Dim cmd = $"netsh http add urlacl url={ip} user=Everyone&exit"
        RegistAddress = cmd.Excute()
    End Function
    <Extension()>
    Public Function RegistRemove(ip As String) As Boolean
        Dim cmd = $"netsh http delete urlacl url={ip}&exit"
        RegistRemove = cmd.Excute()
    End Function
    <Extension()>
    Public Function Excute(cmd As String) As Boolean
        Try
            Dim process = New Process()
            process.StartInfo.FileName = "cmd.exe"
            process.StartInfo.UseShellExecute = False
            process.StartInfo.RedirectStandardInput = True
            process.StartInfo.RedirectStandardOutput = True
            process.StartInfo.RedirectStandardError = True
            process.StartInfo.CreateNoWindow = True
            process.Start()
            process.StandardInput.WriteLine(cmd)
            process.StandardInput.AutoFlush = True
            Dim output = process.StandardOutput.ReadToEnd()
            process.WaitForExit()
            process.Close()
            Excute = True
        Catch ex As Exception
            Excute = False
        End Try
    End Function
    <Extension()>
    Public Function IsUsed(port As String) As Boolean
        Dim inUse = False
        Dim portInt = CInt(port)
        Dim ipProperties = IPGlobalProperties.GetIPGlobalProperties()
        Dim ipEndPoints = ipProperties.GetActiveTcpListeners()
        For Each endPoint In ipEndPoints
            If endPoint.Port = portInt Then Exit For
            inUse = True
        Next
        IsUsed = inUse
    End Function
End Module