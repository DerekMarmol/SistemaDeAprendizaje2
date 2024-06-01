using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SistemaDeAprendizaje2.CalifYRetro;
using System.Windows.Forms.DataVisualization.Charting;
using MySql.Data.MySqlClient;

namespace SistemaDeAprendizaje2
{
    public partial class FormReportes : Form
    {
        private string connectionString = "Server=bofn3obbnejxfyoheir1-mysql.services.clever-cloud.com;Database=bofn3obbnejxfyoheir1;Uid=uh4dunztmvwgo47z;Pwd=uyjiJZkG5JqLtaELmvku;";
        private string nombre;
        private string apellido;
        private string correo;
        private int cursoID;
        private bool esAdmin;
        private int usuarioID;
        public FormReportes(string nombre, string apellido, string correo, int cursoID, bool esAdmin, int usuarioID)
        {
            InitializeComponent();
            this.nombre = nombre;
            this.apellido = apellido;
            this.correo = correo;
            this.cursoID = cursoID;
            this.esAdmin = esAdmin;
            this.usuarioID = usuarioID;
        }

        private void FormReportes_Load(object sender, EventArgs e)
        {

        }

        private void btnGenerarReporte_Click_1(object sender, EventArgs e)
        {
            // Obtener los datos de la tabla de calificaciones
            DataTable dtCalificaciones = new DataTable();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT CursoID, AVG(Calificacion) AS Promedio FROM Calificaciones GROUP BY CursoID";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                        adapter.Fill(dtCalificaciones);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al cargar los datos de calificaciones: " + ex.Message);
                    }
                    finally
                    {
                        if (connection.State == ConnectionState.Open)
                            connection.Close();
                    }
                }
            }

            // Configurar el Chart
            chartReporte.Series.Clear();
            chartReporte.Series.Add("Promedio de Calificaciones");
            chartReporte.Series["Promedio de Calificaciones"].ChartType = SeriesChartType.Column;

            // Agregar datos al Chart
            foreach (DataRow row in dtCalificaciones.Rows)
            {
                string cursoID = row["CursoID"].ToString(); // Suponiendo que el ID del curso es una cadena
                double promedio = Convert.ToDouble(row["Promedio"]);
                chartReporte.Series["Promedio de Calificaciones"].Points.AddXY(cursoID, promedio);
            }
        }
    }
}
