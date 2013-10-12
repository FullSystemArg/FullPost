Imports System.Net.Mail

Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CargarDatos()
    End Sub

    Sub CargarDatos()
        DD_Servidor.SelectedIndex = 0
        DD_Email.SelectedIndex = 0
    End Sub

    Private Sub MenuStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Public Shared Function Enviar(ByVal NombreDestinatario As String, ByVal MailDestinatario As String, ByVal Asunto As String, ByVal Cuerpo As String, ByVal Email As String, ByVal Contraseña As String, ByVal Servidor As String, ByVal Mascara As String, ByVal Respuesta As String, ByVal Puerto As Integer) As String

        Dim resultado As String = MailDestinatario & " - Ok"
        If Puerto = 0 Then Puerto = 587

        Try
            Dim Mail As New System.Net.Mail.MailMessage()
            Mail.IsBodyHtml = True
            Mail.From = New MailAddress(Respuesta, Mascara)
            Mail.To.Add(New MailAddress(MailDestinatario, NombreDestinatario))
            Mail.Subject = Asunto
            Mail.Body = Cuerpo

            Mail.IsBodyHtml = True
            Dim miSMTPClient As New SmtpClient(Servidor, Puerto)
            miSMTPClient.Credentials = New System.Net.NetworkCredential(Email, Contraseña)
            miSMTPClient.Send(Mail)

            Mail.Dispose()
            Mail = Nothing

        Catch ex As Exception
            resultado = MailDestinatario & ex.Message
        End Try

        Return resultado

    End Function

    Private Sub DD_Servidor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DD_Servidor.SelectedIndexChanged
        Select Case DD_Servidor.SelectedIndex
            Case Is = 0
                TB_Servidor.Text = "smtp.live.com"
                TB_Puerto.Text = "25"
            Case Is = 1
                TB_Servidor.Text = "smtp.gmail.com"
                TB_Puerto.Text = "587"
            Case Is = 2
                TB_Servidor.Text = "out.izymail.com"
                TB_Puerto.Text = "25"
        End Select
    End Sub

    Private Sub DD_Email_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DD_Email.SelectedIndexChanged
        TB_Email.Text = DD_Email.Text
        TB_Contraseña.Text = DD_Email.SelectedValue
    End Sub
End Class
