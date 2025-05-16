namespace Fundacion_Animales
{
    partial class opcionesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(opcionesForm));
            btnGato = new Button();
            btnPerro = new Button();
            btnRegresar = new Button();
            SuspendLayout();
            // 
            // btnGato
            // 
            btnGato.BackgroundImage = (Image)resources.GetObject("btnGato.BackgroundImage");
            btnGato.BackgroundImageLayout = ImageLayout.Center;
            btnGato.FlatAppearance.BorderSize = 0;
            btnGato.FlatStyle = FlatStyle.Flat;
            btnGato.Location = new Point(472, 264);
            btnGato.Name = "btnGato";
            btnGato.Size = new Size(255, 125);
            btnGato.TabIndex = 0;
            btnGato.UseVisualStyleBackColor = true;
            // 
            // btnPerro
            // 
            btnPerro.BackgroundImage = (Image)resources.GetObject("btnPerro.BackgroundImage");
            btnPerro.BackgroundImageLayout = ImageLayout.Stretch;
            btnPerro.FlatAppearance.BorderSize = 0;
            btnPerro.FlatStyle = FlatStyle.Flat;
            btnPerro.Location = new Point(73, 264);
            btnPerro.Name = "btnPerro";
            btnPerro.Size = new Size(255, 125);
            btnPerro.TabIndex = 3;
            btnPerro.UseVisualStyleBackColor = true;
            // 
            // btnRegresar
            // 
            btnRegresar.BackgroundImage = (Image)resources.GetObject("btnRegresar.BackgroundImage");
            btnRegresar.BackgroundImageLayout = ImageLayout.Stretch;
            btnRegresar.FlatAppearance.BorderSize = 0;
            btnRegresar.FlatStyle = FlatStyle.Flat;
            btnRegresar.Location = new Point(2, 2);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(64, 60);
            btnRegresar.TabIndex = 4;
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // opcionesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRegresar);
            Controls.Add(btnPerro);
            Controls.Add(btnGato);
            FormBorderStyle = FormBorderStyle.None;
            Name = "opcionesForm";
            Text = "opcionesForm";
            Load += opcionesForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnGato;
        private Button btnPerro;
        private Button btnRegresar;
    }
}