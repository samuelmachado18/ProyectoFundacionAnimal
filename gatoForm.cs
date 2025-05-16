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
    public partial class gatoForm : Form
    {
        public gatoForm()
        {
            InitializeComponent();
        }

        private void gatoForm_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }
    }
}
