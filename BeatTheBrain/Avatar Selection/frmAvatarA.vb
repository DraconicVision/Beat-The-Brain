'\\ Author: Matthew Curran
'\\ Date: 10/03/2020
'\\ Version: VB.net 2017
Public Class frmAvatarA
    Private Sub frmAvatarA_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnEvilPatrick_Click(sender As Object, e As EventArgs) Handles btnEvilPatrick.Click
        '\\ Avatar Image Set
        '\\This sets the image to Evil Patrick.
        frmQuestion1a.picAvatar.Image = picEvilPatrick.Image
        frmQuestion2a.picAvatar.Image = picEvilPatrick.Image
        frmQuestion3a.picAvatar.Image = picEvilPatrick.Image
        frmQuestion4a.picAvatar.Image = picEvilPatrick.Image
        frmQuestion5a.picAvatar.Image = picEvilPatrick.Image
        '\\ PatrickIntro.wav plays
        '\\Notice that the file path is relative, not absolute. This is so that this solution can be deployed in multiple environments.
        My.Computer.Audio.Play("Sounds\PatrickIntro.wav")
        '\\ Open Question 1
        frmQuestion1a.Show()
        '\\ Close Avatar Selection
        Me.Hide()
    End Sub

    Private Sub btnSanic_Click(sender As Object, e As EventArgs) Handles btnSanic.Click
        '\\ Avatar Image Set
        '\\This sets the image to Sanic.
        frmQuestion1a.picAvatar.Image = picSanic.Image
        frmQuestion2a.picAvatar.Image = picSanic.Image
        frmQuestion3a.picAvatar.Image = picSanic.Image
        frmQuestion4a.picAvatar.Image = picSanic.Image
        frmQuestion5a.picAvatar.Image = picSanic.Image
        '\\ SanicIntro.wav plays
        '\\Notice that the file path is relative, not absolute. This is so that this solution can be deployed in multiple environments.
        My.Computer.Audio.Play("Sounds\SanicIntro.wav")
        '\\ Open Question 1
        frmQuestion1a.Show()
        '\\ Close Avatar Selection
        Me.Hide()
    End Sub

    Private Sub btnTyrone_Click(sender As Object, e As EventArgs) Handles btnTyrone.Click
        '\\ Avatar Image Set
        '\\This sets the image to Tyrone.
        frmQuestion1a.picAvatar.Image = picTyrone.Image
        frmQuestion2a.picAvatar.Image = picTyrone.Image
        frmQuestion3a.picAvatar.Image = picTyrone.Image
        frmQuestion4a.picAvatar.Image = picTyrone.Image
        frmQuestion5a.picAvatar.Image = picTyrone.Image
        '\\ TyroneIntro.wav plays
        '\\Notice that the file path is relative, not absolute. This is so that this solution can be deployed in multiple environments.
        My.Computer.Audio.Play("Sounds\TyroneIntro.wav")
        '\\ Open Question 1
        frmQuestion1a.Show()
        '\\ Close Avatar Selection
        Me.Hide()
    End Sub

    Private Sub btnBabyYoda_Click(sender As Object, e As EventArgs) Handles btnBabyYoda.Click
        '\\ Avatar Image Set
        '\\This sets the image to Baby Yoda.
        frmQuestion1a.picAvatar.Image = picBabyYoda.Image
        frmQuestion2a.picAvatar.Image = picBabyYoda.Image
        frmQuestion3a.picAvatar.Image = picBabyYoda.Image
        frmQuestion4a.picAvatar.Image = picBabyYoda.Image
        frmQuestion5a.picAvatar.Image = picBabyYoda.Image
        '\\ YodaIntro.wav plays
        '\\Notice that the file path is relative, not absolute. This is so that this solution can be deployed in multiple environments.
        My.Computer.Audio.Play("Sounds\YodaIntro.wav")
        '\\ Open Question 1
        frmQuestion1a.Show()
        '\\ Close Avatar Selection
        Me.Hide()
    End Sub

    Private Sub btnClose1_Click(sender As Object, e As EventArgs) Handles btnClose1.Click
        '\\ Program End
        End
    End Sub
End Class