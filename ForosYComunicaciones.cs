using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeAprendizaje
{
    public partial class ForosYComunicaciones : Form
    {
        public ForosYComunicaciones()
        {
            InitializeComponent();
        }

        private void btnPublicar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string opinion = txtOpinion.Text;

            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(opinion))
            {
                MessageBox.Show("Por favor, ingrese su nombre y opinión.");
                return;
            }

            string mensaje = $"{nombre}: {opinion}";

            lstOpiniones.Items.Add(mensaje);

            txtNombre.Clear();
            txtOpinion.Clear();
        }
    }
}
