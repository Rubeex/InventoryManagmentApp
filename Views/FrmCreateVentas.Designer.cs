namespace InventoryManagmentApp.Views
{
    partial class FrmCreateVentas
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
            components = new System.ComponentModel.Container();
            txtTotal = new TextBox();
            label10 = new Label();
            txtImpuesto = new TextBox();
            numericImpuesto = new NumericUpDown();
            label9 = new Label();
            txtDescuento = new TextBox();
            numericDescuento = new NumericUpDown();
            label8 = new Label();
            txtSubtotal = new TextBox();
            label7 = new Label();
            btnAgregar = new Button();
            txtCliente = new TextBox();
            label6 = new Label();
            jComboxProductos = new ComboBox();
            btnGuardar = new Button();
            txtObservaciones = new TextBox();
            label5 = new Label();
            dataGridView1 = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Producto = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            label4 = new Label();
            numericCantidad = new NumericUpDown();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            errorProvidertotal = new ErrorProvider(components);
            errorProviderClient = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)numericImpuesto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericDescuento).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericCantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvidertotal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderClient).BeginInit();
            SuspendLayout();
            // 
            // txtTotal
            // 
            txtTotal.Enabled = false;
            txtTotal.Location = new Point(522, 385);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(109, 23);
            txtTotal.TabIndex = 48;
            txtTotal.Tag = "Total";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(456, 386);
            label10.Name = "label10";
            label10.Size = new Size(39, 22);
            label10.TabIndex = 47;
            label10.Text = "Total";
            // 
            // txtImpuesto
            // 
            txtImpuesto.Enabled = false;
            txtImpuesto.Location = new Point(522, 350);
            txtImpuesto.Name = "txtImpuesto";
            txtImpuesto.Size = new Size(109, 23);
            txtImpuesto.TabIndex = 46;
            // 
            // numericImpuesto
            // 
            numericImpuesto.DecimalPlaces = 2;
            numericImpuesto.Enabled = false;
            numericImpuesto.Location = new Point(435, 350);
            numericImpuesto.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            numericImpuesto.Name = "numericImpuesto";
            numericImpuesto.Size = new Size(60, 23);
            numericImpuesto.TabIndex = 45;
            numericImpuesto.Tag = "Taxes";
            numericImpuesto.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericImpuesto.ValueChanged += numericImpuesto_ValueChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(341, 350);
            label9.Name = "label9";
            label9.Size = new Size(66, 22);
            label9.TabIndex = 44;
            label9.Text = "Impuesto";
            // 
            // txtDescuento
            // 
            txtDescuento.Enabled = false;
            txtDescuento.Location = new Point(522, 312);
            txtDescuento.Name = "txtDescuento";
            txtDescuento.Size = new Size(109, 23);
            txtDescuento.TabIndex = 43;
            // 
            // numericDescuento
            // 
            numericDescuento.DecimalPlaces = 2;
            numericDescuento.Enabled = false;
            numericDescuento.Location = new Point(435, 313);
            numericDescuento.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            numericDescuento.Name = "numericDescuento";
            numericDescuento.Size = new Size(60, 23);
            numericDescuento.TabIndex = 42;
            numericDescuento.Tag = "Discount";
            numericDescuento.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericDescuento.ValueChanged += numericDescuento_ValueChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(341, 312);
            label8.Name = "label8";
            label8.Size = new Size(74, 22);
            label8.TabIndex = 41;
            label8.Text = "Descuento";
            // 
            // txtSubtotal
            // 
            txtSubtotal.Enabled = false;
            txtSubtotal.Location = new Point(522, 280);
            txtSubtotal.Name = "txtSubtotal";
            txtSubtotal.Size = new Size(109, 23);
            txtSubtotal.TabIndex = 40;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(456, 281);
            label7.Name = "label7";
            label7.Size = new Size(60, 22);
            label7.TabIndex = 39;
            label7.Text = "Subtotal";
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.DodgerBlue;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgregar.ForeColor = SystemColors.Control;
            btnAgregar.Location = new Point(514, 119);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(113, 31);
            btnAgregar.TabIndex = 38;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtCliente
            // 
            txtCliente.Font = new Font("Segoe UI", 10F);
            txtCliente.Location = new Point(430, 22);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(197, 25);
            txtCliente.TabIndex = 37;
            txtCliente.Tag = "Client";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Poppins", 8F);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(360, 28);
            label6.Name = "label6";
            label6.Size = new Size(48, 19);
            label6.TabIndex = 36;
            label6.Text = "Cliente";
            // 
            // jComboxProductos
            // 
            jComboxProductos.FormattingEnabled = true;
            jComboxProductos.Location = new Point(50, 123);
            jComboxProductos.Name = "jComboxProductos";
            jComboxProductos.Size = new Size(287, 23);
            jComboxProductos.TabIndex = 35;
            jComboxProductos.SelectedIndexChanged += jComboxProductos_SelectedIndexChanged;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.DodgerBlue;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = SystemColors.Control;
            btnGuardar.Location = new Point(298, 570);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(88, 32);
            btnGuardar.TabIndex = 34;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtObservaciones
            // 
            txtObservaciones.Location = new Point(46, 453);
            txtObservaciones.Multiline = true;
            txtObservaciones.Name = "txtObservaciones";
            txtObservaciones.Size = new Size(581, 71);
            txtObservaciones.TabIndex = 33;
            txtObservaciones.Tag = "Observations";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Poppins", 10F);
            label5.ForeColor = Color.Teal;
            label5.Location = new Point(23, 425);
            label5.Name = "label5";
            label5.Size = new Size(116, 25);
            label5.TabIndex = 32;
            label5.Text = "Observaciones";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id, Producto, Cantidad, Precio, Total });
            dataGridView1.Location = new Point(50, 162);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(581, 101);
            dataGridView1.TabIndex = 31;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            // 
            // Producto
            // 
            Producto.HeaderText = "Producto";
            Producto.Name = "Producto";
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.Name = "Cantidad";
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.Name = "Precio";
            // 
            // Total
            // 
            Total.HeaderText = "Total";
            Total.Name = "Total";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Poppins", 8F);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(356, 100);
            label4.Name = "label4";
            label4.Size = new Size(59, 19);
            label4.TabIndex = 30;
            label4.Text = "Cantidad";
            // 
            // numericCantidad
            // 
            numericCantidad.Location = new Point(356, 126);
            numericCantidad.Name = "numericCantidad";
            numericCantidad.Size = new Size(131, 23);
            numericCantidad.TabIndex = 29;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poppins", 8F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(46, 100);
            label3.Name = "label3";
            label3.Size = new Size(53, 19);
            label3.TabIndex = 28;
            label3.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins", 11F);
            label2.ForeColor = Color.Teal;
            label2.Location = new Point(23, 64);
            label2.Name = "label2";
            label2.Size = new Size(82, 26);
            label2.TabIndex = 27;
            label2.Text = "Producto";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 9F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(23, 25);
            label1.Name = "label1";
            label1.Size = new Size(140, 22);
            label1.TabIndex = 26;
            label1.Text = "Crear Orden de Venta";
            // 
            // errorProvidertotal
            // 
            errorProvidertotal.ContainerControl = this;
            errorProvidertotal.Tag = "Total";
            // 
            // errorProviderClient
            // 
            errorProviderClient.ContainerControl = this;
            errorProviderClient.Tag = "Client";
            // 
            // FrmCreateVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(658, 621);
            Controls.Add(txtTotal);
            Controls.Add(label10);
            Controls.Add(txtImpuesto);
            Controls.Add(numericImpuesto);
            Controls.Add(label9);
            Controls.Add(txtDescuento);
            Controls.Add(numericDescuento);
            Controls.Add(label8);
            Controls.Add(txtSubtotal);
            Controls.Add(label7);
            Controls.Add(btnAgregar);
            Controls.Add(txtCliente);
            Controls.Add(label6);
            Controls.Add(jComboxProductos);
            Controls.Add(btnGuardar);
            Controls.Add(txtObservaciones);
            Controls.Add(label5);
            Controls.Add(dataGridView1);
            Controls.Add(label4);
            Controls.Add(numericCantidad);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "FrmCreateVentas";
            Text = "Orden de Ventas";
            Load += FrmCreateVentas_Load;
            ((System.ComponentModel.ISupportInitialize)numericImpuesto).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericDescuento).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericCantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvidertotal).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderClient).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTotal;
        private Label label10;
        private TextBox txtImpuesto;
        private NumericUpDown numericImpuesto;
        private Label label9;
        private TextBox txtDescuento;
        private NumericUpDown numericDescuento;
        private Label label8;
        private TextBox txtSubtotal;
        private Label label7;
        private Button btnAgregar;
        private TextBox txtCliente;
        private Label label6;
        private ComboBox jComboxProductos;
        private Button btnGuardar;
        private TextBox txtObservaciones;
        private Label label5;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Total;
        private Label label4;
        private NumericUpDown numericCantidad;
        private Label label3;
        private Label label2;
        private Label label1;
        private ErrorProvider errorProvidertotal;
        private ErrorProvider errorProviderClient;
    }
}