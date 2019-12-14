Public Class StaffMenu
    Private Sub BtnQuotaCalc_Click(sender As Object, e As EventArgs) Handles BtnQuotaCalc.Click
        Me.Hide()
        QuotaCalculator.Show()
    End Sub

    Private Sub BtnResell_Click(sender As Object, e As EventArgs) Handles BtnResell.Click
        Me.Hide()
        ResellCalculator.Show()
    End Sub

    Private Sub BtnAddGame_Click(sender As Object, e As EventArgs) Handles BtnAddGame.Click
        Me.Hide()
        AddGame.Show()
    End Sub

    Private Sub BtnRecentGames_Click(sender As Object, e As EventArgs) Handles BtnRecentGames.Click
        Me.Hide()
        ViewRecentGames.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        SearchGames.Show()
    End Sub
End Class