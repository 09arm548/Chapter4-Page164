Public Class frmRental

    Private Sub btnDispRentalRates_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDispRentalRates.Click
        Dim readervar As IO.StreamReader = IO.File.OpenText("../../Data.txt")

        Dim strFormat As String
        strFormat = "{0, 15}, {1, 15}, {2, 15}"
        'Try

        'Catch ex As Exception
        '    MessageBox.Show("sdkljf")
        'End Try
        ' lstPrice.Items.Add()

        lstPrice.Items.Add(String.Format(strFormat, "PRICE", "HALF", "FULL"))
        lstPrice.Items.Add(String.Format(strFormat, "RUG", "16", "24"))
        lstPrice.Items.Add(String.Format(strFormat, "LAWN", "12", "18"))
        lstPrice.Items.Add(String.Format(strFormat, "PAINT", "20", "30"))


    End Sub

    Private Sub btnDispCustBill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDispCustBill.Click

        Dim intItem As Integer

        intItem = CInt(CStr(txtItem.Text))
        'Try

        'Catch ex As System.InvalidCastException
        '    MsgBox("wrong")


        'End Try
        ' Dim intDuration As Integer = CStr(txtDuration.Text )

        If intItem = 1 Then
            lstBill.Items.Add("RECEIPT")
            lstBill.Items.Add("Rug")
        End If





    End Sub
End Class
