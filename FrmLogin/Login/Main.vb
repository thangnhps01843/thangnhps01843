Public Class frmMain

    Private Sub mniExit_Click(sender As Object, e As EventArgs) Handles mniExit.Click

        Dim dialog As DialogResult = MessageBox.Show("Bạn muốn kết thúc ứng dụng ?",
                                    "Thông báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Question)


        If (dialog = DialogResult.Yes) Then
            Me.Close()
            Application.Exit()
        End If

    End Sub

    Private Sub mniLogin_Click(sender As Object, e As EventArgs) Handles mniLogin.Click

        Me.Hide()
        Dim cuaso As New frmLogin
        cuaso.Show()

    End Sub

    Private Sub mniAddnew_Click(sender As Object, e As EventArgs) Handles mniAddnew.Click

        Dim frmThemmoi As New frmXem()
        frmThemmoi.Show()
        Me.Hide()

    End Sub

    Private Sub mniInformation_Click(sender As Object, e As EventArgs) Handles mniInformation.Click

        Dim frmInformation As New frmInformation()
        frmInformation.ShowDialog()

    End Sub

    Private Sub mniNhaphang_Click(sender As Object, e As EventArgs) Handles mniNhaphang.Click

        Dim frmXemsp As New frmSanPham
        frmXemsp.Show()
        Me.Hide()

    End Sub
End Class