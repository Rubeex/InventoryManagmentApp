using InventoryManagmentApp.Controllers;
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
    public partial class FrmRoles : Form
    {
        private readonly cRol _cRol;
        public FrmCreateRoles frmCreateRoles;
        public FrmRoles()
        {
            InitializeComponent();
            _cRol = new cRol();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (frmCreateRoles == null || frmCreateRoles.IsDisposed)
            {
                frmCreateRoles = new FrmCreateRoles();
                frmCreateRoles.RolCreado += CargarRolesData;
                frmCreateRoles.Show();
            }
            else
            {
                frmCreateRoles.BringToFront();
            }


        }

        private void FrmRoles_Load(object sender, EventArgs e)
        {
            CargarRolesData();
        }

        public void CargarRolesData()
        {
            try
            {

                var roles = _cRol.getRoles();
                dataGridView1.DataSource = roles;
            }
            catch (Exception ex)
            {
                var resultado = $"Error al cargar los datos: {ex.Message}";
                MessageBox.Show(resultado, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id = (int)dataGridView1.SelectedRows[0].Cells["Id"].Value;
                var rolDto = _cRol.getRol(id);

                if (frmCreateRoles == null || frmCreateRoles.IsDisposed)
                {
                    frmCreateRoles = new FrmCreateRoles();
                    frmCreateRoles.SetRol(rolDto);
                    frmCreateRoles.RolCreado += CargarRolesData;
                    frmCreateRoles.Show();
                }
                else
                {
                    frmCreateRoles.BringToFront();
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
                var resultado = _cRol.eliminarRol(id);
                MessageBox.Show(resultado, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (resultado.Contains("✅"))
                {
                    this.CargarRolesData();
                }

            }
            else
            {
                var resultado = "Por favor seleccione un rol, para poder eliminar.";
                MessageBox.Show(resultado, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
