namespace InventoryManagmentApp.Views
{
    partial class FrmRoles
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
            btnEliminar = new Button();
            btnEditar = new Button();
            textBox1 = new TextBox();
            label2 = new Label();
            btnAgregar = new Button();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = SystemColors.Control;
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Poppins", 9F);
            btnEliminar.ForeColor = Color.Transparent;
            btnEliminar.Image = Properties.Resources.delete;
            btnEliminar.Location = new Point(138, 70);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(80, 32);
            btnEliminar.TabIndex = 12;
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = SystemColors.Control;
            btnEditar.Cursor = Cursors.Hand;
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Poppins", 9F);
            btnEditar.ForeColor = Color.Transparent;
            btnEditar.Image = Properties.Resources.edit1;
            btnEditar.Location = new Point(41, 70);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(80, 32);
            btnEditar.TabIndex = 11;
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(492, 78);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(194, 23);
            textBox1.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins", 9F);
            label2.Location = new Point(434, 79);
            label2.Name = "label2";
            label2.Size = new Size(54, 22);
            label2.TabIndex = 9;
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
            btnAgregar.Location = new Point(636, 24);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(50, 33);
            btnAgregar.TabIndex = 8;
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 9F);
            label1.Location = new Point(34, 24);
            label1.Name = "label1";
            label1.Size = new Size(88, 22);
            label1.TabIndex = 7;
            label1.Text = "Lista de Roles";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(34, 117);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(652, 231);
            dataGridView1.TabIndex = 13;
            // 
            // FrmRoles
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(719, 366);
            Controls.Add(dataGridView1);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(btnAgregar);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmRoles";
            Text = "FrmRoles";
            Load += FrmRoles_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEliminar;
        private Button btnEditar;
        private TextBox textBox1;
        private Label label2;
        private Button btnAgregar;
        private Label label1;
        private DataGridView dataGridView1;
    }
}