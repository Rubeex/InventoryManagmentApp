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
    public partial class FrmViewStocksProducts : Form
    {

        private readonly cProducto _cProducto;
        public FrmViewStocksProducts()
        {
            InitializeComponent();
            _cProducto = new cProducto();
        }

        public void cargarListaStockExistente()
        {
            try
            {
                var ListaProductosStocks = _cProducto.GetProductsStocks();
                dataGridView1.DataSource = ListaProductosStocks;
            }
            catch (Exception ex)
            {
                var resultado = $"Error al cargar los datos: {ex.Message}";
                MessageBox.Show(resultado, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void FrmViewStocksProducts_Load(object sender, EventArgs e)
        {
            cargarListaStockExistente();
        }
    }
}
