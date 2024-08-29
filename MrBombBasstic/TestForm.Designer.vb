<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TestForm
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
        lbl_output = New Label()
        btn_calculate = New Button()
        btn_1 = New Button()
        btn_2 = New Button()
        btn_3 = New Button()
        btn_4 = New Button()
        btn_5 = New Button()
        btn_6 = New Button()
        btn_7 = New Button()
        btn_8 = New Button()
        btn_9 = New Button()
        btn_0 = New Button()
        btn_add = New Button()
        btn_minus = New Button()
        btn_multiply = New Button()
        btn_divide = New Button()
        clearlabel = New Button()
        SuspendLayout()
        ' 
        ' lbl_output
        ' 
        lbl_output.AutoSize = True
        lbl_output.Location = New Point(101, 43)
        lbl_output.Name = "lbl_output"
        lbl_output.Size = New Size(83, 32)
        lbl_output.TabIndex = 0
        lbl_output.Text = "Label1"
        ' 
        ' btn_calculate
        ' 
        btn_calculate.Location = New Point(776, 409)
        btn_calculate.Name = "btn_calculate"
        btn_calculate.Size = New Size(150, 46)
        btn_calculate.TabIndex = 3
        btn_calculate.Text = "="
        btn_calculate.UseVisualStyleBackColor = True
        ' 
        ' btn_1
        ' 
        btn_1.Location = New Point(115, 182)
        btn_1.Name = "btn_1"
        btn_1.Size = New Size(102, 81)
        btn_1.TabIndex = 4
        btn_1.Text = "1"
        btn_1.UseVisualStyleBackColor = True
        ' 
        ' btn_2
        ' 
        btn_2.Location = New Point(115, 284)
        btn_2.Name = "btn_2"
        btn_2.Size = New Size(102, 81)
        btn_2.TabIndex = 5
        btn_2.Text = "2"
        btn_2.UseVisualStyleBackColor = True
        ' 
        ' btn_3
        ' 
        btn_3.Location = New Point(115, 392)
        btn_3.Name = "btn_3"
        btn_3.Size = New Size(102, 81)
        btn_3.TabIndex = 6
        btn_3.Text = "3"
        btn_3.UseVisualStyleBackColor = True
        ' 
        ' btn_4
        ' 
        btn_4.Location = New Point(286, 182)
        btn_4.Name = "btn_4"
        btn_4.Size = New Size(102, 81)
        btn_4.TabIndex = 9
        btn_4.Text = "4"
        btn_4.UseVisualStyleBackColor = True
        ' 
        ' btn_5
        ' 
        btn_5.Location = New Point(286, 284)
        btn_5.Name = "btn_5"
        btn_5.Size = New Size(102, 81)
        btn_5.TabIndex = 8
        btn_5.Text = "5"
        btn_5.UseVisualStyleBackColor = True
        ' 
        ' btn_6
        ' 
        btn_6.Location = New Point(286, 392)
        btn_6.Name = "btn_6"
        btn_6.Size = New Size(102, 81)
        btn_6.TabIndex = 7
        btn_6.Text = "6"
        btn_6.UseVisualStyleBackColor = True
        ' 
        ' btn_7
        ' 
        btn_7.Location = New Point(465, 182)
        btn_7.Name = "btn_7"
        btn_7.Size = New Size(102, 81)
        btn_7.TabIndex = 12
        btn_7.Text = "7"
        btn_7.UseVisualStyleBackColor = True
        ' 
        ' btn_8
        ' 
        btn_8.Location = New Point(465, 284)
        btn_8.Name = "btn_8"
        btn_8.Size = New Size(102, 81)
        btn_8.TabIndex = 11
        btn_8.Text = "8"
        btn_8.UseVisualStyleBackColor = True
        ' 
        ' btn_9
        ' 
        btn_9.Location = New Point(465, 392)
        btn_9.Name = "btn_9"
        btn_9.Size = New Size(102, 81)
        btn_9.TabIndex = 10
        btn_9.Text = "9"
        btn_9.UseVisualStyleBackColor = True
        ' 
        ' btn_0
        ' 
        btn_0.Location = New Point(286, 507)
        btn_0.Name = "btn_0"
        btn_0.Size = New Size(102, 81)
        btn_0.TabIndex = 13
        btn_0.Text = "0"
        btn_0.UseVisualStyleBackColor = True
        ' 
        ' btn_add
        ' 
        btn_add.Location = New Point(690, 199)
        btn_add.Name = "btn_add"
        btn_add.Size = New Size(150, 46)
        btn_add.TabIndex = 14
        btn_add.Text = "+"
        btn_add.UseVisualStyleBackColor = True
        ' 
        ' btn_minus
        ' 
        btn_minus.Location = New Point(871, 199)
        btn_minus.Name = "btn_minus"
        btn_minus.Size = New Size(150, 46)
        btn_minus.TabIndex = 15
        btn_minus.Text = "-"
        btn_minus.UseVisualStyleBackColor = True
        ' 
        ' btn_multiply
        ' 
        btn_multiply.Location = New Point(690, 284)
        btn_multiply.Name = "btn_multiply"
        btn_multiply.Size = New Size(150, 46)
        btn_multiply.TabIndex = 16
        btn_multiply.Text = "*"
        btn_multiply.UseVisualStyleBackColor = True
        ' 
        ' btn_divide
        ' 
        btn_divide.Location = New Point(871, 284)
        btn_divide.Name = "btn_divide"
        btn_divide.Size = New Size(150, 46)
        btn_divide.TabIndex = 17
        btn_divide.Text = "/"
        btn_divide.UseVisualStyleBackColor = True
        ' 
        ' clearlabel
        ' 
        clearlabel.Location = New Point(752, 538)
        clearlabel.Name = "clearlabel"
        clearlabel.Size = New Size(150, 46)
        clearlabel.TabIndex = 18
        clearlabel.Text = "Clear"
        clearlabel.UseVisualStyleBackColor = True
        ' 
        ' TestForm
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1076, 658)
        Controls.Add(clearlabel)
        Controls.Add(btn_divide)
        Controls.Add(btn_multiply)
        Controls.Add(btn_minus)
        Controls.Add(btn_add)
        Controls.Add(btn_0)
        Controls.Add(btn_7)
        Controls.Add(btn_8)
        Controls.Add(btn_9)
        Controls.Add(btn_4)
        Controls.Add(btn_5)
        Controls.Add(btn_6)
        Controls.Add(btn_3)
        Controls.Add(btn_2)
        Controls.Add(btn_1)
        Controls.Add(btn_calculate)
        Controls.Add(lbl_output)
        Name = "TestForm"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lbl_output As Label
    Friend WithEvents btn_calculate As Button
    Friend WithEvents btn_1 As Button
    Friend WithEvents btn_2 As Button
    Friend WithEvents btn_3 As Button
    Friend WithEvents btn_4 As Button
    Friend WithEvents btn_5 As Button
    Friend WithEvents btn_6 As Button
    Friend WithEvents btn_7 As Button
    Friend WithEvents btn_8 As Button
    Friend WithEvents btn_9 As Button
    Friend WithEvents btn_0 As Button
    Friend WithEvents btn_add As Button
    Friend WithEvents btn_minus As Button
    Friend WithEvents btn_multiply As Button
    Friend WithEvents btn_divide As Button
    Friend WithEvents clearlabel As Button

End Class
