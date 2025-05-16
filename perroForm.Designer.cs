namespace Fundacion_Animales
{
    partial class perroForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(perroForm));
            dataGridView1 = new DataGridView();
            btnAdoptar = new Button();
            btnMostrarInfo = new Button();
            btnRegresar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(45, 88);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(713, 274);
            dataGridView1.TabIndex = 0;
            // 
            // btnAdoptar
            // 
            btnAdoptar.BackColor = Color.FromArgb(255, 189, 89);
            btnAdoptar.BackgroundImageLayout = ImageLayout.None;
            btnAdoptar.FlatAppearance.BorderSize = 0;
            btnAdoptar.FlatStyle = FlatStyle.Flat;
            btnAdoptar.Font = new Font("Poor Richard", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnAdoptar.ForeColor = Color.Black;
            btnAdoptar.Location = new Point(54, 378);
            btnAdoptar.Margin = new Padding(0);
            btnAdoptar.Name = "btnAdoptar";
            btnAdoptar.Size = new Size(133, 36);
            btnAdoptar.TabIndex = 1;
            btnAdoptar.Text = "Adoptar";
            btnAdoptar.UseVisualStyleBackColor = false;
            btnAdoptar.Click += btnAdoptar_Click;
            // 
            // btnMostrarInfo
            // 
            btnMostrarInfo.BackColor = Color.FromArgb(255, 189, 89);
            btnMostrarInfo.BackgroundImageLayout = ImageLayout.None;
            btnMostrarInfo.FlatAppearance.BorderSize = 0;
            btnMostrarInfo.FlatStyle = FlatStyle.Flat;
            btnMostrarInfo.Font = new Font("Poor Richard", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnMostrarInfo.ForeColor = Color.Black;
            btnMostrarInfo.Location = new Point(221, 378);
            btnMostrarInfo.Margin = new Padding(0);
            btnMostrarInfo.Name = "btnMostrarInfo";
            btnMostrarInfo.Size = new Size(133, 36);
            btnMostrarInfo.TabIndex = 2;
            btnMostrarInfo.Text = "Mostrar Inf";
            btnMostrarInfo.UseVisualStyleBackColor = false;
            btnMostrarInfo.Click += btnMostrarInfo_Click;
            // 
            // btnRegresar
            // 
            btnRegresar.BackColor = Color.FromArgb(255, 189, 89);
            btnRegresar.BackgroundImageLayout = ImageLayout.None;
            btnRegresar.FlatAppearance.BorderSize = 0;
            btnRegresar.FlatStyle = FlatStyle.Flat;
            btnRegresar.Font = new Font("Poor Richard", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnRegresar.ForeColor = Color.Black;
            btnRegresar.Location = new Point(612, 378);
            btnRegresar.Margin = new Padding(0);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(133, 36);
            btnRegresar.TabIndex = 3;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = false;
            // 
            // perroForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRegresar);
            Controls.Add(btnMostrarInfo);
            Controls.Add(btnAdoptar);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "perroForm";
            Text = "perroForm";
            Load += perroForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnAdoptar;
        private Button btnMostrarInfo;
        private Button btnRegresar;
    }
}