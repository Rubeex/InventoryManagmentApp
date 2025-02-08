using InventoryManagmentApp.Controllers;
using InventoryManagmentApp.DTO;
using InventoryManagmentApp.Models;
using InventoryManagmentApp.Utils;
using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class FrmCreateVentas : Form
    {
        private readonly cProducto _cProducto;
        private readonly cSales _cSales;
        private bool cargando = true;
        private Product Prdcts;
        public UserDTO _user;
        public event Action VentaCreado;


        //Variables
        public decimal subtotal = 0;
        public decimal total = 0;

        public FrmCreateVentas()

        {
            InitializeComponent();
            this.CenterToScreen();
            _cProducto = new cProducto();
            _cSales = new cSales();
        }

        public void cargarProductos()
        {
            try
            {
                var ListaProductos = _cProducto.GetProductosNecesarios();
                jComboxProductos.DataSource = ListaProductos;
                jComboxProductos.DisplayMember = "Producto";
                jComboxProductos.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                var resultado = $"Error al cargar los datos: {ex.Message}";
                MessageBox.Show(resultado, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void FrmCreateVentas_Load(object sender, EventArgs e)
        {
            cargarProductos();
            cargando = false;
        }

        public void calcularTotalComprasDeLaTabla()
        {
            subtotal = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Total"].Value != null)
                {
                    if (decimal.TryParse(row.Cells["Total"].Value.ToString(), out decimal total))
                    {
                        subtotal += total;
                    }
                }
            }

            txtSubtotal.Text = subtotal.ToString();
            calcularTotalFinal();

        }

        private void calcularTotalFinal()
        {
            decimal descuento = numericDescuento.Value;
            decimal impuesto = numericImpuesto.Value;

            decimal totalConDescuento = subtotal - (subtotal * descuento);
            total = totalConDescuento + (totalConDescuento * impuesto);

            txtTotal.Text = total.ToString("0.00");
        }

        public void ActivarDescuentoImpuestos()
        {
            numericDescuento.Enabled = true;
            numericImpuesto.Enabled = true;
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (Prdcts == null)
            {
                MessageBox.Show("Seleccione el Producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (numericCantidad.Value == 0)
            {
                MessageBox.Show("Cantidad debe ser mayor a 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if ((int)numericCantidad.Value <= Prdcts.Stock)
                {
                    var ProductoVentas = new ProductoVentaDTO
                    {
                        Id = Prdcts.ProductId,
                        Producto = Prdcts.ProductName,
                        Cantidad = (int)numericCantidad.Value,
                        Precio = Prdcts.Price,
                        Total = (int)numericCantidad.Value * Prdcts.Price,
                    };

                    var listaProductoVenta = _cSales.agregarProductoVenta(ProductoVentas);
                    AgregarFilaDataGridView(ProductoVentas);
                    calcularTotalComprasDeLaTabla();
                    ActivarDescuentoImpuestos();
                    limpiar();
                }
                else
                {
                    MessageBox.Show("No hay suficiente Stock, para realizar la venta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


            }


        }

        public void limpiar()
        {
            numericCantidad.Value = 0;
            txtCliente.Clear();
            Prdcts = null;

        }

        private bool ProductoExistenteTabla(int Id)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Id"].Value != null && (int)row.Cells["Id"].Value == Id)
                {
                    return true;
                }

            }
            return false;
        }

        private void AgregarFilaDataGridView(ProductoVentaDTO productoVenta)
        {
            if (ProductoExistenteTabla(productoVenta.Id))
            {
                MessageBox.Show("Este producto ya ha sido agregado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                dataGridView1.Rows.Add(productoVenta.Id, productoVenta.Producto, productoVenta.Cantidad, productoVenta.Precio, productoVenta.Total);

            }
        }


        private void jComboxProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cargando) return;

            if (jComboxProductos.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, seleccione una opción.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int Id = (int)jComboxProductos.SelectedValue;
            Prdcts = _cProducto.getProductVentas(Id);

        }

        private void numericDescuento_ValueChanged(object sender, EventArgs e)
        {
            txtDescuento.Text = numericDescuento.Value.ToString();
            calcularTotalFinal();
        }

        private void numericImpuesto_ValueChanged(object sender, EventArgs e)
        {
            txtImpuesto.Text = numericImpuesto.Value.ToString();
            calcularTotalFinal();
        }
        public void setUserSession(UserDTO user)
        {
            _user = user;
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("No se agregado ningun producto para la venta", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var Sale = new Sale
            {

                Client = txtCliente.Text,
                Total = Convert.ToDecimal(txtTotal.Text),
                UserId = _user.Id,
            };


            var errorProviders = new Dictionary<string, ErrorProvider>
            {
                {"Total", errorProvidertotal },
                {"Client", errorProviderClient},
            };

            bool isValid = ValidatorHelper.ValidateEntity(Sale, errorProviders, this);
            if (!isValid) return;
            string resultado;
            resultado = _cSales.agregarVenta(Sale);
            MessageBox.Show(resultado, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (resultado.Contains("✅"))
            {
                this.Close();
                VentaCreado?.Invoke();
            }
        }
    }
}
