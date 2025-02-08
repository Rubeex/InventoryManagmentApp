using InventoryManagmentApp.Controllers;
using InventoryManagmentApp.Models;
using InventoryManagmentApp.Utils;
using InventoryManagmentApp.Views;
using Microsoft.VisualBasic.ApplicationServices;

namespace InventoryManagmentApp
{
    public partial class FrmLogin : Form
    {
        private readonly cLogin clogin;
        public FrmLogin()
        {
            InitializeComponent();
            this.CenterToParent();
            MaximizeBox = false;
            clogin = new cLogin();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var login = new Login()
            {
                Email = txtEmail.Text,
                Password = txtPassword.Text,
            };

            var errorProviders = new Dictionary<string, ErrorProvider>
            {
                {"Email",errorEmail },
                {"Password", errorPassword}
            };


            bool isValid = ValidatorHelper.ValidateEntity(login, errorProviders, this);
            if (!isValid) return;

            var resultado = clogin.Login(login);

            
            MessageBox.Show(resultado, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (resultado.Contains("✅"))
            {
                var userSession = clogin.getUser(login.Email);

                FrmDashboard frmDashboard = new FrmDashboard();
                frmDashboard.Show();
                frmDashboard.setUser(userSession);
                this.Hide();
            }

        }
    }
}
