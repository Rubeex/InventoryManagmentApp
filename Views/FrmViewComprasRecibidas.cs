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
    public partial class FrmViewComprasRecibidas : Form
    {

        private readonly cUser _cUser;
        private readonly cPurchases _Purchase;

        public FrmViewComprasRecibidas()
        {
            InitializeComponent();
            this.CenterToScreen();
            _cUser = new cUser();
            _Purchase = new cPurchases();
        }

        public void setViewProdcutos(Purchase purchase)
        {
            txtID.Text = purchase.PurchasesId.ToString();
            txtComprador.Text = _cUser.getUserNameUser(purchase.UserId);
            txtDescuento.Text = purchase.Discount.ToString();
            txtImpuesto.Text = purchase.Taxes.ToString();
            txtTotal.Text = purchase.Total.ToString();
            txtObservaciones.Text = purchase.Observations;

            var ListaProductos = _Purchase.ListaProductosCompra(purchase.PurchasesProducts.ToList());
            dataGridView1.DataSource = ListaProductos;

        }
        private void FrmViewComprasRecibidas_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
