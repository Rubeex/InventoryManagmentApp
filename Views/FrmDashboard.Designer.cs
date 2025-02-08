namespace InventoryManagmentApp.Views
{
    partial class FrmDashboard
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
            panel1 = new Panel();
            panel4 = new Panel();
            lblNameSession = new Label();
            lblTitle = new Label();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            btnRoles = new Button();
            pictureBox11 = new PictureBox();
            pictureBox10 = new PictureBox();
            pictureBox9 = new PictureBox();
            pictureBox8 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            btnConfiguration = new Button();
            btnUsuario = new Button();
            btnProductos = new Button();
            btnProveedor = new Button();
            lblSecction = new Label();
            btnVentas = new Button();
            btnStocks = new Button();
            btnRecibido = new Button();
            btnCompras = new Button();
            btnDashboard = new Button();
            panel3 = new Panel();
            lblRutas = new Label();
            lblRuta = new Label();
            panelPadre = new Panel();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DodgerBlue;
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(lblTitle);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(919, 37);
            panel1.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(lblNameSession);
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(680, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(239, 37);
            panel4.TabIndex = 2;
            panel4.Paint += panel4_Paint;
            // 
            // lblNameSession
            // 
            lblNameSession.AutoSize = true;
            lblNameSession.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNameSession.ForeColor = Color.White;
            lblNameSession.Location = new Point(20, 11);
            lblNameSession.Name = "lblNameSession";
            lblNameSession.Size = new Size(0, 17);
            lblNameSession.TabIndex = 1;
            lblNameSession.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(12, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(145, 17);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Inventory Dashboard";
            // 
            // panel2
            // 
            panel2.BackColor = Color.MidnightBlue;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(btnRoles);
            panel2.Controls.Add(pictureBox11);
            panel2.Controls.Add(pictureBox10);
            panel2.Controls.Add(pictureBox9);
            panel2.Controls.Add(pictureBox8);
            panel2.Controls.Add(pictureBox7);
            panel2.Controls.Add(pictureBox6);
            panel2.Controls.Add(pictureBox4);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(btnConfiguration);
            panel2.Controls.Add(btnUsuario);
            panel2.Controls.Add(btnProductos);
            panel2.Controls.Add(btnProveedor);
            panel2.Controls.Add(lblSecction);
            panel2.Controls.Add(btnVentas);
            panel2.Controls.Add(btnStocks);
            panel2.Controls.Add(btnRecibido);
            panel2.Controls.Add(btnCompras);
            panel2.Controls.Add(btnDashboard);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 37);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 390);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.coordinate;
            pictureBox1.Location = new Point(12, 289);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(20, 19);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // btnRoles
            // 
            btnRoles.FlatAppearance.BorderSize = 0;
            btnRoles.FlatStyle = FlatStyle.Flat;
            btnRoles.Font = new Font("Poppins", 8.25F);
            btnRoles.ForeColor = Color.White;
            btnRoles.Location = new Point(38, 289);
            btnRoles.Name = "btnRoles";
            btnRoles.Size = new Size(95, 23);
            btnRoles.TabIndex = 21;
            btnRoles.Text = "Roles";
            btnRoles.TextAlign = ContentAlignment.MiddleLeft;
            btnRoles.UseVisualStyleBackColor = true;
            btnRoles.Click += btnRoles_Click;
            // 
            // pictureBox11
            // 
            pictureBox11.Image = Properties.Resources.cogwheel;
            pictureBox11.Location = new Point(12, 318);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(20, 19);
            pictureBox11.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox11.TabIndex = 20;
            pictureBox11.TabStop = false;
            // 
            // pictureBox10
            // 
            pictureBox10.Image = Properties.Resources.team;
            pictureBox10.Location = new Point(12, 260);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(20, 19);
            pictureBox10.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox10.TabIndex = 19;
            pictureBox10.TabStop = false;
            // 
            // pictureBox9
            // 
            pictureBox9.Image = Properties.Resources.box;
            pictureBox9.Location = new Point(12, 231);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(20, 19);
            pictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox9.TabIndex = 18;
            pictureBox9.TabStop = false;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = Properties.Resources.delivery_courier;
            pictureBox8.Location = new Point(12, 202);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(20, 19);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 17;
            pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.discount_tag;
            pictureBox7.Location = new Point(12, 133);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(20, 19);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 16;
            pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.packages;
            pictureBox6.Location = new Point(12, 104);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(20, 19);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 15;
            pictureBox6.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.received;
            pictureBox4.Location = new Point(12, 75);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(20, 19);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 13;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.trend;
            pictureBox3.Location = new Point(12, 46);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(20, 19);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 12;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.dashboard;
            pictureBox2.Location = new Point(12, 17);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(20, 19);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // btnConfiguration
            // 
            btnConfiguration.FlatAppearance.BorderSize = 0;
            btnConfiguration.FlatStyle = FlatStyle.Flat;
            btnConfiguration.Font = new Font("Poppins", 8.25F);
            btnConfiguration.ForeColor = Color.White;
            btnConfiguration.Location = new Point(38, 318);
            btnConfiguration.Name = "btnConfiguration";
            btnConfiguration.Size = new Size(106, 23);
            btnConfiguration.TabIndex = 10;
            btnConfiguration.Text = " Cerrar sesión";
            btnConfiguration.TextAlign = ContentAlignment.MiddleLeft;
            btnConfiguration.UseVisualStyleBackColor = true;
            btnConfiguration.Click += btnConfiguration_Click;
            // 
            // btnUsuario
            // 
            btnUsuario.FlatAppearance.BorderSize = 0;
            btnUsuario.FlatStyle = FlatStyle.Flat;
            btnUsuario.Font = new Font("Poppins", 8.25F);
            btnUsuario.ForeColor = Color.White;
            btnUsuario.Location = new Point(38, 260);
            btnUsuario.Name = "btnUsuario";
            btnUsuario.Size = new Size(95, 23);
            btnUsuario.TabIndex = 9;
            btnUsuario.Text = "Usuarios";
            btnUsuario.TextAlign = ContentAlignment.MiddleLeft;
            btnUsuario.UseVisualStyleBackColor = true;
            btnUsuario.Click += btnUsuario_Click;
            // 
            // btnProductos
            // 
            btnProductos.FlatAppearance.BorderSize = 0;
            btnProductos.FlatStyle = FlatStyle.Flat;
            btnProductos.Font = new Font("Poppins", 8.25F);
            btnProductos.ForeColor = Color.White;
            btnProductos.Location = new Point(38, 231);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(95, 23);
            btnProductos.TabIndex = 8;
            btnProductos.Text = "Productos";
            btnProductos.TextAlign = ContentAlignment.MiddleLeft;
            btnProductos.UseVisualStyleBackColor = true;
            btnProductos.Click += btnProductos_Click;
            // 
            // btnProveedor
            // 
            btnProveedor.FlatAppearance.BorderSize = 0;
            btnProveedor.FlatStyle = FlatStyle.Flat;
            btnProveedor.Font = new Font("Poppins", 8.25F);
            btnProveedor.ForeColor = Color.White;
            btnProveedor.Location = new Point(38, 202);
            btnProveedor.Name = "btnProveedor";
            btnProveedor.Size = new Size(95, 23);
            btnProveedor.TabIndex = 7;
            btnProveedor.Text = "Proveedores";
            btnProveedor.TextAlign = ContentAlignment.MiddleLeft;
            btnProveedor.UseVisualStyleBackColor = true;
            btnProveedor.Click += btnProveedor_Click;
            // 
            // lblSecction
            // 
            lblSecction.AutoSize = true;
            lblSecction.Font = new Font("Poppins", 8.25F);
            lblSecction.ForeColor = Color.White;
            lblSecction.Location = new Point(12, 172);
            lblSecction.Name = "lblSecction";
            lblSecction.Size = new Size(92, 19);
            lblSecction.TabIndex = 6;
            lblSecction.Text = "Mantenimiento";
            // 
            // btnVentas
            // 
            btnVentas.FlatAppearance.BorderSize = 0;
            btnVentas.FlatStyle = FlatStyle.Flat;
            btnVentas.Font = new Font("Poppins", 8.25F);
            btnVentas.ForeColor = Color.White;
            btnVentas.Location = new Point(38, 133);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(95, 23);
            btnVentas.TabIndex = 5;
            btnVentas.Text = "Ventas";
            btnVentas.TextAlign = ContentAlignment.MiddleLeft;
            btnVentas.UseVisualStyleBackColor = true;
            btnVentas.Click += btnVentas_Click;
            // 
            // btnStocks
            // 
            btnStocks.FlatAppearance.BorderSize = 0;
            btnStocks.FlatStyle = FlatStyle.Flat;
            btnStocks.Font = new Font("Poppins", 8.25F);
            btnStocks.ForeColor = Color.White;
            btnStocks.Location = new Point(38, 104);
            btnStocks.Name = "btnStocks";
            btnStocks.Size = new Size(95, 23);
            btnStocks.TabIndex = 4;
            btnStocks.Text = "Stocks";
            btnStocks.TextAlign = ContentAlignment.MiddleLeft;
            btnStocks.UseVisualStyleBackColor = true;
            btnStocks.Click += btnStocks_Click;
            // 
            // btnRecibido
            // 
            btnRecibido.FlatAppearance.BorderSize = 0;
            btnRecibido.FlatStyle = FlatStyle.Flat;
            btnRecibido.Font = new Font("Poppins", 8.25F);
            btnRecibido.ForeColor = Color.White;
            btnRecibido.Location = new Point(38, 75);
            btnRecibido.Name = "btnRecibido";
            btnRecibido.Size = new Size(87, 23);
            btnRecibido.TabIndex = 2;
            btnRecibido.Text = "Recibidos";
            btnRecibido.TextAlign = ContentAlignment.MiddleLeft;
            btnRecibido.UseVisualStyleBackColor = true;
            btnRecibido.Click += btnRecibido_Click;
            // 
            // btnCompras
            // 
            btnCompras.FlatAppearance.BorderSize = 0;
            btnCompras.FlatStyle = FlatStyle.Flat;
            btnCompras.Font = new Font("Poppins", 8.25F);
            btnCompras.ForeColor = Color.White;
            btnCompras.Location = new Point(38, 46);
            btnCompras.Name = "btnCompras";
            btnCompras.Size = new Size(87, 23);
            btnCompras.TabIndex = 1;
            btnCompras.Text = "Compras";
            btnCompras.TextAlign = ContentAlignment.MiddleLeft;
            btnCompras.UseVisualStyleBackColor = true;
            btnCompras.Click += btnCompras_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Poppins", 8.25F);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Location = new Point(38, 17);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(87, 23);
            btnDashboard.TabIndex = 0;
            btnDashboard.Text = "Dashboard";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(lblRutas);
            panel3.Controls.Add(lblRuta);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(200, 37);
            panel3.Name = "panel3";
            panel3.Size = new Size(719, 24);
            panel3.TabIndex = 2;
            // 
            // lblRutas
            // 
            lblRutas.AutoSize = true;
            lblRutas.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRutas.Location = new Point(631, 8);
            lblRutas.Name = "lblRutas";
            lblRutas.Size = new Size(38, 13);
            lblRutas.TabIndex = 1;
            lblRutas.Text = "label3";
            // 
            // lblRuta
            // 
            lblRuta.AutoSize = true;
            lblRuta.Dock = DockStyle.Right;
            lblRuta.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRuta.Location = new Point(719, 0);
            lblRuta.Name = "lblRuta";
            lblRuta.Size = new Size(0, 17);
            lblRuta.TabIndex = 0;
            lblRuta.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelPadre
            // 
            panelPadre.Dock = DockStyle.Fill;
            panelPadre.Location = new Point(200, 61);
            panelPadre.Name = "panelPadre";
            panelPadre.Size = new Size(719, 366);
            panelPadre.TabIndex = 3;
            // 
            // FrmDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(919, 427);
            Controls.Add(panelPadre);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimumSize = new Size(935, 466);
            Name = "FrmDashboard";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            Load += FrmDashboard_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label lblTitle;
        private Panel panel3;
        private Button btnDashboard;
        private Panel panelPadre;
        private Button btnRecibido;
        private Button btnCompras;
        private Button btnConfiguration;
        private Button btnUsuario;
        private Button btnProductos;
        private Button btnProveedor;
        private Label lblSecction;
        private Button btnVentas;
        private Button btnStocks;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox7;
        private PictureBox pictureBox6;
        private PictureBox pictureBox4;
        private PictureBox pictureBox11;
        private PictureBox pictureBox10;
        private PictureBox pictureBox9;
        private PictureBox pictureBox8;
        private Label lblRuta;
        private PictureBox pictureBox1;
        private Button btnRoles;
        private Label lblNameSession;
        private Panel panel4;
        private Label lblRutas;
    }
}