<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StaffLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtUsername = New System.Windows.Forms.TextBox()
        Me.TxtStaffPassword = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BtnStaffLogin = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(154, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Staff Login"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 189)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Password"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 118)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Username"
        '
        'TxtUsername
        '
        Me.TxtUsername.Location = New System.Drawing.Point(148, 115)
        Me.TxtUsername.Name = "TxtUsername"
        Me.TxtUsername.Size = New System.Drawing.Size(170, 20)
        Me.TxtUsername.TabIndex = 4
        '
        'TxtStaffPassword
        '
        Me.TxtStaffPassword.Location = New System.Drawing.Point(148, 189)
        Me.TxtStaffPassword.Name = "TxtStaffPassword"
        Me.TxtStaffPassword.Size = New System.Drawing.Size(170, 20)
        Me.TxtStaffPassword.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(83, 260)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(129, 27)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Clear"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BtnStaffLogin
        '
        Me.BtnStaffLogin.Location = New System.Drawing.Point(277, 260)
        Me.BtnStaffLogin.Name = "BtnStaffLogin"
        Me.BtnStaffLogin.Size = New System.Drawing.Size(136, 27)
        Me.BtnStaffLogin.TabIndex = 8
        Me.BtnStaffLogin.Text = "Login"
        Me.BtnStaffLogin.UseVisualStyleBackColor = True
        '
        'StaffLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(452, 363)
        Me.Controls.Add(Me.BtnStaffLogin)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TxtStaffPassword)
        Me.Controls.Add(Me.TxtUsername)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Name = "StaffLogin"
        Me.Text = "StaffLogin"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtUsername As TextBox
    Friend WithEvents TxtStaffPassword As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents BtnStaffLogin As Button
End Class
