namespace InventoryManagmentApp.Views
{
    partial class FrmViewComprasRecibidas
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
            label2 = new Label();
            txtID = new TextBox();
            dataGridView1 = new DataGridView();
            label3 = new Label();
            txtComprador = new TextBox();
            label1 = new Label();
            txtTotal = new TextBox();
            label10 = new Label();
            txtImpuesto = new TextBox();
            label9 = new Label();
            txtDescuento = new TextBox();
            label8 = new Label();
            txtObservaciones = new TextBox();
            label5 = new Label();
            btnGuardar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins", 11F);
            label2.ForeColor = Color.Teal;
            label2.Location = new Point(21, 22);
            label2.Name = "label2";
            label2.Size = new Size(93, 26);
            label2.TabIndex = 2;
            label2.Text = "ID Compra";
            // 
            // txtID
            // 
            txtID.Enabled = false;
            txtID.Location = new Point(120, 22);
            txtID.Name = "txtID";
            txtID.Size = new Size(138, 23);
            txtID.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(21, 138);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(670, 169);
            dataGridView1.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poppins", 8F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(21, 61);
            label3.Name = "label3";
            label3.Size = new Size(71, 19);
            label3.TabIndex = 5;
            label3.Text = "Comprador";
            // 
            // txtComprador
            // 
            txtComprador.Enabled = false;
            txtComprador.Location = new Point(120, 57);
            txtComprador.Name = "txtComprador";
            txtComprador.Size = new Size(311, 23);
            txtComprador.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 11F);
            label1.ForeColor = Color.Teal;
            label1.Location = new Point(21, 99);
            label1.Name = "label1";
            label1.Size = new Size(90, 26);
            label1.TabIndex = 7;
            label1.Text = "Productos";
            // 
            // txtTotal
            // 
            txtTotal.Enabled = false;
            txtTotal.Location = new Point(582, 402);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(109, 23);
            txtTotal.TabIndex = 31;
            txtTotal.Tag = "Total";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(524, 403);
            label10.Name = "label10";
            label10.Size = new Size(39, 22);
            label10.TabIndex = 30;
            label10.Text = "Total";
            // 
            // txtImpuesto
            // 
            txtImpuesto.Enabled = false;
            txtImpuesto.Location = new Point(582, 367);
            txtImpuesto.Name = "txtImpuesto";
            txtImpuesto.Size = new Size(109, 23);
            txtImpuesto.TabIndex = 29;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(497, 367);
            label9.Name = "label9";
            label9.Size = new Size(66, 22);
            label9.TabIndex = 28;
            label9.Text = "Impuesto";
            // 
            // txtDescuento
            // 
            txtDescuento.Enabled = false;
            txtDescuento.Location = new Point(582, 329);
            txtDescuento.Name = "txtDescuento";
            txtDescuento.Size = new Size(109, 23);
            txtDescuento.TabIndex = 27;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(489, 329);
            label8.Name = "label8";
            label8.Size = new Size(74, 22);
            label8.TabIndex = 26;
            label8.Text = "Descuento";
            // 
            // txtObservaciones
            // 
            txtObservaciones.Enabled = false;
            txtObservaciones.Location = new Point(52, 443);
            txtObservaciones.Multiline = true;
            txtObservaciones.Name = "txtObservaciones";
            txtObservaciones.Size = new Size(639, 71);
            txtObservaciones.TabIndex = 33;
            txtObservaciones.Tag = "Observations";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Poppins", 10F);
            label5.ForeColor = Color.Teal;
            label5.Location = new Point(21, 403);
            label5.Name = "label5";
            label5.Size = new Size(116, 25);
            label5.TabIndex = 32;
            label5.Text = "Observaciones";
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.DodgerBlue;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = SystemColors.Control;
            btnGuardar.Location = new Point(324, 545);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(88, 32);
            btnGuardar.TabIndex = 34;
            btnGuardar.Text = "Regresar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // FrmViewComprasRecibidas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(715, 618);
            Controls.Add(btnGuardar);
            Controls.Add(txtObservaciones);
            Controls.Add(label5);
            Controls.Add(txtTotal);
            Controls.Add(label10);
            Controls.Add(txtImpuesto);
            Controls.Add(label9);
            Controls.Add(txtDescuento);
            Controls.Add(label8);
            Controls.Add(label1);
            Controls.Add(txtComprador);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(txtID);
            Controls.Add(label2);
            MaximizeBox = false;
            Name = "FrmViewComprasRecibidas";
            Text = "Recibidos";
            Load += FrmViewComprasRecibidas_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private TextBox txtID;
        private DataGridView dataGridView1;
        private Label label3;
        private TextBox txtComprador;
        private Label label1;
        private TextBox txtTotal;
        private Label label10;
        private TextBox txtImpuesto;
        private Label label9;
        private TextBox txtDescuento;
        private Label label8;
        private TextBox txtObservaciones;
        private Label label5;
        private Button btnGuardar;
    }
}