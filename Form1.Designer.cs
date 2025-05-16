namespace Fundacion_Animales
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            lblTitulo = new Label();
            ptbMenu = new PictureBox();
            baraLateral = new FlowLayoutPanel();
            pnInicio = new Panel();
            btnInicio = new Button();
            menuContainer = new FlowLayoutPanel();
            pnAdoptar = new Panel();
            btnMenu = new Button();
            panel6 = new Panel();
            btnPerro = new Button();
            panel7 = new Panel();
            button5 = new Button();
            pnConocenos = new Panel();
            button1 = new Button();
            pnContactanos = new Panel();
            button4 = new Button();
            panel2 = new Panel();
            btnAgregarAnimales = new Button();
            menuTransition = new System.Windows.Forms.Timer(components);
            transicionBarraLate = new System.Windows.Forms.Timer(components);
            mainPanel = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbMenu).BeginInit();
            baraLateral.SuspendLayout();
            pnInicio.SuspendLayout();
            menuContainer.SuspendLayout();
            pnAdoptar.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            pnConocenos.SuspendLayout();
            pnContactanos.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(195, 181, 194);
            panel1.Controls.Add(lblTitulo);
            panel1.Controls.Add(ptbMenu);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(991, 39);
            panel1.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Segoe Script", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.Black;
            lblTitulo.Location = new Point(62, 2);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(115, 27);
            lblTitulo.TabIndex = 2;
            lblTitulo.Text = "ENGINEERS";
            // 
            // ptbMenu
            // 
            ptbMenu.BackColor = Color.Transparent;
            ptbMenu.Image = (Image)resources.GetObject("ptbMenu.Image");
            ptbMenu.Location = new Point(0, 0);
            ptbMenu.Name = "ptbMenu";
            ptbMenu.Size = new Size(56, 39);
            ptbMenu.SizeMode = PictureBoxSizeMode.CenterImage;
            ptbMenu.TabIndex = 1;
            ptbMenu.TabStop = false;
            ptbMenu.Click += ptbMenu_Click;
            // 
            // baraLateral
            // 
            baraLateral.BackColor = Color.FromArgb(195, 181, 194);
            baraLateral.Controls.Add(pnInicio);
            baraLateral.Controls.Add(menuContainer);
            baraLateral.Controls.Add(pnConocenos);
            baraLateral.Controls.Add(pnContactanos);
            baraLateral.Controls.Add(panel2);
            baraLateral.Dock = DockStyle.Left;
            baraLateral.FlowDirection = FlowDirection.TopDown;
            baraLateral.Location = new Point(0, 39);
            baraLateral.Name = "baraLateral";
            baraLateral.Size = new Size(56, 494);
            baraLateral.TabIndex = 1;
            // 
            // pnInicio
            // 
            pnInicio.Controls.Add(btnInicio);
            pnInicio.Location = new Point(3, 3);
            pnInicio.Name = "pnInicio";
            pnInicio.Size = new Size(204, 54);
            pnInicio.TabIndex = 7;
            // 
            // btnInicio
            // 
            btnInicio.BackColor = Color.FromArgb(195, 181, 194);
            btnInicio.Image = (Image)resources.GetObject("btnInicio.Image");
            btnInicio.ImageAlign = ContentAlignment.MiddleLeft;
            btnInicio.Location = new Point(-25, -13);
            btnInicio.Margin = new Padding(0);
            btnInicio.Name = "btnInicio";
            btnInicio.Padding = new Padding(30, 0, 0, 0);
            btnInicio.Size = new Size(238, 76);
            btnInicio.TabIndex = 2;
            btnInicio.Text = "INCIO";
            btnInicio.UseVisualStyleBackColor = false;
            btnInicio.Click += btnInicio_Click;
            // 
            // menuContainer
            // 
            menuContainer.Controls.Add(pnAdoptar);
            menuContainer.Controls.Add(panel6);
            menuContainer.Controls.Add(panel7);
            menuContainer.Location = new Point(3, 63);
            menuContainer.Name = "menuContainer";
            menuContainer.Size = new Size(204, 57);
            menuContainer.TabIndex = 6;
            // 
            // pnAdoptar
            // 
            pnAdoptar.Controls.Add(btnMenu);
            pnAdoptar.Location = new Point(0, 0);
            pnAdoptar.Margin = new Padding(0);
            pnAdoptar.Name = "pnAdoptar";
            pnAdoptar.Size = new Size(207, 54);
            pnAdoptar.TabIndex = 7;
            // 
            // btnMenu
            // 
            btnMenu.BackColor = Color.FromArgb(195, 181, 194);
            btnMenu.Image = (Image)resources.GetObject("btnMenu.Image");
            btnMenu.ImageAlign = ContentAlignment.MiddleLeft;
            btnMenu.Location = new Point(-25, -9);
            btnMenu.Margin = new Padding(0);
            btnMenu.Name = "btnMenu";
            btnMenu.Padding = new Padding(30, 0, 0, 0);
            btnMenu.Size = new Size(238, 67);
            btnMenu.TabIndex = 2;
            btnMenu.Text = "Adoptar";
            btnMenu.UseVisualStyleBackColor = false;
            btnMenu.Click += btnMenu_Click;
            // 
            // panel6
            // 
            panel6.Controls.Add(btnPerro);
            panel6.Location = new Point(0, 54);
            panel6.Margin = new Padding(0);
            panel6.Name = "panel6";
            panel6.Size = new Size(204, 54);
            panel6.TabIndex = 8;
            // 
            // btnPerro
            // 
            btnPerro.BackColor = Color.FromArgb(195, 181, 194);
            btnPerro.Image = (Image)resources.GetObject("btnPerro.Image");
            btnPerro.ImageAlign = ContentAlignment.MiddleLeft;
            btnPerro.Location = new Point(-25, -11);
            btnPerro.Margin = new Padding(0);
            btnPerro.Name = "btnPerro";
            btnPerro.Padding = new Padding(30, 0, 0, 0);
            btnPerro.Size = new Size(238, 76);
            btnPerro.TabIndex = 2;
            btnPerro.Text = "PERROS";
            btnPerro.UseVisualStyleBackColor = false;
            btnPerro.Click += btnPerro_Click;
            // 
            // panel7
            // 
            panel7.Controls.Add(button5);
            panel7.Location = new Point(0, 108);
            panel7.Margin = new Padding(0);
            panel7.Name = "panel7";
            panel7.Size = new Size(204, 54);
            panel7.TabIndex = 9;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(195, 181, 194);
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(-25, -11);
            button5.Margin = new Padding(0);
            button5.Name = "button5";
            button5.Padding = new Padding(30, 0, 0, 0);
            button5.Size = new Size(238, 78);
            button5.TabIndex = 2;
            button5.Text = "GATOS";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // pnConocenos
            // 
            pnConocenos.Controls.Add(button1);
            pnConocenos.Location = new Point(3, 126);
            pnConocenos.Name = "pnConocenos";
            pnConocenos.Size = new Size(204, 54);
            pnConocenos.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(195, 181, 194);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(-25, -7);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Padding = new Padding(30, 0, 0, 0);
            button1.Size = new Size(238, 70);
            button1.TabIndex = 2;
            button1.Text = "Conócenos";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pnContactanos
            // 
            pnContactanos.Controls.Add(button4);
            pnContactanos.Location = new Point(3, 186);
            pnContactanos.Name = "pnContactanos";
            pnContactanos.Size = new Size(204, 54);
            pnContactanos.TabIndex = 4;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(195, 181, 194);
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(-25, -13);
            button4.Margin = new Padding(0);
            button4.Name = "button4";
            button4.Padding = new Padding(30, 0, 0, 0);
            button4.Size = new Size(238, 76);
            button4.TabIndex = 2;
            button4.Text = "Contáctanos";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnAgregarAnimales);
            panel2.Location = new Point(3, 246);
            panel2.Name = "panel2";
            panel2.Size = new Size(204, 54);
            panel2.TabIndex = 5;
            // 
            // btnAgregarAnimales
            // 
            btnAgregarAnimales.BackColor = Color.FromArgb(195, 181, 194);
            btnAgregarAnimales.Image = (Image)resources.GetObject("btnAgregarAnimales.Image");
            btnAgregarAnimales.ImageAlign = ContentAlignment.MiddleLeft;
            btnAgregarAnimales.Location = new Point(-25, -15);
            btnAgregarAnimales.Margin = new Padding(0);
            btnAgregarAnimales.Name = "btnAgregarAnimales";
            btnAgregarAnimales.Padding = new Padding(30, 0, 0, 0);
            btnAgregarAnimales.Size = new Size(238, 76);
            btnAgregarAnimales.TabIndex = 2;
            btnAgregarAnimales.Text = "Agregar Mascota";
            btnAgregarAnimales.UseVisualStyleBackColor = false;
            btnAgregarAnimales.Click += btnAgregarAnimales_Click;
            // 
            // menuTransition
            // 
            menuTransition.Interval = 10;
            menuTransition.Tick += menuTransition_Tick;
            // 
            // transicionBarraLate
            // 
            transicionBarraLate.Interval = 10;
            transicionBarraLate.Tick += transicionBarraLate_Tick;
            // 
            // mainPanel
            // 
            mainPanel.BackgroundImage = (Image)resources.GetObject("mainPanel.BackgroundImage");
            mainPanel.BackgroundImageLayout = ImageLayout.Stretch;
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(56, 39);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(935, 494);
            mainPanel.TabIndex = 3;
            mainPanel.Paint += mainPanel_Paint;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(991, 533);
            Controls.Add(mainPanel);
            Controls.Add(baraLateral);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            IsMdiContainer = true;
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptbMenu).EndInit();
            baraLateral.ResumeLayout(false);
            pnInicio.ResumeLayout(false);
            menuContainer.ResumeLayout(false);
            pnAdoptar.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel7.ResumeLayout(false);
            pnConocenos.ResumeLayout(false);
            pnContactanos.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox ptbMenu;
        private Label lblTitulo;
        private FlowLayoutPanel baraLateral;
        private Button button1;
        private Panel pnConocenos;
        private Button btnMenu;
        private System.Windows.Forms.Timer menuTransition;
        private FlowLayoutPanel menuContainer;
        private Panel pnAdoptar;
        private Panel panel6;
        private Button btnPerro;
        private Panel panel7;
        private Button button5;
        private Panel pnInicio;
        private Button btnInicio;
        private Panel pnContactanos;
        private Button button4;
        private System.Windows.Forms.Timer transicionBarraLate;
        private Panel mainPanel;
        private Panel panel2;
        private Button btnAgregarAnimales;
    }
}
