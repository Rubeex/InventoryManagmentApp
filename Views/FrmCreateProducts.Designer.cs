namespace InventoryManagmentApp.Views
{
    partial class FrmCreateProducts
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
            txtProducto = new TextBox();
            label2 = new Label();
            numericPrecio = new NumericUpDown();
            label3 = new Label();
            jComboxEstado = new ComboBox();
            label4 = new Label();
            numericStock = new NumericUpDown();
            label5 = new Label();
            jComboxProveedor = new ComboBox();
            btnGuardar = new Button();
            errorProductoName = new ErrorProvider(components);
            errorPrecio = new ErrorProvider(components);
            errorEstado = new ErrorProvider(components);
            errorProveedor = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)numericPrecio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProductoName).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorPrecio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorEstado).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProveedor).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(24, 44);
            label1.Name = "label1";
            label1.Size = new Size(65, 22);
            label1.TabIndex = 0;
            label1.Text = "Producto";
            // 
            // txtProducto
            // 
            txtProducto.Location = new Point(24, 69);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(357, 23);
            txtProducto.TabIndex = 1;
            txtProducto.Tag = "ProductName";
            txtProducto.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(24, 113);
            label2.Name = "label2";
            label2.Size = new Size(47, 22);
            label2.TabIndex = 2;
            label2.Text = "Precio";
            // 
            // numericPrecio
            // 
            numericPrecio.DecimalPlaces = 2;
            numericPrecio.Location = new Point(24, 147);
            numericPrecio.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericPrecio.Name = "numericPrecio";
            numericPrecio.Size = new Size(166, 23);
            numericPrecio.TabIndex = 3;
            numericPrecio.Tag = "Price";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(236, 113);
            label3.Name = "label3";
            label3.Size = new Size(50, 22);
            label3.TabIndex = 4;
            label3.Text = "Estado";
            // 
            // jComboxEstado
            // 
            jComboxEstado.FormattingEnabled = true;
            jComboxEstado.Location = new Point(236, 147);
            jComboxEstado.Name = "jComboxEstado";
            jComboxEstado.Size = new Size(145, 23);
            jComboxEstado.TabIndex = 5;
            jComboxEstado.Tag = "State";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(24, 192);
            label4.Name = "label4";
            label4.Size = new Size(42, 22);
            label4.TabIndex = 6;
            label4.Text = "Stock";
            // 
            // numericStock
            // 
            numericStock.Enabled = false;
            numericStock.Location = new Point(24, 227);
            numericStock.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericStock.Name = "numericStock";
            numericStock.ReadOnly = true;
            numericStock.Size = new Size(166, 23);
            numericStock.TabIndex = 7;
            numericStock.Tag = "Stock";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(24, 275);
            label5.Name = "label5";
            label5.Size = new Size(72, 22);
            label5.TabIndex = 8;
            label5.Text = "Proveedor";
            // 
            // jComboxProveedor
            // 
            jComboxProveedor.FormattingEnabled = true;
            jComboxProveedor.Location = new Point(24, 309);
            jComboxProveedor.Name = "jComboxProveedor";
            jComboxProveedor.Size = new Size(166, 23);
            jComboxProveedor.TabIndex = 9;
            jComboxProveedor.Tag = "SupplierId";
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.DodgerBlue;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Poppins", 9F);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(103, 355);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(164, 30);
            btnGuardar.TabIndex = 13;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // errorProductoName
            // 
            errorProductoName.ContainerControl = this;
            // 
            // errorPrecio
            // 
            errorPrecio.ContainerControl = this;
            // 
            // errorEstado
            // 
            errorEstado.ContainerControl = this;
            // 
            // errorProveedor
            // 
            errorProveedor.ContainerControl = this;
            // 
            // FrmCreateProducts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(404, 401);
            Controls.Add(btnGuardar);
            Controls.Add(jComboxProveedor);
            Controls.Add(label5);
            Controls.Add(numericStock);
            Controls.Add(label4);
            Controls.Add(jComboxEstado);
            Controls.Add(label3);
            Controls.Add(numericPrecio);
            Controls.Add(label2);
            Controls.Add(txtProducto);
            Controls.Add(label1);
            Name = "FrmCreateProducts";
            Text = "Products";
            Load += FrmCreateProducts_Load;
            ((System.ComponentModel.ISupportInitialize)numericPrecio).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProductoName).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorPrecio).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorEstado).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProveedor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtProducto;
        private Label label2;
        private NumericUpDown numericPrecio;
        private Label label3;
        private ComboBox jComboxEstado;
        private Label label4;
        private NumericUpDown numericStock;
        private Label label5;
        private ComboBox jComboxProveedor;
        private Button btnGuardar;
        private ErrorProvider errorProductoName;
        private ErrorProvider errorPrecio;
        private ErrorProvider errorEstado;
        private ErrorProvider errorProveedor;
    }
}