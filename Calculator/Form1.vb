Imports org.mariuszgromada.math.mxparser

Public Class CalculatorForm

    'hold the answer for the previous valid evaluation
    Private ans As Double = 0

    'this function insert a txt to the input box
    Private Sub Insert_To_Input(txt As String)
        'get the input text from the text box
        Dim inputText As String = tbInput.Text
        'get the cursor position from the text box
        Dim cursorPos As Integer = tbInput.SelectionStart
        'insert the text to the input text and update the display
        tbInput.Text = inputText.Insert(cursorPos, txt)
        'focus on the text box
        tbInput.Focus()
        tbInput.Select(cursorPos + txt.Length, 0)
    End Sub

    'insert the button text to the input
    Private Sub Insert_Text_To_Input(sender As Object, e As EventArgs) Handles btnLeftParen.Click, btnRightParen.Click, btnPower.Click, btnAbs.Click, Button12.Click, Button11.Click, Button10.Click, Button18.Click, Button30.Click, Button29.Click, Button28.Click, Button27.Click, Button26.Click, Button25.Click, Button24.Click, Button23.Click, Button22.Click, Button21.Click, Button20.Click, Button19.Click, Button8.Click, Button7.Click, Button6.Click, Button40.Click, Button38.Click, Button37.Click, Button36.Click, Button35.Click, Button34.Click, Button33.Click, Button32.Click, Button31.Click, Button3.Click, Button2.Click, Button1.Click, Button42.Click, btnPow10.Click
        'cast the sender object to button
        Dim currentButton As Button = DirectCast(sender, Button)
        'insert the text on the button to the input text and update the display
        Insert_To_Input(currentButton.Text)
    End Sub

    'insert sqrt to input
    Private Sub btnSqrt_Click(sender As Object, e As EventArgs) Handles btnSqrt.Click
        Insert_To_Input("sqrt")
    End Sub

    'insert factorial to input
    Private Sub btnFact_Click(sender As Object, e As EventArgs) Handles btnFact.Click
        Insert_To_Input("!")
    End Sub

    'shift the tbInput selection left one position
    Private Sub btnLeft_Click(sender As Object, e As EventArgs) Handles btnLeft.Click
        tbInput.Focus()
        Dim pos As Integer = tbInput.SelectionStart - 1
        If pos < 0 Then
            pos = tbInput.Text.Length
        End If
        tbInput.Select(pos, 0)
    End Sub

    'shift the tbInput selection right one position
    Private Sub btnRight_Click(sender As Object, e As EventArgs) Handles btnRight.Click
        tbInput.Focus()
        Dim pos As Integer = tbInput.SelectionStart + 1
        If pos > tbInput.Text.Length Then
            pos = 0
        End If
        tbInput.Select(pos, 0)
    End Sub

    'delete one character from the text input
    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        'focus on the tbinput
        tbInput.Focus()
        'get the preivous position from cursor position from the text input
        Dim pos As Integer = tbInput.SelectionStart - 1
        'return if the position is left most
        If pos < 0 Then
            Return
        End If
        'get the input text from the text input
        Dim txt As String = tbInput.Text
        'remove one character from the specified position
        tbInput.Text = txt.Remove(pos, 1)
        tbInput.Select(pos, 0)
    End Sub

    'clear the text in the tbInput
    Private Sub btnAC_Click(sender As Object, e As EventArgs) Handles btnAC.Click
        tbInput.Clear()
        tbInput.Focus()
    End Sub

    'this function evaluate the expression
    Private Sub btnEqual_Click(sender As Object, e As EventArgs) Handles btnEqual.Click
        'get the input expression
        Dim expressionStr As String = tbInput.Text
        'replace × with *
        expressionStr = expressionStr.Replace("×", "*")
        'replace ÷ with /
        expressionStr = expressionStr.Replace("÷", "/")
        'replace π with pi
        expressionStr = expressionStr.Replace("π", "pi")
        'evaluate the expression
        Dim expression As Expression = New Expression(expressionStr)
        Dim result As Double = expression.calculate()
        'display the result
        lblAnsDisplay.Text = result.ToString()
    End Sub
End Class
