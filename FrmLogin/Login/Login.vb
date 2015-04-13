Imports System.Data.SqlClient
Public Class frmLogin

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        Dim chuoiketnoi As String = "workstation id=PS01843.mssql.somee.com;packet size=4096;user id=thangnh;pwd=P@ssw0rd;data source=PS01843.mssql.somee.com;persist security info=False;initial catalog=PS01843"
        Dim KetNoi As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim sqlAdapter As New SqlDataAdapter("select * from Login where TenDangNhap ='" & txtAccount.Text & "'and Password='" & txtPassword.Text & "' ", KetNoi)
        Dim tb As New DataTable
        Try
            KetNoi.Open()
            sqlAdapter.Fill(tb)
            If tb.Rows.Count > 0 Then
                MessageBox.Show("Kết Nối Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.None) 'Hiện bảng đăng nhập thành công'
                frmMain.Show()
                Me.Hide()
                txtAccount.Clear()
                txtPassword.Clear()
            ElseIf txtAccount.Text = "" Or txtPassword.Text = "" Then
                MessageBox.Show("Chưa nhập đầy đủ thông tin", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Sai Tài Khoản Hoặc Mật Khẩu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            End If
        Catch ex As Exception
        End Try

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        txtAccount.Clear()
        txtPassword.Clear()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Me.Close()

    End Sub
End Class
