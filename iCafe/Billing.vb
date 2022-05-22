Public Class Billing
    Public Shared tspn As TimeSpan
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        tspn = tspn.Subtract(New TimeSpan(0, 0, 1))
        Label1.Text = tspn.Hours.ToString("D2") + ":" + tspn.Minutes.ToString("D2") + ":" + tspn.Seconds.ToString("D2")
        If tspn.Hours = 0 AndAlso tspn.Minutes = 0 AndAlso tspn.Seconds = 0 Then
            Timer1.Stop()
        End If
    End Sub

    Private Sub Billing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Main.Hide()
    End Sub

    Private Sub Billing_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        WelcomeUser.MdiParent = Main
        WelcomeUser.Dock = DockStyle.Fill
        WelcomeUser.Show()
        Main.Show()
        Paket.Close()
        Scan.Close()
        About.Close()
    End Sub
End Class