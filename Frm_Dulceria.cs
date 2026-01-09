using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace WinFormsFinalProyect
{
    public partial class Frm_Dulceria : Form
    {

        public Frm_Dulceria()
        {
            InitializeComponent();
            fill_tableSweets();
        }

        private void Frm_Dulceria_Load(object sender, EventArgs e)
        {
            Grid_Dulceria.Width = 811; // Ancho total inicial del grid
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Agregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.TextBoxID_Sweet.Text) ||
                string.IsNullOrWhiteSpace(this.TextBoxName_Sweet.Text) ||
                string.IsNullOrWhiteSpace(this.TextBoxPrice_Sweet.Text) ||
                string.IsNullOrWhiteSpace(this.TextBoxStock_Sweet.Text) ||
                string.IsNullOrWhiteSpace(this.TextBoxAbout_Sweet.Text))
            {
                MessageBox.Show("Todos los campos deben estar llenos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                int id = Convert.ToInt32(this.TextBoxID_Sweet.Text);
                string name = this.TextBoxName_Sweet.Text;
                float price = float.Parse(this.TextBoxPrice_Sweet.Text);
                int stock = Convert.ToInt32(this.TextBoxStock_Sweet.Text);
                string about = this.TextBoxAbout_Sweet.Text;

                AdmonDB obj = new AdmonDB();
                obj.insertarDulce(id, name, stock, about, price);
                obj.Disconnect();

                this.TextBoxID_Sweet.Clear();
                this.TextBoxName_Sweet.Clear();
                this.TextBoxPrice_Sweet.Clear();
                this.TextBoxStock_Sweet.Clear();
                this.TextBoxAbout_Sweet.Clear();
                fill_tableSweets();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Error en el formato de los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            fill_tableSweets();
        }


        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.TextBoxID_Sweet.Text))
            {
                MessageBox.Show("Por favor, ingrese un ID para eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                int id = Convert.ToInt32(this.TextBoxID_Sweet.Text);

                AdmonDB obj = new AdmonDB();
                obj.Connect();

                Sweets aux = obj.consultarDulce(id);

                if (aux == null)
                {
                    MessageBox.Show("El ID ingresado no existe en la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.TextBoxID_Sweet.Clear();
                    this.TextBoxName_Sweet.Clear();
                    this.TextBoxPrice_Sweet.Clear();
                    this.TextBoxStock_Sweet.Clear();
                    this.TextBoxAbout_Sweet.Clear();
                    fill_tableSweets();
                }
                else
                {
                    obj.eliminarDulce(id);
                    this.TextBoxID_Sweet.Clear();
                    this.TextBoxName_Sweet.Clear();
                    this.TextBoxPrice_Sweet.Clear();
                    this.TextBoxStock_Sweet.Clear();
                    this.TextBoxAbout_Sweet.Clear();
                    fill_tableSweets();
                }
                fill_tableSweets();

                obj.Disconnect();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("El ID ingresado no es válido: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al eliminar el dulce: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.TextBoxID_Sweet.Text))
            {
                MessageBox.Show("Por favor, ingrese un ID para buscar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                int id = Convert.ToInt32(this.TextBoxID_Sweet.Text);

                AdmonDB obj = new AdmonDB();
                obj.Connect();

                Sweets aux = obj.consultarDulce(id);

                if (aux == null)
                {
                    MessageBox.Show("El ID ingresado no existe en la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.TextBoxID_Sweet.Clear();
                    this.TextBoxName_Sweet.Clear();
                    this.TextBoxPrice_Sweet.Clear();
                    this.TextBoxStock_Sweet.Clear();
                    this.TextBoxAbout_Sweet.Clear();
                }
                else
                {
                    this.TextBoxName_Sweet.Text = aux.Name;
                    this.TextBoxPrice_Sweet.Text = Convert.ToString(aux.Price);
                    this.TextBoxStock_Sweet.Text = Convert.ToString(aux.Stock);
                    this.TextBoxAbout_Sweet.Text = aux.About;
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


        private void Btn_Modificar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.TextBoxID_Sweet.Text))
            {
                MessageBox.Show("Por favor, ingrese un ID para modificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                int id = Convert.ToInt32(this.TextBoxID_Sweet.Text);

                AdmonDB obj = new AdmonDB();
                obj.Connect();

                Sweets aux = obj.consultarDulce(id);

                if (aux == null)
                {
                    MessageBox.Show("El ID ingresado no existe en la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.TextBoxID_Sweet.Clear();
                    this.TextBoxName_Sweet.Clear();
                    this.TextBoxPrice_Sweet.Clear();
                    this.TextBoxStock_Sweet.Clear();
                    this.TextBoxAbout_Sweet.Clear();
                    fill_tableSweets();
                }
                else
                {
                    string name = this.TextBoxName_Sweet.Text;
                    float price = float.Parse(this.TextBoxPrice_Sweet.Text);
                    int stock = Convert.ToInt32(this.TextBoxStock_Sweet.Text);
                    string about = this.TextBoxAbout_Sweet.Text;

                    obj.modificarDulce(id, name, stock, about, price);

                    this.TextBoxID_Sweet.Clear();
                    this.TextBoxName_Sweet.Clear();
                    this.TextBoxPrice_Sweet.Clear();
                    this.TextBoxStock_Sweet.Clear();
                    this.TextBoxAbout_Sweet.Clear();
                    fill_tableSweets();
                }
                fill_tableSweets();

                obj.Disconnect();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("El ID ingresado no es válido: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al modificar el dulce: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void Btn_Close_Page_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        MySqlConnection conexion = new MySqlConnection("Server=localhost; Database=cine; User=root; Password=; SslMode=none;");
        public void fill_tableSweets()
        {
            string consulta = "SELECT * FROM sweets Order By stock ASC";
            MySqlDataAdapter adapter1 = new MySqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();
            adapter1.Fill(dt);
            gridSweets.DataSource = dt;
        }

        private void Frm_Dulceria_Load_1(object sender, EventArgs e)
        {
            string consulta = "SELECT * FROM sweets ORDER BY stock ASC";
            MySqlDataAdapter adapter1 = new MySqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();
            adapter1.Fill(dt);
            gridSweets.DataSource = dt;
        }

        private void button_Ok_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.TextBoxID_Sweet.Text))
            {
                MessageBox.Show("Por favor, ingrese un ID para buscar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                int id = Convert.ToInt32(this.TextBoxID_Sweet.Text);

                AdmonDB obj = new AdmonDB();
                obj.Connect();

                Sweets aux = obj.consultarDulce(id);

                if (aux == null)
                {
                    MessageBox.Show("El ID ingresado no existe en la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.TextBoxID_Sweet.Clear();
                    this.TextBoxName_Sweet.Clear();
                    this.TextBoxPrice_Sweet.Clear();
                    this.TextBoxStock_Sweet.Clear();
                    this.TextBoxAbout_Sweet.Clear();
                    fill_tableSweets();
                }
                else
                {
                    this.TextBoxName_Sweet.Text = aux.Name;
                    this.TextBoxPrice_Sweet.Text = Convert.ToString(aux.Price);
                    this.TextBoxStock_Sweet.Text = Convert.ToString(aux.Stock);
                    this.TextBoxAbout_Sweet.Text = aux.About;
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


        private void gridSweets_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            this.TextBoxID_Sweet.Clear();
            this.TextBoxName_Sweet.Clear();
            this.TextBoxPrice_Sweet.Clear();
            this.TextBoxStock_Sweet.Clear();
            this.TextBoxAbout_Sweet.Clear();
        }
    }
}
