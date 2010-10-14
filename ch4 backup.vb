﻿Public Class frmRental

    Private Sub btnDispRentalRates_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDispRentalRates.Click

        Dim strFormat As String
        strFormat = "{0, -15} {1, 15} {2, 15}"

        'build price table
        lstPrice.Items.Add(String.Format(strFormat, "PRICE", "HALF", "FULL"))
        lstPrice.Items.Add(String.Format(strFormat, "RUG CLEANER", (FormatCurrency("16")), FormatCurrency("24")))
        lstPrice.Items.Add(String.Format(strFormat, "LAWN MOWER", (FormatCurrency("12")), FormatCurrency("18")))
        lstPrice.Items.Add(String.Format(strFormat, "PAINT SPRAYER", (FormatCurrency("20")), FormatCurrency("30")))


    End Sub

    Private Sub btnDispCustBill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDispCustBill.Click

        Dim intItem As Integer = CInt((txtItem.Text))
        Dim dblDeposit As Double = 30.0

        'build title
        lstBill.Items.Add("RECEIPT")

        'data validation
        If intItem <> 1 And intItem <> 2 And intItem <> 3 Then
            MessageBox.Show("You must enter 1, 2, or 3")
        End If
        If txtDuration.Text <> "h" And txtDuration.Text <> "f" Then
            MessageBox.Show("You must enter f or h")
        End If

        'shows specific receipts for each rental
        If intItem = 1 Then
            If txtDuration.Text = "h" Then
                lstBill.Items.Add("Rug           " & "       $16.00")
                lstBill.Items.Add("DEPOSIT         " & FormatCurrency(dblDeposit))
                lstBill.Items.Add("TOTAL")
                lstBill.Items.Add(FormatCurrency(dblDeposit + 16))
            ElseIf txtDuration.Text = "f" Then
                lstBill.Items.Add("Rug           " & "       $24.00")
                lstBill.Items.Add("DEPOSIT         " & FormatCurrency(dblDeposit))
                lstBill.Items.Add("TOTAL")
                lstBill.Items.Add(FormatCurrency(dblDeposit + 24))
            End If
        End If


        If intItem = 2 Then
            If txtDuration.Text = "h" Then
                lstBill.Items.Add("Lawn           " & "       $12.00")
                lstBill.Items.Add("DEPOSIT         " & FormatCurrency(dblDeposit))
                lstBill.Items.Add("TOTAL")
                lstBill.Items.Add(FormatCurrency(dblDeposit + 12))
            ElseIf txtDuration.Text = "f" Then
                lstBill.Items.Add("Lawn           " & "       $18.00")
                lstBill.Items.Add("DEPOSIT         " & FormatCurrency(dblDeposit))
                lstBill.Items.Add("TOTAL")
                lstBill.Items.Add(FormatCurrency(dblDeposit + 18))
            End If
        End If


        If intItem = 3 Then
            If txtDuration.Text = "h" Then
                lstBill.Items.Add("Paint           " & "       $20.00")
                lstBill.Items.Add("DEPOSIT         " & FormatCurrency(dblDeposit))
                lstBill.Items.Add("TOTAL")
                lstBill.Items.Add(FormatCurrency(dblDeposit + 20))
            ElseIf txtDuration.Text = "f" Then
                lstBill.Items.Add("Paint           " & "       $30.00")
                lstBill.Items.Add("DEPOSIT         " & FormatCurrency(dblDeposit))
                lstBill.Items.Add("TOTAL")
                lstBill.Items.Add(FormatCurrency(dblDeposit + 30))
            End If
        End If

    End Sub
End Class
