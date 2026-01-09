using Forms_individuales_proyecto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsFinalProyect;

namespace WinFormsFinalProject
{
    public partial class FormMovie7 : Form
    {
        private string userHere;
        public int id;
        public FormMovie7(string img, string user)
        {
            userHere = user;
            InitializeComponent();
            this.pictureBox_Movie1.Image = System.Drawing.Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "images", img));
            btnAddCartMovie7.Visible = true;

            try
            {
                AdmonDB obj = new AdmonDB();
                obj.Connect();

                Products aux = obj.consultaProductosImg(img);

                btnAddCartMovie7.Visible = true;
                this.txtPrice7.Text = Convert.ToString(aux.Precio);
                this.txtStock7.Text = Convert.ToString(aux.Stock);
                this.rtxtMovie7.Text = aux.About;
                id = aux.Id;

                obj.Disconnect();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al encontrar la pelicula: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rtxtMovie7_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormMovie7_Load(object sender, EventArgs e)
        {

        }

        private void btnAddCartMovie7_Click(object sender, EventArgs e)
        {
            if (userHere == "guest" || userHere == "Guest")
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
                CompraPeliculas art = new CompraPeliculas(id, 1);
                FormMainPage.listaPeliculas.Add(art);
                FormMainPage mp = new FormMainPage(userHere, 0);
                this.Hide();
                mp.ShowDialog();
            }
        }
    }
}
