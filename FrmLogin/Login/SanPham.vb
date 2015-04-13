Imports System.Data.SqlClient
Imports System.Data.DataTable

Public Class frmSanPham

    Dim tb As New DataTable
    Dim connectstr As String = "workstation id=PS01843.mssql.somee.com;packet size=4096;user id=thangnh;pwd=P@ssw0rd;data source=PS01843.mssql.somee.com;persist security info=False;initial catalog=PS01843"

    Private Sub frmSanPham_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim KetNoi As New SqlConnection(connectstr)
        Dim sqlAdapter As New SqlDataAdapter("select * from SanPham", KetNoi)
        Try
            KetNoi.Open()

            sqlAdapter.Fill(tb)
        Catch ex As Exception
        End Try
        DataGridView1.DataSource = tb
        KetNoi.Close()

        Dim index As Integer = DataGridView1.CurrentCell.RowIndex
        txtMasp.Text = DataGridView1.Item(0, index).Value
        txtMaloaisp.Text = DataGridView1.Item(1, index).Value
        txtTensp.Text = DataGridView1.Item(2, index).Value
        txtDongia.Text = DataGridView1.Item(3, index).Value
        txtSoluong.Text = DataGridView1.Item(4, index).Value

    End Sub

    Private Sub frmSanPham_Load()

        Dim KetNoi As New SqlConnection(connectstr)
        Dim sqlAdapter As New SqlDataAdapter("select * from SanPham", KetNoi)
        Try
            KetNoi.Open()

            sqlAdapter.Fill(tb)
        Catch ex As Exception
        End Try
        DataGridView1.DataSource = tb
        KetNoi.Close()

    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click

        Dim query As String = String.Empty
        query &= "INSERT INTO SanPham ( MaSP, LoaiSP_MaLoaiSP, TenSp, DonGia, SoLuongTonKho)"
        query &= "Values(@MaSP,@LoaiSP_MaLoaiSP, @TenSp, @DonGia, @SoLuongTonKho)"
        Using conn As New SqlConnection("workstation id=PS01843.mssql.somee.com;packet size=4096;user id=thangnh;pwd=P@ssw0rd;data source=PS01843.mssql.somee.com;persist security info=False;initial catalog=PS01843")
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaSP", txtMasp.Text)
                    .Parameters.AddWithValue("@LoaiSP_MaLoaiSP", txtMaloaisp.Text)
                    .Parameters.AddWithValue("@TenSP", txtTensp.Text)
                    .Parameters.AddWithValue("@DonGia", txtDongia.Text)
                    .Parameters.AddWithValue("@SoLuongTonKho", txtSoluong.Text)

                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    MessageBox.Show(ex.Message.ToString(), "Loi! Khong the them thanh xong!")
                End Try
                tb.Clear()
                DataGridView1.DataSource = tb
                DataGridView1.DataSource = Nothing
                frmSanPham_Load()
            End Using
        End Using

    End Sub

    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click

        Dim ketnoi As New SqlConnection(connectstr)
        ketnoi.Open()
        Dim stradd As String = "update SanPham set MaSP = @MaSP, LoaiSP_MaLoaiSP = @LoaiSP_MaLoaiSP,  TenSP = @TenSP, DonGia = @DonGia, SoLuongTonKho = @SoLuongTonKho where MaSP = @MaSP "
        Dim com As New SqlCommand(stradd, ketnoi)
        Try

            com.Parameters.AddWithValue("@MaSP", txtMasp.Text)
            com.Parameters.AddWithValue("@LoaiSP_MaLoaiSP", txtMaloaisp.Text)
            com.Parameters.AddWithValue("@TenSP", txtTensp.Text)
            com.Parameters.AddWithValue("@DonGia", txtDongia.Text)
            com.Parameters.AddWithValue("@SoLuongTonKho", txtSoluong.Text)
            com.ExecuteNonQuery()
            ketnoi.Close()

        Catch ex As Exception
            MessageBox.Show("Loi! Khong the sua thanh xong!")

        End Try
        tb.Clear()
        DataGridView1.DataSource = tb
        DataGridView1.DataSource = Nothing
        frmSanPham_Load()

    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click

        Dim ketnoi As New SqlConnection(connectstr)
        ketnoi.Open()
        Dim stradd As String = "Delete from  SanPham where MaSP = @MaSP"
        Dim com As New SqlCommand(stradd, ketnoi)
        Try
            com.Parameters.AddWithValue("@MaSP", txtMasp.Text)
            com.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Loi! Khong the xoa thanh xong!")
        End Try
        tb.Clear()
        DataGridView1.DataSource = tb
        DataGridView1.DataSource = Nothing
        frmSanPham_Load()
    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click

        Me.Close()
        frmMain.Show()

    End Sub
End Class