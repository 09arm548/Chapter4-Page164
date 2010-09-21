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

        Dim intItem As Integer = CInt(CStr(txtItem.Text))
        Dim dblDeposit As Double = 30.0
        Dim dblTotal As Double = 0


        'Try

        'Catch ex As System.InvalidCastException
        '    MsgBox("wrong")


        'End Try
        ' Dim intDuration As Integer = CStr(txtDuration.Text )

        lstBill.Items.Add("RECEIPT")

        If intItem <> 1 Or intItem <> 2 Or intItem <> 3 Then
            MessageBox.Show("You must enter 1, 2, or 3")
        End If
        If txtDuration.Text <> "h" Or txtDuration.Text <> "f" Then
            MessageBox.Show("You must enter f or h")
        End If
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
