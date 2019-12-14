
Public Class CustomerLogin
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Check if username or password is empty
        Try
            If txtPassword.Text = "" Or txtUsername.Text = "" Then
                MessageBox.Show("Please complete the required fields..", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                ' Both fields was supply
                ' Check if user exist in database
                ' Connect to DB
                Dim conn As New System.Data.OleDb.OleDbConnection()
                conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\ipr0z\Downloads\MongooseGames.accdb"


                'conn.Open()
                'MsgBox("Susscess")

                Dim sql As String = "SELECT * FROM Customers WHERE CustUser='" & txtUsername.Text & "' AND CustPass = '" & txtPassword.Text & "'"
                Dim sqlCom As New System.Data.OleDb.OleDbCommand(sql)

                'Open Database Connection
                sqlCom.Connection = conn
                conn.Open()

                Dim sqlRead As System.Data.OleDb.OleDbDataReader = sqlCom.ExecuteReader()

                If sqlRead.Read() Then
                    MsgBox("Login successful")
                    Me.Hide()
                    CustomerMenu.Show()

                Else
                    ' If user enter wrong username and password combination
                    ' Throw an error message
                    MessageBox.Show("Username and Password do not match..", "Authentication Failure", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                    'Clear all fields
                    txtPassword.Text = ""
                    txtUsername.Text = ""

                    'Focus on Username field
                    txtUsername.Focus()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Failed to connect to Database..", "Database Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub CustomerLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Hide()
        AccCrea.Show()
    End Sub
End Class