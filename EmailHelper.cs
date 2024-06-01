using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeAprendizaje2
{
    public static class EmailHelper
    {
        public static void EnviarCorreo(string destinatario, string asunto, string cuerpo)
        {
            var remitente = "proyecto.Progra00@gmail.com";
            var password = "ruoovbweuxihsifh";

            if (string.IsNullOrEmpty(remitente) || string.IsNullOrEmpty(password))
            {
                throw new InvalidOperationException("Las credenciales de correo electrónico no están configuradas correctamente.");
            }

            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential(remitente, password),
                EnableSsl = true,
            };

            var mailMessage = new MailMessage
            {
                From = new MailAddress(remitente),
                Subject = asunto,
                Body = cuerpo,
                IsBodyHtml = true,
            };
            mailMessage.To.Add(destinatario);

            try
            {
                smtpClient.Send(mailMessage);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al enviar el correo: " + ex.Message);
            }
        }
    }
}
