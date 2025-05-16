using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlTypes;
using System.Runtime.Intrinsics.X86;
using System.Data.SqlClient;

namespace Fundacion_Animales
{
    public partial class insertAnimalForm : Form
    {
        SqlConnection con = new SqlConnection();
        public insertAnimalForm()
        {
            InitializeComponent();
            cboEspecie.Items.Add("Perro");
            cboEspecie.Items.Add("Gato");

            cboEstado.Items.Add("Disponible");
            cboEstado.Items.Add("Adoptado");
            cboEstado.Items.Add("Fallecido");

            cboSexo.Items.Add("M");
            cboSexo.Items.Add("H");
        }
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
        private void btnRegresar_Click_1(object sender, EventArgs e)
        {
           
            loadForm(new administracion_animalesForm());

        }
        private void btnFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog foto = new OpenFileDialog();
            DialogResult rs = foto.ShowDialog();
            if (rs == DialogResult.OK)
            {
                ptbImagen.Image = Image.FromFile(foto.FileName);
            }
        }
        private void btnRegistrar_Click_1(object sender, EventArgs e)
        {
            Animal animal = new Animal();

            System.IO.MemoryStream MS = new System.IO.MemoryStream();
            ptbImagen.Image.Save(MS, System.Drawing.Imaging.ImageFormat.Jpeg);

            string nombre = txtNombre.Text;
            string especie = Convert.ToString(cboEspecie.SelectedItem);
            string raza = txtRaza.Text;
            string sexo = Convert.ToString(cboSexo.SelectedItem);
            DateTime fechaNacimiento = dtpFechaNacimiento.Value;
            DateTime fechaIngreso = dtpFechaIngreso.Value;
            string estado = Convert.ToString(cboEstado.SelectedItem);
            byte[] foto = MS.GetBuffer();


            //verificaciones

            if (Regex.IsMatch(txtNombre.Text, @"\d"))
            {
                MessageBox.Show("El nombre no puede contener números");
                return;
            }
            else if (Regex.IsMatch(txtRaza.Text, @"\d"))
            {
                MessageBox.Show("El nombre no puede contener números");
                return;
            }
            else if (!dtpFechaIngreso.Checked)
            {
                MessageBox.Show("Debe seleccionar una fecha de ingreso.");
                return;
            }
            // Verifica que la fecha no esté en el futuro
            else if (fechaIngreso >= DateTime.Today)
            {
                MessageBox.Show("La fecha de ingreso no puede ser en el futuro.");
                return;
            }
            // Verifica que la fecha no sea demasiado antigua (por ejemplo, antes del año 2000)
            else if (fechaIngreso < new DateTime(2000, 1, 1))
            {
                MessageBox.Show("La fecha de ingreso es demasiado antigua para ser válida.");
                return;
            }
            else if (cboEspecie.SelectedItem == null || cboSexo.SelectedItem == null || cboEstado.SelectedItem == null
                  || string.IsNullOrEmpty(cboEspecie.SelectedItem.ToString())
                  || string.IsNullOrEmpty(cboSexo.SelectedItem.ToString())
                  || string.IsNullOrEmpty(cboEstado.SelectedItem.ToString())
                  || string.IsNullOrEmpty(txtNombre.Text)
                  || string.IsNullOrEmpty(txtRaza.Text))
            {
                MessageBox.Show("Verifique que todos los datos esten bien copiados");

            }
            else
            {
                animal.GuardarDatos(nombre, especie, raza, sexo, fechaNacimiento, fechaIngreso, estado, foto);
                SqlCommand proc = new SqlCommand("sp_InsertarAnimal", con);
                proc.CommandType = CommandType.StoredProcedure;
                proc.Parameters.AddWithValue("@nombre", animal.nombre);
                proc.Parameters.AddWithValue("@especie", animal.especie);
                proc.Parameters.AddWithValue("@raza", animal.raza);
                proc.Parameters.AddWithValue("@sexo",animal.sexo);
                proc.Parameters.AddWithValue("@fecha_nacimiento", animal.fecha_nacimiento);
                proc.Parameters.AddWithValue("@fecha_ingreso", animal.fecha_ingreso);
                proc.Parameters.AddWithValue("@estado",animal.estado);
                proc.Parameters.AddWithValue("@foto", animal.foto); //(SqlDbType.Image).value = animal.foto
                try
                {
                    proc.ExecuteNonQuery();   
                    MessageBox.Show("Se modificaron los datos correctamente");

                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error al modificaron los datos: " + ex.Message);
                    MessageBox.Show("Revisa bien los datos ingresados");
                }
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void insertAnimalForm_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            con = ConexionDB.CrearInstancia().CrearConexion();
            con.Open();
        }
    }
}