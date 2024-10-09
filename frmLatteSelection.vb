' Program Name: Latte Selection 
' Developer: Emmanuel Nyameke
' Date: 2nd September 2024
' Purpose: This application displays two latte flavours(pumpkin spice, and mocha). The user can select a latte flavour
Public Class frmLatteSelection
    Private Sub btnPumpkin_Click(sender As Object, e As EventArgs) Handles btnPumpkin.Click
        ' This Code is executed when the user clicks on the pumpkin spice button.
        ' It displays the pumpkin picture
        picPumpkin.Visible = True
        ' It hides the mocha picture
        picMocha.Visible = False
        ' It enables the select latte button
        btnSelect.Enabled = True 'Enable Button
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' This code is executed when the users click the Exit Window Button
        ' It closes the window and terminates the program exeution
        Close()
    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        ' This code is executed when the user clicks the select button. It disables the pumpkin spice button, select button and mocha button. It hides the instruction label, dsiplay the confirmation label, and enable the exit window button.
        btnPumpkin.Enabled = False
        btnSelect.Enabled = False
        btnMocha.Enabled = False
        lblInstructions.Visible = False
        lblConfirmation.Visible = True
        btnExit.Enabled = True
    End Sub

    Private Sub btnMocha_Click(sender As Object, e As EventArgs) Handles btnMocha.Click
        ' This Code is executed when the user clicks on the mocha button.
        ' It displays the mocha picture
        picMocha.Visible = True
        ' It hides the pumpkin spice picture
        picPumpkin.Visible = False
        ' It enables the select latte button
        btnSelect.Enabled = True
    End Sub
End Class
