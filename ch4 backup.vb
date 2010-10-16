Public Class frmRental

    Private Sub btnDispRentalRates_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDispRentalRates.Click

        Dim strFormat As String
        strFormat = "{0, -15} {1, 15:c2} {2, 15:c2}"

        'build price table
        lstPrice.Items.Add(String.Format(strFormat, "PRICE", "HALF", "FULL"))
        lstPrice.Items.Add("")
        lstPrice.Items.Add(String.Format(strFormat, "RUG CLEANER", (16), (24)))
        lstPrice.Items.Add(String.Format(strFormat, "LAWN MOWER", (12), (18)))
        lstPrice.Items.Add(String.Format(strFormat, "PAINT SPRAYER", (20), (30)))

    End Sub

    Private Sub btnDispCustBill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDispCustBill.Click
        
        Dim strItem As String = txtItem.Text
        Dim dblDeposit As Double = 30.0
        Dim strFormat As String
        strFormat = "{0, -15} {1,15:c2}"
        txtDuration.Text = txtDuration.Text.ToLower

        'data validation
        Try
            txtItem.Text = ""
        Catch invalidcastexception As Exception
            MessageBox.Show("You must enter a number.")
        End Try

        'data validation
        If strItem <> "1" And strItem <> "2" And strItem <> "3" Then
            MessageBox.Show("You must enter 1, 2, or 3")
        End If

        If txtDuration.Text <> "h" And txtDuration.Text <> "f" Then
            MessageBox.Show("You must enter f or h")
        End If

        'shows specific receipts for each rental
        If strItem = "1" Then
            If txtDuration.Text = "h" Then
                lstBill.Items.Add("RECEIPT")
                lstBill.Items.Add("")
                lstBill.Items.Add(String.Format(strFormat, "Rug", 16))
                lstBill.Items.Add(String.Format(strFormat, "Deposit", dblDeposit))
                lstBill.Items.Add(String.Format(strFormat, "", "--------"))
                lstBill.Items.Add(String.Format(strFormat, "TOTAL", dblDeposit + 16))
            ElseIf txtDuration.Text = "f" Then
                lstBill.Items.Add("RECEIPT")
                lstBill.Items.Add("")
                lstBill.Items.Add(String.Format(strFormat, "Rug", 24))
                lstBill.Items.Add(String.Format(strFormat, "Deposit", dblDeposit))
                lstBill.Items.Add(String.Format(strFormat, "", "--------"))
                lstBill.Items.Add(String.Format(strFormat, "TOTAL", dblDeposit + 24))
            End If
        End If


        If strItem = "2" Then
            If txtDuration.Text = "h" Then
                lstBill.Items.Add("RECEIPT")
                lstBill.Items.Add("")
                lstBill.Items.Add(String.Format(strFormat, "Lawn", 12))
                lstBill.Items.Add(String.Format(strFormat, "Deposit", dblDeposit))
                lstBill.Items.Add(String.Format(strFormat, "", "--------"))
                lstBill.Items.Add(String.Format(strFormat, "TOTAL", dblDeposit + 12))
            ElseIf txtDuration.Text = "f" Then
                lstBill.Items.Add("RECEIPT")
                lstBill.Items.Add("")
                lstBill.Items.Add(String.Format(strFormat, "Lawn", 18))
                lstBill.Items.Add(String.Format(strFormat, "Deposit", dblDeposit))
                lstBill.Items.Add(String.Format(strFormat, "", "--------"))
                lstBill.Items.Add(String.Format(strFormat, "TOTAL", dblDeposit + 18))
            End If
        End If


        If strItem = "3" Then
            If txtDuration.Text = "h" Then
                lstBill.Items.Add("RECEIPT")
                lstBill.Items.Add("")
                lstBill.Items.Add(String.Format(strFormat, "Paint", 20))
                lstBill.Items.Add(String.Format(strFormat, "Deposit", dblDeposit))
                lstBill.Items.Add(String.Format(strFormat, "", "--------"))
                lstBill.Items.Add(String.Format(strFormat, "TOTAL", dblDeposit + 20))
            ElseIf txtDuration.Text = "f" Then
                lstBill.Items.Add("RECEIPT")
                lstBill.Items.Add("")
                lstBill.Items.Add(String.Format(strFormat, "Paint", 30))
                lstBill.Items.Add(String.Format(strFormat, "Deposit", dblDeposit))
                lstBill.Items.Add(String.Format(strFormat, "", "--------"))
                lstBill.Items.Add(String.Format(strFormat, "TOTAL", dblDeposit + 30))
            End If
        End If

    End Sub
End Class
