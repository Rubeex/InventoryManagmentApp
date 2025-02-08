namespace InventoryManagmentApp.Views
{
    partial class FrmCompras
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
            btnRecibido = new Button();
            textBox1 = new TextBox();
            label2 = new Label();
            btnAgregar = new Button();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnRecibido
            // 
            btnRecibido.BackColor = SystemColors.Control;
            btnRecibido.Cursor = Cursors.Hand;
            btnRecibido.FlatAppearance.BorderSize = 0;
            btnRecibido.FlatStyle = FlatStyle.Flat;
            btnRecibido.Font = new Font("Poppins", 9F);
            btnRecibido.ForeColor = Color.Transparent;
            btnRecibido.Image = Properties.Resources.edit1;
            btnRecibido.Location = new Point(41, 64);
            btnRecibido.Name = "btnRecibido";
            btnRecibido.Size = new Size(80, 32);
            btnRecibido.TabIndex = 26;
            btnRecibido.UseVisualStyleBackColor = false;
            btnRecibido.Click += btnEditar_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(491, 73);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(194, 23);
            textBox1.TabIndex = 25;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins", 9F);
            label2.Location = new Point(434, 73);
            label2.Name = "label2";
            label2.Size = new Size(54, 22);
            label2.TabIndex = 24;
            label2.Text = "Search:";
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.Transparent;
            btnAgregar.FlatAppearance.BorderSize = 0;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Image = Properties.Resources.agregar;
            btnAgregar.Location = new Point(636, 18);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(50, 33);
            btnAgregar.TabIndex = 23;
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 9F);
            label1.Location = new Point(34, 18);
            label1.Name = "label1";
            label1.Size = new Size(113, 22);
            label1.TabIndex = 22;
            label1.Text = "Lista de Compras";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(33, 117);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(652, 231);
            dataGridView1.TabIndex = 21;
            // 
            // FrmCompras
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(719, 366);
            Controls.Add(btnRecibido);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(btnAgregar);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmCompras";
            Text = "FrmCompras";
            Load += FrmCompras_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEliminar;
        private Button btnRecibido;
        private TextBox textBox1;
        private Label label2;
        private Button btnAgregar;
        private Label label1;
        private DataGridView dataGridView1;
    }
}