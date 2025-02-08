namespace InventoryManagmentApp.Views
{
    partial class FrmCreateRoles
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
            txtRolName = new TextBox();
            txtRolDescripcion = new TextBox();
            btnGuardar = new Button();
            errorProviderRolName = new ErrorProvider(components);
            errorProviderRolDescription = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProviderRolName).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderRolDescription).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 9.75F);
            label1.Location = new Point(27, 60);
            label1.Name = "label1";
            label1.Size = new Size(29, 23);
            label1.TabIndex = 0;
            label1.Text = "Rol";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins", 9.75F);
            label2.Location = new Point(27, 144);
            label2.Name = "label2";
            label2.Size = new Size(86, 23);
            label2.TabIndex = 1;
            label2.Text = "Descripción";
            // 
            // txtRolName
            // 
            txtRolName.Font = new Font("Poppins", 9.75F);
            txtRolName.Location = new Point(27, 88);
            txtRolName.Margin = new Padding(3, 5, 3, 5);
            txtRolName.Name = "txtRolName";
            txtRolName.Size = new Size(284, 27);
            txtRolName.TabIndex = 2;
            txtRolName.Tag = "RolName";
            // 
            // txtRolDescripcion
            // 
            txtRolDescripcion.Location = new Point(27, 170);
            txtRolDescripcion.Multiline = true;
            txtRolDescripcion.Name = "txtRolDescripcion";
            txtRolDescripcion.Size = new Size(284, 93);
            txtRolDescripcion.TabIndex = 3;
            txtRolDescripcion.Tag = "RolDescription";
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.DodgerBlue;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Poppins", 9F);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(79, 313);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(164, 30);
            btnGuardar.TabIndex = 11;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // errorProviderRolName
            // 
            errorProviderRolName.ContainerControl = this;
            // 
            // errorProviderRolDescription
            // 
            errorProviderRolDescription.ContainerControl = this;
            // 
            // FrmCreateRoles
            // 
            AutoScaleDimensions = new SizeF(8F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(342, 375);
            Controls.Add(btnGuardar);
            Controls.Add(txtRolDescripcion);
            Controls.Add(txtRolName);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Poppins", 9.75F);
            Margin = new Padding(3, 5, 3, 5);
            MaximizeBox = false;
            Name = "FrmCreateRoles";
            Text = "Rol";
            Load += FrmCreateRoles_Load;
            ((System.ComponentModel.ISupportInitialize)errorProviderRolName).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderRolDescription).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtRolName;
        private TextBox txtRolDescripcion;
        private Button btnGuardar;
        private ErrorProvider errorProviderRolName;
        private ErrorProvider errorProviderRolDescription;
    }
}