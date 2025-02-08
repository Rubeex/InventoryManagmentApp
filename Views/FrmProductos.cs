using InventoryManagmentApp.Controllers;
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
    public partial class FrmProductos : Form
    {

        private readonly cProducto _cProducto;
        private readonly cProveedor _cProveedor;
        public FrmCreateProducts frmCreateProducts;
        public FrmProductos()
        {
            InitializeComponent();
            _cProducto = new cProducto();
            _cProveedor = new cProveedor();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (frmCreateProducts == null || frmCreateProducts.IsDisposed)
            {
                if (_cProveedor.CountProveedores() > 0)
                {
                    frmCreateProducts = new FrmCreateProducts();
                    frmCreateProducts.ProductoCreado += cargarListaProducto;
                    frmCreateProducts.Show();
                }
                else
                {
                    var resultado = "No hay proveedores disponibles. Por favor, cree uno antes de asignarlo.";
                    MessageBox.Show(resultado, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
            else
            {
                frmCreateProducts.BringToFront();
            }
        }

        public void cargarListaProducto()
        {
            try
            {
                var ListaProducto = _cProducto.GetProducts();
                dataGridView1.DataSource = ListaProducto;
            }
            catch (Exception ex)
            {
                var resultado = $"Error al cargar los datos: {ex.Message}";
                MessageBox.Show(resultado, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {
            cargarListaProducto();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int Id = (int)dataGridView1.SelectedRows[0].Cells["Id"].Value;
                var producto = _cProducto.getProduct(Id);

                if (frmCreateProducts == null || frmCreateProducts.IsDisposed)
                {
                    if(_cProveedor.CountProveedores() > 0)
                    {
                        frmCreateProducts = new FrmCreateProducts();
                        frmCreateProducts.Show();
                        frmCreateProducts.setProducto(producto);
                        frmCreateProducts.ProductoCreado += cargarListaProducto;
                    }
                    else
                    {
                        var resultado = "No hay proveedores disponibles. Por favor, cree uno antes de asignarlo.";
                        MessageBox.Show(resultado, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                   
                }
                else
                {
                    frmCreateProducts.BringToFront();
                }
            }
            else
            {
                var resultado = "Por favor seleccione un producto, para poder editar.";
                MessageBox.Show(resultado, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id = (int)dataGridView1.SelectedRows[0].Cells["Id"].Value;
                var resultado = _cProducto.eliminarProducto(id);
                MessageBox.Show(resultado, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (resultado.Contains("✅"))
                {
                    this.cargarListaProducto();
                }

            }
            else
            {
                var resultado = "Por favor seleccione un producto, para poder eliminar.";
                MessageBox.Show(resultado, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
