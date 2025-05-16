namespace Fundacion_Animales
{
    partial class insertAnimalForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(insertAnimalForm));
            panel1 = new Panel();
            btnFoto = new Button();
            dtpFechaNacimiento = new DateTimePicker();
            dtpFechaIngreso = new DateTimePicker();
            btnRegresar = new Button();
            btnRegistrar = new Button();
            ptbImagen = new PictureBox();
            cboEspecie = new ComboBox();
            cboEstado = new ComboBox();
            cboSexo = new ComboBox();
            txtRaza = new TextBox();
            textBox3 = new TextBox();
            txtNombre = new TextBox();
            textBox1 = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbImagen).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(btnFoto);
            panel1.Controls.Add(dtpFechaNacimiento);
            panel1.Controls.Add(dtpFechaIngreso);
            panel1.Controls.Add(btnRegresar);
            panel1.Controls.Add(btnRegistrar);
            panel1.Controls.Add(ptbImagen);
            panel1.Controls.Add(cboEspecie);
            panel1.Controls.Add(cboEstado);
            panel1.Controls.Add(cboSexo);
            panel1.Controls.Add(txtRaza);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(txtNombre);
            panel1.Controls.Add(textBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // btnFoto
            // 
            btnFoto.Location = new Point(628, 276);
            btnFoto.Name = "btnFoto";
            btnFoto.Size = new Size(122, 28);
            btnFoto.TabIndex = 26;
            btnFoto.Text = "Foto:";
            btnFoto.UseVisualStyleBackColor = true;
            btnFoto.Click += btnFoto_Click;
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Location = new Point(246, 304);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(180, 23);
            dtpFechaNacimiento.TabIndex = 25;
            // 
            // dtpFechaIngreso
            // 
            dtpFechaIngreso.Location = new Point(246, 345);
            dtpFechaIngreso.Name = "dtpFechaIngreso";
            dtpFechaIngreso.Size = new Size(180, 23);
            dtpFechaIngreso.TabIndex = 24;
            // 
            // btnRegresar
            // 
            btnRegresar.BackgroundImage = (Image)resources.GetObject("btnRegresar.BackgroundImage");
            btnRegresar.BackgroundImageLayout = ImageLayout.Stretch;
            btnRegresar.FlatAppearance.BorderSize = 0;
            btnRegresar.FlatStyle = FlatStyle.Flat;
            btnRegresar.Location = new Point(3, 5);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(70, 60);
            btnRegresar.TabIndex = 23;
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click_1;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackgroundImage = (Image)resources.GetObject("btnRegistrar.BackgroundImage");
            btnRegistrar.BackgroundImageLayout = ImageLayout.Stretch;
            btnRegistrar.FlatAppearance.BorderSize = 0;
            btnRegistrar.FlatStyle = FlatStyle.Flat;
            btnRegistrar.Location = new Point(608, 361);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(151, 44);
            btnRegistrar.TabIndex = 22;
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click_1;
            // 
            // ptbImagen
            // 
            ptbImagen.Location = new Point(620, 132);
            ptbImagen.Name = "ptbImagen";
            ptbImagen.Size = new Size(130, 118);
            ptbImagen.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbImagen.TabIndex = 21;
            ptbImagen.TabStop = false;
            // 
            // cboEspecie
            // 
            cboEspecie.BackColor = Color.FromArgb(223, 181, 116);
            cboEspecie.FlatStyle = FlatStyle.Flat;
            cboEspecie.FormattingEnabled = true;
            cboEspecie.Location = new Point(246, 172);
            cboEspecie.Name = "cboEspecie";
            cboEspecie.Size = new Size(180, 23);
            cboEspecie.TabIndex = 20;
            // 
            // cboEstado
            // 
            cboEstado.BackColor = Color.FromArgb(223, 181, 116);
            cboEstado.FlatStyle = FlatStyle.Flat;
            cboEstado.FormattingEnabled = true;
            cboEstado.Location = new Point(246, 386);
            cboEstado.Name = "cboEstado";
            cboEstado.Size = new Size(180, 23);
            cboEstado.TabIndex = 19;
            // 
            // cboSexo
            // 
            cboSexo.BackColor = Color.FromArgb(223, 181, 116);
            cboSexo.FlatStyle = FlatStyle.Flat;
            cboSexo.FormattingEnabled = true;
            cboSexo.Location = new Point(246, 259);
            cboSexo.Name = "cboSexo";
            cboSexo.Size = new Size(180, 23);
            cboSexo.TabIndex = 18;
            // 
            // txtRaza
            // 
            txtRaza.BackColor = Color.FromArgb(223, 181, 116);
            txtRaza.BorderStyle = BorderStyle.None;
            txtRaza.Location = new Point(246, 214);
            txtRaza.Multiline = true;
            txtRaza.Name = "txtRaza";
            txtRaza.Size = new Size(180, 26);
            txtRaza.TabIndex = 15;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(223, 181, 116);
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Location = new Point(246, 172);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(180, 26);
            textBox3.TabIndex = 14;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.FromArgb(223, 181, 116);
            txtNombre.BorderStyle = BorderStyle.None;
            txtNombre.Location = new Point(246, 126);
            txtNombre.Multiline = true;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(180, 26);
            txtNombre.TabIndex = 12;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(223, 181, 116);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(246, 126);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(180, 26);
            textBox1.TabIndex = 13;
            // 
            // insertAnimalForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "insertAnimalForm";
            Text = "insertAnimal";
            Load += insertAnimalForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptbImagen).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnRegresar;
        private Button btnRegistrar;
        private PictureBox ptbImagen;
        private ComboBox cboEspecie;
        private ComboBox cboEstado;
        private ComboBox cboSexo;
        private TextBox txtRaza;
        private TextBox textBox3;
        private TextBox txtNombre;
        private TextBox textBox1;
        private DateTimePicker dtpFechaNacimiento;
        private DateTimePicker dtpFechaIngreso;
        private Button btnFoto;
    }
}