using InventoryManagmentApp.Controllers;
using InventoryManagmentApp.DTO;
using InventoryManagmentApp.Models;
using InventoryManagmentApp.Utils;
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
    public partial class FrmCreateProducts : Form
    {
        private readonly cProducto _cProducto;
        private readonly cProveedor _cProveedor;
        public event Action ProductoCreado;
        private int? Id = null;
        public FrmCreateProducts()
        {
            InitializeComponent();
            _cProducto = new cProducto();
            _cProveedor = new cProveedor();
            this.CenterToScreen();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void cargarComboxEstados()
        {

            List<EstadosDTO> listaEstados = new List<EstadosDTO>
            {
                new EstadosDTO {Estado = "Activo"},
                new EstadosDTO {Estado = "Inactivo"}
            };

            jComboxEstado.DataSource = listaEstados;
            jComboxEstado.DisplayMember = "Estado";
            jComboxEstado.ValueMember = "Estado";
        }


        public void cargarComboxProveedores()
        {
            try
            {
                var ListaProveedores = _cProveedor.getProveedores();
                jComboxProveedor.DataSource = ListaProveedores;
                jComboxProveedor.DisplayMember = "Proveedor";
                jComboxProveedor.ValueMember = "Id";

            }
            catch (Exception ex)
            {
                var resultado = $"❌ Error al cargar el proveedor: {ex.Message}";
                MessageBox.Show(resultado, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FrmCreateProducts_Load(object sender, EventArgs e)
        {
            cargarComboxEstados();
            cargarComboxProveedores();
        }

        public void setProducto(Product producto)
        {
            Id = producto.ProductId;
            txtProducto.Text = producto.ProductName;
            numericPrecio.Value = producto.Price;
            jComboxEstado.SelectedValue = producto.State;
            numericStock.Value = producto.Stock;
            jComboxProveedor.SelectedValue = producto.SupplierId;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var Producto = new Product
            {
                ProductName = txtProducto.Text,
                Price = numericPrecio.Value,
                State = jComboxEstado.SelectedValue.ToString(),
                Stock = (int)numericStock.Value,
                SupplierId = (int)jComboxProveedor.SelectedValue
            };

            var errorProviders = new Dictionary<string, ErrorProvider>
            {
                {"ProductName", errorProductoName },
                {"Price", errorPrecio },
                {"State", errorEstado },
                {"SupplierId", errorProveedor},
            };

            bool isValid = ValidatorHelper.ValidateEntity(Producto, errorProviders, this);
            if (!isValid) return;

            string resultado;


            if (Id.HasValue)
            {
                resultado = _cProducto.editarProducto(Id.Value, Producto.ProductName, Producto.Price,
                    Producto.State, Producto.Stock,Producto.SupplierId);
            }
            else
            {
                resultado = _cProducto.agregarProducto(Producto);
            }
            MessageBox.Show(resultado, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (resultado.Contains("✅"))
            {
                Id = null;
                limpiarInputs();
                this.Close();
                ProductoCreado?.Invoke();
            }
        }

        public void limpiarInputs()
        {
            txtProducto.Clear();
            jComboxEstado.SelectedIndex = -1;
            jComboxProveedor.SelectedIndex = -1;
            numericPrecio.Value = 0;
            numericStock.Value = 0;
        }
    }
}
