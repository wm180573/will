﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QuotaCalculator
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtnCalc = New System.Windows.Forms.Button()
        Me.txtGameAge = New System.Windows.Forms.TextBox()
        Me.txtCondition = New System.Windows.Forms.TextBox()
        Me.txtPopularity = New System.Windows.Forms.TextBox()
        Me.txtRRP = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(298, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter number of days since release date:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 132)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(276, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Enter the condition of the case (1-10):"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 168)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(170, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Enter popularity (1-10):"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 202)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(152, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Enter RRP of game:"
        '
        'BtnCalc
        '
        Me.BtnCalc.Location = New System.Drawing.Point(197, 265)
        Me.BtnCalc.Name = "BtnCalc"
        Me.BtnCalc.Size = New System.Drawing.Size(148, 50)
        Me.BtnCalc.TabIndex = 4
        Me.BtnCalc.Text = "Calculate"
        Me.BtnCalc.UseVisualStyleBackColor = True
        '
        'txtGameAge
        '
        Me.txtGameAge.Location = New System.Drawing.Point(340, 96)
        Me.txtGameAge.Name = "txtGameAge"
        Me.txtGameAge.Size = New System.Drawing.Size(170, 20)
        Me.txtGameAge.TabIndex = 5
        '
        'txtCondition
        '
        Me.txtCondition.Location = New System.Drawing.Point(340, 134)
        Me.txtCondition.Name = "txtCondition"
        Me.txtCondition.Size = New System.Drawing.Size(170, 20)
        Me.txtCondition.TabIndex = 6
        '
        'txtPopularity
        '
        Me.txtPopularity.Location = New System.Drawing.Point(340, 170)
        Me.txtPopularity.Name = "txtPopularity"
        Me.txtPopularity.Size = New System.Drawing.Size(170, 20)
        Me.txtPopularity.TabIndex = 7
        '
        'txtRRP
        '
        Me.txtRRP.Location = New System.Drawing.Point(340, 204)
        Me.txtRRP.Name = "txtRRP"
        Me.txtRRP.Size = New System.Drawing.Size(170, 20)
        Me.txtRRP.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(93, 338)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 20)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Price:"
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(197, 338)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(170, 20)
        Me.txtPrice.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(173, 338)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(18, 20)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "£"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(135, 37)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(255, 29)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Buying price calculator"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(316, 204)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(18, 20)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "£"
        '
        'QuotaCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(534, 375)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtRRP)
        Me.Controls.Add(Me.txtPopularity)
        Me.Controls.Add(Me.txtCondition)
        Me.Controls.Add(Me.txtGameAge)
        Me.Controls.Add(Me.BtnCalc)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "QuotaCalculator"
        Me.Text = "QuotaCalculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents BtnCalc As Button
    Friend WithEvents txtGameAge As TextBox
    Friend WithEvents txtCondition As TextBox
    Friend WithEvents txtPopularity As TextBox
    Friend WithEvents txtRRP As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
End Class
