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
using System.Xml.Linq;

namespace InventoryManagmentApp.Views
{
    public partial class FrmCreateProveedor : Form
    {
        private readonly cProveedor _cProveedor;
        public event Action ProveedorCreado;
        private int? Id = null;
        public FrmCreateProveedor()
        {
            InitializeComponent();
            this.CenterToScreen();
            _cProveedor = new cProveedor();
        }

        private void FrmCreateProveedor_Load(object sender, EventArgs e)
        {
            cargarComboxEstados();
        }

        public void cargarComboxEstados()
        {

            List<EstadosDTO> listaEstados = new List<EstadosDTO>
            {
                new EstadosDTO {Estado = "Activo"},
                new EstadosDTO {Estado = "Inactivo"}
            };

            jcomboxEstado.DataSource = listaEstados;
            jcomboxEstado.DisplayMember = "Estado";
            jcomboxEstado.ValueMember = "Estado";
        }


        public void setProveedor(Supplier proveedor)
        {
            Id = proveedor.SupplierId;
            txtProveedor.Text = proveedor.SupplierName;
            txtDireccion.Text = proveedor.SupplierAddress;
            txtEncargado.Text = proveedor.ContactPerson;
            txtTelefono.Text = proveedor.SuplierNumber;
            jcomboxEstado.SelectedValue = proveedor.State;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            var Proveedor = new Supplier
            {
                SupplierName = txtProveedor.Text,
                SupplierAddress = txtDireccion.Text,
                ContactPerson = txtEncargado.Text,
                SuplierNumber = txtTelefono.Text,
                State = jcomboxEstado.SelectedValue.ToString()
            };

            var errorProviders = new Dictionary<string, ErrorProvider>
            {
                {"SupplierName", errorProviderProveedor },
                {"SupplierAddress", errorProviderDireccion },
                {"ContactPerson", errorProviderEncargado },
                {"SuplierNumber", errorProviderTelefono},
                {"State",errorProviderEstado},
            };

            bool isValid = ValidatorHelper.ValidateEntity(Proveedor, errorProviders, this);
            if (!isValid) return;

            string resultado;

            if (Id.HasValue)
            {
                resultado = _cProveedor.editarProveedor(Id.Value, Proveedor.SupplierName,Proveedor.SupplierAddress,
                    Proveedor.ContactPerson,Proveedor.SuplierNumber,Proveedor.State);
            }
            else
            {
                resultado = _cProveedor.agregarProveedor(Proveedor);
            }
            MessageBox.Show(resultado, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (resultado.Contains("✅"))
            {
                Id = null;
                limpiarInputs();
                this.Close();
                ProveedorCreado?.Invoke();
            }

        }

        public void limpiarInputs()
        {
            txtProveedor.Clear();
            txtDireccion.Clear();
            txtEncargado.Clear();
            txtTelefono.Clear();
            jcomboxEstado.SelectedIndex = -1;
        }
    }
}
