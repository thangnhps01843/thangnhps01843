<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmXem
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.lblMa = New System.Windows.Forms.Label()
        Me.labTen = New System.Windows.Forms.Label()
        Me.txtMa = New System.Windows.Forms.TextBox()
        Me.txtTen = New System.Windows.Forms.TextBox()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.btnSua = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnThoat = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 166)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(447, 150)
        Me.DataGridView1.TabIndex = 0
        '
        'lblMa
        '
        Me.lblMa.AutoSize = True
        Me.lblMa.Location = New System.Drawing.Point(44, 19)
        Me.lblMa.Name = "lblMa"
        Me.lblMa.Size = New System.Drawing.Size(61, 13)
        Me.lblMa.TabIndex = 10
        Me.lblMa.Text = "MaLoaiSp :"
        '
        'labTen
        '
        Me.labTen.AutoSize = True
        Me.labTen.Location = New System.Drawing.Point(44, 50)
        Me.labTen.Name = "labTen"
        Me.labTen.Size = New System.Drawing.Size(66, 13)
        Me.labTen.TabIndex = 20
        Me.labTen.Text = "TenLoaiSP :"
        '
        'txtMa
        '
        Me.txtMa.Location = New System.Drawing.Point(123, 12)
        Me.txtMa.Name = "txtMa"
        Me.txtMa.Size = New System.Drawing.Size(183, 20)
        Me.txtMa.TabIndex = 3
        '
        'txtTen
        '
        Me.txtTen.Location = New System.Drawing.Point(123, 47)
        Me.txtTen.Name = "txtTen"
        Me.txtTen.Size = New System.Drawing.Size(183, 20)
        Me.txtTen.TabIndex = 4
        '
        'btnThem
        '
        Me.btnThem.Location = New System.Drawing.Point(35, 95)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(75, 29)
        Me.btnThem.TabIndex = 5
        Me.btnThem.Text = "Them"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'btnSua
        '
        Me.btnSua.Location = New System.Drawing.Point(132, 95)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(75, 29)
        Me.btnSua.TabIndex = 6
        Me.btnSua.Text = "Sua"
        Me.btnSua.UseVisualStyleBackColor = True
        '
        'btnXoa
        '
        Me.btnXoa.Location = New System.Drawing.Point(231, 95)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(75, 29)
        Me.btnXoa.TabIndex = 7
        Me.btnXoa.Text = "Xoa"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'btnThoat
        '
        Me.btnThoat.Location = New System.Drawing.Point(335, 95)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(75, 29)
        Me.btnThoat.TabIndex = 8
        Me.btnThoat.Text = "Thoat"
        Me.btnThoat.UseVisualStyleBackColor = True
        '
        'frmXem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(471, 328)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnSua)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.txtTen)
        Me.Controls.Add(Me.txtMa)
        Me.Controls.Add(Me.labTen)
        Me.Controls.Add(Me.lblMa)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "frmXem"
        Me.Text = "Loai San Pham"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents lblMa As System.Windows.Forms.Label
    Friend WithEvents labTen As System.Windows.Forms.Label
    Friend WithEvents txtMa As System.Windows.Forms.TextBox
    Friend WithEvents txtTen As System.Windows.Forms.TextBox
    Friend WithEvents btnThem As System.Windows.Forms.Button
    Friend WithEvents btnSua As System.Windows.Forms.Button
    Friend WithEvents btnXoa As System.Windows.Forms.Button
    Friend WithEvents btnThoat As System.Windows.Forms.Button
End Class
