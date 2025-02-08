namespace InventoryManagmentApp.Views
{
    partial class FrmCreateCompras
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            numericCantidad = new NumericUpDown();
            dataGridView1 = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Producto = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            label5 = new Label();
            txtObservaciones = new TextBox();
            btnGuardar = new Button();
            jComboxProductos = new ComboBox();
            label6 = new Label();
            txtProveedor = new TextBox();
            btnAgregar = new Button();
            label7 = new Label();
            txtSubtotal = new TextBox();
            label8 = new Label();
            numericDescuento = new NumericUpDown();
            txtDescuento = new TextBox();
            label9 = new Label();
            numericImpuesto = new NumericUpDown();
            txtImpuesto = new TextBox();
            txtTotal = new TextBox();
            label10 = new Label();
            errorProviderDescuento = new ErrorProvider(components);
            errorProviderImpuesto = new ErrorProvider(components);
            errorProvidertotal = new ErrorProvider(components);
            errorProviderObservaciones = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)numericCantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericDescuento).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericImpuesto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderDescuento).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderImpuesto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvidertotal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderObservaciones).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 9F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(12, 24);
            label1.Name = "label1";
            label1.Size = new Size(155, 22);
            label1.TabIndex = 0;
            label1.Text = "Crear Orden de Compra";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins", 11F);
            label2.ForeColor = Color.Teal;
            label2.Location = new Point(12, 63);
            label2.Name = "label2";
            label2.Size = new Size(82, 26);
            label2.TabIndex = 1;
            label2.Text = "Producto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poppins", 8F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(35, 99);
            label3.Name = "label3";
            label3.Size = new Size(53, 19);
            label3.TabIndex = 3;
            label3.Text = "Nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Poppins", 8F);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(345, 99);
            label4.Name = "label4";
            label4.Size = new Size(59, 19);
            label4.TabIndex = 5;
            label4.Text = "Cantidad";
            // 
            // numericCantidad
            // 
            numericCantidad.Location = new Point(345, 125);
            numericCantidad.Name = "numericCantidad";
            numericCantidad.Size = new Size(131, 23);
            numericCantidad.TabIndex = 4;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id, Producto, Cantidad, Precio, Total });
            dataGridView1.Location = new Point(39, 158);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(581, 101);
            dataGridView1.TabIndex = 7;
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
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Poppins", 10F);
            label5.ForeColor = Color.Teal;
            label5.Location = new Point(12, 421);
            label5.Name = "label5";
            label5.Size = new Size(116, 25);
            label5.TabIndex = 8;
            label5.Text = "Observaciones";
            // 
            // txtObservaciones
            // 
            txtObservaciones.Location = new Point(35, 449);
            txtObservaciones.Multiline = true;
            txtObservaciones.Name = "txtObservaciones";
            txtObservaciones.Size = new Size(581, 71);
            txtObservaciones.TabIndex = 9;
            txtObservaciones.Tag = "Observations";
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.DodgerBlue;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = SystemColors.Control;
            btnGuardar.Location = new Point(287, 566);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(88, 32);
            btnGuardar.TabIndex = 10;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += button2_Click;
            // 
            // jComboxProductos
            // 
            jComboxProductos.FormattingEnabled = true;
            jComboxProductos.Location = new Point(39, 122);
            jComboxProductos.Name = "jComboxProductos";
            jComboxProductos.Size = new Size(287, 23);
            jComboxProductos.TabIndex = 11;
            jComboxProductos.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Poppins", 8F);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(349, 27);
            label6.Name = "label6";
            label6.Size = new Size(64, 19);
            label6.TabIndex = 12;
            label6.Text = "Proveedor";
            // 
            // txtProveedor
            // 
            txtProveedor.Enabled = false;
            txtProveedor.Font = new Font("Segoe UI", 10F);
            txtProveedor.Location = new Point(419, 21);
            txtProveedor.Name = "txtProveedor";
            txtProveedor.Size = new Size(197, 25);
            txtProveedor.TabIndex = 13;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.DodgerBlue;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgregar.ForeColor = SystemColors.Control;
            btnAgregar.Location = new Point(503, 118);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(113, 31);
            btnAgregar.TabIndex = 14;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(445, 277);
            label7.Name = "label7";
            label7.Size = new Size(60, 22);
            label7.TabIndex = 15;
            label7.Text = "Subtotal";
            // 
            // txtSubtotal
            // 
            txtSubtotal.Enabled = false;
            txtSubtotal.Location = new Point(511, 276);
            txtSubtotal.Name = "txtSubtotal";
            txtSubtotal.Size = new Size(109, 23);
            txtSubtotal.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(330, 308);
            label8.Name = "label8";
            label8.Size = new Size(74, 22);
            label8.TabIndex = 17;
            label8.Text = "Descuento";
            // 
            // numericDescuento
            // 
            numericDescuento.DecimalPlaces = 2;
            numericDescuento.Enabled = false;
            numericDescuento.Location = new Point(424, 309);
            numericDescuento.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            numericDescuento.Name = "numericDescuento";
            numericDescuento.Size = new Size(60, 23);
            numericDescuento.TabIndex = 19;
            numericDescuento.Tag = "Discount";
            numericDescuento.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericDescuento.ValueChanged += numericDescuento_ValueChanged;
            // 
            // txtDescuento
            // 
            txtDescuento.Enabled = false;
            txtDescuento.Location = new Point(511, 308);
            txtDescuento.Name = "txtDescuento";
            txtDescuento.Size = new Size(109, 23);
            txtDescuento.TabIndex = 20;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(330, 346);
            label9.Name = "label9";
            label9.Size = new Size(66, 22);
            label9.TabIndex = 21;
            label9.Text = "Impuesto";
            // 
            // numericImpuesto
            // 
            numericImpuesto.DecimalPlaces = 2;
            numericImpuesto.Enabled = false;
            numericImpuesto.Location = new Point(424, 346);
            numericImpuesto.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            numericImpuesto.Name = "numericImpuesto";
            numericImpuesto.Size = new Size(60, 23);
            numericImpuesto.TabIndex = 22;
            numericImpuesto.Tag = "Taxes";
            numericImpuesto.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericImpuesto.ValueChanged += numericImpuesto_ValueChanged;
            // 
            // txtImpuesto
            // 
            txtImpuesto.Enabled = false;
            txtImpuesto.Location = new Point(511, 346);
            txtImpuesto.Name = "txtImpuesto";
            txtImpuesto.Size = new Size(109, 23);
            txtImpuesto.TabIndex = 23;
            // 
            // txtTotal
            // 
            txtTotal.Enabled = false;
            txtTotal.Location = new Point(511, 381);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(109, 23);
            txtTotal.TabIndex = 25;
            txtTotal.Tag = "Total";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(445, 382);
            label10.Name = "label10";
            label10.Size = new Size(39, 22);
            label10.TabIndex = 24;
            label10.Text = "Total";
            // 
            // errorProviderDescuento
            // 
            errorProviderDescuento.ContainerControl = this;
            // 
            // errorProviderImpuesto
            // 
            errorProviderImpuesto.ContainerControl = this;
            // 
            // errorProvidertotal
            // 
            errorProvidertotal.ContainerControl = this;
            // 
            // errorProviderObservaciones
            // 
            errorProviderObservaciones.ContainerControl = this;
            // 
            // FrmCreateCompras
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(647, 621);
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
            Controls.Add(txtProveedor);
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
            Name = "FrmCreateCompras";
            Text = "Compras";
            Load += FrmCreateCompras_Load;
            ((System.ComponentModel.ISupportInitialize)numericCantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericDescuento).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericImpuesto).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderDescuento).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderImpuesto).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvidertotal).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderObservaciones).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private NumericUpDown numericCantidad;
        private DataGridView dataGridView1;
        private Label label5;
        private TextBox txtObservaciones;
        private Button btnGuardar;
        private ComboBox jComboxProductos;
        private Label label6;
        private TextBox txtProveedor;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Total;
        private Button btnAgregar;
        private Label label7;
        private TextBox txtSubtotal;
        private Label label8;
        private NumericUpDown numericDescuento;
        private TextBox txtDescuento;
        private Label label9;
        private NumericUpDown numericImpuesto;
        private TextBox txtImpuesto;
        private TextBox txtTotal;
        private Label label10;
        private ErrorProvider errorProviderDescuento;
        private ErrorProvider errorProviderImpuesto;
        private ErrorProvider errorProvidertotal;
        private ErrorProvider errorProviderObservaciones;
    }
}