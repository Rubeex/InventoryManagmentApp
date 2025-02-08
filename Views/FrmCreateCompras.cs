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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace InventoryManagmentApp.Views
{
    public partial class FrmCreateCompras : Form
    {

        public readonly cProducto _cProducto;
        public readonly cProveedor _cProveedor;
        public readonly cPurchases _cPurchases;
        private bool cargando = true;
        private Product Prdcts;
        public UserDTO _user;
        public event Action CompraCreado;


        //Variables
        public decimal subtotal = 0;
        public decimal total = 0;


        public FrmCreateCompras()
        {
            InitializeComponent();
            this.CenterToScreen();
            _cProducto = new cProducto();
            _cProveedor = new cProveedor();
            _cPurchases = new cPurchases();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        public void setUserSession(UserDTO user)
        {
            _user = user;
        }

        public void cargarComboxProductos()
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

        private void FrmCreateCompras_Load(object sender, EventArgs e)
        {

            cargarComboxProductos();
            cargando = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cargando) return;

            if (jComboxProductos.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, seleccione una opción.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int Id = (int)jComboxProductos.SelectedValue;
            Prdcts = _cProducto.getProduct(Id);
            var nameProveedor = _cProveedor.getProveedorName(Prdcts.SupplierId);
            if (nameProveedor.StartsWith("❌"))
            {
                MessageBox.Show(nameProveedor, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                txtProveedor.Text = nameProveedor;
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void AgregarFilaDataGridView(ProductoCompraDTO productoCompra)
        {
            if (ProductoExistenteTabla(productoCompra.Id))
            {
                MessageBox.Show("Este producto ya ha sido agregado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                dataGridView1.Rows.Add(productoCompra.Id, productoCompra.Producto, productoCompra.Cantidad, productoCompra.Precio, productoCompra.total);

            }
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

        public void limpiar()
        {
            numericCantidad.Value = 0;
            txtProveedor.Clear();
            Prdcts = null;

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
                var ProductoCompras = new ProductoCompraDTO
                {
                    Id = Prdcts.ProductId,
                    Producto = Prdcts.ProductName,
                    Cantidad = (int)numericCantidad.Value,
                    Precio = Prdcts.Price,
                    total = (int)numericCantidad.Value * Prdcts.Price,
                };

                var listaProductoCompra = _cPurchases.agregarProductoCompra(ProductoCompras);
                AgregarFilaDataGridView(ProductoCompras);
                calcularTotalComprasDeLaTabla();
                ActivarDescuentoImpuestos();
                limpiar();
            }
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0) {

                MessageBox.Show("No se agregado ningun producto para la compra", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var Purchases = new Purchase
            {
                Discount = numericDescuento.Value,
                Taxes = numericImpuesto.Value,
                Observations = txtObservaciones.Text,
                State = "Pendiente",
                Total = Convert.ToDecimal(txtTotal.Text),
                UserId = _user.Id,
            };

            var errorProviders = new Dictionary<string, ErrorProvider>
            {
                {"Discount", errorProviderDescuento },
                {"Taxes", errorProviderImpuesto },
                {"Total", errorProvidertotal },
                {"Observations", errorProviderObservaciones},
            };


            bool isValid = ValidatorHelper.ValidateEntity(Purchases, errorProviders, this);
            if (!isValid) return;

            string resultado;
            resultado = _cPurchases.agregarCompra(Purchases);
            MessageBox.Show(resultado, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (resultado.Contains("✅"))
            {
                this.Close();
                CompraCreado?.Invoke();
            }
        }
    }
}
