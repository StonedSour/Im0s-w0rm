<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form6
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form6))
        Me.AzenisForm1 = New imos_w0rm.AzenisForm()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.AzenisButton1 = New imos_w0rm.AzenisButton()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.AzenisForm1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AzenisForm1
        '
        Me.AzenisForm1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.AzenisForm1.Controls.Add(Me.PictureBox2)
        Me.AzenisForm1.Controls.Add(Me.PictureBox1)
        Me.AzenisForm1.Controls.Add(Me.AzenisButton1)
        Me.AzenisForm1.Controls.Add(Me.RichTextBox1)
        Me.AzenisForm1.Controls.Add(Me.TextBox3)
        Me.AzenisForm1.Controls.Add(Me.TextBox2)
        Me.AzenisForm1.Controls.Add(Me.TextBox1)
        Me.AzenisForm1.Controls.Add(Me.Label3)
        Me.AzenisForm1.Controls.Add(Me.Label2)
        Me.AzenisForm1.Controls.Add(Me.Label1)
        Me.AzenisForm1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AzenisForm1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.AzenisForm1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.AzenisForm1.Location = New System.Drawing.Point(0, 0)
        Me.AzenisForm1.MinimumSize = New System.Drawing.Size(305, 150)
        Me.AzenisForm1.Name = "AzenisForm1"
        Me.AzenisForm1.Size = New System.Drawing.Size(305, 200)
        Me.AzenisForm1.TabIndex = 0
        Me.AzenisForm1.Text = "Updater No-IP"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(266, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(23, 22)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'AzenisButton1
        '
        Me.AzenisButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.AzenisButton1.Font = New System.Drawing.Font("Trebuchet MS", 10.0!)
        Me.AzenisButton1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.AzenisButton1.Location = New System.Drawing.Point(16, 145)
        Me.AzenisButton1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.AzenisButton1.Name = "AzenisButton1"
        Me.AzenisButton1.Size = New System.Drawing.Size(269, 34)
        Me.AzenisButton1.TabIndex = 14
        Me.AzenisButton1.Text = "Update No-IP"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(20, 220)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(102, 21)
        Me.RichTextBox1.TabIndex = 13
        Me.RichTextBox1.Text = ""
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.TextBox3.ForeColor = System.Drawing.Color.RoyalBlue
        Me.TextBox3.Location = New System.Drawing.Point(112, 104)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox3.Size = New System.Drawing.Size(173, 25)
        Me.TextBox3.TabIndex = 8
        Me.TextBox3.Text = "Your Password"
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.TextBox2.ForeColor = System.Drawing.Color.RoyalBlue
        Me.TextBox2.Location = New System.Drawing.Point(112, 76)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(173, 25)
        Me.TextBox2.TabIndex = 9
        Me.TextBox2.Text = "Your Email"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.TextBox1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.TextBox1.Location = New System.Drawing.Point(112, 48)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(173, 25)
        Me.TextBox1.TabIndex = 10
        Me.TextBox1.Text = "Your No-IP"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label3.Location = New System.Drawing.Point(12, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 19)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Password: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label2.Location = New System.Drawing.Point(38, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 19)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Email: "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label1.Location = New System.Drawing.Point(41, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 19)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Host: "
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(237, 5)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(23, 22)
        Me.PictureBox2.TabIndex = 15
        Me.PictureBox2.TabStop = False
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(305, 200)
        Me.Controls.Add(Me.AzenisForm1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(305, 150)
        Me.Name = "Form6"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "[ No-IP Updater ]"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.AzenisForm1.ResumeLayout(False)
        Me.AzenisForm1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents AzenisForm1 As AzenisForm
    Friend WithEvents AzenisButton1 As AzenisButton
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
