<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUpdate
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmUpdate))
        Me.MetroTheme = New Telerik.WinControls.Themes.TelerikMetroTheme()
        Me.TelerikMetroTheme1 = New Telerik.WinControls.Themes.TelerikMetroTheme()
        Me.btnSkip = New Telerik.WinControls.UI.RadButton()
        Me.txtMessage = New Telerik.WinControls.UI.RadTextBox()
        Me.btnUpdate = New Telerik.WinControls.UI.RadButton()
        Me.TimerSkip = New System.Windows.Forms.Timer(Me.components)
        CType(Me.btnSkip, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMessage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnUpdate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSkip
        '
        Me.btnSkip.Location = New System.Drawing.Point(544, 226)
        Me.btnSkip.Name = "btnSkip"
        Me.btnSkip.Size = New System.Drawing.Size(110, 24)
        Me.btnSkip.TabIndex = 5
        Me.btnSkip.Text = "Skip (30)"
        Me.btnSkip.ThemeName = "TelerikMetro"
        CType(Me.btnSkip.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "Skip (30)"
        CType(Me.btnSkip.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.LightCoral
        '
        'txtMessage
        '
        Me.txtMessage.AutoSize = False
        Me.txtMessage.Location = New System.Drawing.Point(16, 13)
        Me.txtMessage.Multiline = True
        Me.txtMessage.Name = "txtMessage"
        Me.txtMessage.Size = New System.Drawing.Size(638, 207)
        Me.txtMessage.TabIndex = 3
        Me.txtMessage.ThemeName = "TelerikMetro"
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(428, 226)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(110, 24)
        Me.btnUpdate.TabIndex = 4
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.ThemeName = "TelerikMetro"
        CType(Me.btnUpdate.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "Update"
        CType(Me.btnUpdate.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.LightGreen
        '
        'TimerSkip
        '
        Me.TimerSkip.Interval = 1000
        '
        'FrmUpdate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(670, 263)
        Me.Controls.Add(Me.btnSkip)
        Me.Controls.Add(Me.txtMessage)
        Me.Controls.Add(Me.btnUpdate)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmUpdate"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmUpdate"
        Me.ThemeName = "TelerikMetro"
        CType(Me.btnSkip, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMessage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnUpdate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MetroTheme As Telerik.WinControls.Themes.TelerikMetroTheme
    Friend WithEvents TelerikMetroTheme1 As Telerik.WinControls.Themes.TelerikMetroTheme
    Friend WithEvents btnSkip As Telerik.WinControls.UI.RadButton
    Friend WithEvents txtMessage As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents btnUpdate As Telerik.WinControls.UI.RadButton
    Friend WithEvents TimerSkip As Timer
End Class

