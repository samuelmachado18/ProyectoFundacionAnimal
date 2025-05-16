using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fundacion_Animales
{
    public partial class opcionesForm : Form
    {
        public opcionesForm()
        {
            InitializeComponent();
        }




        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void opcionesForm_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }
    }
}
