<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StaffMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnAddGame = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.BtnRecentGames = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BtnResell = New System.Windows.Forms.Button()
        Me.BtnQuotaCalc = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(109, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(375, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mongoose Games system for staff"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(558, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Welcome to the Mongoose Games computer system. Please click the respective button" &
    " to carry out your desired task"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(38, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Games:"
        '
        'BtnAddGame
        '
        Me.BtnAddGame.Location = New System.Drawing.Point(20, 129)
        Me.BtnAddGame.Name = "BtnAddGame"
        Me.BtnAddGame.Size = New System.Drawing.Size(140, 51)
        Me.BtnAddGame.TabIndex = 4
        Me.BtnAddGame.Text = "Add/remove game to/from system"
        Me.BtnAddGame.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(20, 189)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(140, 40)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "View and search all available games"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(20, 235)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(140, 40)
        Me.Button4.TabIndex = 6
        Me.Button4.Text = "Check game quantities"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'BtnRecentGames
        '
        Me.BtnRecentGames.Location = New System.Drawing.Point(20, 287)
        Me.BtnRecentGames.Name = "BtnRecentGames"
        Me.BtnRecentGames.Size = New System.Drawing.Size(140, 50)
        Me.BtnRecentGames.TabIndex = 7
        Me.BtnRecentGames.Text = "View games recently sold/bought to/from customers"
        Me.BtnRecentGames.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(414, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(135, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Customer Details:"
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(418, 129)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(140, 40)
        Me.Button6.TabIndex = 9
        Me.Button6.Text = "Check customer details"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(418, 175)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(140, 40)
        Me.Button7.TabIndex = 10
        Me.Button7.Text = "Update customer details"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(458, 255)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 20)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Other:"
        '
        'BtnResell
        '
        Me.BtnResell.Location = New System.Drawing.Point(418, 278)
        Me.BtnResell.Name = "BtnResell"
        Me.BtnResell.Size = New System.Drawing.Size(140, 40)
        Me.BtnResell.TabIndex = 12
        Me.BtnResell.Text = "Resell price calculator"
        Me.BtnResell.UseVisualStyleBackColor = True
        '
        'BtnQuotaCalc
        '
        Me.BtnQuotaCalc.Location = New System.Drawing.Point(418, 324)
        Me.BtnQuotaCalc.Name = "BtnQuotaCalc"
        Me.BtnQuotaCalc.Size = New System.Drawing.Size(140, 40)
        Me.BtnQuotaCalc.TabIndex = 13
        Me.BtnQuotaCalc.Text = "Buying price calculator"
        Me.BtnQuotaCalc.UseVisualStyleBackColor = True
        '
        'StaffMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(599, 375)
        Me.Controls.Add(Me.BtnQuotaCalc)
        Me.Controls.Add(Me.BtnResell)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.BtnRecentGames)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.BtnAddGame)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "StaffMenu"
        Me.Text = "StaffMenu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnAddGame As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents BtnRecentGames As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents BtnResell As Button
    Friend WithEvents BtnQuotaCalc As Button
End Class
