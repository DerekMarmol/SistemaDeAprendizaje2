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
    public partial class FormAgregarCalificación : Form
    {
        private int idEstudiante;

        public FormAgregarCalificación()
        {
            InitializeComponent();
        }

        public FormAgregarCalificación(int idEstudiante)
        {
            this.idEstudiante = idEstudiante;
        }

        private void FormAgregarCalificación_Load(object sender, EventArgs e)
        {

        }
    }
}
