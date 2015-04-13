<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblTenCh = New System.Windows.Forms.Label()
        Me.lblWelcome = New System.Windows.Forms.ToolStripStatusLabel()
        Me.stsWelcome = New System.Windows.Forms.StatusStrip()
        Me.mniThongtin = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniInformation = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniNhaphang = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniAddnew = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniQuanly = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniLogin = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniHethong = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnsMenu = New System.Windows.Forms.MenuStrip()
        Me.ptbPicture = New System.Windows.Forms.PictureBox()
        Me.stsWelcome.SuspendLayout()
        Me.mnsMenu.SuspendLayout()
        CType(Me.ptbPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.Red
        Me.lblTitle.Location = New System.Drawing.Point(147, 85)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(364, 36)
        Me.lblTitle.TabIndex = 10
        Me.lblTitle.Text = "Phần mềm Quản Lý SQL"
        '
        'lblTenCh
        '
        Me.lblTenCh.AutoSize = True
        Me.lblTenCh.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTenCh.Location = New System.Drawing.Point(12, 42)
        Me.lblTenCh.Name = "lblTenCh"
        Me.lblTenCh.Size = New System.Drawing.Size(188, 19)
        Me.lblTenCh.TabIndex = 11
        Me.lblTenCh.Text = "Phần mềm quản lý SQL NHT"
        '
        'lblWelcome
        '
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(324, 17)
        Me.lblWelcome.Text = "Chào mừng bạn đã đến với phần mềm quản lý SQL PS01843"
        '
        'stsWelcome
        '
        Me.stsWelcome.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblWelcome})
        Me.stsWelcome.Location = New System.Drawing.Point(0, 484)
        Me.stsWelcome.Name = "stsWelcome"
        Me.stsWelcome.Size = New System.Drawing.Size(658, 22)
        Me.stsWelcome.TabIndex = 8
        Me.stsWelcome.Text = "StatusStrip1"
        '
        'mniThongtin
        '
        Me.mniThongtin.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mniInformation})
        Me.mniThongtin.Name = "mniThongtin"
        Me.mniThongtin.Size = New System.Drawing.Size(71, 20)
        Me.mniThongtin.Text = "Thông tin"
        '
        'mniInformation
        '
        Me.mniInformation.Name = "mniInformation"
        Me.mniInformation.Size = New System.Drawing.Size(187, 22)
        Me.mniInformation.Text = "Thông tin phần mềm"
        '
        'mniNhaphang
        '
        Me.mniNhaphang.Name = "mniNhaphang"
        Me.mniNhaphang.Size = New System.Drawing.Size(152, 22)
        Me.mniNhaphang.Text = "Sản Phẩm"
        '
        'mniAddnew
        '
        Me.mniAddnew.Name = "mniAddnew"
        Me.mniAddnew.Size = New System.Drawing.Size(152, 22)
        Me.mniAddnew.Text = "Loại Sản Phẩm"
        '
        'mniQuanly
        '
        Me.mniQuanly.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mniAddnew, Me.mniNhaphang})
        Me.mniQuanly.Name = "mniQuanly"
        Me.mniQuanly.Size = New System.Drawing.Size(115, 20)
        Me.mniQuanly.Text = "Quản lý sản phẩm"
        '
        'mniExit
        '
        Me.mniExit.Name = "mniExit"
        Me.mniExit.ShortcutKeyDisplayString = " F10"
        Me.mniExit.Size = New System.Drawing.Size(146, 22)
        Me.mniExit.Text = "Thoát"
        '
        'mniLogin
        '
        Me.mniLogin.Name = "mniLogin"
        Me.mniLogin.ShortcutKeyDisplayString = "F1"
        Me.mniLogin.Size = New System.Drawing.Size(146, 22)
        Me.mniLogin.Text = "Đăng xuất"
        '
        'mniHethong
        '
        Me.mniHethong.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mniLogin, Me.mniExit})
        Me.mniHethong.Name = "mniHethong"
        Me.mniHethong.Size = New System.Drawing.Size(69, 20)
        Me.mniHethong.Text = "Hệ thống"
        '
        'mnsMenu
        '
        Me.mnsMenu.BackColor = System.Drawing.SystemColors.Menu
        Me.mnsMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mniHethong, Me.mniQuanly, Me.mniThongtin})
        Me.mnsMenu.Location = New System.Drawing.Point(0, 0)
        Me.mnsMenu.Name = "mnsMenu"
        Me.mnsMenu.Size = New System.Drawing.Size(658, 24)
        Me.mnsMenu.TabIndex = 7
        Me.mnsMenu.Text = "Menu"
        '
        'ptbPicture
        '
        Me.ptbPicture.Image = Global.Login.My.Resources.Resources.logo
        Me.ptbPicture.Location = New System.Drawing.Point(171, 194)
        Me.ptbPicture.Name = "ptbPicture"
        Me.ptbPicture.Size = New System.Drawing.Size(316, 118)
        Me.ptbPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptbPicture.TabIndex = 12
        Me.ptbPicture.TabStop = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Cyan
        Me.ClientSize = New System.Drawing.Size(658, 506)
        Me.Controls.Add(Me.ptbPicture)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblTenCh)
        Me.Controls.Add(Me.stsWelcome)
        Me.Controls.Add(Me.mnsMenu)
        Me.Name = "frmMain"
        Me.Text = "Quản Lý"
        Me.stsWelcome.ResumeLayout(False)
        Me.stsWelcome.PerformLayout()
        Me.mnsMenu.ResumeLayout(False)
        Me.mnsMenu.PerformLayout()
        CType(Me.ptbPicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblTenCh As System.Windows.Forms.Label
    Friend WithEvents lblWelcome As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents stsWelcome As System.Windows.Forms.StatusStrip
    Friend WithEvents mniThongtin As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniInformation As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniNhaphang As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniAddnew As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniQuanly As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniLogin As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniHethong As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnsMenu As System.Windows.Forms.MenuStrip
    Friend WithEvents ptbPicture As System.Windows.Forms.PictureBox
End Class
