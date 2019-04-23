<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRegister
    Inherits Telerik.WinControls.UI.RadForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRegister))
        Me.MetroTheme = New Telerik.WinControls.Themes.TelerikMetroTheme()
        Me.pbLogo = New System.Windows.Forms.PictureBox()
        Me.pbActivate = New Telerik.WinControls.UI.RadProgressBar()
        Me.btnActivateLite = New Telerik.WinControls.UI.RadButton()
        Me.btnActivate = New Telerik.WinControls.UI.RadButton()
        Me.txtLicenseCode = New Telerik.WinControls.UI.RadTextBox()
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbActivate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnActivateLite, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnActivate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLicenseCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbLogo
        '
        Me.pbLogo.BackgroundImage = CType(resources.GetObject("pbLogo.BackgroundImage"), System.Drawing.Image)
        Me.pbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pbLogo.Location = New System.Drawing.Point(14, 41)
        Me.pbLogo.Name = "pbLogo"
        Me.pbLogo.Size = New System.Drawing.Size(277, 40)
        Me.pbLogo.TabIndex = 12
        Me.pbLogo.TabStop = False
        '
        'pbActivate
        '
        Me.pbActivate.BackColor = System.Drawing.Color.White
        Me.pbActivate.Location = New System.Drawing.Point(14, 87)
        Me.pbActivate.Name = "pbActivate"
        Me.pbActivate.Size = New System.Drawing.Size(391, 19)
        Me.pbActivate.TabIndex = 11
        Me.pbActivate.ThemeName = "TelerikMetro"
        CType(Me.pbActivate.GetChildAt(0), Telerik.WinControls.UI.RadProgressBarElement).BackColor = System.Drawing.SystemColors.Window
        '
        'btnActivateLite
        '
        Me.btnActivateLite.Location = New System.Drawing.Point(297, 59)
        Me.btnActivateLite.Name = "btnActivateLite"
        Me.btnActivateLite.Size = New System.Drawing.Size(108, 22)
        Me.btnActivateLite.TabIndex = 10
        Me.btnActivateLite.Text = "Activate LITE"
        Me.btnActivateLite.ThemeName = "TelerikMetro"
        CType(Me.btnActivateLite.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "Activate LITE"
        CType(Me.btnActivateLite.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.LightBlue
        '
        'btnActivate
        '
        Me.btnActivate.Location = New System.Drawing.Point(297, 13)
        Me.btnActivate.Name = "btnActivate"
        Me.btnActivate.Size = New System.Drawing.Size(108, 40)
        Me.btnActivate.TabIndex = 9
        Me.btnActivate.Text = "Activate PRO"
        Me.btnActivate.ThemeName = "TelerikMetro"
        CType(Me.btnActivate.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "Activate PRO"
        CType(Me.btnActivate.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.White
        '
        'txtLicenseCode
        '
        Me.txtLicenseCode.BackColor = System.Drawing.Color.White
        Me.txtLicenseCode.Location = New System.Drawing.Point(14, 13)
        Me.txtLicenseCode.Name = "txtLicenseCode"
        Me.txtLicenseCode.NullText = "Please enter you license key here..."
        Me.txtLicenseCode.Size = New System.Drawing.Size(277, 24)
        Me.txtLicenseCode.TabIndex = 8
        Me.txtLicenseCode.ThemeName = "TelerikMetro"
        '
        'FrmRegister
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(419, 118)
        Me.Controls.Add(Me.pbLogo)
        Me.Controls.Add(Me.pbActivate)
        Me.Controls.Add(Me.btnActivateLite)
        Me.Controls.Add(Me.btnActivate)
        Me.Controls.Add(Me.txtLicenseCode)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmRegister"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bulk Ping v2 Registration"
        Me.ThemeName = "TelerikMetro"
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbActivate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnActivateLite, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnActivate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLicenseCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MetroTheme As Telerik.WinControls.Themes.TelerikMetroTheme
    Friend WithEvents pbLogo As PictureBox
    Friend WithEvents pbActivate As Telerik.WinControls.UI.RadProgressBar
    Friend WithEvents btnActivateLite As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnActivate As Telerik.WinControls.UI.RadButton
    Friend WithEvents txtLicenseCode As Telerik.WinControls.UI.RadTextBox
End Class

