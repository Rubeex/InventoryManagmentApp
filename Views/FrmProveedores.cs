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
    public partial class FrmProveedores : Form
    {
        private readonly cProveedor _cProveedor;
        private FrmCreateProveedor frmCreateProveedor;

        public FrmProveedores()
        {
            InitializeComponent();
            _cProveedor = new cProveedor();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (frmCreateProveedor == null || frmCreateProveedor.IsDisposed)
            {
                frmCreateProveedor = new FrmCreateProveedor();
                frmCreateProveedor.ProveedorCreado += cargarListaProveedor;
                frmCreateProveedor.Show();
            }
            else
            {
                frmCreateProveedor.BringToFront();
            }
        }

        public void cargarListaProveedor()
        {
            try
            {
                var ListaProveedor = _cProveedor.getProveedores();
                dataGridView1.DataSource = ListaProveedor;
            }
            catch (Exception ex)
            {
                var resultado = $"Error al cargar los datos: {ex.Message}";
                MessageBox.Show(resultado, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FrmProveedores_Load(object sender, EventArgs e)
        {
            cargarListaProveedor();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int Id = (int)dataGridView1.SelectedRows[0].Cells["Id"].Value;
                var proveedor = _cProveedor.getProveedor(Id);

                if (frmCreateProveedor == null || frmCreateProveedor.IsDisposed)
                {
                    frmCreateProveedor = new FrmCreateProveedor();
                    frmCreateProveedor.Show();
                    frmCreateProveedor.setProveedor(proveedor);
                    frmCreateProveedor.ProveedorCreado += cargarListaProveedor;
                }
                else
                {
                    frmCreateProveedor.BringToFront();
                }
            }
            else
            {
                var resultado = "Por favor seleccione un proveedor, para poder editar.";
                MessageBox.Show(resultado, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id = (int)dataGridView1.SelectedRows[0].Cells["Id"].Value;
                var resultado = _cProveedor.eliminarProveedor(id);
                MessageBox.Show(resultado, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (resultado.Contains("✅"))
                {
                    this.cargarListaProveedor();
                }

            }
            else
            {
                var resultado = "Por favor seleccione un proveedor, para poder eliminar.";
                MessageBox.Show(resultado, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
