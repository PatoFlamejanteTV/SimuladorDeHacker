<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.VenderPacoca = New System.Windows.Forms.Button()
        Me.money = New System.Windows.Forms.Label()
        Me.BuyPacoca = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Labelpacoca = New System.Windows.Forms.Label()
        Me.inflacao = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'VenderPacoca
        '
        Me.VenderPacoca.Location = New System.Drawing.Point(12, 12)
        Me.VenderPacoca.Name = "VenderPacoca"
        Me.VenderPacoca.Size = New System.Drawing.Size(93, 36)
        Me.VenderPacoca.TabIndex = 0
        Me.VenderPacoca.Text = "Vender paçoca" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(+R$1)"
        Me.VenderPacoca.UseVisualStyleBackColor = True
        '
        'money
        '
        Me.money.AutoSize = True
        Me.money.ForeColor = System.Drawing.SystemColors.ControlText
        Me.money.Location = New System.Drawing.Point(354, 223)
        Me.money.Name = "money"
        Me.money.Size = New System.Drawing.Size(37, 13)
        Me.money.TabIndex = 1
        Me.money.Text = "money"
        '
        'BuyPacoca
        '
        Me.BuyPacoca.Location = New System.Drawing.Point(111, 12)
        Me.BuyPacoca.Name = "BuyPacoca"
        Me.BuyPacoca.Size = New System.Drawing.Size(100, 36)
        Me.BuyPacoca.TabIndex = 2
        Me.BuyPacoca.Text = "Comprar paçoca" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(-R$0.7)"
        Me.BuyPacoca.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SimuladorDeHacker.My.Resources.Resources.pacoca
        Me.PictureBox1.Location = New System.Drawing.Point(332, 210)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(19, 13)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Labelpacoca
        '
        Me.Labelpacoca.AutoSize = True
        Me.Labelpacoca.Location = New System.Drawing.Point(354, 210)
        Me.Labelpacoca.Name = "Labelpacoca"
        Me.Labelpacoca.Size = New System.Drawing.Size(43, 13)
        Me.Labelpacoca.TabIndex = 4
        Me.Labelpacoca.Text = "pacoca"
        '
        'inflacao
        '
        Me.inflacao.AutoSize = True
        Me.inflacao.ForeColor = System.Drawing.SystemColors.ControlText
        Me.inflacao.Location = New System.Drawing.Point(9, 223)
        Me.inflacao.Name = "inflacao"
        Me.inflacao.Size = New System.Drawing.Size(55, 13)
        Me.inflacao.TabIndex = 5
        Me.inflacao.Text = "inflacao"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(403, 245)
        Me.Controls.Add(Me.inflacao)
        Me.Controls.Add(Me.Labelpacoca)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BuyPacoca)
        Me.Controls.Add(Me.money)
        Me.Controls.Add(Me.VenderPacoca)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents VenderPacoca As Button
    Friend WithEvents money As Label
    Friend WithEvents BuyPacoca As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Labelpacoca As Label
    Friend WithEvents inflacao As Label
End Class
