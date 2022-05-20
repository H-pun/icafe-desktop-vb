Public Class WelcomeUser
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Paket.MdiParent = Main
        Paket.Dock = DockStyle.Fill
        Paket.Show()
        Me.Close()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Paket.MdiParent = Main
        Paket.Dock = DockStyle.Fill
        Paket.Show()
        Me.Close()
    End Sub
End Class