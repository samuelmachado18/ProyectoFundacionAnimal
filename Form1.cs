using System.Data.SqlClient;
using System.Security.Policy;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace Fundacion_Animales
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection();
        public void loadForm(object Form)
        {
            if (this.mainPanel.Controls.Count > 0)
                this.mainPanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Add(f);
            this.mainPanel.Tag = f;
            f.Show();
        }

        private void MdiPropiedades()
        { 
            this.SetBevel(false);
            Controls.OfType<MdiClient>().FirstOrDefault().BackColor = Color.FromArgb(232, 234, 237);
        }
        public Form1()
        {
            InitializeComponent();
            MdiPropiedades();

            con = ConexionDB.CrearInstancia().CrearConexion();
            con.Open();

        }


        bool menuExpand = false;
        private void menuTransition_Tick(object sender, EventArgs e)
        {
            if (menuExpand == false)
            {
                menuContainer.Height += 10;
                if (menuContainer.Height >= 160)
                {
                    menuTransition.Stop();
                    menuExpand = true;
                }
            }
            else
            {
                menuContainer.Height -= 10;
                if (menuContainer.Height <= 54)
                {
                    menuTransition.Stop();
                    menuExpand = false;
                }
            }



        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            menuTransition.Start();
            loadForm(new opcionesForm());
        }


        bool baraLateralExpand = true;
        private void transicionBarraLate_Tick(object sender, EventArgs e)
        {
            if (baraLateralExpand)
            {
                baraLateral.Width -= 10;
                if (baraLateral.Width <= 56)
                {
                    baraLateralExpand = false;
                    transicionBarraLate.Stop();
                    pnInicio.Width = baraLateral.Width;
                    pnAdoptar.Width = baraLateral.Width;
                    pnConocenos.Width = baraLateral.Width;
                    pnContactanos.Width = baraLateral.Width;
                    menuContainer.Width = baraLateral.Width;
                }

            }
            else
            {
                baraLateral.Width += 10;
                if (baraLateral.Width >= 200)
                {
                    baraLateralExpand = true;
                    transicionBarraLate.Stop();
                }

                pnInicio.Width = baraLateral.Width;
                pnAdoptar.Width = baraLateral.Width;
                pnConocenos.Width = baraLateral.Width;
                pnContactanos.Width = baraLateral.Width;
                menuContainer.Width = baraLateral.Width;
            }

        }

        private void ptbMenu_Click(object sender, EventArgs e)
        {

            transicionBarraLate.Start();
        }




        private void btnInicio_Click(object sender, EventArgs e)
        {
            transicionBarraLate.Start();
            loadForm(new InicioForm());

        }



        private void btnPerro_Click(object sender, EventArgs e)
        {
            loadForm(new perroForm());
            /*
            if (perros == null)
            {
                perros = new Form();
                perros.Width = 935;
                perros.Height = 494;
                perros.FormBorderStyle = FormBorderStyle.None;
                perros.FormClosed += Perros_FormClosed;
                perros.MdiParent = this;
                perros.Dock = DockStyle.Fill;
                perros.Show();
            }
            else
            {
                perros.Activate();
            }*/
        }

        private void Perros_FormClosed(object? sender, FormClosedEventArgs e)
        {
            //  perros = null;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            loadForm(new gatoForm());
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            loadForm(new ContactanosForm());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadForm(new HistoriaForm());
        }

        private void btnAgregarAnimales_Click(object sender, EventArgs e)
        {
          
            loadForm(new administracion_animalesForm()); 
            
        }
    }
}
