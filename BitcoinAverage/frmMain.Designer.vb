<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.txtTmp = New System.Windows.Forms.TextBox()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MarketToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.USDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EURToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CNYToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GBPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CADToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.LayoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SmallToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StandardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlwaysOnTopToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DonateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblcode = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.rshpMainScreen = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.tmrGetTicker = New System.Windows.Forms.Timer(Me.components)
        Me.lblSymbol = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblSmallLayout = New System.Windows.Forms.Button()
        Me.lnkBA = New System.Windows.Forms.LinkLabel()
        Me.lblHigh = New System.Windows.Forms.Label()
        Me.lblLow = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblAverage = New System.Windows.Forms.Label()
        Me.btnUSD = New System.Windows.Forms.Button()
        Me.btnEUR = New System.Windows.Forms.Button()
        Me.btnCNY = New System.Windows.Forms.Button()
        Me.btnGBP = New System.Windows.Forms.Button()
        Me.btnCAD = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblVolCurrencyTmp = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblVolBTC = New System.Windows.Forms.Label()
        Me.lblVolCurrency = New System.Windows.Forms.Label()
        Me.lblTimestamp = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtTmp
        '
        Me.txtTmp.Location = New System.Drawing.Point(93, 218)
        Me.txtTmp.Multiline = True
        Me.txtTmp.Name = "txtTmp"
        Me.txtTmp.Size = New System.Drawing.Size(264, 89)
        Me.txtTmp.TabIndex = 0
        Me.txtTmp.Visible = False
        '
        'lblPrice
        '
        Me.lblPrice.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblPrice.AutoSize = True
        Me.lblPrice.BackColor = System.Drawing.SystemColors.Control
        Me.lblPrice.ContextMenuStrip = Me.ContextMenuStrip1
        Me.lblPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblPrice.ForeColor = System.Drawing.Color.SteelBlue
        Me.lblPrice.Location = New System.Drawing.Point(165, 96)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(45, 13)
        Me.lblPrice.TabIndex = 1
        Me.lblPrice.Text = "Label1"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MarketToolStripMenuItem, Me.ToolStripMenuItem1, Me.LayoutToolStripMenuItem, Me.OptionsToolStripMenuItem, Me.DonateToolStripMenuItem, Me.AboutToolStripMenuItem, Me.ToolStripSeparator1, Me.ExitToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(117, 148)
        '
        'MarketToolStripMenuItem
        '
        Me.MarketToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.USDToolStripMenuItem, Me.EURToolStripMenuItem, Me.CNYToolStripMenuItem, Me.GBPToolStripMenuItem, Me.CADToolStripMenuItem})
        Me.MarketToolStripMenuItem.Name = "MarketToolStripMenuItem"
        Me.MarketToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.MarketToolStripMenuItem.Text = "Market"
        '
        'USDToolStripMenuItem
        '
        Me.USDToolStripMenuItem.Name = "USDToolStripMenuItem"
        Me.USDToolStripMenuItem.Size = New System.Drawing.Size(98, 22)
        Me.USDToolStripMenuItem.Text = "USD"
        '
        'EURToolStripMenuItem
        '
        Me.EURToolStripMenuItem.Name = "EURToolStripMenuItem"
        Me.EURToolStripMenuItem.Size = New System.Drawing.Size(98, 22)
        Me.EURToolStripMenuItem.Text = "EUR"
        '
        'CNYToolStripMenuItem
        '
        Me.CNYToolStripMenuItem.Name = "CNYToolStripMenuItem"
        Me.CNYToolStripMenuItem.Size = New System.Drawing.Size(98, 22)
        Me.CNYToolStripMenuItem.Text = "CNY"
        '
        'GBPToolStripMenuItem
        '
        Me.GBPToolStripMenuItem.Name = "GBPToolStripMenuItem"
        Me.GBPToolStripMenuItem.Size = New System.Drawing.Size(98, 22)
        Me.GBPToolStripMenuItem.Text = "GBP"
        '
        'CADToolStripMenuItem
        '
        Me.CADToolStripMenuItem.Name = "CADToolStripMenuItem"
        Me.CADToolStripMenuItem.Size = New System.Drawing.Size(98, 22)
        Me.CADToolStripMenuItem.Text = "CAD"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(113, 6)
        '
        'LayoutToolStripMenuItem
        '
        Me.LayoutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SmallToolStripMenuItem, Me.StandardToolStripMenuItem})
        Me.LayoutToolStripMenuItem.Name = "LayoutToolStripMenuItem"
        Me.LayoutToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.LayoutToolStripMenuItem.Text = "Layout"
        '
        'SmallToolStripMenuItem
        '
        Me.SmallToolStripMenuItem.Name = "SmallToolStripMenuItem"
        Me.SmallToolStripMenuItem.Size = New System.Drawing.Size(121, 22)
        Me.SmallToolStripMenuItem.Text = "Small"
        '
        'StandardToolStripMenuItem
        '
        Me.StandardToolStripMenuItem.Name = "StandardToolStripMenuItem"
        Me.StandardToolStripMenuItem.Size = New System.Drawing.Size(121, 22)
        Me.StandardToolStripMenuItem.Text = "Standard"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AlwaysOnTopToolStripMenuItem})
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.OptionsToolStripMenuItem.Text = "Options"
        '
        'AlwaysOnTopToolStripMenuItem
        '
        Me.AlwaysOnTopToolStripMenuItem.CheckOnClick = True
        Me.AlwaysOnTopToolStripMenuItem.Name = "AlwaysOnTopToolStripMenuItem"
        Me.AlwaysOnTopToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AlwaysOnTopToolStripMenuItem.Text = "Always on Top"
        '
        'DonateToolStripMenuItem
        '
        Me.DonateToolStripMenuItem.Name = "DonateToolStripMenuItem"
        Me.DonateToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.DonateToolStripMenuItem.Text = "Donate"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(113, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'lblcode
        '
        Me.lblcode.AutoSize = True
        Me.lblcode.BackColor = System.Drawing.SystemColors.Control
        Me.lblcode.ContextMenuStrip = Me.ContextMenuStrip1
        Me.lblcode.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblcode.Location = New System.Drawing.Point(260, 94)
        Me.lblcode.Name = "lblcode"
        Me.lblcode.Size = New System.Drawing.Size(39, 13)
        Me.lblcode.TabIndex = 2
        Me.lblcode.Text = "Label1"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape2, Me.LineShape1, Me.rshpMainScreen})
        Me.ShapeContainer1.Size = New System.Drawing.Size(465, 310)
        Me.ShapeContainer1.TabIndex = 3
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape2
        '
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 35
        Me.LineShape2.X2 = 430
        Me.LineShape2.Y1 = 120
        Me.LineShape2.Y2 = 120
        '
        'LineShape1
        '
        Me.LineShape1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 232
        Me.LineShape1.X2 = 232
        Me.LineShape1.Y1 = 0
        Me.LineShape1.Y2 = 269
        '
        'rshpMainScreen
        '
        Me.rshpMainScreen.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rshpMainScreen.BackColor = System.Drawing.SystemColors.Control
        Me.rshpMainScreen.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.rshpMainScreen.BorderColor = System.Drawing.Color.SteelBlue
        Me.rshpMainScreen.BorderWidth = 3
        Me.rshpMainScreen.ContextMenuStrip = Me.ContextMenuStrip1
        Me.rshpMainScreen.CornerRadius = 15
        Me.rshpMainScreen.Location = New System.Drawing.Point(21, 21)
        Me.rshpMainScreen.Name = "rshpMainScreen"
        Me.rshpMainScreen.Size = New System.Drawing.Size(423, 268)
        '
        'tmrGetTicker
        '
        Me.tmrGetTicker.Enabled = True
        Me.tmrGetTicker.Interval = 60000
        '
        'lblSymbol
        '
        Me.lblSymbol.AutoSize = True
        Me.lblSymbol.BackColor = System.Drawing.SystemColors.Control
        Me.lblSymbol.ContextMenuStrip = Me.ContextMenuStrip1
        Me.lblSymbol.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblSymbol.Location = New System.Drawing.Point(103, 96)
        Me.lblSymbol.Name = "lblSymbol"
        Me.lblSymbol.Size = New System.Drawing.Size(39, 13)
        Me.lblSymbol.TabIndex = 4
        Me.lblSymbol.Text = "Label1"
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.BackColor = System.Drawing.SystemColors.Control
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnClose.Location = New System.Drawing.Point(410, 34)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(24, 23)
        Me.btnClose.TabIndex = 5
        Me.btnClose.Text = "X"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'lblSmallLayout
        '
        Me.lblSmallLayout.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSmallLayout.BackColor = System.Drawing.SystemColors.Control
        Me.lblSmallLayout.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblSmallLayout.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblSmallLayout.Location = New System.Drawing.Point(380, 34)
        Me.lblSmallLayout.Name = "lblSmallLayout"
        Me.lblSmallLayout.Size = New System.Drawing.Size(24, 23)
        Me.lblSmallLayout.TabIndex = 6
        Me.lblSmallLayout.Text = "S"
        Me.lblSmallLayout.UseVisualStyleBackColor = False
        '
        'lnkBA
        '
        Me.lnkBA.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lnkBA.AutoSize = True
        Me.lnkBA.BackColor = System.Drawing.SystemColors.Control
        Me.lnkBA.Location = New System.Drawing.Point(296, 268)
        Me.lnkBA.Name = "lnkBA"
        Me.lnkBA.Size = New System.Drawing.Size(135, 13)
        Me.lnkBA.TabIndex = 7
        Me.lnkBA.TabStop = True
        Me.lnkBA.Text = "BitcoinAverage Price Index"
        '
        'lblHigh
        '
        Me.lblHigh.AutoSize = True
        Me.lblHigh.BackColor = System.Drawing.SystemColors.Control
        Me.lblHigh.ContextMenuStrip = Me.ContextMenuStrip1
        Me.lblHigh.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblHigh.ForeColor = System.Drawing.Color.SteelBlue
        Me.lblHigh.Location = New System.Drawing.Point(99, 130)
        Me.lblHigh.Name = "lblHigh"
        Me.lblHigh.Size = New System.Drawing.Size(53, 25)
        Me.lblHigh.TabIndex = 8
        Me.lblHigh.Text = "high"
        '
        'lblLow
        '
        Me.lblLow.AutoSize = True
        Me.lblLow.BackColor = System.Drawing.SystemColors.Control
        Me.lblLow.ContextMenuStrip = Me.ContextMenuStrip1
        Me.lblLow.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblLow.ForeColor = System.Drawing.Color.SteelBlue
        Me.lblLow.Location = New System.Drawing.Point(99, 165)
        Me.lblLow.Name = "lblLow"
        Me.lblLow.Size = New System.Drawing.Size(53, 25)
        Me.lblLow.TabIndex = 9
        Me.lblLow.Text = "high"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label1.Location = New System.Drawing.Point(40, 165)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 25)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "low "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label2.Location = New System.Drawing.Point(40, 130)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 25)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "high"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label3.Location = New System.Drawing.Point(40, 199)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 25)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "avg"
        '
        'lblAverage
        '
        Me.lblAverage.AutoSize = True
        Me.lblAverage.BackColor = System.Drawing.SystemColors.Control
        Me.lblAverage.ContextMenuStrip = Me.ContextMenuStrip1
        Me.lblAverage.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblAverage.ForeColor = System.Drawing.Color.SteelBlue
        Me.lblAverage.Location = New System.Drawing.Point(99, 199)
        Me.lblAverage.Name = "lblAverage"
        Me.lblAverage.Size = New System.Drawing.Size(53, 25)
        Me.lblAverage.TabIndex = 13
        Me.lblAverage.Text = "high"
        '
        'btnUSD
        '
        Me.btnUSD.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnUSD.BackColor = System.Drawing.SystemColors.Control
        Me.btnUSD.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnUSD.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnUSD.Location = New System.Drawing.Point(42, 34)
        Me.btnUSD.Name = "btnUSD"
        Me.btnUSD.Size = New System.Drawing.Size(57, 23)
        Me.btnUSD.TabIndex = 14
        Me.btnUSD.Text = "USD"
        Me.btnUSD.UseVisualStyleBackColor = False
        '
        'btnEUR
        '
        Me.btnEUR.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEUR.BackColor = System.Drawing.SystemColors.Control
        Me.btnEUR.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEUR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnEUR.Location = New System.Drawing.Point(105, 34)
        Me.btnEUR.Name = "btnEUR"
        Me.btnEUR.Size = New System.Drawing.Size(57, 23)
        Me.btnEUR.TabIndex = 15
        Me.btnEUR.Text = "EUR"
        Me.btnEUR.UseVisualStyleBackColor = False
        '
        'btnCNY
        '
        Me.btnCNY.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCNY.BackColor = System.Drawing.SystemColors.Control
        Me.btnCNY.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCNY.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnCNY.Location = New System.Drawing.Point(168, 34)
        Me.btnCNY.Name = "btnCNY"
        Me.btnCNY.Size = New System.Drawing.Size(57, 23)
        Me.btnCNY.TabIndex = 16
        Me.btnCNY.Text = "CNY"
        Me.btnCNY.UseVisualStyleBackColor = False
        '
        'btnGBP
        '
        Me.btnGBP.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGBP.BackColor = System.Drawing.SystemColors.Control
        Me.btnGBP.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnGBP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnGBP.Location = New System.Drawing.Point(231, 34)
        Me.btnGBP.Name = "btnGBP"
        Me.btnGBP.Size = New System.Drawing.Size(57, 23)
        Me.btnGBP.TabIndex = 17
        Me.btnGBP.Text = "GBP"
        Me.btnGBP.UseVisualStyleBackColor = False
        '
        'btnCAD
        '
        Me.btnCAD.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCAD.BackColor = System.Drawing.SystemColors.Control
        Me.btnCAD.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCAD.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnCAD.Location = New System.Drawing.Point(294, 34)
        Me.btnCAD.Name = "btnCAD"
        Me.btnCAD.Size = New System.Drawing.Size(57, 23)
        Me.btnCAD.TabIndex = 18
        Me.btnCAD.Text = "CAD"
        Me.btnCAD.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label4.Location = New System.Drawing.Point(210, 130)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 25)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "vol (BTC)"
        '
        'lblVolCurrencyTmp
        '
        Me.lblVolCurrencyTmp.AutoSize = True
        Me.lblVolCurrencyTmp.BackColor = System.Drawing.SystemColors.Control
        Me.lblVolCurrencyTmp.ContextMenuStrip = Me.ContextMenuStrip1
        Me.lblVolCurrencyTmp.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblVolCurrencyTmp.Location = New System.Drawing.Point(210, 165)
        Me.lblVolCurrencyTmp.Name = "lblVolCurrencyTmp"
        Me.lblVolCurrencyTmp.Size = New System.Drawing.Size(96, 25)
        Me.lblVolCurrencyTmp.TabIndex = 20
        Me.lblVolCurrencyTmp.Text = "vol (???)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label6.Location = New System.Drawing.Point(192, 199)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(110, 25)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "timestamp"
        '
        'lblVolBTC
        '
        Me.lblVolBTC.AutoSize = True
        Me.lblVolBTC.BackColor = System.Drawing.SystemColors.Control
        Me.lblVolBTC.ContextMenuStrip = Me.ContextMenuStrip1
        Me.lblVolBTC.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblVolBTC.ForeColor = System.Drawing.Color.SteelBlue
        Me.lblVolBTC.Location = New System.Drawing.Point(318, 130)
        Me.lblVolBTC.Name = "lblVolBTC"
        Me.lblVolBTC.Size = New System.Drawing.Size(53, 25)
        Me.lblVolBTC.TabIndex = 22
        Me.lblVolBTC.Text = "high"
        '
        'lblVolCurrency
        '
        Me.lblVolCurrency.AutoSize = True
        Me.lblVolCurrency.BackColor = System.Drawing.SystemColors.Control
        Me.lblVolCurrency.ContextMenuStrip = Me.ContextMenuStrip1
        Me.lblVolCurrency.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblVolCurrency.ForeColor = System.Drawing.Color.SteelBlue
        Me.lblVolCurrency.Location = New System.Drawing.Point(318, 165)
        Me.lblVolCurrency.Name = "lblVolCurrency"
        Me.lblVolCurrency.Size = New System.Drawing.Size(53, 25)
        Me.lblVolCurrency.TabIndex = 23
        Me.lblVolCurrency.Text = "high"
        '
        'lblTimestamp
        '
        Me.lblTimestamp.AutoSize = True
        Me.lblTimestamp.BackColor = System.Drawing.SystemColors.Control
        Me.lblTimestamp.ContextMenuStrip = Me.ContextMenuStrip1
        Me.lblTimestamp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblTimestamp.ForeColor = System.Drawing.Color.SteelBlue
        Me.lblTimestamp.Location = New System.Drawing.Point(302, 206)
        Me.lblTimestamp.Name = "lblTimestamp"
        Me.lblTimestamp.Size = New System.Drawing.Size(33, 16)
        Me.lblTimestamp.TabIndex = 24
        Me.lblTimestamp.Text = "high"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(465, 310)
        Me.Controls.Add(Me.lblTimestamp)
        Me.Controls.Add(Me.lblVolCurrency)
        Me.Controls.Add(Me.lblVolBTC)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblVolCurrencyTmp)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnCAD)
        Me.Controls.Add(Me.btnGBP)
        Me.Controls.Add(Me.btnCNY)
        Me.Controls.Add(Me.btnEUR)
        Me.Controls.Add(Me.btnUSD)
        Me.Controls.Add(Me.lblAverage)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblHigh)
        Me.Controls.Add(Me.lblLow)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lnkBA)
        Me.Controls.Add(Me.lblSmallLayout)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lblSymbol)
        Me.Controls.Add(Me.lblcode)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.txtTmp)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.TransparencyKey = System.Drawing.Color.White
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtTmp As System.Windows.Forms.TextBox
    Friend WithEvents lblPrice As System.Windows.Forms.Label
    Friend WithEvents lblcode As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents rshpMainScreen As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents tmrGetTicker As System.Windows.Forms.Timer
    Friend WithEvents lblSymbol As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents lblSmallLayout As System.Windows.Forms.Button
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents OptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AlwaysOnTopToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LayoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SmallToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StandardToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MarketToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents USDToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EURToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CNYToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GBPToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CADToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DonateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lnkBA As System.Windows.Forms.LinkLabel
    Friend WithEvents lblHigh As System.Windows.Forms.Label
    Friend WithEvents lblLow As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblAverage As System.Windows.Forms.Label
    Friend WithEvents btnUSD As System.Windows.Forms.Button
    Friend WithEvents btnEUR As System.Windows.Forms.Button
    Friend WithEvents btnCNY As System.Windows.Forms.Button
    Friend WithEvents btnGBP As System.Windows.Forms.Button
    Friend WithEvents btnCAD As System.Windows.Forms.Button
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblVolCurrencyTmp As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblVolBTC As System.Windows.Forms.Label
    Friend WithEvents lblVolCurrency As System.Windows.Forms.Label
    Friend WithEvents lblTimestamp As System.Windows.Forms.Label

End Class
