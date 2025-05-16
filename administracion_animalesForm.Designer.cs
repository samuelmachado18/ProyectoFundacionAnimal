namespace Fundacion_Animales
{
    partial class administracion_animalesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(administracion_animalesForm));
            panel1 = new Panel();
            btnReporte = new Button();
            btnEliminar = new Button();
            btnEditar = new Button();
            btnNuevo = new Button();
            btnRegresar = new Button();
            dgvAdministracionAnimal = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAdministracionAnimal).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(dgvAdministracionAnimal);
            panel1.Controls.Add(btnReporte);
            panel1.Controls.Add(btnEliminar);
            panel1.Controls.Add(btnEditar);
            panel1.Controls.Add(btnNuevo);
            panel1.Controls.Add(btnRegresar);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 0;
            // 
            // btnReporte
            // 
            btnReporte.BackgroundImage = (Image)resources.GetObject("btnReporte.BackgroundImage");
            btnReporte.BackgroundImageLayout = ImageLayout.Stretch;
            btnReporte.FlatAppearance.BorderSize = 0;
            btnReporte.FlatStyle = FlatStyle.Flat;
            btnReporte.Location = new Point(587, 375);
            btnReporte.Name = "btnReporte";
            btnReporte.Size = new Size(169, 47);
            btnReporte.TabIndex = 10;
            btnReporte.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.BackgroundImage = (Image)resources.GetObject("btnEliminar.BackgroundImage");
            btnEliminar.BackgroundImageLayout = ImageLayout.Stretch;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Location = new Point(402, 375);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(169, 47);
            btnEliminar.TabIndex = 9;
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.BackgroundImage = (Image)resources.GetObject("btnEditar.BackgroundImage");
            btnEditar.BackgroundImageLayout = ImageLayout.Stretch;
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Location = new Point(221, 374);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(169, 47);
            btnEditar.TabIndex = 8;
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.BackgroundImage = (Image)resources.GetObject("btnNuevo.BackgroundImage");
            btnNuevo.BackgroundImageLayout = ImageLayout.Stretch;
            btnNuevo.FlatAppearance.BorderSize = 0;
            btnNuevo.FlatStyle = FlatStyle.Flat;
            btnNuevo.Location = new Point(46, 373);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(169, 47);
            btnNuevo.TabIndex = 7;
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click_1;
            // 
            // btnRegresar
            // 
            btnRegresar.BackgroundImage = (Image)resources.GetObject("btnRegresar.BackgroundImage");
            btnRegresar.BackgroundImageLayout = ImageLayout.Stretch;
            btnRegresar.FlatAppearance.BorderSize = 0;
            btnRegresar.FlatStyle = FlatStyle.Flat;
            btnRegresar.Location = new Point(3, 3);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(62, 60);
            btnRegresar.TabIndex = 6;
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // dgvAdministracionAnimal
            // 
            dgvAdministracionAnimal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAdministracionAnimal.Location = new Point(56, 145);
            dgvAdministracionAnimal.MultiSelect = false;
            dgvAdministracionAnimal.Name = "dgvAdministracionAnimal";
            dgvAdministracionAnimal.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAdministracionAnimal.Size = new Size(683, 211);
            dgvAdministracionAnimal.TabIndex = 11;
            // 
            // administracion_animalesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "administracion_animalesForm";
            Text = "administracion_animalesForm";
            Load += administracion_animalesForm_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAdministracionAnimal).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnReporte;
        private Button btnEliminar;
        private Button btnEditar;
        private Button btnNuevo;
        private Button btnRegresar;
        private DataGridView dgvAdministracionAnimal;
    }
}