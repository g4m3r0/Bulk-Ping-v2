<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
        Me.MetroTheme = New Telerik.WinControls.Themes.TelerikMetroTheme()
        Me.TableLayoutPanelMain = New System.Windows.Forms.TableLayoutPanel()
        Me.btnStop = New Telerik.WinControls.UI.RadButton()
        Me.btnPing = New Telerik.WinControls.UI.RadButton()
        Me.btnRemove = New Telerik.WinControls.UI.RadButton()
        Me.PageViewMain = New Telerik.WinControls.UI.RadPageView()
        Me.RadPageViewMainLinkList = New Telerik.WinControls.UI.RadPageViewPage()
        Me.folvLink = New BrightIdeasSoftware.FastObjectListView()
        Me.RadPageViewMainProxyList = New Telerik.WinControls.UI.RadPageViewPage()
        Me.folvProxy = New BrightIdeasSoftware.FastObjectListView()
        Me.RadPageViewMainPingServices = New Telerik.WinControls.UI.RadPageViewPage()
        Me.TxtPingservices = New System.Windows.Forms.TextBox()
        Me.BtnPingservicesSaveChanges = New Telerik.WinControls.UI.RadButton()
        Me.BtnPingservicesLoadDefault = New Telerik.WinControls.UI.RadButton()
        Me.RadPageViewMainKeywords = New Telerik.WinControls.UI.RadPageViewPage()
        Me.TxtKeywords = New System.Windows.Forms.TextBox()
        Me.BtnKeywordsSaveChanges = New Telerik.WinControls.UI.RadButton()
        Me.BtnKeywordsLoadDefault = New Telerik.WinControls.UI.RadButton()
        Me.RadPageViewMainSettings = New Telerik.WinControls.UI.RadPageViewPage()
        Me.PanelGeneralSettings = New System.Windows.Forms.Panel()
        Me.cbPingBacklinks = New Telerik.WinControls.UI.RadCheckBox()
        Me.txtSettingsParseProxiesPath = New Telerik.WinControls.UI.RadTextBox()
        Me.btnSettingsParseProxiesBrowse = New Telerik.WinControls.UI.RadButton()
        Me.cbSettingsParseProxies = New Telerik.WinControls.UI.RadCheckBox()
        Me.txtSettingsParseProxiesMinutes = New Telerik.WinControls.UI.RadTextBox()
        Me.cbSettingsDeleteDownProxies = New Telerik.WinControls.UI.RadCheckBox()
        Me.cbSettingsEnableProxies = New Telerik.WinControls.UI.RadCheckBox()
        Me.lCurMaxThreads = New Telerik.WinControls.UI.RadLabel()
        Me.cbSettingsSaveProxiesOnExit = New Telerik.WinControls.UI.RadCheckBox()
        Me.btnApplyThreads = New Telerik.WinControls.UI.RadButton()
        Me.cbSettingsEnableLogging = New Telerik.WinControls.UI.RadCheckBox()
        Me.cbSettingsEnableGridlines = New Telerik.WinControls.UI.RadCheckBox()
        Me.cbSettingsSaveLinksOnExit = New Telerik.WinControls.UI.RadCheckBox()
        Me.cbSaveSettingsOnExit = New Telerik.WinControls.UI.RadCheckBox()
        Me.txtThreadsValue = New Telerik.WinControls.UI.RadTextBox()
        Me.txtTimeoutValue = New Telerik.WinControls.UI.RadTextBox()
        Me.lTimeout = New Telerik.WinControls.UI.RadLabel()
        Me.lThreads = New Telerik.WinControls.UI.RadLabel()
        Me.lGeneralSettings = New Telerik.WinControls.UI.RadLabel()
        Me.btnExportLinks = New Telerik.WinControls.UI.RadButton()
        Me.btnImportLinks = New Telerik.WinControls.UI.RadButton()
        Me.PanelTopStats = New System.Windows.Forms.Panel()
        Me.btnChangelog = New System.Windows.Forms.Button()
        Me.btnUpdateAvailable = New System.Windows.Forms.Button()
        Me.btnGetProVersion = New System.Windows.Forms.Button()
        Me.btnActivateProVersion = New System.Windows.Forms.Button()
        Me.btnReportBug = New System.Windows.Forms.Button()
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.lTopRunningThreads = New Telerik.WinControls.UI.RadLabel()
        Me.lTopSentBacklinks = New Telerik.WinControls.UI.RadLabel()
        Me.lTopSentPings = New Telerik.WinControls.UI.RadLabel()
        Me.lTopTotalProxies = New Telerik.WinControls.UI.RadLabel()
        Me.lTopTotalLinks = New Telerik.WinControls.UI.RadLabel()
        Me.cmBtnPing = New Telerik.WinControls.UI.RadContextMenu(Me.components)
        Me.RadMenuItemPingSend = New Telerik.WinControls.UI.RadMenuItem()
        Me.RadMenuItemPingSendAll = New Telerik.WinControls.UI.RadMenuItem()
        Me.RadMenuItemPingSendTicked = New Telerik.WinControls.UI.RadMenuItem()
        Me.RadMenuItemPingSendNew = New Telerik.WinControls.UI.RadMenuItem()
        Me.RadMenuItemPingSendBacklinks = New Telerik.WinControls.UI.RadMenuItem()
        Me.RadMenuItemPingSendBacklinksAll = New Telerik.WinControls.UI.RadMenuItem()
        Me.RadMenuItemPingSendBacklinksTicked = New Telerik.WinControls.UI.RadMenuItem()
        Me.RadMenuItemPingSendBacklinksNew = New Telerik.WinControls.UI.RadMenuItem()
        Me.cmBtnImport = New Telerik.WinControls.UI.RadContextMenu(Me.components)
        Me.RadMenuItemImportLinkFile = New Telerik.WinControls.UI.RadMenuItem()
        Me.RadMenuItemImportLinkClipboard = New Telerik.WinControls.UI.RadMenuItem()
        Me.RadMenuItemImportProxiesFile = New Telerik.WinControls.UI.RadMenuItem()
        Me.RadMenuItemImportProxyClipboard = New Telerik.WinControls.UI.RadMenuItem()
        Me.cmBtnExport = New Telerik.WinControls.UI.RadContextMenu(Me.components)
        Me.RadMenuItemExportTxt = New Telerik.WinControls.UI.RadMenuItem()
        Me.RadMenuItemExportTxtAll = New Telerik.WinControls.UI.RadMenuItem()
        Me.RadMenuItemExportTxtTicked = New Telerik.WinControls.UI.RadMenuItem()
        Me.RadMenuItemExportCSV = New Telerik.WinControls.UI.RadMenuItem()
        Me.RadMenuItemExportCSVAll = New Telerik.WinControls.UI.RadMenuItem()
        Me.RadMenuItemExportCSVTicked = New Telerik.WinControls.UI.RadMenuItem()
        Me.RadMenuSeparatorExport = New Telerik.WinControls.UI.RadMenuSeparatorItem()
        Me.RadMenuItemExportBacklinkReport = New Telerik.WinControls.UI.RadMenuItem()
        Me.cmBtnRemove = New Telerik.WinControls.UI.RadContextMenu(Me.components)
        Me.RadMenuItemRemoveLinkAll = New Telerik.WinControls.UI.RadMenuItem()
        Me.RadMenuItemRemoveLinkTicked = New Telerik.WinControls.UI.RadMenuItem()
        Me.RadMenuItemRemoveProxyAll = New Telerik.WinControls.UI.RadMenuItem()
        Me.RadMenuItemRemoveProxyTicked = New Telerik.WinControls.UI.RadMenuItem()
        Me.TimerRefreshObjects = New System.Windows.Forms.Timer(Me.components)
        Me.TimerRefreshStatus = New System.Windows.Forms.Timer(Me.components)
        Me.TimerParseProxies = New System.Windows.Forms.Timer(Me.components)
        Me.TimerProxyHandler = New System.Windows.Forms.Timer(Me.components)
        Me.ToolTipMain = New System.Windows.Forms.ToolTip(Me.components)
        Me.TableLayoutPanelMain.SuspendLayout()
        CType(Me.btnStop, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnPing, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnRemove, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PageViewMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PageViewMain.SuspendLayout()
        Me.RadPageViewMainLinkList.SuspendLayout()
        CType(Me.folvLink, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPageViewMainProxyList.SuspendLayout()
        CType(Me.folvProxy, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPageViewMainPingServices.SuspendLayout()
        CType(Me.BtnPingservicesSaveChanges, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnPingservicesLoadDefault, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPageViewMainKeywords.SuspendLayout()
        CType(Me.BtnKeywordsSaveChanges, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnKeywordsLoadDefault, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPageViewMainSettings.SuspendLayout()
        Me.PanelGeneralSettings.SuspendLayout()
        CType(Me.cbPingBacklinks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSettingsParseProxiesPath, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSettingsParseProxiesBrowse, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbSettingsParseProxies, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cbSettingsParseProxies.SuspendLayout()
        CType(Me.txtSettingsParseProxiesMinutes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbSettingsDeleteDownProxies, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbSettingsEnableProxies, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lCurMaxThreads, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbSettingsSaveProxiesOnExit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnApplyThreads, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbSettingsEnableLogging, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbSettingsEnableGridlines, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbSettingsSaveLinksOnExit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbSaveSettingsOnExit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtThreadsValue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTimeoutValue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lTimeout, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lThreads, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lGeneralSettings, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnExportLinks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnImportLinks, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelTopStats.SuspendLayout()
        CType(Me.lTopRunningThreads, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lTopSentBacklinks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lTopSentPings, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lTopTotalProxies, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lTopTotalLinks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanelMain
        '
        Me.TableLayoutPanelMain.ColumnCount = 6
        Me.TableLayoutPanelMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 63.0!))
        Me.TableLayoutPanelMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 63.0!))
        Me.TableLayoutPanelMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 63.0!))
        Me.TableLayoutPanelMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 63.0!))
        Me.TableLayoutPanelMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 63.0!))
        Me.TableLayoutPanelMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanelMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanelMain.Controls.Add(Me.btnStop, 4, 0)
        Me.TableLayoutPanelMain.Controls.Add(Me.btnPing, 0, 0)
        Me.TableLayoutPanelMain.Controls.Add(Me.btnRemove, 3, 0)
        Me.TableLayoutPanelMain.Controls.Add(Me.PageViewMain, 0, 1)
        Me.TableLayoutPanelMain.Controls.Add(Me.btnExportLinks, 2, 0)
        Me.TableLayoutPanelMain.Controls.Add(Me.btnImportLinks, 1, 0)
        Me.TableLayoutPanelMain.Controls.Add(Me.PanelTopStats, 5, 0)
        Me.TableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanelMain.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanelMain.Name = "TableLayoutPanelMain"
        Me.TableLayoutPanelMain.RowCount = 2
        Me.TableLayoutPanelMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56.0!))
        Me.TableLayoutPanelMain.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanelMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanelMain.Size = New System.Drawing.Size(1016, 445)
        Me.TableLayoutPanelMain.TabIndex = 1
        '
        'btnStop
        '
        Me.btnStop.BackColor = System.Drawing.SystemColors.ControlText
        Me.btnStop.ForeColor = System.Drawing.Color.White
        Me.btnStop.Location = New System.Drawing.Point(255, 3)
        Me.btnStop.Name = "btnStop"
        '
        '
        '
        Me.btnStop.RootElement.AccessibleDescription = "Stop"
        Me.btnStop.RootElement.AccessibleName = "Stop"
        Me.btnStop.Size = New System.Drawing.Size(55, 50)
        Me.btnStop.TabIndex = 6
        Me.btnStop.Text = "Stop"
        Me.btnStop.ThemeName = "TelerikMetro"
        Me.ToolTipMain.SetToolTip(Me.btnStop, "Stop all operations.")
        CType(Me.btnStop.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "Stop"
        CType(Me.btnStop.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.LightCoral
        '
        'btnPing
        '
        Me.btnPing.BackColor = System.Drawing.Color.White
        Me.btnPing.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnPing.Location = New System.Drawing.Point(3, 3)
        Me.btnPing.Name = "btnPing"
        Me.btnPing.Size = New System.Drawing.Size(55, 50)
        Me.btnPing.TabIndex = 4
        Me.btnPing.Text = "Ping"
        Me.btnPing.ThemeName = "TelerikMetro"
        '
        'btnRemove
        '
        Me.btnRemove.BackColor = System.Drawing.Color.White
        Me.btnRemove.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnRemove.Location = New System.Drawing.Point(192, 3)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(55, 50)
        Me.btnRemove.TabIndex = 5
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.ThemeName = "TelerikMetro"
        '
        'PageViewMain
        '
        Me.TableLayoutPanelMain.SetColumnSpan(Me.PageViewMain, 6)
        Me.PageViewMain.Controls.Add(Me.RadPageViewMainLinkList)
        Me.PageViewMain.Controls.Add(Me.RadPageViewMainProxyList)
        Me.PageViewMain.Controls.Add(Me.RadPageViewMainPingServices)
        Me.PageViewMain.Controls.Add(Me.RadPageViewMainKeywords)
        Me.PageViewMain.Controls.Add(Me.RadPageViewMainSettings)
        Me.PageViewMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PageViewMain.Location = New System.Drawing.Point(3, 59)
        Me.PageViewMain.Name = "PageViewMain"
        Me.PageViewMain.SelectedPage = Me.RadPageViewMainPingServices
        Me.PageViewMain.Size = New System.Drawing.Size(1010, 383)
        Me.PageViewMain.TabIndex = 0
        Me.PageViewMain.Text = "PageViewMain"
        Me.PageViewMain.ThemeName = "TelerikMetro"
        '
        'RadPageViewMainLinkList
        '
        Me.RadPageViewMainLinkList.Controls.Add(Me.folvLink)
        Me.RadPageViewMainLinkList.ItemSize = New System.Drawing.SizeF(56.0!, 25.0!)
        Me.RadPageViewMainLinkList.Location = New System.Drawing.Point(5, 31)
        Me.RadPageViewMainLinkList.Name = "RadPageViewMainLinkList"
        Me.RadPageViewMainLinkList.Size = New System.Drawing.Size(1000, 347)
        Me.RadPageViewMainLinkList.Text = "Link List"
        '
        'folvLink
        '
        Me.folvLink.AutoArrange = False
        Me.folvLink.CausesValidation = False
        Me.folvLink.CellEditUseWholeCell = False
        Me.folvLink.CheckBoxes = True
        Me.folvLink.Dock = System.Windows.Forms.DockStyle.Fill
        Me.folvLink.Location = New System.Drawing.Point(0, 0)
        Me.folvLink.Name = "folvLink"
        Me.folvLink.ShowGroups = False
        Me.folvLink.ShowImagesOnSubItems = True
        Me.folvLink.Size = New System.Drawing.Size(1000, 347)
        Me.folvLink.TabIndex = 0
        Me.folvLink.TriggerCellOverEventsWhenOverHeader = False
        Me.folvLink.UseCellFormatEvents = True
        Me.folvLink.UseCompatibleStateImageBehavior = False
        Me.folvLink.View = System.Windows.Forms.View.Details
        Me.folvLink.VirtualMode = True
        '
        'RadPageViewMainProxyList
        '
        Me.RadPageViewMainProxyList.Controls.Add(Me.folvProxy)
        Me.RadPageViewMainProxyList.ItemSize = New System.Drawing.SizeF(64.0!, 25.0!)
        Me.RadPageViewMainProxyList.Location = New System.Drawing.Point(5, 31)
        Me.RadPageViewMainProxyList.Name = "RadPageViewMainProxyList"
        Me.RadPageViewMainProxyList.Size = New System.Drawing.Size(1000, 347)
        Me.RadPageViewMainProxyList.Text = "Proxy List"
        '
        'folvProxy
        '
        Me.folvProxy.AutoArrange = False
        Me.folvProxy.CausesValidation = False
        Me.folvProxy.CellEditUseWholeCell = False
        Me.folvProxy.CheckBoxes = True
        Me.folvProxy.Dock = System.Windows.Forms.DockStyle.Fill
        Me.folvProxy.Location = New System.Drawing.Point(0, 0)
        Me.folvProxy.Name = "folvProxy"
        Me.folvProxy.ShowGroups = False
        Me.folvProxy.ShowImagesOnSubItems = True
        Me.folvProxy.Size = New System.Drawing.Size(1000, 347)
        Me.folvProxy.TabIndex = 1
        Me.folvProxy.TriggerCellOverEventsWhenOverHeader = False
        Me.folvProxy.UseCellFormatEvents = True
        Me.folvProxy.UseCompatibleStateImageBehavior = False
        Me.folvProxy.View = System.Windows.Forms.View.Details
        Me.folvProxy.VirtualMode = True
        '
        'RadPageViewMainPingServices
        '
        Me.RadPageViewMainPingServices.Controls.Add(Me.TxtPingservices)
        Me.RadPageViewMainPingServices.Controls.Add(Me.BtnPingservicesSaveChanges)
        Me.RadPageViewMainPingServices.Controls.Add(Me.BtnPingservicesLoadDefault)
        Me.RadPageViewMainPingServices.ItemSize = New System.Drawing.SizeF(84.0!, 25.0!)
        Me.RadPageViewMainPingServices.Location = New System.Drawing.Point(5, 31)
        Me.RadPageViewMainPingServices.Name = "RadPageViewMainPingServices"
        Me.RadPageViewMainPingServices.Size = New System.Drawing.Size(1000, 347)
        Me.RadPageViewMainPingServices.Text = "Ping Services"
        '
        'TxtPingservices
        '
        Me.TxtPingservices.Location = New System.Drawing.Point(0, 3)
        Me.TxtPingservices.Multiline = True
        Me.TxtPingservices.Name = "TxtPingservices"
        Me.TxtPingservices.Size = New System.Drawing.Size(1000, 315)
        Me.TxtPingservices.TabIndex = 27
        Me.TxtPingservices.Text = resources.GetString("TxtPingservices.Text")
        '
        'BtnPingservicesSaveChanges
        '
        Me.BtnPingservicesSaveChanges.Location = New System.Drawing.Point(92, 324)
        Me.BtnPingservicesSaveChanges.Name = "BtnPingservicesSaveChanges"
        Me.BtnPingservicesSaveChanges.Size = New System.Drawing.Size(84, 23)
        Me.BtnPingservicesSaveChanges.TabIndex = 26
        Me.BtnPingservicesSaveChanges.Text = "Save Changes"
        Me.BtnPingservicesSaveChanges.ThemeName = "TelerikMetro"
        '
        'BtnPingservicesLoadDefault
        '
        Me.BtnPingservicesLoadDefault.Location = New System.Drawing.Point(0, 324)
        Me.BtnPingservicesLoadDefault.Name = "BtnPingservicesLoadDefault"
        Me.BtnPingservicesLoadDefault.Size = New System.Drawing.Size(83, 23)
        Me.BtnPingservicesLoadDefault.TabIndex = 25
        Me.BtnPingservicesLoadDefault.Text = "Load Default"
        Me.BtnPingservicesLoadDefault.ThemeName = "TelerikMetro"
        '
        'RadPageViewMainKeywords
        '
        Me.RadPageViewMainKeywords.Controls.Add(Me.TxtKeywords)
        Me.RadPageViewMainKeywords.Controls.Add(Me.BtnKeywordsSaveChanges)
        Me.RadPageViewMainKeywords.Controls.Add(Me.BtnKeywordsLoadDefault)
        Me.RadPageViewMainKeywords.ItemSize = New System.Drawing.SizeF(65.0!, 25.0!)
        Me.RadPageViewMainKeywords.Location = New System.Drawing.Point(5, 31)
        Me.RadPageViewMainKeywords.Name = "RadPageViewMainKeywords"
        Me.RadPageViewMainKeywords.Size = New System.Drawing.Size(1000, 347)
        Me.RadPageViewMainKeywords.Text = "Keywords"
        '
        'TxtKeywords
        '
        Me.TxtKeywords.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtKeywords.Location = New System.Drawing.Point(0, 0)
        Me.TxtKeywords.Multiline = True
        Me.TxtKeywords.Name = "TxtKeywords"
        Me.TxtKeywords.Size = New System.Drawing.Size(1005, 318)
        Me.TxtKeywords.TabIndex = 29
        Me.TxtKeywords.Text = "Keyword1" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Keyword2" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Keyword3" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Keyword4"
        '
        'BtnKeywordsSaveChanges
        '
        Me.BtnKeywordsSaveChanges.Location = New System.Drawing.Point(89, 324)
        Me.BtnKeywordsSaveChanges.Name = "BtnKeywordsSaveChanges"
        Me.BtnKeywordsSaveChanges.Size = New System.Drawing.Size(84, 23)
        Me.BtnKeywordsSaveChanges.TabIndex = 28
        Me.BtnKeywordsSaveChanges.Text = "Save Changes"
        Me.BtnKeywordsSaveChanges.ThemeName = "TelerikMetro"
        '
        'BtnKeywordsLoadDefault
        '
        Me.BtnKeywordsLoadDefault.Location = New System.Drawing.Point(0, 324)
        Me.BtnKeywordsLoadDefault.Name = "BtnKeywordsLoadDefault"
        Me.BtnKeywordsLoadDefault.Size = New System.Drawing.Size(83, 23)
        Me.BtnKeywordsLoadDefault.TabIndex = 27
        Me.BtnKeywordsLoadDefault.Text = "Load Default"
        Me.BtnKeywordsLoadDefault.ThemeName = "TelerikMetro"
        '
        'RadPageViewMainSettings
        '
        Me.RadPageViewMainSettings.Controls.Add(Me.PanelGeneralSettings)
        Me.RadPageViewMainSettings.ItemSize = New System.Drawing.SizeF(56.0!, 25.0!)
        Me.RadPageViewMainSettings.Location = New System.Drawing.Point(5, 31)
        Me.RadPageViewMainSettings.Name = "RadPageViewMainSettings"
        Me.RadPageViewMainSettings.Size = New System.Drawing.Size(1000, 347)
        Me.RadPageViewMainSettings.Text = "Settings"
        '
        'PanelGeneralSettings
        '
        Me.PanelGeneralSettings.BackColor = System.Drawing.Color.White
        Me.PanelGeneralSettings.Controls.Add(Me.cbPingBacklinks)
        Me.PanelGeneralSettings.Controls.Add(Me.txtSettingsParseProxiesPath)
        Me.PanelGeneralSettings.Controls.Add(Me.btnSettingsParseProxiesBrowse)
        Me.PanelGeneralSettings.Controls.Add(Me.cbSettingsParseProxies)
        Me.PanelGeneralSettings.Controls.Add(Me.cbSettingsDeleteDownProxies)
        Me.PanelGeneralSettings.Controls.Add(Me.cbSettingsEnableProxies)
        Me.PanelGeneralSettings.Controls.Add(Me.lCurMaxThreads)
        Me.PanelGeneralSettings.Controls.Add(Me.cbSettingsSaveProxiesOnExit)
        Me.PanelGeneralSettings.Controls.Add(Me.btnApplyThreads)
        Me.PanelGeneralSettings.Controls.Add(Me.cbSettingsEnableLogging)
        Me.PanelGeneralSettings.Controls.Add(Me.cbSettingsEnableGridlines)
        Me.PanelGeneralSettings.Controls.Add(Me.cbSettingsSaveLinksOnExit)
        Me.PanelGeneralSettings.Controls.Add(Me.cbSaveSettingsOnExit)
        Me.PanelGeneralSettings.Controls.Add(Me.txtThreadsValue)
        Me.PanelGeneralSettings.Controls.Add(Me.txtTimeoutValue)
        Me.PanelGeneralSettings.Controls.Add(Me.lTimeout)
        Me.PanelGeneralSettings.Controls.Add(Me.lThreads)
        Me.PanelGeneralSettings.Controls.Add(Me.lGeneralSettings)
        Me.PanelGeneralSettings.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelGeneralSettings.Location = New System.Drawing.Point(0, 0)
        Me.PanelGeneralSettings.Margin = New System.Windows.Forms.Padding(0)
        Me.PanelGeneralSettings.Name = "PanelGeneralSettings"
        Me.PanelGeneralSettings.Size = New System.Drawing.Size(1000, 347)
        Me.PanelGeneralSettings.TabIndex = 1
        '
        'cbPingBacklinks
        '
        Me.cbPingBacklinks.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbPingBacklinks.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cbPingBacklinks.Location = New System.Drawing.Point(201, 149)
        Me.cbPingBacklinks.Name = "cbPingBacklinks"
        Me.cbPingBacklinks.Size = New System.Drawing.Size(159, 21)
        Me.cbPingBacklinks.TabIndex = 32
        Me.cbPingBacklinks.Text = "Ping created Backlinks"
        Me.cbPingBacklinks.ThemeName = "TelerikMetro"
        Me.cbPingBacklinks.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
        '
        'txtSettingsParseProxiesPath
        '
        Me.txtSettingsParseProxiesPath.Location = New System.Drawing.Point(341, 286)
        Me.txtSettingsParseProxiesPath.Name = "txtSettingsParseProxiesPath"
        Me.txtSettingsParseProxiesPath.NullText = "Browse Path"
        Me.txtSettingsParseProxiesPath.Size = New System.Drawing.Size(234, 24)
        Me.txtSettingsParseProxiesPath.TabIndex = 31
        Me.txtSettingsParseProxiesPath.ThemeName = "TelerikMetro"
        '
        'btnSettingsParseProxiesBrowse
        '
        Me.btnSettingsParseProxiesBrowse.Location = New System.Drawing.Point(581, 286)
        Me.btnSettingsParseProxiesBrowse.Name = "btnSettingsParseProxiesBrowse"
        Me.btnSettingsParseProxiesBrowse.Size = New System.Drawing.Size(61, 23)
        Me.btnSettingsParseProxiesBrowse.TabIndex = 30
        Me.btnSettingsParseProxiesBrowse.Text = "Browse"
        Me.btnSettingsParseProxiesBrowse.ThemeName = "TelerikMetro"
        '
        'cbSettingsParseProxies
        '
        Me.cbSettingsParseProxies.Controls.Add(Me.txtSettingsParseProxiesMinutes)
        Me.cbSettingsParseProxies.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cbSettingsParseProxies.Location = New System.Drawing.Point(4, 284)
        Me.cbSettingsParseProxies.Name = "cbSettingsParseProxies"
        Me.cbSettingsParseProxies.Size = New System.Drawing.Size(331, 21)
        Me.cbSettingsParseProxies.TabIndex = 28
        Me.cbSettingsParseProxies.Text = "Parse proxies from File every                      minutes."
        Me.cbSettingsParseProxies.ThemeName = "TelerikMetro"
        '
        'txtSettingsParseProxiesMinutes
        '
        Me.txtSettingsParseProxiesMinutes.Location = New System.Drawing.Point(197, 0)
        Me.txtSettingsParseProxiesMinutes.Name = "txtSettingsParseProxiesMinutes"
        Me.txtSettingsParseProxiesMinutes.Size = New System.Drawing.Size(70, 24)
        Me.txtSettingsParseProxiesMinutes.TabIndex = 29
        Me.txtSettingsParseProxiesMinutes.Text = "60"
        Me.txtSettingsParseProxiesMinutes.ThemeName = "TelerikMetro"
        '
        'cbSettingsDeleteDownProxies
        '
        Me.cbSettingsDeleteDownProxies.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbSettingsDeleteDownProxies.Enabled = False
        Me.cbSettingsDeleteDownProxies.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cbSettingsDeleteDownProxies.Location = New System.Drawing.Point(4, 257)
        Me.cbSettingsDeleteDownProxies.Name = "cbSettingsDeleteDownProxies"
        Me.cbSettingsDeleteDownProxies.Size = New System.Drawing.Size(211, 21)
        Me.cbSettingsDeleteDownProxies.TabIndex = 27
        Me.cbSettingsDeleteDownProxies.Text = "Remove down proxies from list"
        Me.cbSettingsDeleteDownProxies.ThemeName = "TelerikMetro"
        Me.cbSettingsDeleteDownProxies.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
        '
        'cbSettingsEnableProxies
        '
        Me.cbSettingsEnableProxies.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cbSettingsEnableProxies.Location = New System.Drawing.Point(4, 230)
        Me.cbSettingsEnableProxies.Name = "cbSettingsEnableProxies"
        Me.cbSettingsEnableProxies.Size = New System.Drawing.Size(112, 21)
        Me.cbSettingsEnableProxies.TabIndex = 26
        Me.cbSettingsEnableProxies.Text = "Enable proxies"
        Me.cbSettingsEnableProxies.ThemeName = "TelerikMetro"
        '
        'lCurMaxThreads
        '
        Me.lCurMaxThreads.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lCurMaxThreads.Location = New System.Drawing.Point(234, 39)
        Me.lCurMaxThreads.Name = "lCurMaxThreads"
        Me.lCurMaxThreads.Size = New System.Drawing.Size(155, 21)
        Me.lCurMaxThreads.TabIndex = 25
        Me.lCurMaxThreads.Text = "(Current max. Threads 0)"
        Me.lCurMaxThreads.ThemeName = "TelerikMetro"
        '
        'cbSettingsSaveProxiesOnExit
        '
        Me.cbSettingsSaveProxiesOnExit.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbSettingsSaveProxiesOnExit.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cbSettingsSaveProxiesOnExit.Location = New System.Drawing.Point(4, 149)
        Me.cbSettingsSaveProxiesOnExit.Name = "cbSettingsSaveProxiesOnExit"
        Me.cbSettingsSaveProxiesOnExit.Size = New System.Drawing.Size(144, 21)
        Me.cbSettingsSaveProxiesOnExit.TabIndex = 21
        Me.cbSettingsSaveProxiesOnExit.Text = "Save Proxies on exit"
        Me.cbSettingsSaveProxiesOnExit.ThemeName = "TelerikMetro"
        Me.cbSettingsSaveProxiesOnExit.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
        '
        'btnApplyThreads
        '
        Me.btnApplyThreads.Location = New System.Drawing.Point(164, 39)
        Me.btnApplyThreads.Name = "btnApplyThreads"
        Me.btnApplyThreads.Size = New System.Drawing.Size(64, 23)
        Me.btnApplyThreads.TabIndex = 20
        Me.btnApplyThreads.Text = "Apply"
        Me.btnApplyThreads.ThemeName = "TelerikMetro"
        Me.btnApplyThreads.Visible = False
        '
        'cbSettingsEnableLogging
        '
        Me.cbSettingsEnableLogging.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cbSettingsEnableLogging.Location = New System.Drawing.Point(4, 203)
        Me.cbSettingsEnableLogging.Name = "cbSettingsEnableLogging"
        Me.cbSettingsEnableLogging.Size = New System.Drawing.Size(150, 21)
        Me.cbSettingsEnableLogging.TabIndex = 18
        Me.cbSettingsEnableLogging.Text = "Enable Debug-Mode"
        Me.cbSettingsEnableLogging.ThemeName = "TelerikMetro"
        '
        'cbSettingsEnableGridlines
        '
        Me.cbSettingsEnableGridlines.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cbSettingsEnableGridlines.Location = New System.Drawing.Point(4, 176)
        Me.cbSettingsEnableGridlines.Name = "cbSettingsEnableGridlines"
        Me.cbSettingsEnableGridlines.Size = New System.Drawing.Size(174, 21)
        Me.cbSettingsEnableGridlines.TabIndex = 17
        Me.cbSettingsEnableGridlines.Text = "Enable GridLines on Lists"
        Me.cbSettingsEnableGridlines.ThemeName = "TelerikMetro"
        '
        'cbSettingsSaveLinksOnExit
        '
        Me.cbSettingsSaveLinksOnExit.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbSettingsSaveLinksOnExit.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cbSettingsSaveLinksOnExit.Location = New System.Drawing.Point(4, 122)
        Me.cbSettingsSaveLinksOnExit.Name = "cbSettingsSaveLinksOnExit"
        Me.cbSettingsSaveLinksOnExit.Size = New System.Drawing.Size(131, 21)
        Me.cbSettingsSaveLinksOnExit.TabIndex = 15
        Me.cbSettingsSaveLinksOnExit.Text = "Save Links on exit"
        Me.cbSettingsSaveLinksOnExit.ThemeName = "TelerikMetro"
        Me.cbSettingsSaveLinksOnExit.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
        '
        'cbSaveSettingsOnExit
        '
        Me.cbSaveSettingsOnExit.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbSaveSettingsOnExit.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cbSaveSettingsOnExit.Location = New System.Drawing.Point(4, 95)
        Me.cbSaveSettingsOnExit.Name = "cbSaveSettingsOnExit"
        Me.cbSaveSettingsOnExit.Size = New System.Drawing.Size(144, 21)
        Me.cbSaveSettingsOnExit.TabIndex = 14
        Me.cbSaveSettingsOnExit.Text = "Save Setting on exit"
        Me.cbSaveSettingsOnExit.ThemeName = "TelerikMetro"
        Me.cbSaveSettingsOnExit.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
        '
        'txtThreadsValue
        '
        Me.txtThreadsValue.Location = New System.Drawing.Point(88, 40)
        Me.txtThreadsValue.Name = "txtThreadsValue"
        Me.txtThreadsValue.Size = New System.Drawing.Size(70, 24)
        Me.txtThreadsValue.TabIndex = 5
        Me.txtThreadsValue.Text = "10"
        Me.txtThreadsValue.ThemeName = "TelerikMetro"
        '
        'txtTimeoutValue
        '
        Me.txtTimeoutValue.Location = New System.Drawing.Point(88, 67)
        Me.txtTimeoutValue.Name = "txtTimeoutValue"
        Me.txtTimeoutValue.Size = New System.Drawing.Size(70, 24)
        Me.txtTimeoutValue.TabIndex = 4
        Me.txtTimeoutValue.Text = "5"
        Me.txtTimeoutValue.ThemeName = "TelerikMetro"
        '
        'lTimeout
        '
        Me.lTimeout.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lTimeout.Location = New System.Drawing.Point(4, 66)
        Me.lTimeout.Name = "lTimeout"
        Me.lTimeout.Size = New System.Drawing.Size(78, 21)
        Me.lTimeout.TabIndex = 3
        Me.lTimeout.Text = "Timeout (s):"
        Me.lTimeout.ThemeName = "TelerikMetro"
        '
        'lThreads
        '
        Me.lThreads.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lThreads.Location = New System.Drawing.Point(4, 39)
        Me.lThreads.Name = "lThreads"
        Me.lThreads.Size = New System.Drawing.Size(58, 21)
        Me.lThreads.TabIndex = 2
        Me.lThreads.Text = "Threads:"
        Me.lThreads.ThemeName = "TelerikMetro"
        '
        'lGeneralSettings
        '
        Me.lGeneralSettings.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold)
        Me.lGeneralSettings.ForeColor = System.Drawing.Color.DarkOrange
        Me.lGeneralSettings.Location = New System.Drawing.Point(4, 3)
        Me.lGeneralSettings.Name = "lGeneralSettings"
        Me.lGeneralSettings.Size = New System.Drawing.Size(155, 30)
        Me.lGeneralSettings.TabIndex = 1
        Me.lGeneralSettings.Text = "General Settings"
        Me.lGeneralSettings.ThemeName = "TelerikMetro"
        '
        'btnExportLinks
        '
        Me.btnExportLinks.BackColor = System.Drawing.Color.White
        Me.btnExportLinks.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnExportLinks.Location = New System.Drawing.Point(129, 3)
        Me.btnExportLinks.Name = "btnExportLinks"
        Me.btnExportLinks.Size = New System.Drawing.Size(55, 50)
        Me.btnExportLinks.TabIndex = 3
        Me.btnExportLinks.Text = "Export"
        Me.btnExportLinks.ThemeName = "TelerikMetro"
        '
        'btnImportLinks
        '
        Me.btnImportLinks.BackColor = System.Drawing.Color.White
        Me.btnImportLinks.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnImportLinks.Location = New System.Drawing.Point(66, 3)
        Me.btnImportLinks.Name = "btnImportLinks"
        Me.btnImportLinks.Size = New System.Drawing.Size(55, 50)
        Me.btnImportLinks.TabIndex = 2
        Me.btnImportLinks.Text = "Import"
        Me.btnImportLinks.ThemeName = "TelerikMetro"
        '
        'PanelTopStats
        '
        Me.PanelTopStats.Controls.Add(Me.btnChangelog)
        Me.PanelTopStats.Controls.Add(Me.btnUpdateAvailable)
        Me.PanelTopStats.Controls.Add(Me.btnGetProVersion)
        Me.PanelTopStats.Controls.Add(Me.btnActivateProVersion)
        Me.PanelTopStats.Controls.Add(Me.btnReportBug)
        Me.PanelTopStats.Controls.Add(Me.btnHelp)
        Me.PanelTopStats.Controls.Add(Me.lTopRunningThreads)
        Me.PanelTopStats.Controls.Add(Me.lTopSentBacklinks)
        Me.PanelTopStats.Controls.Add(Me.lTopSentPings)
        Me.PanelTopStats.Controls.Add(Me.lTopTotalProxies)
        Me.PanelTopStats.Controls.Add(Me.lTopTotalLinks)
        Me.PanelTopStats.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelTopStats.Location = New System.Drawing.Point(318, 3)
        Me.PanelTopStats.Name = "PanelTopStats"
        Me.PanelTopStats.Size = New System.Drawing.Size(695, 50)
        Me.PanelTopStats.TabIndex = 7
        '
        'btnChangelog
        '
        Me.btnChangelog.BackColor = System.Drawing.SystemColors.Control
        Me.btnChangelog.BackgroundImage = Global.Bulk_Ping_v2.My.Resources.Resources._027
        Me.btnChangelog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnChangelog.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnChangelog.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnChangelog.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnChangelog.Location = New System.Drawing.Point(641, 2)
        Me.btnChangelog.Name = "btnChangelog"
        Me.btnChangelog.Size = New System.Drawing.Size(23, 23)
        Me.btnChangelog.TabIndex = 44
        Me.ToolTipMain.SetToolTip(Me.btnChangelog, "View Changelog.")
        Me.btnChangelog.UseVisualStyleBackColor = False
        '
        'btnUpdateAvailable
        '
        Me.btnUpdateAvailable.BackColor = System.Drawing.SystemColors.Control
        Me.btnUpdateAvailable.BackgroundImage = Global.Bulk_Ping_v2.My.Resources.Resources._043
        Me.btnUpdateAvailable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnUpdateAvailable.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnUpdateAvailable.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdateAvailable.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnUpdateAvailable.Location = New System.Drawing.Point(525, 2)
        Me.btnUpdateAvailable.Name = "btnUpdateAvailable"
        Me.btnUpdateAvailable.Size = New System.Drawing.Size(23, 23)
        Me.btnUpdateAvailable.TabIndex = 43
        Me.ToolTipMain.SetToolTip(Me.btnUpdateAvailable, "New version available. Press to update.")
        Me.btnUpdateAvailable.UseVisualStyleBackColor = False
        Me.btnUpdateAvailable.Visible = False
        '
        'btnGetProVersion
        '
        Me.btnGetProVersion.BackColor = System.Drawing.SystemColors.Control
        Me.btnGetProVersion.BackgroundImage = Global.Bulk_Ping_v2.My.Resources.Resources._045
        Me.btnGetProVersion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnGetProVersion.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnGetProVersion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGetProVersion.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnGetProVersion.Location = New System.Drawing.Point(583, 2)
        Me.btnGetProVersion.Name = "btnGetProVersion"
        Me.btnGetProVersion.Size = New System.Drawing.Size(23, 23)
        Me.btnGetProVersion.TabIndex = 42
        Me.ToolTipMain.SetToolTip(Me.btnGetProVersion, "Visit our store.")
        Me.btnGetProVersion.UseVisualStyleBackColor = False
        '
        'btnActivateProVersion
        '
        Me.btnActivateProVersion.BackColor = System.Drawing.SystemColors.Control
        Me.btnActivateProVersion.BackgroundImage = Global.Bulk_Ping_v2.My.Resources.Resources._0301
        Me.btnActivateProVersion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnActivateProVersion.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnActivateProVersion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnActivateProVersion.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnActivateProVersion.Location = New System.Drawing.Point(554, 2)
        Me.btnActivateProVersion.Name = "btnActivateProVersion"
        Me.btnActivateProVersion.Size = New System.Drawing.Size(23, 23)
        Me.btnActivateProVersion.TabIndex = 41
        Me.ToolTipMain.SetToolTip(Me.btnActivateProVersion, "Change your license code.")
        Me.btnActivateProVersion.UseVisualStyleBackColor = False
        '
        'btnReportBug
        '
        Me.btnReportBug.BackColor = System.Drawing.SystemColors.Control
        Me.btnReportBug.BackgroundImage = Global.Bulk_Ping_v2.My.Resources.Resources._030
        Me.btnReportBug.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnReportBug.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnReportBug.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReportBug.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnReportBug.Location = New System.Drawing.Point(612, 2)
        Me.btnReportBug.Name = "btnReportBug"
        Me.btnReportBug.Size = New System.Drawing.Size(23, 23)
        Me.btnReportBug.TabIndex = 40
        Me.ToolTipMain.SetToolTip(Me.btnReportBug, "Report Bug or get support by mail.")
        Me.btnReportBug.UseVisualStyleBackColor = False
        '
        'btnHelp
        '
        Me.btnHelp.BackColor = System.Drawing.SystemColors.Control
        Me.btnHelp.BackgroundImage = Global.Bulk_Ping_v2.My.Resources.Resources._010
        Me.btnHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnHelp.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHelp.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnHelp.Location = New System.Drawing.Point(670, 2)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(23, 23)
        Me.btnHelp.TabIndex = 39
        Me.ToolTipMain.SetToolTip(Me.btnHelp, "View the manual.")
        Me.btnHelp.UseVisualStyleBackColor = False
        '
        'lTopRunningThreads
        '
        Me.lTopRunningThreads.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lTopRunningThreads.Location = New System.Drawing.Point(554, 26)
        Me.lTopRunningThreads.Name = "lTopRunningThreads"
        Me.lTopRunningThreads.Size = New System.Drawing.Size(132, 21)
        Me.lTopRunningThreads.TabIndex = 38
        Me.lTopRunningThreads.Text = "Running Thread(s): 0"
        Me.lTopRunningThreads.ThemeName = "TelerikMetro"
        '
        'lTopSentBacklinks
        '
        Me.lTopSentBacklinks.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lTopSentBacklinks.Location = New System.Drawing.Point(206, 26)
        Me.lTopSentBacklinks.Name = "lTopSentBacklinks"
        Me.lTopSentBacklinks.Size = New System.Drawing.Size(107, 21)
        Me.lTopSentBacklinks.TabIndex = 37
        Me.lTopSentBacklinks.Text = "Sent Backlinks: 0"
        Me.lTopSentBacklinks.ThemeName = "TelerikMetro"
        Me.ToolTipMain.SetToolTip(Me.lTopSentBacklinks, "Shows the total sent backlinks.")
        '
        'lTopSentPings
        '
        Me.lTopSentPings.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lTopSentPings.Location = New System.Drawing.Point(206, 3)
        Me.lTopSentPings.Name = "lTopSentPings"
        Me.lTopSentPings.Size = New System.Drawing.Size(84, 21)
        Me.lTopSentPings.TabIndex = 36
        Me.lTopSentPings.Text = "Sent Pings: 0"
        Me.lTopSentPings.ThemeName = "TelerikMetro"
        Me.ToolTipMain.SetToolTip(Me.lTopSentPings, "Show the total sent pings.")
        '
        'lTopTotalProxies
        '
        Me.lTopTotalProxies.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lTopTotalProxies.Location = New System.Drawing.Point(3, 26)
        Me.lTopTotalProxies.Name = "lTopTotalProxies"
        Me.lTopTotalProxies.Size = New System.Drawing.Size(98, 21)
        Me.lTopTotalProxies.TabIndex = 35
        Me.lTopTotalProxies.Text = "Total Proxies: 0"
        Me.lTopTotalProxies.ThemeName = "TelerikMetro"
        Me.ToolTipMain.SetToolTip(Me.lTopTotalProxies, "Shows the amount of proxies inside Proxy List.")
        '
        'lTopTotalLinks
        '
        Me.lTopTotalLinks.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lTopTotalLinks.Location = New System.Drawing.Point(3, 3)
        Me.lTopTotalLinks.Name = "lTopTotalLinks"
        Me.lTopTotalLinks.Size = New System.Drawing.Size(85, 21)
        Me.lTopTotalLinks.TabIndex = 34
        Me.lTopTotalLinks.Text = "Total Links: 0"
        Me.lTopTotalLinks.ThemeName = "TelerikMetro"
        Me.ToolTipMain.SetToolTip(Me.lTopTotalLinks, "Shows the amount of links iside Link List.")
        '
        'cmBtnPing
        '
        Me.cmBtnPing.Items.AddRange(New Telerik.WinControls.RadItem() {Me.RadMenuItemPingSend, Me.RadMenuItemPingSendBacklinks})
        Me.cmBtnPing.ThemeName = "TelerikMetro"
        '
        'RadMenuItemPingSend
        '
        Me.RadMenuItemPingSend.Items.AddRange(New Telerik.WinControls.RadItem() {Me.RadMenuItemPingSendAll, Me.RadMenuItemPingSendTicked, Me.RadMenuItemPingSendNew})
        Me.RadMenuItemPingSend.Name = "RadMenuItemPingSend"
        Me.RadMenuItemPingSend.Text = "Send Pings"
        '
        'RadMenuItemPingSendAll
        '
        Me.RadMenuItemPingSendAll.Name = "RadMenuItemPingSendAll"
        Me.RadMenuItemPingSendAll.Text = "Ping All links"
        '
        'RadMenuItemPingSendTicked
        '
        Me.RadMenuItemPingSendTicked.Name = "RadMenuItemPingSendTicked"
        Me.RadMenuItemPingSendTicked.Text = "Ping Ticked links"
        '
        'RadMenuItemPingSendNew
        '
        Me.RadMenuItemPingSendNew.Name = "RadMenuItemPingSendNew"
        Me.RadMenuItemPingSendNew.Text = "Ping New links"
        '
        'RadMenuItemPingSendBacklinks
        '
        Me.RadMenuItemPingSendBacklinks.Items.AddRange(New Telerik.WinControls.RadItem() {Me.RadMenuItemPingSendBacklinksAll, Me.RadMenuItemPingSendBacklinksTicked, Me.RadMenuItemPingSendBacklinksNew})
        Me.RadMenuItemPingSendBacklinks.Name = "RadMenuItemPingSendBacklinks"
        Me.RadMenuItemPingSendBacklinks.Text = "Send Backlinks"
        '
        'RadMenuItemPingSendBacklinksAll
        '
        Me.RadMenuItemPingSendBacklinksAll.Name = "RadMenuItemPingSendBacklinksAll"
        Me.RadMenuItemPingSendBacklinksAll.Text = "Index All links"
        '
        'RadMenuItemPingSendBacklinksTicked
        '
        Me.RadMenuItemPingSendBacklinksTicked.Name = "RadMenuItemPingSendBacklinksTicked"
        Me.RadMenuItemPingSendBacklinksTicked.Text = "Index Ticked links"
        '
        'RadMenuItemPingSendBacklinksNew
        '
        Me.RadMenuItemPingSendBacklinksNew.Name = "RadMenuItemPingSendBacklinksNew"
        Me.RadMenuItemPingSendBacklinksNew.Text = "Index New links"
        '
        'cmBtnImport
        '
        Me.cmBtnImport.Items.AddRange(New Telerik.WinControls.RadItem() {Me.RadMenuItemImportLinkFile, Me.RadMenuItemImportLinkClipboard, Me.RadMenuItemImportProxiesFile, Me.RadMenuItemImportProxyClipboard})
        Me.cmBtnImport.ThemeName = "TelerikMetro"
        '
        'RadMenuItemImportLinkFile
        '
        Me.RadMenuItemImportLinkFile.Name = "RadMenuItemImportLinkFile"
        Me.RadMenuItemImportLinkFile.Text = "Import links from File"
        '
        'RadMenuItemImportLinkClipboard
        '
        Me.RadMenuItemImportLinkClipboard.Name = "RadMenuItemImportLinkClipboard"
        Me.RadMenuItemImportLinkClipboard.Text = "Import links from Clipboard"
        '
        'RadMenuItemImportProxiesFile
        '
        Me.RadMenuItemImportProxiesFile.Name = "RadMenuItemImportProxiesFile"
        Me.RadMenuItemImportProxiesFile.Text = "Import proxies from File (IP:PORT)"
        '
        'RadMenuItemImportProxyClipboard
        '
        Me.RadMenuItemImportProxyClipboard.Name = "RadMenuItemImportProxyClipboard"
        Me.RadMenuItemImportProxyClipboard.Text = "Import proxies from Clipboard (IP:PORT)"
        '
        'cmBtnExport
        '
        Me.cmBtnExport.Items.AddRange(New Telerik.WinControls.RadItem() {Me.RadMenuItemExportTxt, Me.RadMenuItemExportCSV, Me.RadMenuSeparatorExport, Me.RadMenuItemExportBacklinkReport})
        Me.cmBtnExport.ThemeName = "TelerikMetro"
        '
        'RadMenuItemExportTxt
        '
        Me.RadMenuItemExportTxt.Items.AddRange(New Telerik.WinControls.RadItem() {Me.RadMenuItemExportTxtAll, Me.RadMenuItemExportTxtTicked})
        Me.RadMenuItemExportTxt.Name = "RadMenuItemExportTxt"
        Me.RadMenuItemExportTxt.Text = "Export as Textfile"
        '
        'RadMenuItemExportTxtAll
        '
        Me.RadMenuItemExportTxtAll.Name = "RadMenuItemExportTxtAll"
        Me.RadMenuItemExportTxtAll.Text = "Export All as .txt"
        '
        'RadMenuItemExportTxtTicked
        '
        Me.RadMenuItemExportTxtTicked.Name = "RadMenuItemExportTxtTicked"
        Me.RadMenuItemExportTxtTicked.Text = "Export Ticked as .txt"
        '
        'RadMenuItemExportCSV
        '
        Me.RadMenuItemExportCSV.Items.AddRange(New Telerik.WinControls.RadItem() {Me.RadMenuItemExportCSVAll, Me.RadMenuItemExportCSVTicked})
        Me.RadMenuItemExportCSV.Name = "RadMenuItemExportCSV"
        Me.RadMenuItemExportCSV.Text = "Export as CSV (Excel)"
        '
        'RadMenuItemExportCSVAll
        '
        Me.RadMenuItemExportCSVAll.Name = "RadMenuItemExportCSVAll"
        Me.RadMenuItemExportCSVAll.Text = "Export All as .csv"
        '
        'RadMenuItemExportCSVTicked
        '
        Me.RadMenuItemExportCSVTicked.Name = "RadMenuItemExportCSVTicked"
        Me.RadMenuItemExportCSVTicked.Text = "Export Ticked as .csv"
        '
        'RadMenuSeparatorExport
        '
        Me.RadMenuSeparatorExport.Name = "RadMenuSeparatorExport"
        Me.RadMenuSeparatorExport.Text = ""
        Me.RadMenuSeparatorExport.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RadMenuItemExportBacklinkReport
        '
        Me.RadMenuItemExportBacklinkReport.Name = "RadMenuItemExportBacklinkReport"
        Me.RadMenuItemExportBacklinkReport.Text = "Create Backlink report"
        '
        'cmBtnRemove
        '
        Me.cmBtnRemove.Items.AddRange(New Telerik.WinControls.RadItem() {Me.RadMenuItemRemoveLinkAll, Me.RadMenuItemRemoveLinkTicked, Me.RadMenuItemRemoveProxyAll, Me.RadMenuItemRemoveProxyTicked})
        Me.cmBtnRemove.ThemeName = "TelerikMetro"
        '
        'RadMenuItemRemoveLinkAll
        '
        Me.RadMenuItemRemoveLinkAll.Name = "RadMenuItemRemoveLinkAll"
        Me.RadMenuItemRemoveLinkAll.Text = "Remove all Links"
        '
        'RadMenuItemRemoveLinkTicked
        '
        Me.RadMenuItemRemoveLinkTicked.Name = "RadMenuItemRemoveLinkTicked"
        Me.RadMenuItemRemoveLinkTicked.Text = "Remove Ticked links"
        '
        'RadMenuItemRemoveProxyAll
        '
        Me.RadMenuItemRemoveProxyAll.Name = "RadMenuItemRemoveProxyAll"
        Me.RadMenuItemRemoveProxyAll.Text = "Remove All proxies"
        '
        'RadMenuItemRemoveProxyTicked
        '
        Me.RadMenuItemRemoveProxyTicked.Name = "RadMenuItemRemoveProxyTicked"
        Me.RadMenuItemRemoveProxyTicked.Text = "Remove Ticked proxies"
        '
        'TimerRefreshObjects
        '
        Me.TimerRefreshObjects.Interval = 10000
        '
        'TimerRefreshStatus
        '
        Me.TimerRefreshStatus.Interval = 5000
        '
        'TimerParseProxies
        '
        '
        'TimerProxyHandler
        '
        Me.TimerProxyHandler.Interval = 10000
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1016, 445)
        Me.Controls.Add(Me.TableLayoutPanelMain)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmMain"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bulk Ping v2"
        Me.ThemeName = "TelerikMetro"
        Me.TableLayoutPanelMain.ResumeLayout(False)
        CType(Me.btnStop, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnPing, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnRemove, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PageViewMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PageViewMain.ResumeLayout(False)
        Me.RadPageViewMainLinkList.ResumeLayout(False)
        CType(Me.folvLink, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPageViewMainProxyList.ResumeLayout(False)
        CType(Me.folvProxy, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPageViewMainPingServices.ResumeLayout(False)
        Me.RadPageViewMainPingServices.PerformLayout()
        CType(Me.BtnPingservicesSaveChanges, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnPingservicesLoadDefault, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPageViewMainKeywords.ResumeLayout(False)
        Me.RadPageViewMainKeywords.PerformLayout()
        CType(Me.BtnKeywordsSaveChanges, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnKeywordsLoadDefault, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPageViewMainSettings.ResumeLayout(False)
        Me.PanelGeneralSettings.ResumeLayout(False)
        Me.PanelGeneralSettings.PerformLayout()
        CType(Me.cbPingBacklinks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSettingsParseProxiesPath, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSettingsParseProxiesBrowse, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbSettingsParseProxies, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cbSettingsParseProxies.ResumeLayout(False)
        Me.cbSettingsParseProxies.PerformLayout()
        CType(Me.txtSettingsParseProxiesMinutes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbSettingsDeleteDownProxies, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbSettingsEnableProxies, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lCurMaxThreads, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbSettingsSaveProxiesOnExit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnApplyThreads, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbSettingsEnableLogging, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbSettingsEnableGridlines, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbSettingsSaveLinksOnExit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbSaveSettingsOnExit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtThreadsValue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTimeoutValue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lTimeout, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lThreads, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lGeneralSettings, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnExportLinks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnImportLinks, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelTopStats.ResumeLayout(False)
        Me.PanelTopStats.PerformLayout()
        CType(Me.lTopRunningThreads, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lTopSentBacklinks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lTopSentPings, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lTopTotalProxies, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lTopTotalLinks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MetroTheme As Telerik.WinControls.Themes.TelerikMetroTheme
    Friend WithEvents TableLayoutPanelMain As TableLayoutPanel
    Friend WithEvents btnRemove As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnPing As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnExportLinks As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnImportLinks As Telerik.WinControls.UI.RadButton
    Friend WithEvents PageViewMain As Telerik.WinControls.UI.RadPageView
    Friend WithEvents RadPageViewMainLinkList As Telerik.WinControls.UI.RadPageViewPage
    Friend WithEvents RadPageViewMainProxyList As Telerik.WinControls.UI.RadPageViewPage
    Friend WithEvents btnStop As Telerik.WinControls.UI.RadButton
    Friend WithEvents cmBtnPing As Telerik.WinControls.UI.RadContextMenu
    Friend WithEvents RadMenuItemPingSend As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents RadMenuItemPingSendAll As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents RadMenuItemPingSendTicked As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents RadMenuItemPingSendNew As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents RadMenuItemPingSendBacklinks As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents RadMenuItemPingSendBacklinksAll As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents RadMenuItemPingSendBacklinksTicked As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents RadMenuItemPingSendBacklinksNew As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents cmBtnImport As Telerik.WinControls.UI.RadContextMenu
    Friend WithEvents RadMenuItemImportLinkFile As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents RadMenuItemImportLinkClipboard As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents RadMenuItemImportProxiesFile As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents RadMenuItemImportProxyClipboard As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents RadPageViewMainKeywords As Telerik.WinControls.UI.RadPageViewPage
    Friend WithEvents RadPageViewMainPingServices As Telerik.WinControls.UI.RadPageViewPage
    Friend WithEvents RadPageViewMainSettings As Telerik.WinControls.UI.RadPageViewPage
    Friend WithEvents cmBtnExport As Telerik.WinControls.UI.RadContextMenu
    Friend WithEvents cmBtnRemove As Telerik.WinControls.UI.RadContextMenu
    Friend WithEvents RadMenuItemExportTxt As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents RadMenuItemExportTxtAll As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents RadMenuItemExportTxtTicked As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents RadMenuItemExportCSV As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents RadMenuItemExportCSVAll As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents RadMenuItemExportCSVTicked As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents RadMenuSeparatorExport As Telerik.WinControls.UI.RadMenuSeparatorItem
    Friend WithEvents RadMenuItemExportBacklinkReport As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents RadMenuItemRemoveLinkAll As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents RadMenuItemRemoveLinkTicked As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents RadMenuItemRemoveProxyAll As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents RadMenuItemRemoveProxyTicked As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents PanelGeneralSettings As Panel
    Friend WithEvents cbSettingsEnableProxies As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents lCurMaxThreads As Telerik.WinControls.UI.RadLabel
    Friend WithEvents cbSettingsSaveProxiesOnExit As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents btnApplyThreads As Telerik.WinControls.UI.RadButton
    Friend WithEvents cbSettingsEnableLogging As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents cbSettingsEnableGridlines As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents cbSettingsSaveLinksOnExit As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents cbSaveSettingsOnExit As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents txtThreadsValue As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txtTimeoutValue As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents lTimeout As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lThreads As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lGeneralSettings As Telerik.WinControls.UI.RadLabel
    Friend WithEvents folvLink As BrightIdeasSoftware.FastObjectListView
    Friend WithEvents folvProxy As BrightIdeasSoftware.FastObjectListView
    Friend WithEvents cbSettingsDeleteDownProxies As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents btnSettingsParseProxiesBrowse As Telerik.WinControls.UI.RadButton
    Friend WithEvents txtSettingsParseProxiesMinutes As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents cbSettingsParseProxies As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents BtnPingservicesSaveChanges As Telerik.WinControls.UI.RadButton
    Friend WithEvents BtnPingservicesLoadDefault As Telerik.WinControls.UI.RadButton
    Friend WithEvents BtnKeywordsSaveChanges As Telerik.WinControls.UI.RadButton
    Friend WithEvents BtnKeywordsLoadDefault As Telerik.WinControls.UI.RadButton
    Friend WithEvents TxtPingservices As TextBox
    Friend WithEvents TxtKeywords As TextBox
    Friend WithEvents TimerRefreshObjects As Timer
    Friend WithEvents PanelTopStats As Panel
    Friend WithEvents btnChangelog As Button
    Friend WithEvents btnUpdateAvailable As Button
    Friend WithEvents btnGetProVersion As Button
    Friend WithEvents btnActivateProVersion As Button
    Friend WithEvents btnReportBug As Button
    Friend WithEvents btnHelp As Button
    Friend WithEvents lTopRunningThreads As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lTopSentBacklinks As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lTopSentPings As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lTopTotalProxies As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lTopTotalLinks As Telerik.WinControls.UI.RadLabel
    Friend WithEvents TimerRefreshStatus As Timer
    Friend WithEvents txtSettingsParseProxiesPath As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents TimerParseProxies As Timer
    Friend WithEvents TimerProxyHandler As Timer
    Friend WithEvents ToolTipMain As ToolTip
    Friend WithEvents cbPingBacklinks As Telerik.WinControls.UI.RadCheckBox
End Class
