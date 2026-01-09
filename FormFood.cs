using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Forms_individuales_proyecto;
using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using WinFormsFinalProyect;
using System.Data.SqlClient;

namespace WinFormsFinalProject
{
    public partial class FormFood : Form
    {
        private string user;
        private FormMainPage MainPage;
        //public List<int> dulcesID = new List<int>();
        public int[] idsOrdenados;

        public FormFood()
        {
            InitializeComponent();
        }

        public FormFood(string sendedUser)
        {
            InitializeComponent();
            this.user = sendedUser;
            fill_tableFood();
        }

        public FormFood(FormMainPage mainPage)
        {
            InitializeComponent();
            MainPage = mainPage;
            fill_tableFood();
        }
        
        MySqlConnection conexion = new MySqlConnection("Server=localhost; Database=cine; User=root; Password=; SslMode=none;");

        public void fill_tableFood()
        {
            
            string consulta = "SELECT * FROM sweets Order By stock ASC"; //string consulta = "SELECT * FROM sweets Order By stock, id ASC";
            MySqlDataAdapter adapter1 = new MySqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();
            adapter1.Fill(dt);
            gridPelicula.DataSource = dt;

            consulta = "SELECT id FROM sweets Order By stock ASC";
            //MySqlDataAdapter adapter2 = new MySqlDataAdapter(consulta, conexion);
            List<int> dulcesID = new List<int>();
            //DataSet ds = new DataSet(); 
            //adapter2.Fill(ds);
            //ds.
            using (conexion)
            {
                conexion.Open();

                using (MySqlCommand command = new MySqlCommand(consulta, conexion))
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        dulcesID.Add(reader.GetInt32(0)); // Agregar el Id a la lista
                    }
                    idsOrdenados = dulcesID.ToArray();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //agregar a carrito palomitas de mantequilla chicas
            string guest = "guest";
            if (user == guest)
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
                CompraDulces art = new CompraDulces(idsOrdenados[0], 1);
                FormMainPage.listaDulces.Add(art);
                FormFood food = new FormFood();
                food.TopLevel = false; // Set it as control (for panel)
                food.FormBorderStyle = FormBorderStyle.None; // No border style

            }
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gridPelicula_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //agregar a carrito palomitas de caramelo chicas
            string guest = "guest";
            if (user == guest)
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
                CompraDulces art = new CompraDulces(idsOrdenados[1], 1);
                FormMainPage.listaDulces.Add(art);
                FormFood food = new FormFood();
                food.TopLevel = false; // Set it as control (for panel)
                food.FormBorderStyle = FormBorderStyle.None; // No border style

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //agregar a carrito regresco de maquina
            string guest = "guest";
            if (user == guest)
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
                CompraDulces art = new CompraDulces(idsOrdenados[2], 1);
                FormMainPage.listaDulces.Add(art);
                FormFood food = new FormFood();
                food.TopLevel = false; // Set it as control (for panel)
                food.FormBorderStyle = FormBorderStyle.None; // No border style

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //agregar a carrito palomitas de mantequilla grandes
            string guest = "guest";
            if (user == guest)
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
                CompraDulces art = new CompraDulces(idsOrdenados[3], 1);
                FormMainPage.listaDulces.Add(art);
                FormFood food = new FormFood();
                food.TopLevel = false; // Set it as control (for panel)
                food.FormBorderStyle = FormBorderStyle.None; // No border style

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //agregar a carrito palomitas de caramelo grandes
            string guest = "guest";
            if (user == guest)
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
                CompraDulces art = new CompraDulces(idsOrdenados[4], 1);
                FormMainPage.listaDulces.Add(art);
                FormFood food = new FormFood();
                food.TopLevel = false; // Set it as control (for panel)
                food.FormBorderStyle = FormBorderStyle.None; // No border style

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //agregar a carrito nachos
            string guest = "guest";
            if (user == guest)
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
                CompraDulces art = new CompraDulces(idsOrdenados[5], 1);
                FormMainPage.listaDulces.Add(art);
                FormFood food = new FormFood();
                food.TopLevel = false; // Set it as control (for panel)
                food.FormBorderStyle = FormBorderStyle.None; // No border style

            }
        }
    }
}
