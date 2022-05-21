Imports Newtonsoft.Json

Public Class TopUp
    Private Sub TopUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        nominal.SelectedIndex = 0
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        WelcomeAdmin.MdiParent = Main
        WelcomeAdmin.Dock = DockStyle.Fill
        WelcomeAdmin.Show()
        Me.Close()
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        WelcomeUser.MdiParent = Main
        WelcomeUser.Dock = DockStyle.Fill
        WelcomeUser.Show()
        Me.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim QR As New MessagingToolkit.QRCode.Codec.QRCodeEncoder
        Dim code = Helper.RandomString()
        Dim amount = 0
        Select Case nominal.SelectedIndex
            Case 0
                amount = 5000
            Case 1
                amount = 10000
            Case 2
                amount = 25000
            Case 3
                amount = 50000
            Case 4
                amount = 100000
        End Select

        Dim data As New With {
            code,
            amount
        }

        Try
            If Not Helper.HttpRequestPost("redeem/generate", data).status = 200 Then
                MessageBox.Show("Generate gagal, Silakan periksa koneksi atau tunggu beberapa saat lagi!", "Server Error",
                  MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            Dim json = JsonConvert.SerializeObject(data)
            Label2.Text = "Code: " + code
            QR.QRCodeVersion = 0
            QR_Billing.Image = New Bitmap(QR.Encode(json))
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class