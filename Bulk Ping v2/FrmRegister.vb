Imports CS2PHPCryptography
Imports NLog
Imports System.Threading

Public Class FrmRegister
    Protected ReadOnly secure As SecurePHPConnection
    Private logger As Logger = LogManager.GetCurrentClassLogger()

    Public Sub New()

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        secure = New SecurePHPConnection()
        secure.SetRemotePhpScriptLocation("https://shop.gsoftwarelab.com/api/licensegsl/")

        AddHandler secure.OnResponseReceived, AddressOf SecureOnResponseReceived
        AddHandler secure.OnConnectionEstablished, AddressOf SecureOnConnectionEstablished
    End Sub

    Private Sub FrmRegister_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Try

            If Version.Check() = False Then
                FrmUpdate.Show()
            End If
            If Not My.Settings.License = Nothing Then
                txtLicenseCode.Text = My.Settings.License
                pbActivate.Value1 = 5
                pbActivate.Text = "Initialization..."
            End If

            secure.EstablishSecureConnectionAsync()


        Catch ex As Exception
            MsgBox("Can't connect to secure server! Please try again later.", MsgBoxStyle.Critical, "Critical Error")
        End Try
    End Sub

    Private Sub SecureOnResponseReceived(sender As Object, e As ResponseReceivedEventArgs)
        Try
            Select Case True
                Case e.Response = Nothing
                    MessageBox.Show("Invaild or expired license, please try it again later!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Case e.Response = "DISCONNECTED"
                    Close()
                Case e.Response = "NOT CONNECTED"
                    Close()
                Case Else
                    If e.Response.Split(CChar("|"))(1) = txtLicenseCode.Text And e.Response.Split(CChar("|"))(0) = Hwid.GetSystemSerialNumber And e.Response.Split(CChar("|"))(3) = Hwid.GetCpuId Then
                        If Application.OpenForms().OfType(Of FrmMain).Any Then
                            FrmMain.Close()
                        End If

                        pbActivate.Value1 = 100
                        Delay(1)
                        pbActivate.Text = "Done..."

                        My.Settings.License = txtLicenseCode.Text
                        Version.LicenseKey = txtLicenseCode.Text

                        If e.Response.Split(CChar("|"))(2) = Version.SoftwareLiteId And e.Response.Split(CChar("|"))(4) = "4496678b8fc899973444a2065e4d6fd510b4725e" Then
                            My.Settings.Lite = True
                            Version.CurrentId = Version.SoftwareLiteId
                        ElseIf e.Response.Split(CChar("|"))(2) = Version.SoftwareId And e.Response.Split(CChar("|"))(4) = "f3534db51ac9c3b29d7efb0e32ff2527da9c0c8d" Then
                            My.Settings.Lite = False
                            Version.CurrentId = Version.SoftwareId
                        Else
                            MessageBox.Show("Invaild or expired license, please try it again later!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If

                        My.Settings.Save()

                        If Version.Vertified Then
                            Version.Vertified = False
                        Else
                            Version.Vertified = True
                        End If

                        secure.CloseConnection()
                        FrmMain.Show()
                    Else
                        If Application.OpenForms().OfType(Of FrmMain).Any Then
                            FrmMain.Close()
                        End If

                        My.Settings.License = Nothing
                        My.Settings.Lite = False
                        My.Settings.Save()


                        pbActivate.Text = "Ups something went wrong..."
                        pbActivate.Value1 = 0
                        MessageBox.Show(My.Resources.errorLicense, My.Resources._error, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
            End Select

        Catch ex As Exception
            logger.Error(ex.ToString)
            MsgBox("Something went wrong!", MsgBoxStyle.Critical, "Critical Error")
        End Try
    End Sub

    Public Sub GetLicense(ByVal lite As Boolean)
        Try
            pbActivate.Visible = True

            If Not txtLicenseCode.Text = Nothing Then

                Thread.Sleep(250)

                If secure.SecureConnectionEstablished Then
                    pbActivate.Value1 = 50

                    If lite Then
                        secure.SendMessageSecureAsync(txtLicenseCode.Text & "|" & Version.SoftwareLiteId & "|" & Hwid.GetCpuId)
                    Else
                        secure.SendMessageSecureAsync(txtLicenseCode.Text & "|" & Version.SoftwareId & "|" & Hwid.GetCpuId)
                    End If

                End If
                pbActivate.Text = "Getting some things done..."
            End If
        Catch ex As Exception
            logger.Error(ex.ToString)
            MsgBox("Something went wrong!", MsgBoxStyle.Critical, "Critical Error")
            Process.Start(Application.StartupPath + "/Updater.exe")
            Application.Exit()
        End Try
    End Sub

    Private Sub SecureOnConnectionEstablished(sender As Object, e As OnConnectionEstablishedEventArgs)
        If Not My.Settings.License = Nothing Then
            txtLicenseCode.Text = My.Settings.License
            GetLicense(My.Settings.Lite)
        End If
    End Sub

    Private Sub BtnActivate_Click(sender As Object, e As EventArgs) Handles btnActivate.Click
        pbActivate.Value1 = 5
        pbActivate.Text = "Initialization..."
        GetLicense(False)
    End Sub

    Private Sub BtnActivateLite_Click(sender As Object, e As EventArgs) Handles btnActivateLite.Click
        pbActivate.Value1 = 5
        pbActivate.Text = "Initialization..."
        GetLicense(True)
    End Sub

    Private Sub PbLogo_Click(sender As Object, e As EventArgs) Handles pbLogo.Click
        Process.Start("https://gsoftwarelab.com")
    End Sub

    Sub Delay(ByVal dblSecs As Double)

        Const OneSec As Double = 1.0# / (1440.0# * 60.0#)
        Dim dblWaitTil As Date
        Now.AddSeconds(OneSec)
        dblWaitTil = Now.AddSeconds(OneSec).AddSeconds(dblSecs)
        Do Until Now > dblWaitTil
            Application.DoEvents() ' Allow windows messages to be processed
        Loop

    End Sub
End Class