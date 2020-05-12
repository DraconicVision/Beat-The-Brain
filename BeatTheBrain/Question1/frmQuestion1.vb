'\\ Author: Matthew Curran
'\\ Date: 10/03/2020
'\\ Version: VB.net 2017
Public Class frmQuestion1
    Private Sub frmQuestion1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '\\ Start Timer
        '\\Start the timer as soon as the form loads.
        tmr1.Start()
    End Sub

    '\\ Timer Set
    '\\This sets the base time to 20seconds
    Dim timercount As Integer = 20

    Private Sub btnQ1B_Click(sender As Object, e As EventArgs) Handles btnQ1B.Click
        '\\ Correct Answer
        '\\ Correct.wav Plays
        '\\Notice that the file path is relative, not absolute. This is so that this solution can be deployed in multiple environments.
        My.Computer.Audio.Play("Sounds\Correct.wav")
        '\\ Timer Stop
        '\\This should stop the timer for the current form
        tmr1.Stop()
        '\\Proceeds to question 2.
        frmQuestion2.Show()
        '\\ Close Question 1.
        Me.Hide()
    End Sub
    Private Sub btnQ1A_Click(sender As Object, e As EventArgs) Handles btnQ1A.Click
        '\\ Timer Stop
        '\\This should stop the timer for the current form
        tmr1.Stop()
        '\\ Incorrect Answer
        frmLoser.Show()
        '\\ Close Question 1.
        Me.Hide()
        '\\ Incorrect.wav Plays
        '\\Notice that the file path is relative, not absolute. This is so that this solution can be deployed in multiple environments.
        My.Computer.Audio.Play("Sounds\Incorrect.wav")
    End Sub

    Private Sub btnQ1C_Click(sender As Object, e As EventArgs) Handles btnQ1C.Click
        '\\ Timer Stop
        '\\This should stop the timer for the current form
        tmr1.Stop()
        '\\ Incorrect Answer
        frmLoser.Show()
        '\\ Close Question 1.
        Me.Hide()
        '\\ Incorrect.wav Plays
        '\\Notice that the file path is relative, not absolute. This is so that this solution can be deployed in multiple environments.
        My.Computer.Audio.Play("Sounds\Incorrect.wav")
    End Sub

    Private Sub tmrCount_Tick(sender As Object, e As EventArgs) Handles tmr1.Tick
        '\\ Label Timer Display
        '\\This sets the lblTimer to the timercount value as a string
        lblTimer.Text = timercount.ToString
        If timercount = 0 Then
            '\\ Timer Complete
            '\\If The timer reaches 0 it will display the Loser form and hide this question.
            frmLoser.Show()
            Me.Hide()
        Else
            '\\ Timer Incomplete
            '\\If the timer is not yet 0 the timercount value will be reduced by 1
            timercount -= 1
        End If
    End Sub

End Class