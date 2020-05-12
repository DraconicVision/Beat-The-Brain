Public Class btnClose
    Private Sub FrmLogin()
        btnLogin.FlatStyle = FlatStyle.Flat
        btnLogin.FlatAppearance.BorderColor = Color.Black
    End Sub
    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play("H:\Units\Developing Programming Solutions\VB Programs\Beat The Brain\Sounds\Lets Get Ready to Rumble.wav")
    End Sub
    Private Sub lblPass_Click(sender As Object, e As EventArgs) Handles lblPass.Click

    End Sub
    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        AvatarSelection.Show()
        Hide()
    End Sub

    Private Sub txtUser_TextChanged(sender As Object, e As EventArgs) Handles txtUser.TextChanged

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles btnClose2.Click
        End
    End Sub

    Private Sub txtPass_TextChanged(sender As Object, e As EventArgs) Handles txtPass.TextChanged

    End Sub
End Class
