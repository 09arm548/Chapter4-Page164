<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRental
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
        Me.btnDispRentalRates = New System.Windows.Forms.Button()
        Me.btnDispCustBill = New System.Windows.Forms.Button()
        Me.lstPrice = New System.Windows.Forms.ListBox()
        Me.lstBill = New System.Windows.Forms.ListBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.lblItem = New System.Windows.Forms.Label()
        Me.lblDuration = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnDispRentalRates
        '
        Me.btnDispRentalRates.Location = New System.Drawing.Point(83, 17)
        Me.btnDispRentalRates.Name = "btnDispRentalRates"
        Me.btnDispRentalRates.Size = New System.Drawing.Size(150, 60)
        Me.btnDispRentalRates.TabIndex = 0
        Me.btnDispRentalRates.Text = "Display Rental Rates"
        Me.btnDispRentalRates.UseVisualStyleBackColor = True
        '
        'btnDispCustBill
        '
        Me.btnDispCustBill.Location = New System.Drawing.Point(83, 238)
        Me.btnDispCustBill.Name = "btnDispCustBill"
        Me.btnDispCustBill.Size = New System.Drawing.Size(150, 57)
        Me.btnDispCustBill.TabIndex = 1
        Me.btnDispCustBill.Text = "Display Customer Bill"
        Me.btnDispCustBill.UseVisualStyleBackColor = True
        '
        'lstPrice
        '
        Me.lstPrice.FormattingEnabled = True
        Me.lstPrice.Location = New System.Drawing.Point(411, 17)
        Me.lstPrice.Name = "lstPrice"
        Me.lstPrice.Size = New System.Drawing.Size(293, 95)
        Me.lstPrice.TabIndex = 2
        '
        'lstBill
        '
        Me.lstBill.FormattingEnabled = True
        Me.lstBill.Location = New System.Drawing.Point(411, 200)
        Me.lstBill.Name = "lstBill"
        Me.lstBill.Size = New System.Drawing.Size(293, 95)
        Me.lstBill.TabIndex = 3
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(236, 99)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(41, 20)
        Me.TextBox1.TabIndex = 4
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(236, 166)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(41, 20)
        Me.TextBox2.TabIndex = 5
        '
        'lblItem
        '
        Me.lblItem.AutoSize = True
        Me.lblItem.Location = New System.Drawing.Point(56, 99)
        Me.lblItem.Name = "lblItem"
        Me.lblItem.Size = New System.Drawing.Size(125, 13)
        Me.lblItem.TabIndex = 6
        Me.lblItem.Text = "Select an item (1, 2, or3):"
        '
        'lblDuration
        '
        Me.lblDuration.AutoSize = True
        Me.lblDuration.Location = New System.Drawing.Point(53, 166)
        Me.lblDuration.Name = "lblDuration"
        Me.lblDuration.Size = New System.Drawing.Size(128, 13)
        Me.lblDuration.TabIndex = 7
        Me.lblDuration.Text = "Select a duration (H or F):"
        '
        'frmRental
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(790, 364)
        Me.Controls.Add(Me.lblDuration)
        Me.Controls.Add(Me.lblItem)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lstBill)
        Me.Controls.Add(Me.lstPrice)
        Me.Controls.Add(Me.btnDispCustBill)
        Me.Controls.Add(Me.btnDispRentalRates)
        Me.Name = "frmRental"
        Me.Text = "Welcome to Eddie's Equipment Rental"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnDispRentalRates As System.Windows.Forms.Button
    Friend WithEvents btnDispCustBill As System.Windows.Forms.Button
    Friend WithEvents lstPrice As System.Windows.Forms.ListBox
    Friend WithEvents lstBill As System.Windows.Forms.ListBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents lblItem As System.Windows.Forms.Label
    Friend WithEvents lblDuration As System.Windows.Forms.Label

End Class
