Imports System
Imports System.Collections.Generic
Imports Newtonsoft.Json.Linq
Imports Newtonsoft.Json


Public Class frmMain
    Const meX As Integer = 480
    Const meY As Integer = 270

    Dim layoutME As String
    Dim BASC As BitcoinAverageStructure.Current_Market
    Dim BASA As BitcoinAverageStructure.Available_Market

    Private Sub frmMain_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        SaveSetting(My.Application.Info.ProductName, "Options", "Window Position Left", Me.Left)
        SaveSetting(My.Application.Info.ProductName, "Options", "Window Position Top", Me.Top)
        SaveSetting(My.Application.Info.ProductName, "Options", "layoutME", layoutME)
        SaveSetting(My.Application.Info.ProductName, "Options", "TopMost", AlwaysOnTopToolStripMenuItem.Checked)
        SaveSetting(My.Application.Info.ProductName, "Options", "MarketC", BASC.Currency_Code)
        SaveSetting(My.Application.Info.ProductName, "Options", "MarketS", BASC.Currency_Symbol)
    End Sub


    Private Sub frmMain_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If My.Application.Info.Title <> "" Then Me.Text = My.Application.Info.Title
        Me.Left = GetSetting(My.Application.Info.ProductName, "Options", "Window Position Left", Screen.PrimaryScreen.Bounds.Width / 2 - Me.Width / 2)
        Me.Top = GetSetting(My.Application.Info.ProductName, "Options", "Window Position Top", Screen.PrimaryScreen.Bounds.Height / 2 - Me.Height / 2)
        Me.Width = meX
        Me.Height = mey
        BASA.EUR.code = "EUR"
        BASA.USD.code = "USD"
        BASA.CNY.code = "CNY"
        BASA.GBP.code = "GBP"
        BASA.CAD.code = "CAD"
        BASA.USD.symbol = "$"
        BASA.EUR.symbol = "€"
        BASA.CNY.symbol = "¥"
        BASA.GBP.symbol = "£"
        BASA.CAD.symbol = "$"
        BASC.Currency_Symbol = GetSetting(My.Application.Info.ProductName, "Options", "MarketS", BASA.EUR.symbol)
        BASC.Currency_Code = GetSetting(My.Application.Info.ProductName, "Options", "MarketC", BASA.EUR.code)
        layoutME = GetSetting(My.Application.Info.ProductName, "Options", "layoutME", "standard")
        If GetSetting(My.Application.Info.ProductName, "Options", "TopMost", False) = True Then AlwaysOnTopToolStripMenuItem.PerformClick()





        'lblPrice.Font = New Font("Arial", ClientSize.Height / 8)
        ''lblMarket.Top = lblPrice.Top + lblPrice.height
        'lblMarket.Left = lblPrice.Left + lblPrice.Width
        'lblMarket.Font = New Font("Arial", ClientSize.Height / 16)
        'frmMain_SizeChanged(Me, e)

        LineShape1.Visible = False
    End Sub

    Private Sub frmMain_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown
        Me.Refresh()
        GetNewData(BASC.Currency_Code)
    End Sub

    Private Sub frmMain_SizeChanged(sender As Object, e As System.EventArgs) Handles Me.SizeChanged
        'LineShape1.X1 = Me.Width / 2
        'LineShape1.X2 = Me.Width / 2
        'LineShape1.Y1 = 0
        'LineShape1.Y2 = Me.Height

        'lblPrice.Font = New Font("Arial", ClientSize.Height / 8)
        'lblMarket.Font = New Font("Arial", ClientSize.Height / 16)
        'lblPrice.Top = (rshpMainScreen.Top + rshpMainScreen.Height / 4)
        'lblPrice.Refresh()
        'lblPrice.Left = ((rshpMainScreen.Width / 2) - (lblPrice.Width / 2)) ' - (lblMarket.Width / 2)
        'lblMarket.Left = lblPrice.Left + lblPrice.Width
        'lblMarket.Top = lblPrice.Top

        ''Me.Width = lblPrice.Left + lblPrice.Width + lblMarket.Left + lblMarket.Width
        'txtTmp.Text = (rshpMainScreen.Width / 2) - lblPrice.Width / 2 '- lblMarket.Left / 2
        'txtTmp.AppendText(vbCrLf & rshpMainScreen.Width)
        'txtTmp.AppendText(vbCrLf & lblPrice.Width)
    End Sub

    Private Sub RectangleShape1_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles rshpMainScreen.MouseDown, lblPrice.MouseDown, lblcode.MouseDown, lblSymbol.MouseDown, lblAverage.MouseDown, lblHigh.MouseDown, lblLow.MouseDown, lblTimestamp.MouseDown, lblVolBTC.MouseDown, lblVolCurrency.MouseDown, Label1.MouseDown, Label2.MouseDown, Label3.MouseDown, Label4.MouseDown, lblVolCurrencyTmp.MouseDown, Label6.MouseDown
        If e.Button = MouseButtons.Left Then
            ShapeContainer1.Capture = False
            For Each C As Control In Me.Controls
                If TypeOf C Is Label Then C.Capture = False
            Next

            ' Create and send a WM_NCLBUTTONDOWN message.
            Const WM_NCLBUTTONDOWN As Integer = &HA1S
            Const HTCAPTION As Integer = 2
            Dim msg As Message = Message.Create(Me.Handle, WM_NCLBUTTONDOWN, New IntPtr(HTCAPTION), IntPtr.Zero)
            Me.DefWndProc(msg)
        End If
    End Sub

    Private Sub SmallToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SmallToolStripMenuItem.Click, lblSmallLayout.Click

        layoutME = "small"
        StandardToolStripMenuItem.Checked = False
        SmallToolStripMenuItem.Checked = True
        Me.Height = 100

        lblPrice.Font = New Font("Arial", (ClientSize.Height / 4))
        lblcode.Font = New Font("Arial", (ClientSize.Height / 8))
        lblSymbol.Font = New Font("Arial", (ClientSize.Height / 8))
        Me.Width = lblSymbol.Width + lblPrice.Width + lblcode.Width + 60
        lblPrice.Top = (rshpMainScreen.Top + rshpMainScreen.Height / 4) - 6
        lblPrice.Refresh()
        lblPrice.Left = ((rshpMainScreen.Width / 2) - (lblPrice.Width / 2)) + 12 ' - (lblMarket.Width / 2)
        lblcode.Left = lblPrice.Left + lblPrice.Width
        lblcode.Top = lblPrice.Top
        lblSymbol.Left = lblPrice.Left - lblSymbol.Width
        lblSymbol.Top = lblPrice.Top



        For Each C As Control In Me.Controls
            If TypeOf C Is Button Then C.Visible = False
        Next
        lnkBA.Visible = False


        'frmMain_SizeChanged(Me, e)
    End Sub
    Sub refreshME()
        If layoutME = "small" Then
            SmallToolStripMenuItem.PerformClick()
        Else
            StandardToolStripMenuItem.PerformClick()
        End If
    End Sub
    Private Sub StandardToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles StandardToolStripMenuItem.Click
        layoutME = "standard"
        SmallToolStripMenuItem.Checked = False
        StandardToolStripMenuItem.Checked = True


        Me.Width = mex
        Me.Height = mey

        lblPrice.Font = New Font("Arial", ClientSize.Height / 8)
        lblcode.Font = New Font("Arial", ClientSize.Height / 16)
        lblSymbol.Font = New Font("Arial", ClientSize.Height / 16)
        lblPrice.Top = (rshpMainScreen.Top + rshpMainScreen.Height / 4) - 10
        lblPrice.Refresh()
        lblPrice.Left = ((rshpMainScreen.Width / 2) - (lblPrice.Width / 2)) ' - (lblMarket.Width / 2)
        lblcode.Left = lblPrice.Left + lblPrice.Width
        lblcode.Top = lblPrice.Top
        lblSymbol.Left = lblPrice.Left - lblSymbol.Width
        lblSymbol.Top = lblPrice.Top

        For Each C As Control In Me.Controls
            If TypeOf C Is Button Then C.Visible = True
        Next
        lnkBA.Visible = True

        'frmMain_SizeChanged(Me, e)
    End Sub

    Private Sub tmrGetTicker_Tick(sender As System.Object, e As System.EventArgs) Handles tmrGetTicker.Tick
        GetNewData(BASC.Currency_Code)
    End Sub

    Private Sub GetNewData(symbol As String)
        Try
            Dim tmpResponseFromServer As String = JSON_GET("https://api.bitcoinaverage.com/ticker/" & symbol) '"https://api.bitcoinaverage.com/ticker/EUR/"
            'txtTmp.Text = tmpResponseFromServer

            If tmpResponseFromServer = "" Then Exit Sub
            Dim ticker As BitcoinAverage.Ticker = JsonConvert.DeserializeObject(Of BitcoinAverage.Ticker)(RepairTicker(tmpResponseFromServer))
            lblPrice.Text = FormatNumber(ticker.last, 2)
            lblHigh.Text = FormatNumber(ticker.ask, 2)
            lblLow.Text = FormatNumber(ticker.bid, 2)
            lblAverage.Text = FormatNumber(ticker.avg_24h, 2)
            lblcode.Text = BASC.Currency_Code
            lblSymbol.Text = BASC.Currency_Symbol
            lblVolCurrencyTmp.Text = "vol (" & BASC.Currency_Code & ")"
            lblVolCurrency.Text = FormatNumber(ticker.total_vol, 2) & " M"
            lblVolBTC.Text = FormatNumber(ticker.total_vol / ticker.avg_24h, 2) & " K"
            lblTimestamp.Text = FormatDateTime(ticker.timestamp)
            txtTmp.AppendText(ticker.avg_24h)
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        Finally

        End Try
        refreshME()
    End Sub

    Private Sub USDToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles USDToolStripMenuItem.Click, btnUSD.Click
        BASC.Currency_Code = BASA.USD.code
        BASC.Currency_Code = BASA.USD.code
        BASC.Currency_Symbol = BASA.USD.symbol
        tmrGetTicker_Tick(Me, e)
    End Sub

    Private Sub EURToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EURToolStripMenuItem.Click, btnEUR.Click
        BASC.Currency_Code = BASA.EUR.code
        BASC.Currency_Code = BASA.EUR.code
        BASC.Currency_Symbol = BASA.EUR.symbol
        tmrGetTicker_Tick(Me, e)
    End Sub

    Private Sub DonateToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DonateToolStripMenuItem.Click
        Dim i As Boolean = Me.TopMost
        Me.TopMost = False
        frmDonate.ShowDialog()
        Me.TopMost = i
    End Sub

    Private Sub CNYToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CNYToolStripMenuItem.Click, btnCNY.Click
        BASC.Currency_Code = BASA.CNY.code
        BASC.Currency_Code = BASA.CNY.code
        BASC.Currency_Symbol = BASA.CNY.symbol
        tmrGetTicker_Tick(Me, e)
    End Sub

    Private Sub GBPToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles GBPToolStripMenuItem.Click, btnGBP.Click
        BASC.Currency_Code = BASA.GBP.code
        BASC.Currency_Code = BASA.GBP.code
        BASC.Currency_Symbol = BASA.GBP.symbol
        tmrGetTicker_Tick(Me, e)
    End Sub

    Private Sub CADToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CADToolStripMenuItem.Click, btnCAD.Click
        BASC.Currency_Code = BASA.CAD.code
        BASC.Currency_Code = BASA.CAD.code
        BASC.Currency_Symbol = BASA.CAD.symbol
        tmrGetTicker_Tick(Me, e)
    End Sub

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click, ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub AlwaysOnTopToolStripMenuItem_Click_1(sender As System.Object, e As System.EventArgs) Handles AlwaysOnTopToolStripMenuItem.Click
        If AlwaysOnTopToolStripMenuItem.CheckState = CheckState.Checked Then Me.TopMost = True Else Me.TopMost = False
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        Dim i As Boolean = Me.TopMost
        Me.TopMost = False
        AboutBox.ShowDialog()
        Me.TopMost = i
    End Sub

    Private Sub lnkBA_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkBA.LinkClicked
        System.Diagnostics.Process.Start("https://bitcoinaverage.com")
    End Sub

End Class


Namespace BitcoinAverageStructure
    Public Structure Current_Market
        Public Currency_Code As String
        Public Currency_Symbol As String
    End Structure

    Public Structure Available_Market
        Public EUR As Currency
        Public USD As Currency
        Public CNY As Currency
        Public GBP As Currency
        Public CAD As Currency
    End Structure
End Namespace

Public Structure Currency
    Public code As String
    Public symbol As String
End Structure
