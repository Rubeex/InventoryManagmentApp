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

    public partial class FrmCreateUser : Form
    {
        private readonly cUser _cUser;
        private readonly cRol _cRol;
        public event Action UserCreado;
        private int? Id = null;

        public FrmCreateUser()
        {
            InitializeComponent();
            this.CenterToScreen();
            _cRol = new cRol();
            _cUser = new cUser();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void FrmCreateUser_Load(object sender, EventArgs e)
        {
            cargarComboxRoles();
        }

        public void SetUser(User user)
        {
            Id = user.UserId;
            txtName.Text = user.FirstName;
            txtLastName.Text = user.LastName;
            txtEmail.Text = user.Email;
            txtPassword.Text = user.Password;
            Console.WriteLine(user.RolId);
            jComboxRol.SelectedValue = user.RolId;
        }


        public void cargarComboxRoles()
        {
            try
            {
                var listaRoles = _cRol.getRoles();
                jComboxRol.DataSource = listaRoles;
                jComboxRol.DisplayMember = "Rol";
                jComboxRol.ValueMember = "Id";

            }
            catch (Exception ex)
            {
                var resultado = $"❌ Error al cargar el rol: {ex.Message}";
                MessageBox.Show(resultado, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            var user = new User()
            {
                FirstName = txtName.Text,
                LastName = txtLastName.Text,
                Email = txtEmail.Text,
                Password = txtPassword.Text,
                RolId = (int)jComboxRol.SelectedValue,
            };

            var errorProviders = new Dictionary<string, ErrorProvider>
            {
                {"FirstName" , errorNameProvider },
                {"LastName", errorLastNameProvider},
                {"Email", errorEmailProvider},
                {"Password", errorPasswordProvider},
                {"RolId" , errorRolProvider}
            };

            bool isValid = ValidatorHelper.ValidateEntity(user, errorProviders, this);
            if (!isValid) return;

            string resultado;

            if (Id.HasValue)
            {
                resultado = _cUser.editarUser(Id.Value,user.FirstName,user.LastName,user.Email,user.Password,user.RolId);
            }
            else
            {
                resultado = _cUser.agregarUser(user);
            }

            MessageBox.Show(resultado, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);


            if (resultado.Contains("✅"))
            {
                Id = null;
                limpiarInputs();
                this.Close();

                UserCreado?.Invoke();
            }
        }

        public void limpiarInputs()
        {
            txtName.Clear();
            txtLastName.Clear();
            txtEmail.Clear();
            txtPassword.Clear();
            jComboxRol.SelectedIndex = -1;
        }
    }
}
