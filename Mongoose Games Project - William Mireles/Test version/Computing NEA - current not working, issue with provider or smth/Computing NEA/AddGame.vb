Imports System.Data.OleDb
Public Class AddGame
    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        ' 
        ' Check if username or password is empty
        'If txtTitle.Text = "" Or txtPrice.Text = "" Or txtGenre.Text = "" Or txtDeveloper.Text = "" Or txtCustomerID.Text = "" Then
        'MessageBox.Show("Please complete the required fields..", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        'Else
        ' Both fields was supply
        'Check If user exist in database
        'Connect to DB
        If BoughtOrSold.Text = "Bought" Then

            Dim conn As New System.Data.OleDb.OleDbConnection()
            conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\ipr0z\Downloads\MongooseGames.accdb"

            Dim sql As String = "INSERT INTO Games (GameName,Price,Genre,Developer) VALUES ('" & txtTitle.Text & "', '" & txtPrice.Text & "', '" & txtGenre.Text & "', '" & txtDeveloper.Text & "')"

            Dim sqlCom As New System.Data.OleDb.OleDbCommand(sql)
            MessageBox.Show("Game added to system, you will now be redirected to the main menu screen", "Appending of game successful")
            Me.Hide()
            AddToRecent.Show()

            'Open Database Connection
            sqlCom.Connection = conn
            conn.Open()

            Dim sqlRead As System.Data.OleDb.OleDbDataReader = sqlCom.ExecuteReader()


        ElseIf BoughtOrSold.Text = "Sold" Then
            Dim GameIDEntered As Integer = Convert.ToInt32(txtGameID.Text)
            Dim conn As New System.Data.OleDb.OleDbConnection()
            conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\ipr0z\Downloads\MongooseGames.accdb"

            Dim sql As String = "DELETE * FROM Games WHERE (GameID) = (" & txtGameID.Text & ")"

            Dim sqlCom As New System.Data.OleDb.OleDbCommand(sql)
            MessageBox.Show("Game removed from system, you will now be redirected to the main menu screen", "Removal of game successful")
            Me.Hide()
            AddToRecent.Show()

            'Open Database Connection
            sqlCom.Connection = conn
            conn.Open()

            Dim sqlRead As System.Data.OleDb.OleDbDataReader = sqlCom.ExecuteReader()
        End If
    End Sub

    Private Sub BtnMainMenu_Click(sender As Object, e As EventArgs) Handles BtnMainMenu.Click
        Me.Hide()
        StaffMenu.Show()
    End Sub
End Class