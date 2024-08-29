Option Explicit On
Imports System.DirectoryServices

Public Class TestForm

    Dim FirstNumber As Double
    Dim SecondNumber As Double
    Dim operation As String

    Public Sub NumberButton_Click(sender As Object, e As EventArgs) Handles btn_0.Click, btn_1.Click, btn_2.Click, btn_3.Click, btn_4.Click, btn_5.Click, btn_6.Click, btn_7.Click, btn_8.Click, btn_9.Click
        Dim button As Button = CType(sender, Button)
        lbl_output.Text = lbl_output.Text & button.Text
    End Sub

    Public Sub clearlabel_Click(sender As Object, e As EventArgs) Handles clearlabel.Click
        lbl_output.Text = ""
    End Sub

    Public Sub OperatorButton_Click(sender As Object, e As EventArgs) Handles btn_add.Click, btn_minus.Click, btn_multiply.Click, btn_divide.Click
        FirstNumber = Double.Parse(lbl_output.Text) 'Had to use .Parse as Integer was a structure type #errormsg
        operation = CType(sender, Button).Text
        lbl_output.Text = ""
    End Sub

    Public Sub btn_calculate_Click(sender As Object, e As EventArgs) Handles btn_calculate.Click
        SecondNumber = Double.Parse(lbl_output.Text)
        'lbl_output.Text = FirstNumber & SecondNumber
        Select Case operation
            Case "+"
                lbl_output.Text = (FirstNumber + SecondNumber).ToString
            Case "-"
                lbl_output.Text = (FirstNumber - SecondNumber).ToString
            Case "*"
                lbl_output.Text = (FirstNumber * SecondNumber).ToString
            Case "/"
                lbl_output.Text = (FirstNumber / SecondNumber).ToString
        End Select
    End Sub
End Class








