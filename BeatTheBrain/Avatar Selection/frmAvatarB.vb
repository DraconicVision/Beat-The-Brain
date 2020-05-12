'\\ Author: Matthew Curran
'\\ Date: 10/03/2020
'\\ Version: VB.net 2017
Public Class frmAvatarB
    Private Sub btnEvilPatrick_Click(sender As Object, e As EventArgs) Handles btnEvilPatrick.Click
        '\\ Avatar Image Set
        '\\This sets the image to Evil Patrick.
        frmQuestion1b.picAvatar.Image = picEvilPatrick.Image
        frmQuestion2b.picAvatar.Image = picEvilPatrick.Image
        frmQuestion3b.picAvatar.Image = picEvilPatrick.Image
        frmQuestion4b.picAvatar.Image = picEvilPatrick.Image
        frmQuestion5b.picAvatar.Image = picEvilPatrick.Image
        '\\ PatrickIntro.wav plays
        '\\Notice that the file path is relative, not absolute. This is so that this solution can be deployed in multiple environments.
        My.Computer.Audio.Play("Sounds\PatrickIntro.wav")
        '\\ Open Question 1
        frmQuestion1b.Show()
        '\\ Close Avatar Selection
        Me.Hide()
    End Sub

    Private Sub btnSanic_Click(sender As Object, e As EventArgs) Handles btnSanic.Click
        '\\ Avatar Image Set
        '\\This sets the image to Sanic.
        frmQuestion1b.picAvatar.Image = picSanic.Image
        frmQuestion2b.picAvatar.Image = picSanic.Image
        frmQuestion3b.picAvatar.Image = picSanic.Image
        frmQuestion4b.picAvatar.Image = picSanic.Image
        frmQuestion5b.picAvatar.Image = picSanic.Image
        '\\ SanicIntro.wav plays
        '\\Notice that the file path is relative, not absolute. This is so that this solution can be deployed in multiple environments.
        My.Computer.Audio.Play("Sounds\SanicIntro.wav")
        '\\ Open Question 1
        frmQuestion1b.Show()
        '\\ Close Avatar Selection
        Me.Hide()
    End Sub

    Private Sub btnTyrone_Click(sender As Object, e As EventArgs) Handles btnTyrone.Click
        '\\ Avatar Image Set
        '\\This sets the image to Tyrone.
        frmQuestion1b.picAvatar.Image = picTyrone.Image
        frmQuestion2b.picAvatar.Image = picTyrone.Image
        frmQuestion3b.picAvatar.Image = picTyrone.Image
        frmQuestion4b.picAvatar.Image = picTyrone.Image
        frmQuestion5b.picAvatar.Image = picTyrone.Image
        '\\ TyroneIntro.wav plays
        '\\Notice that the file path is relative, not absolute. This is so that this solution can be deployed in multiple environments.
        My.Computer.Audio.Play("Sounds\TyroneIntro.wav")
        '\\ Open Question 1
        frmQuestion1b.Show()
        '\\ Close Avatar Selection
        Me.Hide()
    End Sub

    Private Sub btnBabyYoda_Click(sender As Object, e As EventArgs) Handles btnBabyYoda.Click
        '\\ Avatar Image Set
        '\\This sets the image to Baby Yoda.
        frmQuestion1b.picAvatar.Image = picBabyYoda.Image
        frmQuestion2b.picAvatar.Image = picBabyYoda.Image
        frmQuestion3b.picAvatar.Image = picBabyYoda.Image
        frmQuestion4b.picAvatar.Image = picBabyYoda.Image
        frmQuestion5b.picAvatar.Image = picBabyYoda.Image
        '\\ YodaIntro.wav plays
        '\\Notice that the file path is relative, not absolute. This is so that this solution can be deployed in multiple environments.
        My.Computer.Audio.Play("Sounds\YodaIntro.wav")
        '\\ Open Question 1
        frmQuestion1b.Show()
        '\\ Close Avatar Selection
        Me.Hide()
    End Sub

    Private Sub frmAvatarB_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnClose1_Click(sender As Object, e As EventArgs) Handles btnClose1.Click
        '\\ Program End
        End
    End Sub
End Class