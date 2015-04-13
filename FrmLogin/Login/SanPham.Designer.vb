<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSanPham
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
        Me.btnThoat = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnSua = New System.Windows.Forms.Button()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.txtTensp = New System.Windows.Forms.TextBox()
        Me.txtMasp = New System.Windows.Forms.TextBox()
        Me.labTensp = New System.Windows.Forms.Label()
        Me.lblMaSP = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtMaloaisp = New System.Windows.Forms.TextBox()
        Me.lblMaloaisp = New System.Windows.Forms.Label()
        Me.lblDongia = New System.Windows.Forms.Label()
        Me.txtDongia = New System.Windows.Forms.TextBox()
        Me.lblSoluong = New System.Windows.Forms.Label()
        Me.txtSoluong = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnThoat
        '
        Me.btnThoat.Location = New System.Drawing.Point(324, 158)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(75, 29)
        Me.btnThoat.TabIndex = 27
        Me.btnThoat.Text = "Thoat"
        Me.btnThoat.UseVisualStyleBackColor = True
        '
        'btnXoa
        '
        Me.btnXoa.Location = New System.Drawing.Point(220, 158)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(75, 29)
        Me.btnXoa.TabIndex = 26
        Me.btnXoa.Text = "Xoa"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'btnSua
        '
        Me.btnSua.Location = New System.Drawing.Point(121, 158)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(75, 29)
        Me.btnSua.TabIndex = 25
        Me.btnSua.Text = "Sua"
        Me.btnSua.UseVisualStyleBackColor = True
        '
        'btnThem
        '
        Me.btnThem.Location = New System.Drawing.Point(24, 158)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(75, 29)
        Me.btnThem.TabIndex = 24
        Me.btnThem.Text = "Them"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'txtTensp
        '
        Me.txtTensp.Location = New System.Drawing.Point(99, 64)
        Me.txtTensp.Name = "txtTensp"
        Me.txtTensp.Size = New System.Drawing.Size(183, 20)
        Me.txtTensp.TabIndex = 23
        '
        'txtMasp
        '
        Me.txtMasp.Location = New System.Drawing.Point(99, 12)
        Me.txtMasp.Name = "txtMasp"
        Me.txtMasp.Size = New System.Drawing.Size(183, 20)
        Me.txtMasp.TabIndex = 22
        '
        'labTensp
        '
        Me.labTensp.AutoSize = True
        Me.labTensp.Location = New System.Drawing.Point(20, 67)
        Me.labTensp.Name = "labTensp"
        Me.labTensp.Size = New System.Drawing.Size(49, 13)
        Me.labTensp.TabIndex = 29
        Me.labTensp.Text = "Ten SP :"
        '
        'lblMaSP
        '
        Me.lblMaSP.AutoSize = True
        Me.lblMaSP.Location = New System.Drawing.Point(20, 19)
        Me.lblMaSP.Name = "lblMaSP"
        Me.lblMaSP.Size = New System.Drawing.Size(44, 13)
        Me.lblMaSP.TabIndex = 28
        Me.lblMaSP.Text = "Ma Sp :"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(0, 203)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(447, 150)
        Me.DataGridView1.TabIndex = 21
        '
        'txtMaloaisp
        '
        Me.txtMaloaisp.ForeColor = System.Drawing.SystemColors.InfoText
        Me.txtMaloaisp.Location = New System.Drawing.Point(99, 38)
        Me.txtMaloaisp.Name = "txtMaloaisp"
        Me.txtMaloaisp.Size = New System.Drawing.Size(183, 20)
        Me.txtMaloaisp.TabIndex = 22
        '
        'lblMaloaisp
        '
        Me.lblMaloaisp.AutoSize = True
        Me.lblMaloaisp.Location = New System.Drawing.Point(20, 45)
        Me.lblMaloaisp.Name = "lblMaloaisp"
        Me.lblMaloaisp.Size = New System.Drawing.Size(61, 13)
        Me.lblMaloaisp.TabIndex = 28
        Me.lblMaloaisp.Text = "MaLoaiSp :"
        '
        'lblDongia
        '
        Me.lblDongia.AutoSize = True
        Me.lblDongia.Location = New System.Drawing.Point(20, 93)
        Me.lblDongia.Name = "lblDongia"
        Me.lblDongia.Size = New System.Drawing.Size(50, 13)
        Me.lblDongia.TabIndex = 29
        Me.lblDongia.Text = "Don gia :"
        '
        'txtDongia
        '
        Me.txtDongia.Location = New System.Drawing.Point(99, 90)
        Me.txtDongia.Name = "txtDongia"
        Me.txtDongia.Size = New System.Drawing.Size(183, 20)
        Me.txtDongia.TabIndex = 23
        '
        'lblSoluong
        '
        Me.lblSoluong.AutoSize = True
        Me.lblSoluong.Location = New System.Drawing.Point(20, 119)
        Me.lblSoluong.Name = "lblSoluong"
        Me.lblSoluong.Size = New System.Drawing.Size(55, 13)
        Me.lblSoluong.TabIndex = 29
        Me.lblSoluong.Text = "So luong :"
        '
        'txtSoluong
        '
        Me.txtSoluong.Location = New System.Drawing.Point(99, 116)
        Me.txtSoluong.Name = "txtSoluong"
        Me.txtSoluong.Size = New System.Drawing.Size(183, 20)
        Me.txtSoluong.TabIndex = 23
        '
        'frmSanPham
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(447, 352)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnSua)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.txtSoluong)
        Me.Controls.Add(Me.txtDongia)
        Me.Controls.Add(Me.txtTensp)
        Me.Controls.Add(Me.lblSoluong)
        Me.Controls.Add(Me.txtMaloaisp)
        Me.Controls.Add(Me.lblDongia)
        Me.Controls.Add(Me.txtMasp)
        Me.Controls.Add(Me.labTensp)
        Me.Controls.Add(Me.lblMaloaisp)
        Me.Controls.Add(Me.lblMaSP)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "frmSanPham"
        Me.Text = "SanPham"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnThoat As System.Windows.Forms.Button
    Friend WithEvents btnXoa As System.Windows.Forms.Button
    Friend WithEvents btnSua As System.Windows.Forms.Button
    Friend WithEvents btnThem As System.Windows.Forms.Button
    Friend WithEvents txtTensp As System.Windows.Forms.TextBox
    Friend WithEvents txtMasp As System.Windows.Forms.TextBox
    Friend WithEvents labTensp As System.Windows.Forms.Label
    Friend WithEvents lblMaSP As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents txtMaloaisp As System.Windows.Forms.TextBox
    Friend WithEvents lblMaloaisp As System.Windows.Forms.Label
    Friend WithEvents lblDongia As System.Windows.Forms.Label
    Friend WithEvents txtDongia As System.Windows.Forms.TextBox
    Friend WithEvents lblSoluong As System.Windows.Forms.Label
    Friend WithEvents txtSoluong As System.Windows.Forms.TextBox
End Class
