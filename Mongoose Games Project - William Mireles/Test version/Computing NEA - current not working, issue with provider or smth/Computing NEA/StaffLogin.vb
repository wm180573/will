Imports System.Data.OleDb
Public Class StaffLogin
    Dim connString As String
    Public myConnection As OleDbConnection = New OleDbConnection
    Public dr As OleDbDataReader

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnStaffLogin.Click
        Try
            ' Check if username or password is empty
            If TxtStaffPassword.Text = "" Or TxtUsername.Text = "" Then
                MessageBox.Show("Please complete the required fields..", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                ' Both fields was supply
                ' Check if user exist in database
                ' Connect to DB
                Dim conn As New System.Data.OleDb.OleDbConnection()
                conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\ipr0z\Downloads\MongooseGames.accdb"


                'conn.Open()
                'MsgBox("Susscess")

                Dim sql As String = "SELECT * FROM Staff WHERE StaffUser='" & TxtUsername.Text & "' AND StaffPass = '" & TxtStaffPassword.Text & "'"
                Dim sqlCom As New System.Data.OleDb.OleDbCommand(sql)

                'Open Database Connection
                sqlCom.Connection = conn
                conn.Open()

                Dim sqlRead As System.Data.OleDb.OleDbDataReader = sqlCom.ExecuteReader()

                If sqlRead.Read() Then
                    MsgBox("Login successful")
                    Me.Hide()
                    StaffMenu.Show()

                Else
                    ' If user enter wrong username and password combination
                    ' Throw an error message
                    MessageBox.Show("Username and Password do not match..", "Authentication Failure", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                    'Clear all fields
                    TxtStaffPassword.Text = ""
                    TxtUsername.Text = ""

                    'Focus on Username field
                    TxtUsername.Focus()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Failed to connect to Database..", "Database Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try



    End Sub

    Private Sub StaffLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
End Class