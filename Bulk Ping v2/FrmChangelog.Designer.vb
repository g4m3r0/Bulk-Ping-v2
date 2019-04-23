<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmChangelog
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmChangelog))
        Me.MetroTheme = New Telerik.WinControls.Themes.TelerikMetroTheme()
        Me.pbLogo = New System.Windows.Forms.PictureBox()
        Me.txtChangelog = New System.Windows.Forms.TextBox()
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbLogo
        '
        Me.pbLogo.BackgroundImage = CType(resources.GetObject("pbLogo.BackgroundImage"), System.Drawing.Image)
        Me.pbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbLogo.Location = New System.Drawing.Point(12, 1)
        Me.pbLogo.Name = "pbLogo"
        Me.pbLogo.Size = New System.Drawing.Size(497, 67)
        Me.pbLogo.TabIndex = 1
        Me.pbLogo.TabStop = False
        '
        'txtChangelog
        '
        Me.txtChangelog.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtChangelog.Location = New System.Drawing.Point(12, 74)
        Me.txtChangelog.Multiline = True
        Me.txtChangelog.Name = "txtChangelog"
        Me.txtChangelog.Size = New System.Drawing.Size(497, 313)
        Me.txtChangelog.TabIndex = 2
        '
        'FrmChangelog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(521, 399)
        Me.Controls.Add(Me.txtChangelog)
        Me.Controls.Add(Me.pbLogo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmChangelog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Changelog"
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MetroTheme As Telerik.WinControls.Themes.TelerikMetroTheme
    Friend WithEvents pbLogo As PictureBox
    Friend WithEvents txtChangelog As TextBox
End Class
