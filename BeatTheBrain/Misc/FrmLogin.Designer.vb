<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class btnClose
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.PicLogo = New System.Windows.Forms.PictureBox()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.lblPass = New System.Windows.Forms.Label()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.btnEnd = New System.Windows.Forms.Button()
        CType(Me.PicLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PicLogo
        '
        Me.PicLogo.BackColor = System.Drawing.Color.Lavender
        Me.PicLogo.Image = Global.BeatTheBrain.My.Resources.Resources.ChaseLogo
        Me.PicLogo.Location = New System.Drawing.Point(146, 43)
        Me.PicLogo.Name = "PicLogo"
        Me.PicLogo.Size = New System.Drawing.Size(444, 223)
        Me.PicLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicLogo.TabIndex = 0
        Me.PicLogo.TabStop = False
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.BackColor = System.Drawing.Color.DimGray
        Me.lblUser.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblUser.Location = New System.Drawing.Point(142, 299)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(89, 20)
        Me.lblUser.TabIndex = 1
        Me.lblUser.Text = "UserName:"
        '
        'lblPass
        '
        Me.lblPass.AutoSize = True
        Me.lblPass.BackColor = System.Drawing.Color.DimGray
        Me.lblPass.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblPass.Location = New System.Drawing.Point(142, 335)
        Me.lblPass.Name = "lblPass"
        Me.lblPass.Size = New System.Drawing.Size(86, 20)
        Me.lblPass.TabIndex = 2
        Me.lblPass.Text = "Password: "
        '
        'txtUser
        '
        Me.txtUser.BackColor = System.Drawing.Color.Gray
        Me.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUser.Location = New System.Drawing.Point(248, 299)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(259, 20)
        Me.txtUser.TabIndex = 3
        '
        'txtPass
        '
        Me.txtPass.BackColor = System.Drawing.Color.Gray
        Me.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPass.Location = New System.Drawing.Point(248, 334)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPass.Size = New System.Drawing.Size(259, 20)
        Me.txtPass.TabIndex = 4
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.DimGray
        Me.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.Location = New System.Drawing.Point(530, 411)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(104, 28)
        Me.btnLogin.TabIndex = 5
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'btnEnd
        '
        Me.btnEnd.BackColor = System.Drawing.Color.DimGray
        Me.btnEnd.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnEnd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btnEnd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray
        Me.btnEnd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEnd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnd.Location = New System.Drawing.Point(650, 411)
        Me.btnEnd.Name = "btnEnd"
        Me.btnEnd.Size = New System.Drawing.Size(104, 28)
        Me.btnEnd.TabIndex = 6
        Me.btnEnd.Text = "Close"
        Me.btnEnd.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnEnd)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.lblPass)
        Me.Controls.Add(Me.lblUser)
        Me.Controls.Add(Me.PicLogo)
        Me.Name = "btnClose"
        Me.Text = "Login "
        CType(Me.PicLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PicLogo As PictureBox
    Friend WithEvents lblUser As Label
    Friend WithEvents lblPass As Label
    Friend WithEvents txtUser As TextBox
    Friend WithEvents txtPass As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents btnEnd As Button
End Class
