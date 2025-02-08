namespace InventoryManagmentApp.Views
{
    partial class FrmUsuarios
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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            btnAgregar = new Button();
            label2 = new Label();
            textBox1 = new TextBox();
            btnEditar = new Button();
            btnEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(34, 117);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(652, 231);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 9F);
            label1.Location = new Point(34, 24);
            label1.Name = "label1";
            label1.Size = new Size(109, 22);
            label1.TabIndex = 1;
            label1.Text = "Lista de Usuarios";
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
            btnAgregar.TabIndex = 2;
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins", 9F);
            label2.Location = new Point(434, 79);
            label2.Name = "label2";
            label2.Size = new Size(54, 22);
            label2.TabIndex = 3;
            label2.Text = "Search:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(492, 78);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(194, 23);
            textBox1.TabIndex = 4;
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
            btnEditar.TabIndex = 5;
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
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
            btnEliminar.TabIndex = 6;
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // FrmUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(719, 366);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(btnAgregar);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmUsuarios";
            Text = "FrmUsuarios";
            Load += FrmUsuarios_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Button btnAgregar;
        private Label label2;
        private TextBox textBox1;
        private Button btnEditar;
        private Button btnEliminar;
    }
}