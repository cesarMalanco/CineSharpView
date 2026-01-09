using Forms_individuales_proyecto;
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

namespace WinFormsFinalProject
{
    public partial class FormHome : Form
    {
        private string userHere;
        public FormHome()
        {
            InitializeComponent();
        }

        public FormHome(string user)
        {
            InitializeComponent();
            userHere = user;
            labeln.Text = "¡Bienvenid@ " + user + "!";

        }

        private void FormHome_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void labeln_Click(object sender, EventArgs e)
        {

        }

        private void cart_Click(object sender, EventArgs e)
        {
            Frm_Carrito cart = new Frm_Carrito(userHere);
            this.Hide();
            cart.ShowDialog();
        }

        private void cart_Click_1(object sender, EventArgs e)
        {
            string guest = "guest";
            if (userHere == guest)
            {
                DialogResult result = MessageBox.Show("¿Desea ingresar a su cuenta para comprar?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    FormLoginPage loginPage = new FormLoginPage();// Crete instance for Login Page
                    this.Hide(); // Hide this
                    loginPage.ShowDialog(); // Show Login Page
                }
            }
            else
            {
                Frm_Carrito cart = new Frm_Carrito(userHere);
                this.Hide();
                cart.ShowDialog();
            }
        }
    }
}
