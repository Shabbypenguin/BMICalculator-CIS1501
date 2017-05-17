Public Class MetroForm

    Friend WithEvents MetroTabPage1 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MetroTabPage2 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MetroTabControl1 As MetroFramework.Controls.MetroTabControl
    Friend WithEvents metricButton As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents imperialButton As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents heightTextBox As MetroFramework.Controls.MetroTextBox

    Private Sub heightTextBox_Click(sender As Object, e As EventArgs) Handles heightTextBox.Click
        'This checks if the user has put anything in and skips clear if so.
        If heightTextBox.Text = "INs or CMs" Then
            'This clears the box of any text for user input
            heightTextBox.Clear()
        End If
    End Sub

    Friend WithEvents weightTextBox As MetroFramework.Controls.MetroTextBox

    Private Sub weightTextBox_Click(sender As Object, e As EventArgs) Handles weightTextBox.Click
        'This checks if the user has put anything in and skips clear if so.
        If weightTextBox.Text = "LBs or KGs" Then
            'This clears the box of any text for user input
            weightTextBox.Clear()
        End If
    End Sub

    Friend WithEvents calulateButton As MetroFramework.Controls.MetroButton
    Friend WithEvents exitButton As MetroFramework.Controls.MetroButton

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        'If the exit button is clicked then we make a call to display a msg box that is ok/cancel styled
        If MsgBox("Do you really wish to quit?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
            Application.Exit()
        End If
    End Sub

    Private Sub bmiTextBox_Click(sender As Object, e As EventArgs) Handles bmiTextBox.Click
        'This checks if the user has put anything in and skips clear if so.
        If bmiTextBox.Text = "BMI" Then
            'This clears the box of any text for user input
            bmiTextBox.Clear()
        End If
    End Sub

    Private Sub calulateButton_Click(sender As Object, e As EventArgs) Handles calulateButton.Click
        'First we need to declare some variables we will use
        Dim heightInput As Decimal
        Dim weightInput As Decimal
        
        'We want to make sure the user put a number and not a string otherwise the program will crash
        If Not IsNumeric(heightTextBox.Text) Then
            'If they didn't then prompt them to put a number and return
            MessageBox.Show("Please enter in a height number")
            Exit Sub
        Else
            'Here we set the height variable based off user input
            heightInput = heightTextBox.Text
        End If
        
        'We want to make sure the user put a number and not a string otherwise the program will crash
        If Not IsNumeric(weightTextBox.Text) Then
            'If they didn't then prompt them to put a number and return
            MessageBox.Show("Please enter in a weight number")
            Exit Sub
        Else
            'Here we set the weight variable based off user input
            weightInput = weightTextBox.Text
        End If

        'I opted to use ushort as we arent too concerned with decimals and I doubt anyone is over 65535% body fat
        Dim BMI As UShort
        'We perform the BMI calulations
        'I check and see if we are using imperial or metric and use the appropriate formula
        If imperialButton.Checked Then
            BMI = 703 * weightInput / heightInput ^ 2
        ElseIf metricButton.Checked Then
            BMI = weightInput / heightInput ^ 2
        End If
        'Then convert it to a string
        Dim bmiOutput As String = Convert.ToString(BMI)
        'Now we want to output it to the text box for the user to see
        bmiTextBox.Text = bmiOutput + "%"
    End Sub

End Class
