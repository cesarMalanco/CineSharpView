using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsFinalProject;

namespace WinFormsFinalProyect
{
    public partial class Frm_Productos : Form
    {
        public Frm_Productos()
        {
            InitializeComponent();
            fill_tablePeliculas();
        }

        private void Btn_Close_Page_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonBuscar_Peliculas_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.textBoxID_Pelicula.Text))
            {
                MessageBox.Show("Por favor, ingrese un ID para buscar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                int id = Convert.ToInt32(this.textBoxID_Pelicula.Text);

                AdmonDB obj = new AdmonDB();
                obj.Connect();

                Products aux = obj.consultaProductos(id);

                if (aux == null)
                {
                    MessageBox.Show("El ID ingresado no existe en la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.textBoxID_Pelicula.Clear();
                }
                else
                {
                    this.textBoxTitulo_Peliculas.Text = aux.Name;
                    this.textBoxStock_Peliculas.Text = Convert.ToString(aux.Stock);
                }

                obj.Disconnect();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("El ID ingresado no es válido: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al consultar el dulce: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        MySqlConnection conexion = new MySqlConnection("Server=localhost; Database=cine; User=root; Password=; SslMode=none;");

        public void fill_tablePeliculas()
        {
            string consulta = "SELECT * FROM products Order By stock ASC";
            MySqlDataAdapter adapter1 = new MySqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();
            adapter1.Fill(dt);
            gridPelicula.DataSource = dt;
        }

        private void Frm_Dulceria_Load_1(object sender, EventArgs e)
        {
            string consulta = "SELECT * FROM products";
            MySqlDataAdapter adapter1 = new MySqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();
            adapter1.Fill(dt);
            gridPelicula.DataSource = dt;
        }

        private void buttonLimpiar_Peliculas_Click(object sender, EventArgs e)
        {
            this.textBoxID_Pelicula.Clear();
            this.textBoxTitulo_Peliculas.Clear();
            this.textBoxStock_Peliculas.Clear();
        }

        private void buttonRegresar_Peliculas_Click(object sender, EventArgs e)
        {
            Frm_Main mainpage = new Frm_Main();
            this.Hide();
            mainpage.ShowDialog();
        }
    }
}
