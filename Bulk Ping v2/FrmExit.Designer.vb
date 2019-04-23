<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmExit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmExit))
        Me.MetroTheme = New Telerik.WinControls.Themes.TelerikMetroTheme()
        Me.btnForceExit = New Telerik.WinControls.UI.RadButton()
        Me.pbConnection = New Telerik.WinControls.UI.RadProgressBar()
        Me.TelerikMetroTheme1 = New Telerik.WinControls.Themes.TelerikMetroTheme()
        CType(Me.btnForceExit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbConnection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnForceExit
        '
        Me.btnForceExit.Location = New System.Drawing.Point(332, 13)
        Me.btnForceExit.Name = "btnForceExit"
        Me.btnForceExit.Size = New System.Drawing.Size(110, 24)
        Me.btnForceExit.TabIndex = 10
        Me.btnForceExit.Text = "Force exit"
        Me.btnForceExit.ThemeName = "TelerikMetro"
        CType(Me.btnForceExit.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "Force exit"
        CType(Me.btnForceExit.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.LightCoral
        '
        'pbConnection
        '
        Me.pbConnection.Location = New System.Drawing.Point(15, 13)
        Me.pbConnection.Name = "pbConnection"
        Me.pbConnection.Size = New System.Drawing.Size(311, 24)
        Me.pbConnection.TabIndex = 9
        Me.pbConnection.Text = "Saving data... Please wait!"
        Me.pbConnection.ThemeName = "TelerikMetro"
        '
        'FrmExit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(456, 50)
        Me.Controls.Add(Me.btnForceExit)
        Me.Controls.Add(Me.pbConnection)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmExit"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Closing.."
        Me.ThemeName = "TelerikMetro"
        CType(Me.btnForceExit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbConnection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MetroTheme As Telerik.WinControls.Themes.TelerikMetroTheme
    Friend WithEvents btnForceExit As Telerik.WinControls.UI.RadButton
    Friend WithEvents pbConnection As Telerik.WinControls.UI.RadProgressBar
    Friend WithEvents TelerikMetroTheme1 As Telerik.WinControls.Themes.TelerikMetroTheme
End Class

