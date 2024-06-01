using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeAprendizaje2
{
    public partial class FormVerMateriales : Form
    {
        private string connectionString = "Server=bofn3obbnejxfyoheir1-mysql.services.clever-cloud.com;Database=bofn3obbnejxfyoheir1;User=uh4dunztmvwgo47z;Password=uyjiJZkG5JqLtaELmvku;Port=3306;SslMode=Preferred;";

        private string nombre;
        private string apellido;
        private string correo;
        private int cursoID;
        private bool esAdmin;
        private int usuarioID;
        private object cursoID1;

        public FormVerMateriales(string nombre, string apellido, string correo, int cursoID, bool esAdmin, int usuarioID)
        {
            InitializeComponent();
            CargarMateriales();
            this.nombre = nombre;
            this.apellido = apellido;
            this.correo = correo;
            this.cursoID = cursoID;
            this.esAdmin = esAdmin;
            this.usuarioID = usuarioID;
        }

        public FormVerMateriales(int cursoID)
        {
            this.cursoID = cursoID;
        }

        public FormVerMateriales(string nombre, string apellido, string correo, object cursoID1, bool esAdmin, int usuarioID)
        {
            InitializeComponent();
            CargarMateriales();
            this.nombre = nombre;
            this.apellido = apellido;
            this.correo = correo;
            this.cursoID1 = cursoID1;
            this.esAdmin = esAdmin;
            this.usuarioID = usuarioID;
        }

        private void CargarMateriales()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT MaterialID, Nombre, Descripcion, TipoArchivo, RutaArchivo FROM Materiales WHERE CursoID = @CursoID";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@CursoID", cursoID);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }
        }

        private void btnDescargar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string rutaArchivo = dataGridView1.SelectedRows[0].Cells["RutaArchivo"].Value.ToString();
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.FileName = System.IO.Path.GetFileName(rutaArchivo);
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        System.IO.File.Copy(rutaArchivo, saveFileDialog.FileName);
                        MessageBox.Show("Archivo descargado con éxito.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un material para descargar.");
            }
        }

        private void btnCatalogoCurso_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                FormCatalogoCursos formCatalogo = new FormCatalogoCursos(esAdmin, usuarioID);
                formCatalogo.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void FormVerMateriales_Load(object sender, EventArgs e)
        {

        }
    }
}
