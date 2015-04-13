Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class frmXem

    Dim tb As New DataTable
    Dim connectstr As String = "workstation id=PS01843.mssql.somee.com;packet size=4096;user id=thangnh;pwd=P@ssw0rd;data source=PS01843.mssql.somee.com;persist security info=False;initial catalog=PS01843"

    Private Sub frmXem_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim KetNoi As New SqlConnection(connectstr)
        Dim sqlAdapter As New SqlDataAdapter("select * from LoaiSP", KetNoi)
        Try
            KetNoi.Open()

            sqlAdapter.Fill(tb)
        Catch ex As Exception
        End Try
        DataGridView1.DataSource = tb
        KetNoi.Close()

        Dim index As Integer = DataGridView1.CurrentCell.RowIndex
        txtMa.Text = DataGridView1.Item(0, index).Value
        txtTen.Text = DataGridView1.Item(1, index).Value

    End Sub

    Private Sub frmXem_Load()

        Dim KetNoi As New SqlConnection(connectstr)
        Dim sqlAdapter As New SqlDataAdapter("select * from LoaiSP", KetNoi)
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
        query &= "INSERT INTO LoaiSP ( MaLoaiSP, TenLoaiSP)"
        query &= "Values(@MaLoaiSP,@TenLoaiSP)"
        Using conn As New SqlConnection("workstation id=PS01843.mssql.somee.com;packet size=4096;user id=thangnh;pwd=P@ssw0rd;data source=PS01843.mssql.somee.com;persist security info=False;initial catalog=PS01843")
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaLoaiSP", txtMa.Text)
                    .Parameters.AddWithValue("@TenLoaiSP", txtTen.Text)
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
                frmXem_Load()
            End Using
        End Using

    End Sub

    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click

        Dim ketnoi As New SqlConnection(connectstr)
        ketnoi.Open()
        Dim stradd As String = "update LoaiSP set MaLoaiSP = @MaLoaiSP,TenLoaiSP = @TenLoaiSP where MaLoaiSP = @MaLoaiSP "
        Dim com As New SqlCommand(stradd, ketnoi)
        Try

            com.Parameters.AddWithValue("@MaLoaiSP", txtMa.Text)
            com.Parameters.AddWithValue("@TenLoaiSP", txtTen.Text)
            com.ExecuteNonQuery()
            ketnoi.Close()

        Catch ex As Exception
            MessageBox.Show("Loi! Khong the sua thanh xong!")

        End Try
        tb.Clear()
        DataGridView1.DataSource = tb
        DataGridView1.DataSource = Nothing
        frmXem_Load()

    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click

        Dim ketnoi As New SqlConnection(connectstr)
        ketnoi.Open()
        Dim stradd As String = "Delete from  LoaiSp where MaLoaiSP = @MaLoaiSP"
        Dim com As New SqlCommand(stradd, ketnoi)
        Try
            com.Parameters.AddWithValue("@MaLoaiSP", txtMa.Text)
            com.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Loi! Khong the xoa thanh xong!")
        End Try
        tb.Clear()
        DataGridView1.DataSource = tb
        DataGridView1.DataSource = Nothing
        frmXem_Load()

    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click

        Me.Close()
        frmMain.Show()

    End Sub
End Class