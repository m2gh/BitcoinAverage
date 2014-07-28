<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDonate
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
        Me.OKButton = New System.Windows.Forms.Button()
        Me.txtInfo = New System.Windows.Forms.TextBox()
        Me.grpbBTC = New System.Windows.Forms.GroupBox()
        Me.txtBTC = New System.Windows.Forms.TextBox()
        Me.btnCopyBTC = New System.Windows.Forms.Button()
        Me.grpbLTC = New System.Windows.Forms.GroupBox()
        Me.btnCopyLTC = New System.Windows.Forms.Button()
        Me.txtLTC = New System.Windows.Forms.TextBox()
        Me.grpbBTC.SuspendLayout()
        Me.grpbLTC.SuspendLayout()
        Me.SuspendLayout()
        '
        'OKButton
        '
        Me.OKButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OKButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.OKButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.OKButton.Location = New System.Drawing.Point(176, 183)
        Me.OKButton.Name = "OKButton"
        Me.OKButton.Size = New System.Drawing.Size(84, 30)
        Me.OKButton.TabIndex = 1
        Me.OKButton.Text = "&OK"
        '
        'txtInfo
        '
        Me.txtInfo.BackColor = System.Drawing.SystemColors.Control
        Me.txtInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.txtInfo.Location = New System.Drawing.Point(13, 12)
        Me.txtInfo.Multiline = True
        Me.txtInfo.Name = "txtInfo"
        Me.txtInfo.ReadOnly = True
        Me.txtInfo.Size = New System.Drawing.Size(440, 57)
        Me.txtInfo.TabIndex = 2
        Me.txtInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'grpbBTC
        '
        Me.grpbBTC.Controls.Add(Me.btnCopyBTC)
        Me.grpbBTC.Controls.Add(Me.txtBTC)
        Me.grpbBTC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.grpbBTC.Location = New System.Drawing.Point(14, 75)
        Me.grpbBTC.Name = "grpbBTC"
        Me.grpbBTC.Size = New System.Drawing.Size(439, 48)
        Me.grpbBTC.TabIndex = 4
        Me.grpbBTC.TabStop = False
        Me.grpbBTC.Text = "BTC ADDRESS"
        '
        'txtBTC
        '
        Me.txtBTC.BackColor = System.Drawing.SystemColors.Control
        Me.txtBTC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.txtBTC.Location = New System.Drawing.Point(9, 17)
        Me.txtBTC.Name = "txtBTC"
        Me.txtBTC.ReadOnly = True
        Me.txtBTC.Size = New System.Drawing.Size(331, 22)
        Me.txtBTC.TabIndex = 0
        Me.txtBTC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnCopyBTC
        '
        Me.btnCopyBTC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnCopyBTC.Location = New System.Drawing.Point(346, 17)
        Me.btnCopyBTC.Name = "btnCopyBTC"
        Me.btnCopyBTC.Size = New System.Drawing.Size(87, 26)
        Me.btnCopyBTC.TabIndex = 1
        Me.btnCopyBTC.Text = "Copy"
        Me.btnCopyBTC.UseVisualStyleBackColor = True
        '
        'grpbLTC
        '
        Me.grpbLTC.Controls.Add(Me.btnCopyLTC)
        Me.grpbLTC.Controls.Add(Me.txtLTC)
        Me.grpbLTC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.grpbLTC.Location = New System.Drawing.Point(14, 129)
        Me.grpbLTC.Name = "grpbLTC"
        Me.grpbLTC.Size = New System.Drawing.Size(439, 48)
        Me.grpbLTC.TabIndex = 5
        Me.grpbLTC.TabStop = False
        Me.grpbLTC.Text = "LTC ADDRESS"
        '
        'btnCopyLTC
        '
        Me.btnCopyLTC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnCopyLTC.Location = New System.Drawing.Point(346, 13)
        Me.btnCopyLTC.Name = "btnCopyLTC"
        Me.btnCopyLTC.Size = New System.Drawing.Size(87, 26)
        Me.btnCopyLTC.TabIndex = 1
        Me.btnCopyLTC.Text = "Copy"
        Me.btnCopyLTC.UseVisualStyleBackColor = True
        '
        'txtLTC
        '
        Me.txtLTC.BackColor = System.Drawing.SystemColors.Control
        Me.txtLTC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.txtLTC.Location = New System.Drawing.Point(9, 17)
        Me.txtLTC.Name = "txtLTC"
        Me.txtLTC.ReadOnly = True
        Me.txtLTC.Size = New System.Drawing.Size(331, 22)
        Me.txtLTC.TabIndex = 0
        Me.txtLTC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'frmDonate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(465, 218)
        Me.Controls.Add(Me.grpbLTC)
        Me.Controls.Add(Me.grpbBTC)
        Me.Controls.Add(Me.txtInfo)
        Me.Controls.Add(Me.OKButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDonate"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Form1"
        Me.grpbBTC.ResumeLayout(False)
        Me.grpbBTC.PerformLayout()
        Me.grpbLTC.ResumeLayout(False)
        Me.grpbLTC.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OKButton As System.Windows.Forms.Button
    Friend WithEvents txtInfo As System.Windows.Forms.TextBox
    Friend WithEvents grpbBTC As System.Windows.Forms.GroupBox
    Friend WithEvents btnCopyBTC As System.Windows.Forms.Button
    Friend WithEvents txtBTC As System.Windows.Forms.TextBox
    Friend WithEvents grpbLTC As System.Windows.Forms.GroupBox
    Friend WithEvents btnCopyLTC As System.Windows.Forms.Button
    Friend WithEvents txtLTC As System.Windows.Forms.TextBox
End Class
