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
        Me.txtItem = New System.Windows.Forms.TextBox()
        Me.txtDuration = New System.Windows.Forms.TextBox()
        Me.lblItem = New System.Windows.Forms.Label()
        Me.lblDuration = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnDispRentalRates
        '
        Me.btnDispRentalRates.Location = New System.Drawing.Point(97, 18)
        Me.btnDispRentalRates.Name = "btnDispRentalRates"
        Me.btnDispRentalRates.Size = New System.Drawing.Size(175, 65)
        Me.btnDispRentalRates.TabIndex = 0
        Me.btnDispRentalRates.Text = "Display Rental Rates"
        Me.btnDispRentalRates.UseVisualStyleBackColor = True
        '
        'btnDispCustBill
        '
        Me.btnDispCustBill.Location = New System.Drawing.Point(97, 256)
        Me.btnDispCustBill.Name = "btnDispCustBill"
        Me.btnDispCustBill.Size = New System.Drawing.Size(175, 61)
        Me.btnDispCustBill.TabIndex = 1
        Me.btnDispCustBill.Text = "Display Customer Bill"
        Me.btnDispCustBill.UseVisualStyleBackColor = True
        '
        'lstPrice
        '
        Me.lstPrice.FormattingEnabled = True
        Me.lstPrice.ItemHeight = 17
        Me.lstPrice.Location = New System.Drawing.Point(479, 18)
        Me.lstPrice.Name = "lstPrice"
        Me.lstPrice.Size = New System.Drawing.Size(402, 123)
        Me.lstPrice.TabIndex = 2
        '
        'lstBill
        '
        Me.lstBill.FormattingEnabled = True
        Me.lstBill.ItemHeight = 17
        Me.lstBill.Location = New System.Drawing.Point(479, 215)
        Me.lstBill.Name = "lstBill"
        Me.lstBill.Size = New System.Drawing.Size(402, 123)
        Me.lstBill.TabIndex = 3
        '
        'txtItem
        '
        Me.txtItem.Location = New System.Drawing.Point(318, 107)
        Me.txtItem.Name = "txtItem"
        Me.txtItem.Size = New System.Drawing.Size(47, 23)
        Me.txtItem.TabIndex = 4
        '
        'txtDuration
        '
        Me.txtDuration.Location = New System.Drawing.Point(318, 179)
        Me.txtDuration.Name = "txtDuration"
        Me.txtDuration.Size = New System.Drawing.Size(47, 23)
        Me.txtDuration.TabIndex = 5
        '
        'lblItem
        '
        Me.lblItem.AutoSize = True
        Me.lblItem.Location = New System.Drawing.Point(65, 107)
        Me.lblItem.Name = "lblItem"
        Me.lblItem.Size = New System.Drawing.Size(232, 17)
        Me.lblItem.TabIndex = 6
        Me.lblItem.Text = "Select an item (1, 2, or 3):"
        '
        'lblDuration
        '
        Me.lblDuration.AutoSize = True
        Me.lblDuration.Location = New System.Drawing.Point(62, 179)
        Me.lblDuration.Name = "lblDuration"
        Me.lblDuration.Size = New System.Drawing.Size(224, 17)
        Me.lblDuration.TabIndex = 7
        Me.lblDuration.Text = "Select a duration (H or F):"
        '
        'frmRental
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(922, 392)
        Me.Controls.Add(Me.lblDuration)
        Me.Controls.Add(Me.lblItem)
        Me.Controls.Add(Me.txtDuration)
        Me.Controls.Add(Me.txtItem)
        Me.Controls.Add(Me.lstBill)
        Me.Controls.Add(Me.lstPrice)
        Me.Controls.Add(Me.btnDispCustBill)
        Me.Controls.Add(Me.btnDispRentalRates)
        Me.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmRental"
        Me.Text = "Welcome to Eddie's Equipment Rental"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnDispRentalRates As System.Windows.Forms.Button
    Friend WithEvents btnDispCustBill As System.Windows.Forms.Button
    Friend WithEvents lstPrice As System.Windows.Forms.ListBox
    Friend WithEvents lstBill As System.Windows.Forms.ListBox
    Friend WithEvents txtItem As System.Windows.Forms.TextBox
    Friend WithEvents txtDuration As System.Windows.Forms.TextBox
    Friend WithEvents lblItem As System.Windows.Forms.Label
    Friend WithEvents lblDuration As System.Windows.Forms.Label

End Class
