<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Me.txtAccount = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.lblPassowrd = New System.Windows.Forms.Label()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtAccount
        '
        Me.txtAccount.Location = New System.Drawing.Point(115, 23)
        Me.txtAccount.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtAccount.Name = "txtAccount"
        Me.txtAccount.Size = New System.Drawing.Size(158, 22)
        Me.txtAccount.TabIndex = 0
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(115, 82)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(158, 22)
        Me.txtPassword.TabIndex = 1
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Location = New System.Drawing.Point(23, 32)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(38, 15)
        Me.lblUser.TabIndex = 20
        Me.lblUser.Text = "User :"
        '
        'lblPassowrd
        '
        Me.lblPassowrd.AutoSize = True
        Me.lblPassowrd.Location = New System.Drawing.Point(23, 82)
        Me.lblPassowrd.Name = "lblPassowrd"
        Me.lblPassowrd.Size = New System.Drawing.Size(65, 15)
        Me.lblPassowrd.TabIndex = 21
        Me.lblPassowrd.Text = "Password :"
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(25, 148)
        Me.btnLogin.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(68, 28)
        Me.btnLogin.TabIndex = 3
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(115, 148)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(81, 28)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(222, 150)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(70, 28)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(333, 202)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.lblPassowrd)
        Me.Controls.Add(Me.lblUser)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtAccount)
        Me.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmLogin"
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtAccount As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents lblUser As System.Windows.Forms.Label
    Friend WithEvents lblPassowrd As System.Windows.Forms.Label
    Friend WithEvents btnLogin As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
