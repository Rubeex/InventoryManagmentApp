namespace InventoryManagmentApp.Views
{
    partial class FrmCreateUser
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
            label5 = new Label();
            txtName = new TextBox();
            txtLastName = new TextBox();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            jComboxRol = new ComboBox();
            btnGuardar = new Button();
            errorNameProvider = new ErrorProvider(components);
            errorLastNameProvider = new ErrorProvider(components);
            errorEmailProvider = new ErrorProvider(components);
            errorRolProvider = new ErrorProvider(components);
            errorPasswordProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorNameProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorLastNameProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorEmailProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorRolProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorPasswordProvider).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 9.75F);
            label1.ImageAlign = ContentAlignment.BottomCenter;
            label1.Location = new Point(28, 74);
            label1.Name = "label1";
            label1.Size = new Size(64, 23);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins", 9.75F);
            label2.Location = new Point(28, 143);
            label2.Name = "label2";
            label2.Size = new Size(64, 23);
            label2.TabIndex = 1;
            label2.Text = "Apellido:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poppins", 9.75F);
            label3.Location = new Point(28, 226);
            label3.Name = "label3";
            label3.Size = new Size(47, 23);
            label3.TabIndex = 2;
            label3.Text = "Email:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Poppins", 9.75F);
            label4.Location = new Point(28, 305);
            label4.Name = "label4";
            label4.Size = new Size(89, 23);
            label4.TabIndex = 3;
            label4.Text = "Contraseña:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Poppins", 9.75F);
            label5.Location = new Point(28, 400);
            label5.Name = "label5";
            label5.Size = new Size(31, 23);
            label5.TabIndex = 4;
            label5.Text = "Rol:";
            // 
            // txtName
            // 
            txtName.Location = new Point(28, 100);
            txtName.Name = "txtName";
            txtName.Size = new Size(324, 23);
            txtName.TabIndex = 5;
            txtName.Tag = "FirstName";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(28, 178);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(324, 23);
            txtLastName.TabIndex = 6;
            txtLastName.Tag = "LastName";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(28, 254);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(324, 23);
            txtEmail.TabIndex = 7;
            txtEmail.Tag = "Email";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(28, 347);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(324, 23);
            txtPassword.TabIndex = 8;
            txtPassword.Tag = "Password";
            txtPassword.UseSystemPasswordChar = true;
            // 
            // jComboxRol
            // 
            jComboxRol.FormattingEnabled = true;
            jComboxRol.Location = new Point(28, 442);
            jComboxRol.Name = "jComboxRol";
            jComboxRol.Size = new Size(233, 23);
            jComboxRol.TabIndex = 9;
            jComboxRol.Tag = "RolId";
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.DodgerBlue;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Poppins", 9F);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(108, 520);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(164, 30);
            btnGuardar.TabIndex = 10;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // errorNameProvider
            // 
            errorNameProvider.ContainerControl = this;
            // 
            // errorLastNameProvider
            // 
            errorLastNameProvider.ContainerControl = this;
            // 
            // errorEmailProvider
            // 
            errorEmailProvider.ContainerControl = this;
            // 
            // errorRolProvider
            // 
            errorRolProvider.ContainerControl = this;
            // 
            // errorPasswordProvider
            // 
            errorPasswordProvider.ContainerControl = this;
            // 
            // FrmCreateUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(383, 575);
            Controls.Add(btnGuardar);
            Controls.Add(jComboxRol);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(txtLastName);
            Controls.Add(txtName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "FrmCreateUser";
            Text = "User";
            Load += FrmCreateUser_Load;
            ((System.ComponentModel.ISupportInitialize)errorNameProvider).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorLastNameProvider).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorEmailProvider).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorRolProvider).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorPasswordProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtName;
        private TextBox txtLastName;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private ComboBox jComboxRol;
        private Button btnGuardar;
        private ErrorProvider errorNameProvider;
        private ErrorProvider errorLastNameProvider;
        private ErrorProvider errorEmailProvider;
        private ErrorProvider errorRolProvider;
        private ErrorProvider errorPasswordProvider;
    }
}