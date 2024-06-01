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
    public partial class FormInicio : Form
    {
        private bool isAdmin;
        private int usuarioID;
        private string nombre;
        private string apellido;
        private string correo;

        public FormInicio()
        {
            InitializeComponent();
        }

        public FormInicio(bool isAdmin, int usuarioID, string nombre, string apellido, string correo)
        {
            this.isAdmin = isAdmin;
            this.usuarioID = usuarioID;
            this.nombre = nombre;
            this.apellido = apellido;
            this.correo = correo;
        }
    }
}
