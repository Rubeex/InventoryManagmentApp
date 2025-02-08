using InventoryManagmentApp.Controllers;
using InventoryManagmentApp.DTO;
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
    public partial class FrmVentas : Form
    {
        public FrmCreateVentas frmCreateVentas;
        public UserDTO _user;
        private readonly cSales _cSales;

        public FrmVentas(UserDTO user)
        {
            InitializeComponent();
            _user = user;
            _cSales = new cSales();

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (frmCreateVentas == null || frmCreateVentas.IsDisposed)
            {
                frmCreateVentas = new FrmCreateVentas();
                frmCreateVentas.VentaCreado += cargarListaVentas;
                frmCreateVentas.Show();
                frmCreateVentas.setUserSession(_user);

            }
            else
            {
                frmCreateVentas.BringToFront();
            }
        }


        public void cargarListaVentas()
        {
            try
            {
                var listaVentas = _cSales.getVentas();
                dataGridView1.DataSource = listaVentas;
            }
            catch (Exception ex)
            {
                var resultado = $"Error al cargar los datos: {ex.Message}";
                MessageBox.Show(resultado, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void FrmVentas_Load(object sender, EventArgs e)
        {
            cargarListaVentas();
        }
    }
}
