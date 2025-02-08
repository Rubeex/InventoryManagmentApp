using InventoryManagmentApp.Controllers;
using InventoryManagmentApp.DTO;
using InventoryManagmentApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagmentApp.Views
{
    public partial class FrmUsuarios : Form
    {
        private readonly cUser _cUser;
        private FrmCreateUser frmCreateUser;
        public FrmUsuarios()
        {
            InitializeComponent();
            _cUser = new cUser();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (frmCreateUser == null || frmCreateUser.IsDisposed)
            {
                frmCreateUser = new FrmCreateUser();
                frmCreateUser.UserCreado += cargarListaUsuarios;
                frmCreateUser.Show();
            }
            else
            {
                frmCreateUser.BringToFront();
            }

        }

        public void cargarListaUsuarios()
        {
            try
            {
                var ListaUsuarios = _cUser.getUsers();
                dataGridView1.DataSource = ListaUsuarios;
            }
            catch (Exception ex)
            {
                var resultado = $"Error al cargar los datos: {ex.Message}";
                MessageBox.Show(resultado, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            cargarListaUsuarios();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int Id = (int)dataGridView1.SelectedRows[0].Cells["Id"].Value;
                var user = _cUser.getUser(Id);

                if (frmCreateUser == null || frmCreateUser.IsDisposed)
                {
                    frmCreateUser = new FrmCreateUser();
                    frmCreateUser.Show();
                    frmCreateUser.SetUser(user);
                    frmCreateUser.UserCreado += cargarListaUsuarios;
                }
                else
                {
                    frmCreateUser.BringToFront();
                }
            }
            else
            {
                var resultado = "Por favor seleccione un rol, para poder editar.";
                MessageBox.Show(resultado, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id = (int)dataGridView1.SelectedRows[0].Cells["Id"].Value;
                var resultado = _cUser.eliminarUser(id);
                MessageBox.Show(resultado, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (resultado.Contains("✅"))
                {
                    this.cargarListaUsuarios();
                }

            }
            else
            {
                var resultado = "Por favor seleccione un usuario, para poder eliminar.";
                MessageBox.Show(resultado, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
