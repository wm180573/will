﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnCustomerLogin = New System.Windows.Forms.Button()
        Me.BtnStaffLogin = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(117, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(277, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mongoose Games Login"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(27, 170)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(155, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "For customers:"
        '
        'BtnCustomerLogin
        '
        Me.BtnCustomerLogin.Location = New System.Drawing.Point(32, 209)
        Me.BtnCustomerLogin.Name = "BtnCustomerLogin"
        Me.BtnCustomerLogin.Size = New System.Drawing.Size(136, 35)
        Me.BtnCustomerLogin.TabIndex = 2
        Me.BtnCustomerLogin.Text = "Customer Login"
        Me.BtnCustomerLogin.UseVisualStyleBackColor = True
        '
        'BtnStaffLogin
        '
        Me.BtnStaffLogin.Location = New System.Drawing.Point(317, 209)
        Me.BtnStaffLogin.Name = "BtnStaffLogin"
        Me.BtnStaffLogin.Size = New System.Drawing.Size(136, 35)
        Me.BtnStaffLogin.TabIndex = 3
        Me.BtnStaffLogin.Text = "Staff Login"
        Me.BtnStaffLogin.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(291, 170)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(191, 25)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "For staff members:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(583, 283)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BtnStaffLogin)
        Me.Controls.Add(Me.BtnCustomerLogin)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnCustomerLogin As Button
    Friend WithEvents BtnStaffLogin As Button
    Friend WithEvents Label3 As Label
End Class
