Public Class Login
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        WelcomeUser.MdiParent = Main
        WelcomeUser.Dock = DockStyle.Fill
        WelcomeUser.Show()
        Me.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If TextBox1.Text = "admin" And TextBox2.Text = "admin" Then
            WelcomeAdmin.MdiParent = Main
            WelcomeAdmin.Dock = DockStyle.Fill
            WelcomeAdmin.Show()
            Me.Close()
        Else
            MsgBox("Username/Password salah!")
        End If
    End Sub
End Class