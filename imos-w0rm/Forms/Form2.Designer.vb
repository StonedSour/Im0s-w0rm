<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.s = New System.Windows.Forms.SaveFileDialog()
        Me.AzenisForm1 = New imos_w0rm.AzenisForm()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BypassSP = New imos_w0rm.AzenisCheckbox()
        Me.cicon = New imos_w0rm.AzenisCheckbox()
        Me.FW = New imos_w0rm.AzenisCheckbox()
        Me.uac = New imos_w0rm.AzenisCheckbox()
        Me.bsod = New imos_w0rm.AzenisCheckbox()
        Me.CheckBox3 = New imos_w0rm.AzenisCheckbox()
        Me.CheckBox1 = New imos_w0rm.AzenisCheckbox()
        Me.p2p = New imos_w0rm.AzenisCheckbox()
        Me.folder = New imos_w0rm.AzenisCheckbox()
        Me.shortcut = New imos_w0rm.AzenisCheckbox()
        Me.link = New imos_w0rm.AzenisRadiobutton()
        Me.exe = New imos_w0rm.AzenisRadiobutton()
        Me.AzenisButton1 = New imos_w0rm.AzenisButton()
        Me.PathS = New System.Windows.Forms.ComboBox()
        Me.mutex = New System.Windows.Forms.TextBox()
        Me.iconBox = New System.Windows.Forms.PictureBox()
        Me.port = New System.Windows.Forms.TextBox()
        Me.exename = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.vn = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.startupname = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.host = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AzenisForm1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iconBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        's
        '
        Me.s.Title = "Choose a place to save your worm"
        '
        'AzenisForm1
        '
        Me.AzenisForm1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.AzenisForm1.Controls.Add(Me.PictureBox2)
        Me.AzenisForm1.Controls.Add(Me.PictureBox1)
        Me.AzenisForm1.Controls.Add(Me.BypassSP)
        Me.AzenisForm1.Controls.Add(Me.cicon)
        Me.AzenisForm1.Controls.Add(Me.FW)
        Me.AzenisForm1.Controls.Add(Me.uac)
        Me.AzenisForm1.Controls.Add(Me.bsod)
        Me.AzenisForm1.Controls.Add(Me.CheckBox3)
        Me.AzenisForm1.Controls.Add(Me.CheckBox1)
        Me.AzenisForm1.Controls.Add(Me.p2p)
        Me.AzenisForm1.Controls.Add(Me.folder)
        Me.AzenisForm1.Controls.Add(Me.shortcut)
        Me.AzenisForm1.Controls.Add(Me.link)
        Me.AzenisForm1.Controls.Add(Me.exe)
        Me.AzenisForm1.Controls.Add(Me.AzenisButton1)
        Me.AzenisForm1.Controls.Add(Me.PathS)
        Me.AzenisForm1.Controls.Add(Me.mutex)
        Me.AzenisForm1.Controls.Add(Me.iconBox)
        Me.AzenisForm1.Controls.Add(Me.port)
        Me.AzenisForm1.Controls.Add(Me.exename)
        Me.AzenisForm1.Controls.Add(Me.TextBox2)
        Me.AzenisForm1.Controls.Add(Me.vn)
        Me.AzenisForm1.Controls.Add(Me.Label3)
        Me.AzenisForm1.Controls.Add(Me.Label5)
        Me.AzenisForm1.Controls.Add(Me.Label4)
        Me.AzenisForm1.Controls.Add(Me.startupname)
        Me.AzenisForm1.Controls.Add(Me.Label2)
        Me.AzenisForm1.Controls.Add(Me.host)
        Me.AzenisForm1.Controls.Add(Me.Label6)
        Me.AzenisForm1.Controls.Add(Me.Label1)
        Me.AzenisForm1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AzenisForm1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.AzenisForm1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.AzenisForm1.Location = New System.Drawing.Point(0, 0)
        Me.AzenisForm1.MinimumSize = New System.Drawing.Size(305, 150)
        Me.AzenisForm1.Name = "AzenisForm1"
        Me.AzenisForm1.Size = New System.Drawing.Size(305, 545)
        Me.AzenisForm1.TabIndex = 0
        Me.AzenisForm1.Text = "Builder"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(236, 5)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(23, 22)
        Me.PictureBox2.TabIndex = 62
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(265, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(23, 22)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'BypassSP
        '
        Me.BypassSP.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.BypassSP.Checked = False
        Me.BypassSP.Font = New System.Drawing.Font("Trebuchet MS", 10.0!)
        Me.BypassSP.ForeColor = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.BypassSP.Location = New System.Drawing.Point(12, 337)
        Me.BypassSP.MinimumSize = New System.Drawing.Size(20, 20)
        Me.BypassSP.Name = "BypassSP"
        Me.BypassSP.Size = New System.Drawing.Size(272, 21)
        Me.BypassSP.TabIndex = 61
        Me.BypassSP.Text = "Bypass Screening Programs - Disabled"
        '
        'cicon
        '
        Me.cicon.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.cicon.Checked = False
        Me.cicon.Font = New System.Drawing.Font("Trebuchet MS", 10.0!)
        Me.cicon.ForeColor = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.cicon.Location = New System.Drawing.Point(12, 474)
        Me.cicon.MinimumSize = New System.Drawing.Size(20, 20)
        Me.cicon.Name = "cicon"
        Me.cicon.Size = New System.Drawing.Size(237, 21)
        Me.cicon.TabIndex = 60
        Me.cicon.Text = "Change Icon - Disabled"
        '
        'FW
        '
        Me.FW.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.FW.Checked = False
        Me.FW.Font = New System.Drawing.Font("Trebuchet MS", 10.0!)
        Me.FW.ForeColor = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.FW.Location = New System.Drawing.Point(12, 310)
        Me.FW.MinimumSize = New System.Drawing.Size(20, 20)
        Me.FW.Name = "FW"
        Me.FW.Size = New System.Drawing.Size(259, 21)
        Me.FW.TabIndex = 59
        Me.FW.Text = "Bypass Windows Firewall - Disabled"
        '
        'uac
        '
        Me.uac.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.uac.Checked = False
        Me.uac.Font = New System.Drawing.Font("Trebuchet MS", 10.0!)
        Me.uac.ForeColor = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.uac.Location = New System.Drawing.Point(12, 283)
        Me.uac.MinimumSize = New System.Drawing.Size(20, 20)
        Me.uac.Name = "uac"
        Me.uac.Size = New System.Drawing.Size(197, 21)
        Me.uac.TabIndex = 58
        Me.uac.Text = "Bypass UAC - Disabled"
        '
        'bsod
        '
        Me.bsod.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.bsod.Checked = False
        Me.bsod.Font = New System.Drawing.Font("Trebuchet MS", 10.0!)
        Me.bsod.ForeColor = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.bsod.Location = New System.Drawing.Point(12, 256)
        Me.bsod.MinimumSize = New System.Drawing.Size(20, 20)
        Me.bsod.Name = "bsod"
        Me.bsod.Size = New System.Drawing.Size(213, 21)
        Me.bsod.TabIndex = 57
        Me.bsod.Text = "Protect Process - Disabled"
        '
        'CheckBox3
        '
        Me.CheckBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.CheckBox3.Checked = False
        Me.CheckBox3.Font = New System.Drawing.Font("Trebuchet MS", 10.0!)
        Me.CheckBox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.CheckBox3.Location = New System.Drawing.Point(12, 444)
        Me.CheckBox3.MinimumSize = New System.Drawing.Size(20, 20)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(213, 21)
        Me.CheckBox3.TabIndex = 56
        Me.CheckBox3.Text = "Drive Spread - Disabled"
        '
        'CheckBox1
        '
        Me.CheckBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.CheckBox1.Checked = False
        Me.CheckBox1.Font = New System.Drawing.Font("Trebuchet MS", 10.0!)
        Me.CheckBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.CheckBox1.Location = New System.Drawing.Point(12, 229)
        Me.CheckBox1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(197, 21)
        Me.CheckBox1.TabIndex = 55
        Me.CheckBox1.Text = "Bot Killer - Disabled"
        '
        'p2p
        '
        Me.p2p.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.p2p.Checked = False
        Me.p2p.Font = New System.Drawing.Font("Trebuchet MS", 10.0!)
        Me.p2p.ForeColor = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.p2p.Location = New System.Drawing.Point(12, 417)
        Me.p2p.MinimumSize = New System.Drawing.Size(20, 20)
        Me.p2p.Name = "p2p"
        Me.p2p.Size = New System.Drawing.Size(213, 21)
        Me.p2p.TabIndex = 54
        Me.p2p.Text = "P2P Spread - Disabled"
        '
        'folder
        '
        Me.folder.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.folder.Checked = False
        Me.folder.Font = New System.Drawing.Font("Trebuchet MS", 10.0!)
        Me.folder.ForeColor = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.folder.Location = New System.Drawing.Point(12, 390)
        Me.folder.MinimumSize = New System.Drawing.Size(20, 20)
        Me.folder.Name = "folder"
        Me.folder.Size = New System.Drawing.Size(213, 21)
        Me.folder.TabIndex = 53
        Me.folder.Text = "Folders Spread - Disabled"
        '
        'shortcut
        '
        Me.shortcut.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.shortcut.Checked = False
        Me.shortcut.Font = New System.Drawing.Font("Trebuchet MS", 10.0!)
        Me.shortcut.ForeColor = System.Drawing.Color.RoyalBlue
        Me.shortcut.Location = New System.Drawing.Point(12, 363)
        Me.shortcut.MinimumSize = New System.Drawing.Size(20, 20)
        Me.shortcut.Name = "shortcut"
        Me.shortcut.Size = New System.Drawing.Size(186, 21)
        Me.shortcut.TabIndex = 52
        Me.shortcut.Text = "ShortCut Spread - Disabled"
        '
        'link
        '
        Me.link.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.link.Checked = False
        Me.link.Font = New System.Drawing.Font("Trebuchet MS", 10.0!)
        Me.link.ForeColor = System.Drawing.Color.RoyalBlue
        Me.link.Location = New System.Drawing.Point(12, 204)
        Me.link.MinimumSize = New System.Drawing.Size(20, 20)
        Me.link.Name = "link"
        Me.link.Size = New System.Drawing.Size(142, 21)
        Me.link.TabIndex = 51
        Me.link.Text = "USB Spread / Link"
        '
        'exe
        '
        Me.exe.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.exe.Checked = False
        Me.exe.Font = New System.Drawing.Font("Trebuchet MS", 10.0!)
        Me.exe.ForeColor = System.Drawing.Color.RoyalBlue
        Me.exe.Location = New System.Drawing.Point(160, 204)
        Me.exe.MinimumSize = New System.Drawing.Size(20, 20)
        Me.exe.Name = "exe"
        Me.exe.Size = New System.Drawing.Size(126, 21)
        Me.exe.TabIndex = 50
        Me.exe.Text = "USB Spread / EXE"
        '
        'AzenisButton1
        '
        Me.AzenisButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.AzenisButton1.Font = New System.Drawing.Font("Trebuchet MS", 10.0!)
        Me.AzenisButton1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.AzenisButton1.Location = New System.Drawing.Point(85, 501)
        Me.AzenisButton1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.AzenisButton1.Name = "AzenisButton1"
        Me.AzenisButton1.Size = New System.Drawing.Size(140, 32)
        Me.AzenisButton1.TabIndex = 49
        Me.AzenisButton1.Text = "Build Worn"
        '
        'PathS
        '
        Me.PathS.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.PathS.ForeColor = System.Drawing.Color.RoyalBlue
        Me.PathS.FormattingEnabled = True
        Me.PathS.Items.AddRange(New Object() {"Temp", "AppData", "UserProfile", "ProgramData", "WinDir"})
        Me.PathS.Location = New System.Drawing.Point(135, 173)
        Me.PathS.Name = "PathS"
        Me.PathS.Size = New System.Drawing.Size(149, 25)
        Me.PathS.TabIndex = 46
        Me.PathS.Text = "Temp"
        '
        'mutex
        '
        Me.mutex.Location = New System.Drawing.Point(315, 197)
        Me.mutex.Name = "mutex"
        Me.mutex.Size = New System.Drawing.Size(51, 25)
        Me.mutex.TabIndex = 43
        '
        'iconBox
        '
        Me.iconBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.iconBox.Location = New System.Drawing.Point(34, 501)
        Me.iconBox.Name = "iconBox"
        Me.iconBox.Size = New System.Drawing.Size(33, 32)
        Me.iconBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.iconBox.TabIndex = 42
        Me.iconBox.TabStop = False
        '
        'port
        '
        Me.port.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.port.Enabled = False
        Me.port.ForeColor = System.Drawing.Color.RoyalBlue
        Me.port.Location = New System.Drawing.Point(135, 70)
        Me.port.Name = "port"
        Me.port.Size = New System.Drawing.Size(149, 25)
        Me.port.TabIndex = 41
        '
        'exename
        '
        Me.exename.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.exename.ForeColor = System.Drawing.Color.RoyalBlue
        Me.exename.Location = New System.Drawing.Point(135, 147)
        Me.exename.Name = "exename"
        Me.exename.Size = New System.Drawing.Size(149, 25)
        Me.exename.TabIndex = 31
        Me.exename.Text = "Worm.exe"
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.TextBox2.ForeColor = System.Drawing.Color.RoyalBlue
        Me.TextBox2.Location = New System.Drawing.Point(135, 96)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(149, 25)
        Me.TextBox2.TabIndex = 30
        Me.TextBox2.Text = "[ MUTEX ]"
        '
        'vn
        '
        Me.vn.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.vn.ForeColor = System.Drawing.Color.RoyalBlue
        Me.vn.Location = New System.Drawing.Point(135, 122)
        Me.vn.Name = "vn"
        Me.vn.Size = New System.Drawing.Size(149, 25)
        Me.vn.TabIndex = 29
        Me.vn.Text = "HacKed"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label3.Location = New System.Drawing.Point(34, 150)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 19)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "ExeName : "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label5.Location = New System.Drawing.Point(12, 125)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 19)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Victim Name : "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label4.Location = New System.Drawing.Point(30, 173)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 19)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Directory  : "
        '
        'startupname
        '
        Me.startupname.Enabled = False
        Me.startupname.Location = New System.Drawing.Point(472, 472)
        Me.startupname.Name = "startupname"
        Me.startupname.Size = New System.Drawing.Size(136, 25)
        Me.startupname.TabIndex = 27
        Me.startupname.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label2.Location = New System.Drawing.Point(65, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 19)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Port : "
        '
        'host
        '
        Me.host.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.host.ForeColor = System.Drawing.Color.RoyalBlue
        Me.host.Location = New System.Drawing.Point(135, 45)
        Me.host.Name = "host"
        Me.host.Size = New System.Drawing.Size(149, 25)
        Me.host.TabIndex = 26
        Me.host.Text = "127.0.0.1"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label6.Location = New System.Drawing.Point(45, 99)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 19)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "MUTEX : "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label1.Location = New System.Drawing.Point(36, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 19)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "IP \ Host : "
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(305, 545)
        Me.Controls.Add(Me.AzenisForm1)
        Me.ForeColor = System.Drawing.Color.Maroon
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(305, 150)
        Me.Name = "Form2"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Builder | Black Worm"
        Me.TopMost = True
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.AzenisForm1.ResumeLayout(False)
        Me.AzenisForm1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iconBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents AzenisForm1 As AzenisForm
    Friend WithEvents PathS As ComboBox
    Friend WithEvents mutex As TextBox
    Friend WithEvents iconBox As PictureBox
    Friend WithEvents port As TextBox
    Friend WithEvents exename As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents vn As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents startupname As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents host As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents s As SaveFileDialog
    Friend WithEvents AzenisButton1 As AzenisButton
    Friend WithEvents link As AzenisRadiobutton
    Friend WithEvents exe As AzenisRadiobutton
    Friend WithEvents shortcut As AzenisCheckbox
    Friend WithEvents BypassSP As AzenisCheckbox
    Friend WithEvents cicon As AzenisCheckbox
    Friend WithEvents FW As AzenisCheckbox
    Friend WithEvents uac As AzenisCheckbox
    Friend WithEvents bsod As AzenisCheckbox
    Friend WithEvents CheckBox3 As AzenisCheckbox
    Friend WithEvents CheckBox1 As AzenisCheckbox
    Friend WithEvents p2p As AzenisCheckbox
    Friend WithEvents folder As AzenisCheckbox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
