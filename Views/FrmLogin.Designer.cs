namespace InventoryManagmentApp
{
    partial class FrmLogin
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
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            errorEmail = new ErrorProvider(components);
            errorPassword = new ErrorProvider(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorEmail).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorPassword).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DodgerBlue;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.ForeColor = SystemColors.ControlText;
            panel1.Location = new Point(-2, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 380);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(72, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(137, 113);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Century Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(179, 287);
            label3.Name = "label3";
            label3.Size = new Size(89, 32);
            label3.TabIndex = 3;
            label3.Text = "Developed by \r\nAlejandroV\r\n";
            label3.TextAlign = ContentAlignment.TopRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(134, 140);
            label2.Name = "label2";
            label2.Size = new Size(151, 100);
            label2.TabIndex = 2;
            label2.Text = "Welcome to \r\nthe Inventory \r\nManagment\r\nSystem\r\n";
            label2.TextAlign = ContentAlignment.MiddleRight;
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DodgerBlue;
            label1.Location = new Point(337, 74);
            label1.Name = "label1";
            label1.Size = new Size(181, 21);
            label1.TabIndex = 1;
            label1.Text = "Login to your account";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(337, 117);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(218, 25);
            txtEmail.TabIndex = 2;
            txtEmail.Tag = "Email";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(337, 162);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(218, 25);
            txtPassword.TabIndex = 3;
            txtPassword.Tag = "Password";
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.DodgerBlue;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(337, 209);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(103, 30);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Sign In";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.user;
            pictureBox2.Location = new Point(308, 117);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(23, 25);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.padlock;
            pictureBox3.Location = new Point(308, 162);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(23, 25);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // errorEmail
            // 
            errorEmail.ContainerControl = this;
            // 
            // errorPassword
            // 
            errorPassword.ContainerControl = this;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 341);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "FrmLogin";
            Text = "Login";
            Load += FrmLogin_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorEmail).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorPassword).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private Button btnLogin;
        private Label label3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private ErrorProvider errorEmail;
        private ErrorProvider errorPassword;
    }
}
