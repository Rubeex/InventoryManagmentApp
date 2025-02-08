using InventoryManagmentApp.Controllers;
using InventoryManagmentApp.DTO;
using InventoryManagmentApp.Models;
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

namespace InventoryManagmentApp.Views
{
    public partial class FrmDashboard : Form
    {
        public UserDTO _user;
        public FrmDashboard()
        {
            InitializeComponent();

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmDashboard_Load(object sender, EventArgs e)
        {
            AbrirFormHijo(new FrmHome());
            lblRutas.Text = "/Dashboard";


        }

        private void AbrirFormInicio(object formulario)
        {
            Form formH = formulario as Form;
            formH.TopLevel = false;
            formH.Dock = DockStyle.Fill;
            this.panelPadre.Controls.Add(formH);
            this.panelPadre.Tag = formH;
            formH.Show();
        }

        public void setUser(UserDTO user)
        {
            _user = user;
            lblNameSession.Text = $"{_user.Apellido} --- {user.Rol}";
            GestionRoles(user.Rol);

        }


        public void GestionRoles(string Rol)
        {

            if (Rol == "Secretaria")
            {
                btnRoles.Visible = false;
                pictureBox1.Visible = false;
                pictureBox10.Visible = false;
                btnVentas.Visible = false;
                btnCompras.Visible = false;
                btnRecibido.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox7.Visible = false;
                btnUsuario.Visible = false;
    

            }

            if (Rol == "Comprador")
            {
                btnRoles.Visible = false;
          
                pictureBox1.Visible = false;
                btnProductos.Visible = false;
                pictureBox10.Visible = false;
                btnVentas.Visible = false;
        
                pictureBox7.Visible = false;
                btnUsuario.Visible = false;
                pictureBox9.Visible = false;
                btnProveedor.Visible = false;
                pictureBox8.Visible = false;

            }

            if (Rol == "Vendedor")
            {
                btnRoles.Visible = false;
                pictureBox1.Visible = false;
                btnProductos.Visible = false;
                pictureBox10.Visible = false;
                btnCompras.Visible = false;
                btnRecibido.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                btnProveedor.Visible = false;
                pictureBox8.Visible = false;
                btnUsuario.Visible = false;
                pictureBox9.Visible = false;

            }

        }

        private void AbrirFormHijo(object formulario)
        {
            if (this.panelPadre.Controls.Count > 0)
            {
                this.panelPadre.Controls.RemoveAt(0);
            }

            Form formH = formulario as Form;
            formH.TopLevel = false;
            formH.Dock = DockStyle.Fill;
            this.panelPadre.Controls.Add(formH);
            this.panelPadre.Tag = formH;
            formH.Show();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new FrmHome());
            lblRutas.Text = "/Dashboard";
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new FrmCompras(_user));
            lblRutas.Text = "/Compras";


        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new FrmUsuarios());
            lblRutas.Text = "/Usuarios";


        }

        private void btnRoles_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new FrmRoles());
            lblRutas.Text = "/Roles";

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnProveedor_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new FrmProveedores());
            lblRutas.Text = "/Proveedor";

        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new FrmProductos());
            lblRutas.Text = "/Productos";


        }

        private void btnRecibido_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new FrmRecibidos());
            lblRutas.Text = "/Recibidos";
        }

        private void btnStocks_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new FrmViewStocksProducts());
            lblRutas.Text = "/stocks";
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new FrmVentas(_user));
            lblRutas.Text = "/ventas";
        }

        private void btnConfiguration_Click(object sender, EventArgs e)
        {



            this.Hide(); // Oculta la ventana actual
            FrmLogin login = new FrmLogin();
            login.Show();
        }
    }
}
