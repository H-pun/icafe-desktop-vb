Imports Newtonsoft.Json

Public Class Paket
    Private Sub GenerateQR(ByVal billing_type As Integer, ByVal time As String, ByVal type As String, ByVal price As String)
        Dim QR As New MessagingToolkit.QRCode.Codec.QRCodeEncoder
        Dim token = Helper.RandomString()
        Dim json = JsonConvert.SerializeObject(New With {
            billing_type,
            token
        })
        Scan.token = token
        Scan.time.Text = time
        Scan.type.Text = type
        Scan.price.Text = price

        Try
            QR.QRCodeVersion = 0
            Scan.QR_Billing.Image = New Bitmap(QR.Encode(json))
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Scan.MdiParent = Main
        Scan.Dock = DockStyle.Fill
        Scan.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        GenerateQR(1, Label7.Text, Label8.Text, Label9.Text)
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        GenerateQR(2, Label12.Text, Label11.Text, Label10.Text)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        GenerateQR(3, Label15.Text, Label14.Text, Label13.Text)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        GenerateQR(4, Label18.Text, Label17.Text, Label16.Text)
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        WelcomeUser.MdiParent = Main
        WelcomeUser.Dock = DockStyle.Fill
        WelcomeUser.Show()
        Me.Close()
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        About.MdiParent = Main
        About.Dock = DockStyle.Fill
        About.Show()
        Me.Close()
    End Sub


    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            Dim result = Helper.HttpRequestGet("billing/verify?token=" + TextBox1.Text)
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
                Me.Close()
            Else
                MessageBox.Show("Waktu biling sudah habis!", "Expired",
                                MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class