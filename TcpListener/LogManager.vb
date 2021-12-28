Imports System.IO
Imports Serilog
Imports Serilog.Configuration
Imports Serilog.Core

Public NotInheritable Class LogManager
    Private Log As Logger
    Private Sub New()
        Dim action As New Action(Of LoggerSinkConfiguration)(AddressOf FormatString)
        Log = New LoggerConfiguration().MinimumLevel.Debug().WriteTo.Async(action).CreateLogger()
    End Sub
    Private Sub FormatString(configuration As LoggerSinkConfiguration)
        Dim LogFile = Path.Combine(Environment.CurrentDirectory, "tcp_log", "log-.txt")
        configuration.File(LogFile, RollingInterval.Day)
    End Sub
End Class