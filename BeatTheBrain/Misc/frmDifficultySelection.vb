'\\ Author: Matthew Curran
'\\ Date: 10/03/2020
'\\ Version: VB.net 2017
Public Class frmDifficultySelection
    Private Sub frmDifficultySelection_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnEasy_Click(sender As Object, e As EventArgs) Handles btnEasy.Click
        '\\ Easy Difficulty
        '\\This will take you to the easy Avatar selection.
        AvatarSelection.Show()
        '\\ Close Difficulty Selection form
        Me.Hide()
        '\\ ImReady.wav plays
        '\\Notice that the file path is relative, not absolute. This is so that this solution can be deployed in multiple environments.
        My.Computer.Audio.Play("Sounds\ImReady.wav")
    End Sub

    Private Sub btnMedium_Click(sender As Object, e As EventArgs) Handles btnMedium.Click
        '\\ Medium Difficulty
        '\\This will take you to the medium Avatar selection.
        frmAvatarA.Show()
        '\\ Close Difficulty Selection form
        Me.Hide()
        '\\ ImReady.wav plays
        '\\Notice that the file path is relative, not absolute. This is so that this solution can be deployed in multiple environments.
        My.Computer.Audio.Play("Sounds\ImReady.wav")
    End Sub

    Private Sub btnHard_Click(sender As Object, e As EventArgs) Handles btnHard.Click
        '\\ Hard Difficulty
        '\\This will take you to the hard Avatar selection.
        frmAvatarB.Show()
        '\\ Close Difficulty Selection form
        Me.Hide()
        '\\ ImReady.wav plays
        '\\Notice that the file path is relative, not absolute. This is so that this solution can be deployed in multiple environments.
        My.Computer.Audio.Play("Sounds\ImReady.wav")
    End Sub

    Private Sub btnClose1_Click(sender As Object, e As EventArgs) Handles btnClose1.Click
        '\\ Program End
        End
    End Sub
End Class