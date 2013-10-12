Imports System.Net.Mail

Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

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
End Class
