Public Class AvatarSelection
    Private Sub frmAvatar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnClose1_Click(sender As Object, e As EventArgs) Handles btnClose1.Click
        End
    End Sub

    Private Sub btnEvilPatrick_Click(sender As Object, e As EventArgs) Handles btnEvilPatrick.Click
        frmQuestion1.picAvatar.Image = picEvilPatrick.Image
        frmQuestion2.picAvatar.Image = picEvilPatrick.Image
        frmQuestion3.picAvatar.Image = picEvilPatrick.Image
        frmQuestion4.picAvatar.Image = picEvilPatrick.Image
        frmQuestion5.picAvatar.Image = picEvilPatrick.Image
        frmQuestion1.Show()
        Me.Hide()
    End Sub

    Private Sub btnSanic_Click(sender As Object, e As EventArgs) Handles btnSanic.Click
        frmQuestion1.picAvatar.Image = picSanic.Image
        frmQuestion2.picAvatar.Image = picSanic.Image
        frmQuestion3.picAvatar.Image = picSanic.Image
        frmQuestion4.picAvatar.Image = picSanic.Image
        frmQuestion5.picAvatar.Image = picSanic.Image
        frmQuestion1.Show()
        Me.Hide()
    End Sub
End Class