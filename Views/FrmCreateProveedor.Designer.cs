namespace InventoryManagmentApp.Views
{
    partial class FrmCreateProveedor
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
            txtProveedor = new TextBox();
            txtDireccion = new TextBox();
            label2 = new Label();
            txtEncargado = new TextBox();
            label3 = new Label();
            txtTelefono = new TextBox();
            label4 = new Label();
            label5 = new Label();
            jcomboxEstado = new ComboBox();
            btnGuardar = new Button();
            errorProviderProveedor = new ErrorProvider(components);
            errorProviderDireccion = new ErrorProvider(components);
            errorProviderEncargado = new ErrorProvider(components);
            errorProviderTelefono = new ErrorProvider(components);
            errorProviderEstado = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProviderProveedor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderDireccion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderEncargado).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderTelefono).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderEstado).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(23, 62);
            label1.Name = "label1";
            label1.Size = new Size(75, 23);
            label1.TabIndex = 0;
            label1.Text = "Proveedor";
            // 
            // txtProveedor
            // 
            txtProveedor.Location = new Point(23, 88);
            txtProveedor.Name = "txtProveedor";
            txtProveedor.Size = new Size(299, 23);
            txtProveedor.TabIndex = 1;
            txtProveedor.Tag = "SupplierName";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(23, 163);
            txtDireccion.Multiline = true;
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(299, 52);
            txtDireccion.TabIndex = 3;
            txtDireccion.Tag = "SupplierAddress";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(23, 137);
            label2.Name = "label2";
            label2.Size = new Size(70, 23);
            label2.TabIndex = 2;
            label2.Text = "Dirección";
            // 
            // txtEncargado
            // 
            txtEncargado.Location = new Point(23, 263);
            txtEncargado.Name = "txtEncargado";
            txtEncargado.Size = new Size(299, 23);
            txtEncargado.TabIndex = 5;
            txtEncargado.Tag = "ContactPerson";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(23, 237);
            label3.Name = "label3";
            label3.Size = new Size(82, 23);
            label3.TabIndex = 4;
            label3.Text = "Encargado";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(23, 337);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(299, 23);
            txtTelefono.TabIndex = 7;
            txtTelefono.Tag = "SuplierNumber";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(23, 311);
            label4.Name = "label4";
            label4.Size = new Size(64, 23);
            label4.TabIndex = 6;
            label4.Text = "Teléfono";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(29, 389);
            label5.Name = "label5";
            label5.Size = new Size(55, 23);
            label5.TabIndex = 8;
            label5.Text = "Estado";
            // 
            // jcomboxEstado
            // 
            jcomboxEstado.FormattingEnabled = true;
            jcomboxEstado.Location = new Point(23, 415);
            jcomboxEstado.Name = "jcomboxEstado";
            jcomboxEstado.Size = new Size(216, 23);
            jcomboxEstado.TabIndex = 9;
            jcomboxEstado.Tag = "State";
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.DodgerBlue;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Poppins", 9F);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(86, 478);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(164, 30);
            btnGuardar.TabIndex = 12;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // errorProviderProveedor
            // 
            errorProviderProveedor.ContainerControl = this;
            // 
            // errorProviderDireccion
            // 
            errorProviderDireccion.ContainerControl = this;
            // 
            // errorProviderEncargado
            // 
            errorProviderEncargado.ContainerControl = this;
            // 
            // errorProviderTelefono
            // 
            errorProviderTelefono.ContainerControl = this;
            // 
            // errorProviderEstado
            // 
            errorProviderEstado.ContainerControl = this;
            // 
            // FrmCreateProveedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(350, 533);
            Controls.Add(btnGuardar);
            Controls.Add(jcomboxEstado);
            Controls.Add(label5);
            Controls.Add(txtTelefono);
            Controls.Add(label4);
            Controls.Add(txtEncargado);
            Controls.Add(label3);
            Controls.Add(txtDireccion);
            Controls.Add(label2);
            Controls.Add(txtProveedor);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "FrmCreateProveedor";
            Text = "Proveedor";
            Load += FrmCreateProveedor_Load;
            ((System.ComponentModel.ISupportInitialize)errorProviderProveedor).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderDireccion).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderEncargado).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderTelefono).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderEstado).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtProveedor;
        private TextBox txtDireccion;
        private Label label2;
        private TextBox txtEncargado;
        private Label label3;
        private TextBox txtTelefono;
        private Label label4;
        private Label label5;
        private ComboBox jcomboxEstado;
        private Button btnGuardar;
        private ErrorProvider errorProviderProveedor;
        private ErrorProvider errorProviderDireccion;
        private ErrorProvider errorProviderEncargado;
        private ErrorProvider errorProviderTelefono;
        private ErrorProvider errorProviderEstado;
    }
}