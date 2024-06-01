using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10Notificaciones
{
    public partial class CentroDeNotificaciones : Form
    {
        private string myEmail = "proyecto.Progra00@gmail.com";
        private readonly string myPassword = "ruoovbweuxihsifh";
        private string myAlias = "Proyecto Daniel, Derek y Andreina";
        private string[] myAdjuntos;
        private MailMessage mCorreo;
        string connectionString = "Server=bofn3obbnejxfyoheir1-mysql.services.clever-cloud.com;Database=bofn3obbnejxfyoheir1;User=uh4dunztmvwgo47z;Password=uyjiJZkG5JqLtaELmvku;Port=3306;SslMode=Preferred;";
        private string nombre;
        private string apellido;
        private string correo;
        private int cursoID;
        private bool esAdmin;
        private int usuarioID;

        public CentroDeNotificaciones(string nombre, string apellido, string correo, int cursoID, bool esAdmin, int usuarioID)
        {
            InitializeComponent();
            this.nombre = nombre;
            this.apellido = apellido;
            this.correo = correo;
            this.cursoID = cursoID;
            this.esAdmin = esAdmin;
            this.usuarioID = usuarioID;
            CargarUsuarios();
        }

        private void CargarUsuarios()
        {
            // Cargar usuarios en el ComboBox
            List<string> usuarios = new List<string>();

            using (MySqlConnection connection = new MySqlConnection("Server=bofn3obbnejxfyoheir1-mysql.services.clever-cloud.com;Database=bofn3obbnejxfyoheir1;User=uh4dunztmvwgo47z;Password=uyjiJZkG5JqLtaELmvku;Port=3306;SslMode=Preferred;"))
            {
                string query = "SELECT Email, Nombre FROM Usuarios";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string email = reader.GetString("Email");
                                string nombre = reader.GetString("Nombre");
                                usuarios.Add($"{nombre} ({email})");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al cargar los usuarios: " + ex.Message);
                    }
                    finally
                    {
                        if (connection.State == ConnectionState.Open)
                            connection.Close();
                    }
                }
            }

            cmbEmailTo.DataSource = usuarios;
        }

        private void CrearCuerpoCorreo()
        {
            mCorreo = new MailMessage();
            mCorreo.From = new MailAddress(myEmail, myAlias, System.Text.Encoding.UTF8);

            // Extraer el correo electrónico del ComboBox
            string selectedUser = cmbEmailTo.SelectedItem.ToString();
            string email = selectedUser.Substring(selectedUser.IndexOf('(') + 1).TrimEnd(')');

            mCorreo.To.Add(email);
            mCorreo.Subject = txtSubject.Text.Trim();
            mCorreo.Body = txtMessage.Text.Trim();
            mCorreo.IsBodyHtml = true;
            mCorreo.Priority = MailPriority.High;

            if (myAdjuntos != null)
            {
                for (int i = 0; i < myAdjuntos.Length; i++)
                {
                    mCorreo.Attachments.Add(new Attachment(myAdjuntos[i]));
                }
            }
        }

        private void Enviar()
        {
            try
            {
                SmtpClient smpt = new SmtpClient();
                smpt.UseDefaultCredentials = false;
                smpt.Port = 587;
                smpt.Host = "smtp.gmail.com";
                smpt.Credentials = new System.Net.NetworkCredential(myEmail, myPassword);
                ServicePointManager.ServerCertificateValidationCallback = delegate (object s,
                    X509Certificate certificate, X509Chain chain, SslPolicyErrors erros)
                { return true; };
                smpt.EnableSsl = true;
                smpt.Send(mCorreo);
                MessageBox.Show("Enviado");
                lblFiles.Text = "";

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void AdjuntarArchivos()
        {
            var names = "";
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            ofd.Title = "Adjuntar Archivos al Correo";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                myAdjuntos = ofd.FileNames;
            }

            for (int i = 0; i < myAdjuntos.Length; i++)
            {
                names += myAdjuntos[i] + "\n";
            }
            lblFiles.Text = names;
        }

        private void txtSubject_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            CrearCuerpoCorreo();
            Enviar();
        }

        private void btnFiles_Click(object sender, EventArgs e)
        {
            AdjuntarArchivos();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CentroDeNotificaciones_Load(object sender, EventArgs e)
        {
            CargarUsuarios();
        }
    }
}
