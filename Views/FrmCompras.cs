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
    public partial class FrmCompras : Form
    {

        public FrmCreateCompras frmCreateCompras;
        public readonly cPurchases _cPurchases;
        public UserDTO _user;

        public FrmCompras(UserDTO user)
        {
            InitializeComponent();
            _user = user;
            _cPurchases = new cPurchases();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (frmCreateCompras == null || frmCreateCompras.IsDisposed)
            {
                frmCreateCompras = new FrmCreateCompras();
                frmCreateCompras.CompraCreado += cargarListaCompras;
                frmCreateCompras.Show();
                frmCreateCompras.setUserSession(_user);

            }
            else
            {
                frmCreateCompras.BringToFront();
            }
        }

        private void FrmCompras_Load(object sender, EventArgs e)
        {
            cargarListaCompras();
        }

        public void cargarListaCompras()
        {
            try
            {
                var listaCompras = _cPurchases.getCompras();
                dataGridView1.DataSource = listaCompras;
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
                DialogResult resultado = MessageBox.Show("¿Está seguro de que esta compra, ya se recibio?",
                    "Confirmación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    MessageBox.Show($"Compra Recibida con ID: {Id}");
                    string mensaje = _cPurchases.actualizarStockProducts(Id);

                    MessageBox.Show(mensaje, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargarListaCompras();
                }
                else
                {
                    MessageBox.Show("Operación cancelada.");
                }
            }
            else
            {
                var resultado = "Por favor seleccione una compra, para poder editar.";
                MessageBox.Show(resultado, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
