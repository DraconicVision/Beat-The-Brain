<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLoser
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLoser))
        Me.lbl25Points = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnClose1 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl25Points
        '
        Me.lbl25Points.AutoSize = True
        Me.lbl25Points.BackColor = System.Drawing.Color.Silver
        Me.lbl25Points.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbl25Points.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.lbl25Points.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl25Points.Location = New System.Drawing.Point(29, 37)
        Me.lbl25Points.Name = "lbl25Points"
        Me.lbl25Points.Size = New System.Drawing.Size(469, 31)
        Me.lbl25Points.TabIndex = 2
        Me.lbl25Points.Text = "You lose, you have not beat the brain!"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 96)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(493, 283)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'btnClose1
        '
        Me.btnClose1.BackColor = System.Drawing.Color.DimGray
        Me.btnClose1.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnClose1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btnClose1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray
        Me.btnClose1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose1.Location = New System.Drawing.Point(401, 435)
        Me.btnClose1.Name = "btnClose1"
        Me.btnClose1.Size = New System.Drawing.Size(104, 28)
        Me.btnClose1.TabIndex = 8
        Me.btnClose1.Text = "Close"
        Me.btnClose1.UseVisualStyleBackColor = False
        '
        'frmLoser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(517, 475)
        Me.Controls.Add(Me.btnClose1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lbl25Points)
        Me.Name = "frmLoser"
        Me.Text = "Loser!"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl25Points As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnClose1 As Button
End Class
