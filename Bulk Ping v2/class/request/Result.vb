Imports System.Globalization
Imports System.Threading
Imports NLog
Public Class Result
    Private Shared logger As Logger = LogManager.GetCurrentClassLogger()
    Public Shared Sub CalculateResult(rState As ResultObj)
        Try

            If Not rState.LinkObject.Link = Nothing Then

                If rState.Status = "[Success]" Then
                    rState.LinkObject.Successful += 1
                    rState.LinkObject.Backcolor = Color.DarkGreen
                    Interlocked.Increment(Stats.SuccessfulPing)
                Else
                    Interlocked.Increment(Stats.FailedPing)
                End If
                Dim time As Date = My.Computer.Clock.LocalTime
                rState.LinkObject.Update = "Pinged " & time.ToString("MM/dd/yyyy HH:mm:ss", CultureInfo.CreateSpecificCulture("en-US"))
                Interlocked.Increment(Stats.SentPing)
                Interlocked.Increment(Stats.SentPingMin)
            End If
        Catch ex As Exception
            logger.Error(ex.ToString)
        End Try
    End Sub

    Public Shared Sub CalculateResultBacklink(rState As ResultObj)
        Try

            If Not rState.LinkObject.Link = Nothing Then

                If rState.Status = "[Success]" Then
                    rState.LinkObject.SuccessfulBacklinks += 1
                    rState.LinkObject.Backcolor = Color.DarkGreen
                    Interlocked.Increment(Stats.SuccessfulPing)
                Else
                    Interlocked.Increment(Stats.FailedPing)
                End If
                Dim time As Date = My.Computer.Clock.LocalTime
                rState.LinkObject.Update = "Pinged " & time.ToString("MM/dd/yyyy HH:mm:ss", CultureInfo.CreateSpecificCulture("en-US"))
                Interlocked.Increment(Stats.SentPing)
                Interlocked.Increment(Stats.SentPingMin)
            End If
        Catch ex As Exception
            logger.Error(ex.ToString)
        End Try
    End Sub

End Class
