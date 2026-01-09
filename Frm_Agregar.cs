using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace WinFormsFinalProyect
{
    public partial class Frm_Agregar : Form
    {
        List<Users> users;
        List<Products> products;
        private bool isOpening; // Para controlar si se está abriendo o cerrando el panel

        public Frm_Agregar()
        {
            InitializeComponent();
        }

        private void Frm_Agregar_Load(object sender, EventArgs e)
        {
            timer1.Interval = 10; //  mayor velocidad
            PnlAddData.Width = 0; // El panel comienza cerrado
            PnlAddData.Visible = false;
            Contenedor_Peliculas.Width = 819; // Ancho total inicial del grid
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int panelSpeed = 30; // Velocidad de cambio del ancho del panel
            int gridSpeed = 30;  // Velocidad de ajuste del ancho del grid (coherente con panelSpeed)

            if (isOpening)
            {
                // Abrir el panel
                if (PnlAddData.Width < 300)
                {
                    PnlAddData.Width += panelSpeed; // Incrementar el ancho del panel
                    Contenedor_Peliculas.Width -= gridSpeed; // Reducir gradualmente el ancho del grid
                }
                else
                {
                    PnlAddData.Width = 300; // Fijar el tamaño final del panel
                    Contenedor_Peliculas.Width = 513; // Fijar el tamaño final del grid
                    timer1.Stop(); // Detener la animación
                }
            }
            else
            {
                // Cerrar el panel
                if (PnlAddData.Width > 0)
                {
                    PnlAddData.Width -= panelSpeed; // Reducir gradualmente el ancho del panel
                    Contenedor_Peliculas.Width += gridSpeed; // Incrementar gradualmente el ancho del grid
                }
                else
                {
                    PnlAddData.Width = 0; // Fijar el tamaño final del panel
                    Contenedor_Peliculas.Width = 814; // Fijar el tamaño final del grid
                    PnlAddData.Visible = false; // Ocultar el panel al terminar
                    timer1.Stop(); // Detener la animación
                }
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            isOpening = false;
            timer1.Start();
        }

        private void Btn_Agregar_Click(object sender, EventArgs e)
        {
            isOpening = true;

            AdmonDB obj = new AdmonDB();
            obj.Connect();
            int count = obj.ContarProductos();
            obj.Disconnect();

            if (count == 8)
            {
                MessageBox.Show("Haz alcanzado el limite de productos permitidos en el sistema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                PnlAddData.Visible = true; // Asegurarse de que el panel sea visible
                timer1.Start();
            }
        }


        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            Pic_photo.Image = null;
        }

        private void Btn_Open_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Pic_photo.ImageLocation = openFileDialog.FileName;
            }
        }

        private void Btn_Close_Page_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TextBoxID_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Verificar que todos los TextBox tengan datos
            if (string.IsNullOrWhiteSpace(this.TextBoxID.Text) ||
                string.IsNullOrWhiteSpace(this.TextBoxTitulo.Text) ||
                string.IsNullOrWhiteSpace(this.TextBoxDescription.Text) ||
                string.IsNullOrWhiteSpace(this.TextBoxPrecio.Text) ||
                string.IsNullOrWhiteSpace(this.TextBoxStock.Text) ||
                string.IsNullOrWhiteSpace(this.TextBoxImagen.Text))
            {
                MessageBox.Show("Todos los campos deben estar llenos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                if (this.TextBoxImagen.Text == "backToTheFuture.jpg" || this.TextBoxImagen.Text == "emma.jpg" || this.TextBoxImagen.Text == "ferris.jpg" || this.TextBoxImagen.Text == "goneGirl.jpg" || this.TextBoxImagen.Text == "knivesOut.jpg" || this.TextBoxImagen.Text == "lalaLand.jpg" || this.TextBoxImagen.Text == "prideAndPrej.jpg" || this.TextBoxImagen.Text == "shreck.jpg")
                {
                    int id = Convert.ToInt32(this.TextBoxID.Text);
                    string name = this.TextBoxTitulo.Text;
                    string about = this.TextBoxDescription.Text;
                    float precio = float.Parse(this.TextBoxPrecio.Text);
                    int stock = Convert.ToInt32(this.TextBoxStock.Text);
                    string img = this.TextBoxImagen.Text;

                    AdmonDB obj = new AdmonDB();
                    obj.Connect();
                    obj.insertarProducto(id, name, img, about, precio, stock);
                    obj.Disconnect();

                    this.TextBoxID.Clear();
                    this.TextBoxTitulo.Clear();
                    this.TextBoxDescription.Clear();
                    this.TextBoxPrecio.Clear();
                    this.TextBoxStock.Clear();
                    this.TextBoxImagen.Clear();

                    fill_table();
                }
                else
                {
                    MessageBox.Show("El nombre de imagen no está en existencia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.TextBoxID.Clear();
                    this.TextBoxTitulo.Clear();
                    this.TextBoxDescription.Clear();
                    this.TextBoxPrecio.Clear();
                    this.TextBoxStock.Clear();
                    this.TextBoxImagen.Clear();

                    return;
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Error en el formato de los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al agregar el producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TextBoxTitulo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        MySqlConnection conexion = new MySqlConnection("Server=localhost; Database=cine; User=root; Password=; SslMode=none;");

        public void fill_table()
        {
            string consulta = "SELECT * FROM products";
            MySqlDataAdapter adapter1 = new MySqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();
            adapter1.Fill(dt);
            gridA.DataSource = dt;
        }

        private void Frm_Agregar_Load_1(object sender, EventArgs e)
        {
            string consulta = "SELECT * FROM products";
            MySqlDataAdapter adapter1 = new MySqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();
            adapter1.Fill(dt);
            gridA.DataSource = dt;
        }

        private void gridA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Contenedor_Peliculas_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gridA_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
