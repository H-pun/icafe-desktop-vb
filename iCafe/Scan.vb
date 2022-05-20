Public Class Scan
    Public Shared token As String
    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Paket.MdiParent = Main
        Paket.Dock = DockStyle.Fill
        Paket.Show()
        Me.Close()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        WelcomeUser.MdiParent = Main
        WelcomeUser.Dock = DockStyle.Fill
        WelcomeUser.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim result = Helper.HttpRequestGet("billing/verify?token=" + token)
            If Not result.status = 200 Then
                MessageBox.Show("Pembayaran tidak ditemukan!", "Invalid token",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            Dim data = result.data
            Dim expired As DateTime = DateTime.Parse(data("timeEnd"))
            Dim now As DateTime = DateTime.Now
            If DateTime.Compare(now, expired) < 0 Then
                Billing.tspn = expired.Subtract(now)
                Billing.PictureBox1.Load(data("pictureUrl"))
                Billing.label2.Text = data("displayName")
                Billing.Timer1.Start()
                Billing.Show()
                Main.Hide()
            Else
                MessageBox.Show("Waktu biling sudah habis!", "Expired",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class