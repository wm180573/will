Imports System.Data.OleDb
Public Class AccCrea


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Check if username or password is empty
        If txtPassword.Text = "" Or txtUsername.Text = "" Or txtFirstName.Text = "" Or txtSurname.Text = "" Or txtTelephone.Text = "" Or txtAddress.Text = "" Or txtCounty.Text = "" Then
            MessageBox.Show("Please complete the required fields..", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        ElseIf txtUsername.text = txtFirstName.text Or txtPassword.text = txtSurname.text Then
            MessageBox.Show("Please do not use your name as a username or password ", "Security warning")
        Else
            ' Both fields was supply
            ' Check if user exist in database
            ' Connect to DB
            Dim conn As New System.Data.OleDb.OleDbConnection()
            conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\ipr0z\Downloads\MongooseGames.accdb"

            Dim sql As String = "INSERT INTO customers (CustUser,CustPass,FirstName,Surname,PhoneNum,Address,County) VALUES ('" & txtUsername.Text & "', '" & txtPassword.Text & "', '" & txtFirstName.Text & "', '" & txtSurname.Text & "', '" & txtTelephone.Text & "', '" & txtAddress.Text & "', '" & txtCounty.Text & "')"
            Dim sqlCom As New System.Data.OleDb.OleDbCommand(sql)
            MessageBox.Show("Account Created, and details saved, you will now be redirected to the login screen", "Account creation successful")
            Me.Hide()
            CustomerLogin.Show()


            'Open Database Connection
            sqlCom.Connection = conn
            conn.Open()

            Dim sqlRead As System.Data.OleDb.OleDbDataReader = sqlCom.ExecuteReader()
        End If
    End Sub
End Class