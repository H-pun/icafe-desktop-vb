﻿Public Class Main
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WelcomeUser.MdiParent = Me
        WelcomeUser.Dock = DockStyle.Fill
        WelcomeUser.Show()
    End Sub

    Private Sub Main_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then
            WelcomeAdmin.MdiParent = Me
            WelcomeAdmin.Dock = DockStyle.Fill
            WelcomeAdmin.Show()
            WelcomeUser.Close()
            Paket.Close()
            Scan.Close()
        End If
    End Sub
End Class