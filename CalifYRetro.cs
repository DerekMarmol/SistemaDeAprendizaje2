﻿using MySql.Data.MySqlClient;
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
    public partial class CalifYRetro : Form
    {
        string connectionString = "Server=bofn3obbnejxfyoheir1-mysql.services.clever-cloud.com;Database=bofn3obbnejxfyoheir1;User=uh4dunztmvwgo47z;Password=uyjiJZkG5JqLtaELmvku;Port=3306;SslMode=Preferred;";

        private string nombre;
        private string apellido;
        private string correo;
        private int cursoID;
        private bool esAdmin;
        private int usuarioID;

        public CalifYRetro(string nombre, string apellido, string correo, int cursoID, bool esAdmin, int usuarioID)
        {
            InitializeComponent();
            this.nombre = nombre;
            this.apellido = apellido;
            this.correo = correo;
            this.cursoID = cursoID;
            this.esAdmin = esAdmin;
            this.usuarioID = usuarioID;

            ConfigurarDataGridView();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBox1.SelectedItem != null)
            {
                int idEstudiante = ((Usuario)ComboBox1.SelectedItem).UsuarioID;
                CargarCalificacionesEstudiante(idEstudiante);
            }
        }

        private void CargarCalificacionesEstudiante(int idEstudiante)
        {
            DataTable dtCalificaciones = new DataTable();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT CalificacionID, CursoID, Calificacion, Retroalimentacion FROM Calificaciones WHERE EstudianteID = @EstudianteID";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@EstudianteID", idEstudiante);
                    try
                    {
                        connection.Open();
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            adapter.Fill(dtCalificaciones);
                            dtgCalificaciones.DataSource = dtCalificaciones;

                            foreach (DataGridViewColumn column in dtgCalificaciones.Columns)
                            {
                                column.ReadOnly = !esAdmin; // Solo los administradores pueden editar
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al cargar las calificaciones del estudiante: " + ex.Message);
                    }
                    finally
                    {
                        if (connection.State == ConnectionState.Open)
                            connection.Close();
                    }
                }
            }
        }

        public class Usuario
        {
            public int UsuarioID { get; set; }
            public string NombreCompleto { get; set; }
        }

        private void CargarEstudiantes()
        {
            List<Usuario> estudiantes = new List<Usuario>();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT UsuarioID, CONCAT(Nombre, ' ', Apellido) AS NombreCompleto FROM Usuarios";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Usuario usuario = new Usuario
                                {
                                    UsuarioID = reader.GetInt32("UsuarioID"),
                                    NombreCompleto = reader.GetString("NombreCompleto")
                                };
                                estudiantes.Add(usuario);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al cargar los estudiantes: " + ex.Message);
                    }
                    finally
                    {
                        if (connection.State == ConnectionState.Open)
                            connection.Close();
                    }
                }
            }

            ComboBox1.DataSource = estudiantes;
            ComboBox1.DisplayMember = "NombreCompleto";
            ComboBox1.ValueMember = "UsuarioID";
        }


        private int ObtenerIdSeleccionado(string seleccionado)
        {
            int idSelected = int.Parse(seleccionado.Split('-')[0].Trim());
            return idSelected;
        }

        private void ConfigurarDataGridView()
        {
            dtgCalificaciones.AllowUserToAddRows = false;
            dtgCalificaciones.AllowUserToDeleteRows = false;
            dtgCalificaciones.EditMode = DataGridViewEditMode.EditOnEnter;
            dtgCalificaciones.CellValueChanged += dtgCalificaciones_CellValueChanged;
        }

        private List<int> filasEditadas = new List<int>();

        private void dtgCalificaciones_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && !dtgCalificaciones.Rows[e.RowIndex].IsNewRow)
            {
                int calificacionID = Convert.ToInt32(dtgCalificaciones.Rows[e.RowIndex].Cells["CalificacionID"].Value);
                if (!filasEditadas.Contains(calificacionID))
                {
                    filasEditadas.Add(calificacionID);
                }
            }
        }

        private void buttonG_Click_1(object sender, EventArgs e)
        {
            if (!esAdmin)
            {
                MessageBox.Show("No tienes permisos para guardar las calificaciones.");
                return;
            }

            if (ComboBox1.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione un estudiante.");
                return;
            }

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    foreach (int calificacionID in filasEditadas)
                    {
                        DataGridViewRow row = null;
                        foreach (DataGridViewRow r in dtgCalificaciones.Rows)
                        {
                            if (Convert.ToInt32(r.Cells["CalificacionID"].Value) == calificacionID)
                            {
                                row = r;
                                break;
                            }
                        }

                        if (row != null)
                        {
                            string calificacion = row.Cells["Calificacion"].Value.ToString();
                            string retroalimentacion = row.Cells["Retroalimentacion"].Value.ToString();

                            string updateQuery = "UPDATE Calificaciones SET Calificacion = @Calificacion, Retroalimentacion = @Retroalimentacion WHERE CalificacionID = @CalificacionID";
                            using (MySqlCommand updateCommand = new MySqlCommand(updateQuery, connection))
                            {
                                updateCommand.Parameters.AddWithValue("@Calificacion", calificacion);
                                updateCommand.Parameters.AddWithValue("@Retroalimentacion", retroalimentacion);
                                updateCommand.Parameters.AddWithValue("@CalificacionID", calificacionID);

                                int updateResult = updateCommand.ExecuteNonQuery();
                                if (updateResult <= 0)
                                {
                                    MessageBox.Show($"Error al actualizar la calificación y retroalimentación para CalificacionID: {calificacionID}.");
                                }
                            }
                        }
                    }
                    MessageBox.Show("Las calificaciones y retroalimentaciones se han actualizado correctamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar las calificaciones y retroalimentaciones: " + ex.Message);
                }
                finally
                {
                    if (connection.State == ConnectionState.Open)
                        connection.Close();
                }
            }

            filasEditadas.Clear();
        }

        private void buttonAd_Click(object sender, EventArgs e)
        {
            if (ComboBox1.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione un estudiante antes de agregar una calificación.");
                return;
            }

            int idEstudiante = ((Usuario)ComboBox1.SelectedItem).UsuarioID;

            FormAgregarCalificación nuevoForm = new FormAgregarCalificación(idEstudiante);
            DialogResult result = nuevoForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                // La calificación se agregó correctamente, recargamos las calificaciones del estudiante
                CargarCalificacionesEstudiante(idEstudiante);
            }
        }

        private void CalifYRetro_Load(object sender, EventArgs e)
        {
            CargarEstudiantes();

            if (ComboBox1.SelectedItem != null)
            {
                int idEstudiante = ObtenerIdSeleccionado(ComboBox1.SelectedItem.ToString());
                CargarCalificacionesEstudiante(idEstudiante);
            }
        }
    }
}

