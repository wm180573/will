Public Class QuotaCalculator
    Private Sub BtnCalc_Click(sender As Object, e As EventArgs) Handles BtnCalc.Click
        Try
            Dim GameAge As Integer = Convert.ToDouble(txtGameAge.Text)

            Dim Condition As Integer = Convert.ToDouble(txtCondition.Text)

            Dim Popularity As Integer = Convert.ToDouble(txtPopularity.Text)

            Dim RRP As Integer = Convert.ToDouble(txtRRP.Text)



            ' rules for games under a year old

            If Popularity >= 7 And GameAge <= 365 Then
                txtPrice.Text = (RRP * 0.75) - (10 - Condition) * 1.5

            ElseIf Popularity >= 5 And GameAge <= 365 Then
                txtPrice.Text = (RRP * 0.65) - (10 - Condition) * 1.5

            ElseIf Popularity >= 3 And GameAge <= 365 Then
                txtPrice.Text = (RRP * 0.5) - (10 - Condition) * 1.5

            ElseIf Popularity < 2 And GameAge <= 365 Then
                txtPrice.Text = (RRP * 0.3) - (10 - Condition) * 1.5

                ' now rules for games over a year old

            ElseIf Popularity >= 7 And GameAge > 365 Then
                txtPrice.Text = (RRP * 0.7) - (10 - Condition) * 1.5

            ElseIf Popularity >= 5 And GameAge > 365 Then
                txtPrice.Text = (RRP * 0.6) - (10 - Condition) * 1.5

            ElseIf Popularity >= 3 And GameAge > 365 Then
                txtPrice.Text = (RRP * 0.45) - (10 - Condition) * 1.5

            ElseIf Popularity < 2 And GameAge > 365 Then
                txtPrice.Text = (RRP * 0.25) - (10 - Condition) * 1.5



            Else
                MessageBox.Show("The game's caracteristics do not match any field ", "Error while calculating quota")
            End If
        Catch ex As Exception
            MessageBox.Show("Please enter the required fields", "Error While compiling values")
        End Try
    End Sub

    Private Sub QuotaCalculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class