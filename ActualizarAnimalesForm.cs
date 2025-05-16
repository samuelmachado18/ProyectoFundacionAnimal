using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fundacion_Animales
{
    public partial class ActualizarAnimalesForm : Form
    {
        SqlConnection con = new SqlConnection();
        Animal CapturarDatos;
        public ActualizarAnimalesForm()
        {

            InitializeComponent();
        }

        public ActualizarAnimalesForm(Animal capturarDatos)
        {
            CapturarDatos = new Animal();


            CapturarDatos.id_animal = capturarDatos.id_animal;
            CapturarDatos.nombre = capturarDatos.nombre;
            CapturarDatos.especie = capturarDatos.especie;
            CapturarDatos.raza = capturarDatos.raza;
            CapturarDatos.sexo = capturarDatos.sexo;
            CapturarDatos.fecha_nacimiento = capturarDatos.fecha_nacimiento;
            CapturarDatos.fecha_ingreso = capturarDatos.fecha_ingreso;
            CapturarDatos.estado = capturarDatos.estado;
            CapturarDatos.foto = capturarDatos.foto;
            InitializeComponent();
            cboEspecie.Items.Add("Perro");
            cboEspecie.Items.Add("Gato");

            cboEstado.Items.Add("Disponible");
            cboEstado.Items.Add("Adoptado");
            cboEstado.Items.Add("Fallecido");

            cboSexo.Items.Add("M");
            cboSexo.Items.Add("H");

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

        private void btnActualizar_Click(object sender, EventArgs e)
        {
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

            CapturarDatos.GuardarDatos(nombre, especie, raza, sexo, fechaNacimiento, fechaIngreso, estado, foto);
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

                SqlCommand proc = new SqlCommand("sp_ActualizarAnimal", con);
                proc.CommandType = CommandType.StoredProcedure;
                proc.Parameters.AddWithValue("@id_animal", CapturarDatos.id_animal);
                proc.Parameters.AddWithValue("@nombre", CapturarDatos.nombre);
                proc.Parameters.AddWithValue("@especie", CapturarDatos.especie);
                proc.Parameters.AddWithValue("@raza", CapturarDatos.raza);
                proc.Parameters.AddWithValue("@sexo", CapturarDatos.sexo);
                proc.Parameters.AddWithValue("@fecha_nacimiento", CapturarDatos.fecha_nacimiento);
                proc.Parameters.AddWithValue("@fecha_ingreso", CapturarDatos.fecha_ingreso);
                proc.Parameters.AddWithValue("@estado", CapturarDatos.estado);
                proc.Parameters.AddWithValue("@foto", CapturarDatos.foto); //(SqlDbType.Image).value = animal.foto
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

        private void ActualizarAnimalesForm_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            con = ConexionDB.CrearInstancia().CrearConexion();
            con.Open();
            try {
                int id = CapturarDatos.id_animal;
                txtNombre.Text = CapturarDatos.nombre;
                cboEspecie.Text = CapturarDatos.especie;
                txtRaza.Text = CapturarDatos.raza;
                cboSexo.Text = CapturarDatos.sexo;
                dtpFechaNacimiento.Value = CapturarDatos.fecha_nacimiento;
                dtpFechaIngreso.Value = CapturarDatos.fecha_ingreso;
                cboEstado.Text = CapturarDatos.estado;
                System.IO.MemoryStream MS = new System.IO.MemoryStream(CapturarDatos.foto);
                ptbImagen.Image = Image.FromStream(MS);
            }
            catch (Exception ex)
            {   
                this.Close(); 
                MessageBox.Show("seleccione una fila" + ex.Message);
            }
            
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            loadForm(new administracion_animalesForm());
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
    }
}
