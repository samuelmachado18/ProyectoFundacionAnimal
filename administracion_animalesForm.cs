using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fundacion_Animales
{
    public partial class administracion_animalesForm : Form
    {
        SqlConnection con = new SqlConnection();

        public void loadForm(object Form)
        {
            if (this.Controls.Count > 0)
                this.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.Controls.Add(f);
            this.Tag = f;
            f.Show();
        }
        public administracion_animalesForm()
        {
            InitializeComponent();

        }



        private void administracion_animalesForm_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            con = ConexionDB.CrearInstancia().CrearConexion();
            con.Open();
            llenarTablas();
        }

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            insertAnimalForm insertAnimalform = new insertAnimalForm();
            insertAnimalform.FormClosed += (s, args) =>
            {
                // Recargas el formulario que quieras mostrar después
                administracion_animalesForm formInicio = new administracion_animalesForm();
                loadForm(formInicio);
            };
            loadForm(insertAnimalform);


        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            //this.Close();
            InicioForm inicioForm = new InicioForm();
            inicioForm.FormClosed += (s, args) =>
            {
                InicioForm inicio = new InicioForm();
                loadForm(inicio); // vuelve a cargar InicioForm dentro del contenedor
            };

            loadForm(inicioForm);

        }

        private void dgvAdministracionAnimal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void llenarTablas()
        {

            string Consulta = "select * from Animal";
            SqlDataAdapter Adaptador = new SqlDataAdapter(Consulta, con);
            DataTable dt = new DataTable();
            Adaptador.Fill(dt);
            dgvAdministracionAnimal.DataSource = dt;
            dgvAdministracionAnimal.ClearSelection();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvAdministracionAnimal.SelectedRows.Count > 0)
            {
                DataGridViewRow fila = dgvAdministracionAnimal.SelectedRows[0];

               int id = Convert.ToInt32(fila.Cells["id_animal"].Value);
                string nombre = fila.Cells["nombre"].Value.ToString();
                string especie = fila.Cells["especie"].Value.ToString();
                string raza = fila.Cells["raza"].Value.ToString();
                string sexo = fila.Cells["sexo"].Value.ToString();
                DateTime fechaNacimiento = Convert.ToDateTime(fila.Cells["fecha_nacimiento"].Value);
                DateTime fechaIngreso = Convert.ToDateTime(fila.Cells["fecha_ingreso"].Value);
                string estado = fila.Cells["estado"].Value.ToString();
                byte[] foto = fila.Cells["foto"].Value as byte[];

                Animal CapturarDatos = new Animal();
                CapturarDatos.GuardarDatos(id, nombre, especie, raza, sexo, fechaNacimiento, fechaIngreso, estado, foto);

                ActualizarAnimalesForm actualizarFORM = new ActualizarAnimalesForm(CapturarDatos);
                loadForm(actualizarFORM);
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una fila.");
            }

        }
    }
}

