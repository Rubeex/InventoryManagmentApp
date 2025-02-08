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
    public partial class FrmCreateRoles : Form
    {
        private readonly cRol _cRol;
        public event Action RolCreado;
        private int? Id = null;
        public FrmCreateRoles()
        {
            InitializeComponent();
            this.CenterToScreen();
            _cRol = new cRol();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            // Crear objeto rol
            var rol = new Rol
            {
                RolName = txtRolName.Text,
                RolDescription = txtRolDescripcion.Text
            };

            var errorProviders = new Dictionary<string, ErrorProvider>
    {
        { "RolName", errorProviderRolName },
        { "RolDescription", errorProviderRolDescription }
    };

            bool isValid = ValidatorHelper.ValidateEntity(rol, errorProviders, this);
            if (!isValid) return; 

            string resultado;

            if (Id.HasValue) 
            {
                resultado = _cRol.editarRol(Id.Value, rol.RolName, rol.RolDescription);
            }
            else 
            {
                resultado = _cRol.agregarRol(rol);
            }

            MessageBox.Show(resultado, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (resultado.Contains("✅"))
            {
                Id = null; 
                LimpiarInputs();
                this.Close();

                RolCreado?.Invoke();
            }
        }

        public void SetRol(RolDTO rolDto)
        {
            Id = rolDto.Id;
            txtRolName.Text = rolDto.Rol;
            txtRolDescripcion.Text = rolDto.Description;

        }


        public void LimpiarInputs()
        {
            txtRolName.Clear();
            txtRolDescripcion.Clear();
        }
       

        private void FrmCreateRoles_Load(object sender, EventArgs e)
        {

        }
    }
}
