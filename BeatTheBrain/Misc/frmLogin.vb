'\\ Author: Matthew Curran
'\\ Date: 10/03/2020
'\\ Version: VB.net 2017
Public Class btnClose
    Private Sub FrmLogin()
        '\\ Button Styling
        btnLogin.FlatStyle = FlatStyle.Flat
        btnLogin.FlatAppearance.BorderColor = Color.Black
    End Sub

    '\\ Variable String Setting
    '\\This sets two variables as string data types.
    <VBFixedString(20)> Public password As String
    <VBFixedString(20)> Public username As String

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '\\ Load Sound
        '\\Notice that the file path is relative, not absolute. This is so that this solution can be deployed in multiple environments.
        My.Computer.Audio.Play("Sounds/Lets Get Ready to Rumble.wav")
    End Sub
    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        '\\ Variable Value Setting
        '\\This sets the value entered in the text boxes as the variables
        password = txtPass.Text
        username = txtUser.Text
        '\\ Login Mechanism
        '\\If the password = Password and username = Matthew then it shows the difficulty selection.
        If password = "Password" And username = "Matthew" Then
            frmDifficultySelection.Show()
            Me.Hide()
        Else
            '\\ Else Statement
            '\\If the Then previous requirements are Not met a message box appears.
            MsgBox("Sorry the details entered are incorrect.")
        End If
    End Sub

    Private Sub btnEnd_Click(sender As Object, e As EventArgs) Handles btnEnd.Click
        '\\ Program End
        End
    End Sub

    Private Sub txtUser_TextChanged(sender As Object, e As EventArgs) Handles txtUser.TextChanged

    End Sub
End Class
