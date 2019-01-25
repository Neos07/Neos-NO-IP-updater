<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.NotifyIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.MainFormSkin = New Neos_NO_IP_Updater.FormSkin()
        Me.AutoUpdateCheckBox = New Neos_NO_IP_Updater.FlatCheckBox()
        Me.ListBox = New System.Windows.Forms.ListBox()
        Me.UpdateButton = New Neos_NO_IP_Updater.FlatButton()
        Me.HostTextBox = New Neos_NO_IP_Updater.FlatTextBox()
        Me.Host = New Neos_NO_IP_Updater.FlatLabel()
        Me.Password = New Neos_NO_IP_Updater.FlatLabel()
        Me.Username = New Neos_NO_IP_Updater.FlatLabel()
        Me.PasswordTextBox = New Neos_NO_IP_Updater.FlatTextBox()
        Me.CloseButton = New Neos_NO_IP_Updater.FlatClose()
        Me.MiniButton = New Neos_NO_IP_Updater.FlatMini()
        Me.UsernameTextBox = New Neos_NO_IP_Updater.FlatTextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.UpdateTimer = New System.Windows.Forms.Timer(Me.components)
        Me.MainFormSkin.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NotifyIcon
        '
        Me.NotifyIcon.Icon = CType(resources.GetObject("NotifyIcon.Icon"), System.Drawing.Icon)
        Me.NotifyIcon.Text = "Neos NO-IP Updater"
        '
        'MainFormSkin
        '
        Me.MainFormSkin.BackColor = System.Drawing.Color.White
        Me.MainFormSkin.BaseColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.MainFormSkin.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MainFormSkin.Controls.Add(Me.AutoUpdateCheckBox)
        Me.MainFormSkin.Controls.Add(Me.ListBox)
        Me.MainFormSkin.Controls.Add(Me.UpdateButton)
        Me.MainFormSkin.Controls.Add(Me.HostTextBox)
        Me.MainFormSkin.Controls.Add(Me.Host)
        Me.MainFormSkin.Controls.Add(Me.Password)
        Me.MainFormSkin.Controls.Add(Me.Username)
        Me.MainFormSkin.Controls.Add(Me.PasswordTextBox)
        Me.MainFormSkin.Controls.Add(Me.CloseButton)
        Me.MainFormSkin.Controls.Add(Me.MiniButton)
        Me.MainFormSkin.Controls.Add(Me.UsernameTextBox)
        Me.MainFormSkin.Controls.Add(Me.PictureBox2)
        Me.MainFormSkin.Controls.Add(Me.PictureBox1)
        Me.MainFormSkin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainFormSkin.FlatColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MainFormSkin.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.MainFormSkin.ForeColor = System.Drawing.SystemColors.ControlText
        Me.MainFormSkin.HeaderColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.MainFormSkin.HeaderMaximize = False
        Me.MainFormSkin.Location = New System.Drawing.Point(0, 0)
        Me.MainFormSkin.Name = "MainFormSkin"
        Me.MainFormSkin.Size = New System.Drawing.Size(424, 494)
        Me.MainFormSkin.TabIndex = 0
        Me.MainFormSkin.Text = "Neos NO-IP Updater"
        '
        'AutoUpdateCheckBox
        '
        Me.AutoUpdateCheckBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.AutoUpdateCheckBox.BaseColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.AutoUpdateCheckBox.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.AutoUpdateCheckBox.Checked = False
        Me.AutoUpdateCheckBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AutoUpdateCheckBox.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.AutoUpdateCheckBox.Location = New System.Drawing.Point(15, 308)
        Me.AutoUpdateCheckBox.Name = "AutoUpdateCheckBox"
        Me.AutoUpdateCheckBox.Options = Neos_NO_IP_Updater.FlatCheckBox._Options.Style1
        Me.AutoUpdateCheckBox.Size = New System.Drawing.Size(112, 22)
        Me.AutoUpdateCheckBox.TabIndex = 14
        Me.AutoUpdateCheckBox.Text = "Auto Update"
        '
        'ListBox
        '
        Me.ListBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.ListBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListBox.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.ListBox.ForeColor = System.Drawing.Color.White
        Me.ListBox.ItemHeight = 17
        Me.ListBox.Location = New System.Drawing.Point(12, 346)
        Me.ListBox.Name = "ListBox"
        Me.ListBox.Size = New System.Drawing.Size(400, 136)
        Me.ListBox.TabIndex = 13
        '
        'UpdateButton
        '
        Me.UpdateButton.BackColor = System.Drawing.Color.Transparent
        Me.UpdateButton.BaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.UpdateButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UpdateButton.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.UpdateButton.Location = New System.Drawing.Point(284, 301)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Rounded = False
        Me.UpdateButton.Size = New System.Drawing.Size(128, 33)
        Me.UpdateButton.TabIndex = 11
        Me.UpdateButton.Text = "Update"
        Me.UpdateButton.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'HostTextBox
        '
        Me.HostTextBox.BackColor = System.Drawing.Color.Transparent
        Me.HostTextBox.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.HostTextBox.Location = New System.Drawing.Point(84, 263)
        Me.HostTextBox.MaxLength = 32767
        Me.HostTextBox.Multiline = False
        Me.HostTextBox.Name = "HostTextBox"
        Me.HostTextBox.ReadOnly = False
        Me.HostTextBox.Size = New System.Drawing.Size(328, 26)
        Me.HostTextBox.TabIndex = 10
        Me.HostTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.HostTextBox.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.HostTextBox.UseSystemPasswordChar = False
        '
        'Host
        '
        Me.Host.BackColor = System.Drawing.Color.Transparent
        Me.Host.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Host.ForeColor = System.Drawing.Color.White
        Me.Host.Location = New System.Drawing.Point(12, 268)
        Me.Host.Name = "Host"
        Me.Host.Size = New System.Drawing.Size(66, 18)
        Me.Host.TabIndex = 9
        Me.Host.Text = "Host:"
        '
        'Password
        '
        Me.Password.BackColor = System.Drawing.Color.Transparent
        Me.Password.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Password.ForeColor = System.Drawing.Color.White
        Me.Password.Location = New System.Drawing.Point(12, 226)
        Me.Password.Name = "Password"
        Me.Password.Size = New System.Drawing.Size(66, 18)
        Me.Password.TabIndex = 8
        Me.Password.Text = "Password:"
        '
        'Username
        '
        Me.Username.BackColor = System.Drawing.Color.Transparent
        Me.Username.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Username.ForeColor = System.Drawing.Color.White
        Me.Username.Location = New System.Drawing.Point(12, 188)
        Me.Username.Name = "Username"
        Me.Username.Size = New System.Drawing.Size(66, 18)
        Me.Username.TabIndex = 7
        Me.Username.Text = "Username:"
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.BackColor = System.Drawing.Color.Transparent
        Me.PasswordTextBox.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.PasswordTextBox.Location = New System.Drawing.Point(84, 223)
        Me.PasswordTextBox.MaxLength = 32767
        Me.PasswordTextBox.Multiline = False
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.ReadOnly = False
        Me.PasswordTextBox.Size = New System.Drawing.Size(328, 26)
        Me.PasswordTextBox.TabIndex = 6
        Me.PasswordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.PasswordTextBox.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PasswordTextBox.UseSystemPasswordChar = True
        '
        'CloseButton
        '
        Me.CloseButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CloseButton.BackColor = System.Drawing.Color.White
        Me.CloseButton.BaseColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.CloseButton.Font = New System.Drawing.Font("Marlett", 12.0!)
        Me.CloseButton.Location = New System.Drawing.Point(394, 12)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(18, 18)
        Me.CloseButton.TabIndex = 5
        Me.CloseButton.Text = "CloseButton"
        Me.CloseButton.TextColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        '
        'MiniButton
        '
        Me.MiniButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MiniButton.BackColor = System.Drawing.Color.White
        Me.MiniButton.BaseColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.MiniButton.Font = New System.Drawing.Font("Marlett", 12.0!)
        Me.MiniButton.Location = New System.Drawing.Point(370, 12)
        Me.MiniButton.Name = "MiniButton"
        Me.MiniButton.Size = New System.Drawing.Size(18, 18)
        Me.MiniButton.TabIndex = 4
        Me.MiniButton.Text = "MiniButton"
        Me.MiniButton.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.BackColor = System.Drawing.Color.Transparent
        Me.UsernameTextBox.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.UsernameTextBox.Location = New System.Drawing.Point(84, 183)
        Me.UsernameTextBox.MaxLength = 32767
        Me.UsernameTextBox.Multiline = False
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.ReadOnly = False
        Me.UsernameTextBox.Size = New System.Drawing.Size(328, 26)
        Me.UsernameTextBox.TabIndex = 2
        Me.UsernameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.UsernameTextBox.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.UsernameTextBox.UseSystemPasswordChar = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.PictureBox2.Image = Global.Neos_NO_IP_Updater.My.Resources.Resources.NO_IP_Icon1
        Me.PictureBox2.Location = New System.Drawing.Point(3, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(22, 22)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.PictureBox1.Image = Global.Neos_NO_IP_Updater.My.Resources.Resources.NoIP
        Me.PictureBox1.Location = New System.Drawing.Point(12, 55)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(400, 104)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'UpdateTimer
        '
        Me.UpdateTimer.Interval = 1000
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(424, 494)
        Me.ControlBox = False
        Me.Controls.Add(Me.MainFormSkin)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MainForm"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Neos NO-IP Updater"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.MainFormSkin.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MainFormSkin As Neos_NO_IP_Updater.FormSkin
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents UsernameTextBox As Neos_NO_IP_Updater.FlatTextBox
    Friend WithEvents NotifyIcon As System.Windows.Forms.NotifyIcon
    Friend WithEvents CloseButton As Neos_NO_IP_Updater.FlatClose
    Friend WithEvents MiniButton As Neos_NO_IP_Updater.FlatMini
    Friend WithEvents PasswordTextBox As Neos_NO_IP_Updater.FlatTextBox
    Friend WithEvents Username As Neos_NO_IP_Updater.FlatLabel
    Friend WithEvents HostTextBox As Neos_NO_IP_Updater.FlatTextBox
    Friend WithEvents Host As Neos_NO_IP_Updater.FlatLabel
    Friend WithEvents Password As Neos_NO_IP_Updater.FlatLabel
    Friend WithEvents UpdateButton As Neos_NO_IP_Updater.FlatButton
    Friend WithEvents ListBox As System.Windows.Forms.ListBox
    Friend WithEvents AutoUpdateCheckBox As Neos_NO_IP_Updater.FlatCheckBox
    Friend WithEvents UpdateTimer As System.Windows.Forms.Timer

End Class
