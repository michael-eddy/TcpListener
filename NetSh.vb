﻿Public Class NetSh
    Public Shared Function RegistAddress(ip As String) As Boolean
        Dim cmd = $"netsh http add urlacl url={ip} user=Everyone&exit"
        RegistAddress = Excute(cmd)
    End Function
    Public Shared Function RegistRemove(ip As String) As Boolean
        Dim cmd = $"netsh http delete urlacl url={ip}&exit"
        RegistRemove = Excute(cmd)
    End Function
    Public Shared Function Excute(cmd As String) As Boolean
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
End Class