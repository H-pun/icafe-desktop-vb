Public Class About

    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles Label15.Click
        WelcomeUser.MdiParent = Main
        WelcomeUser.Dock = DockStyle.Fill
        WelcomeUser.Show()
        Me.Close()
    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click
        Paket.MdiParent = Main
        Paket.Dock = DockStyle.Fill
        Paket.Show()
        Me.Close()
    End Sub
End Class