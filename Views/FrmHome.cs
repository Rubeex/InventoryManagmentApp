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
    public partial class FrmHome : Form
    {
        private readonly cUser _cUser;
        private readonly cProveedor _cProveedor;
        private readonly cProducto _cProducto;
        private readonly cPurchases _cPurchases;
        private readonly cSales _cSales;
        public FrmHome()
        {
            InitializeComponent();
            _cUser = new cUser();
            _cProveedor = new cProveedor();
            _cProducto = new cProducto();
            _cPurchases = new cPurchases();
            _cSales = new cSales();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmHome_Load(object sender, EventArgs e)
        {
            lblCountUsers.Text = _cUser.CountUsers().ToString();
            lblCountProveedores.Text = _cProveedor.CountProveedores().ToString();
            lblCountProductos.Text = _cProducto.CountPrductos().ToString();
            lblCountRecibidos.Text = _cPurchases.CountRecibidosCompras().ToString();
            lblCountCompras.Text = _cPurchases.CountCompras().ToString();
            lblTotalCompras.Text = _cPurchases.totalComprasRecibidas().ToString();
            lblCountVentas.Text = _cSales.CountVentas().ToString();
            lblTotalVentas.Text = _cSales.totalVentas().ToString();
        }

        private void lblTotalCompras_Click(object sender, EventArgs e)
        {

        }
    }
}
