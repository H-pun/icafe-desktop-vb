Public Class WelcomeAdmin
    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        WelcomeUser.MdiParent = Main
        WelcomeUser.Dock = DockStyle.Fill
        WelcomeUser.Show()
        Me.Close()
    End Sub
End Class