<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDifficultySelection
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDifficultySelection))
        Me.btnClose1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.btnHard = New System.Windows.Forms.Button()
        Me.btnMedium = New System.Windows.Forms.Button()
        Me.btnEasy = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnClose1
        '
        Me.btnClose1.BackColor = System.Drawing.Color.DimGray
        Me.btnClose1.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnClose1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btnClose1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray
        Me.btnClose1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose1.Location = New System.Drawing.Point(652, 410)
        Me.btnClose1.Name = "btnClose1"
        Me.btnClose1.Size = New System.Drawing.Size(104, 28)
        Me.btnClose1.TabIndex = 11
        Me.btnClose1.Text = "Close"
        Me.btnClose1.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 37)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(226, 146)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(287, 37)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(226, 146)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 13
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(562, 37)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(226, 146)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 14
        Me.PictureBox3.TabStop = False
        '
        'btnHard
        '
        Me.btnHard.BackColor = System.Drawing.Color.DimGray
        Me.btnHard.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnHard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btnHard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray
        Me.btnHard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHard.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.btnHard.Location = New System.Drawing.Point(604, 189)
        Me.btnHard.Name = "btnHard"
        Me.btnHard.Size = New System.Drawing.Size(143, 39)
        Me.btnHard.TabIndex = 15
        Me.btnHard.Text = "Hard"
        Me.btnHard.UseVisualStyleBackColor = False
        '
        'btnMedium
        '
        Me.btnMedium.BackColor = System.Drawing.Color.DimGray
        Me.btnMedium.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnMedium.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btnMedium.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray
        Me.btnMedium.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMedium.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.btnMedium.Location = New System.Drawing.Point(329, 189)
        Me.btnMedium.Name = "btnMedium"
        Me.btnMedium.Size = New System.Drawing.Size(143, 39)
        Me.btnMedium.TabIndex = 16
        Me.btnMedium.Text = "Medium"
        Me.btnMedium.UseVisualStyleBackColor = False
        '
        'btnEasy
        '
        Me.btnEasy.BackColor = System.Drawing.Color.DimGray
        Me.btnEasy.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnEasy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btnEasy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray
        Me.btnEasy.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEasy.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.btnEasy.Location = New System.Drawing.Point(53, 189)
        Me.btnEasy.Name = "btnEasy"
        Me.btnEasy.Size = New System.Drawing.Size(143, 39)
        Me.btnEasy.TabIndex = 17
        Me.btnEasy.Text = "Easy"
        Me.btnEasy.UseVisualStyleBackColor = False
        '
        'frmDifficultySelection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnEasy)
        Me.Controls.Add(Me.btnMedium)
        Me.Controls.Add(Me.btnHard)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnClose1)
        Me.Name = "frmDifficultySelection"
        Me.Text = "Difficulty Selection"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnClose1 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents btnHard As Button
    Friend WithEvents btnMedium As Button
    Friend WithEvents btnEasy As Button
End Class
