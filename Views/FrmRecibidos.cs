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
    public partial class FrmRecibidos : Form
    {

        private readonly cPurchases _cPurchase;
        public FrmViewComprasRecibidas frmViewCompras;
        public FrmRecibidos()
        {
            InitializeComponent();
            _cPurchase = new cPurchases();
        }

        private void FrmRecibidos_Load(object sender, EventArgs e)
        {
            CargarListaDeComprasRecibidas();
        }

        public void CargarListaDeComprasRecibidas()
        {
            try
            {
                var ListaComprasRecibidas = _cPurchase.getComprasRecibidas();
                dataGridView1.DataSource = ListaComprasRecibidas;

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
                int Id = (int)dataGridView1.SelectedRows[0].Cells["Id"].Value;
                var Purchase = _cPurchase.getPurchs(Id);
                if (frmViewCompras == null || frmViewCompras.IsDisposed)
                {
                    frmViewCompras = new FrmViewComprasRecibidas();
                    frmViewCompras.Show();
                    frmViewCompras.setViewProdcutos(Purchase);
                }
                else
                {
                    frmViewCompras.BringToFront();
                }

            }
            else
            {
                var resultado = "Por favor seleccione una compra, para poder observar.";
                MessageBox.Show(resultado, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
