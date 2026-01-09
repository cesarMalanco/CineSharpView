using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Runtime.Intrinsics.X86;
using System.Windows.Forms;

namespace WinFormsFinalProyect
{
    public partial class Eliminar : Form
    {
        private bool isOpening; // Para controlar si se está abriendo o cerrando el panel
        private bool openingID;

        public Eliminar()
        {
            InitializeComponent();
            fill_table2();
        }

        private void Frm_Eliminar_Load(object sender, EventArgs e)
        {
            timer1.Interval = 10; //  mayor velocidad
            timer2.Interval = 10;
            PnlAddData.Width = 0; // El panel comienza cerrado
            PnlAddData.Visible = false;
            Pnl_Info.Width = 0; // El panel Pnl_Info comienza cerrado
            Pnl_Info.Visible = false; // Inicialmente oculto
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            int panelSpeed = 30; // Velocidad de cambio del ancho del panel

            if (openingID)
            {
                // Abrir el panel
                if (PnlAddData.Width < 300)
                {
                    PnlAddData.Width += panelSpeed; // Incrementar el ancho del panel
                    // El Contenedor_Peliculas no se ve afectado
                }
                else
                {
                    PnlAddData.Width = 300; // Fijar el tamaño final del panel
                    timer1.Stop(); // Detener la animación
                }
            }
            else
            {
                // Cerrar el panel
                if (PnlAddData.Width > 0)
                {
                    PnlAddData.Width -= panelSpeed; // Reducir gradualmente el ancho del panel
                    // El Contenedor_Peliculas no se ve afectado
                }
                else
                {
                    PnlAddData.Width = 0; // Fijar el tamaño final del panel
                    PnlAddData.Visible = false; // Ocultar el panel al terminar
                    timer1.Stop(); // Detener la animación
                }
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            int panelSpeed = 30; // Velocidad de cambio del ancho del panel

            if (isOpening)
            {
                // Abrir el panel Pnl_Info
                if (Pnl_Info.Width < 300)
                {
                    Pnl_Info.Width += panelSpeed; // Incrementar el ancho del panel
                    PnlAddData.Visible = false; // Ocultar PnlAddData cuando se abre Pnl_Info
                    // El Contenedor_Peliculas no se ve afectado
                }
                else
                {
                    Pnl_Info.Width = 300; // Fijar el tamaño final del panel
                    timer1.Stop(); // Detener la animación
                }
            }
            else
            {
                // Cerrar el panel Pnl_Info
                if (Pnl_Info.Width > 0)
                {
                    Pnl_Info.Width -= panelSpeed; // Reducir gradualmente el ancho del panel
                    // El Contenedor_Peliculas no se ve afectado
                }
                else
                {
                    Pnl_Info.Width = 0; // Fijar el tamaño final del panel
                    Pnl_Info.Visible = false; // Ocultar el panel al terminar
                    PnlAddData.Visible = true; // Mostrar PnlAddData nuevamente
                    timer1.Stop(); // Detener la animación
                }
            }
        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            isOpening = true;
            PnlAddData.Visible = true;
            timer2.Start();
        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.TextBoxID_Eliminar.Text))
            {
                MessageBox.Show("Por favor, ingrese un ID para buscar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                int id = Convert.ToInt32(this.TextBoxID_Eliminar.Text);

                AdmonDB obj = new AdmonDB();
                obj.Connect();

                Products aux = obj.consultaProductos(id);

                if (aux == null)
                {
                    MessageBox.Show("El ID ingresado no existe en la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.TextBoxID_Eliminar.Clear();
                }
                else
                {
                    isOpening = true;
                    PnlAddData.Visible = false; // Ocultar PnlAddData inmediatamente al presionar el botón
                    Pnl_Info.Visible = true; // Mostrar Pnl_Info
                    timer1.Start(); // Iniciar la animación de Pnl_Info

                    this.textBoxTitulo_E.Text = aux.Name;
                    this.textBoxPrecio_E.Text = Convert.ToString(aux.Precio);
                    this.textBoxStock_E.Text = Convert.ToString(aux.Stock);
                    this.textBoxDescripcion_E.Text = aux.About;
                }

                obj.Disconnect();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("El ID ingresado no es válido: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al buscar el producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void Btn_Close_Page_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            isOpening = false;
            timer1.Start();
        }

        private void Contenedor_Peliculas_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void TextBoxID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.TextBoxID_Eliminar.Text))
            {
                MessageBox.Show("Por favor, ingrese un ID para eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                int id = Convert.ToInt32(this.TextBoxID_Eliminar.Text);

                AdmonDB obj = new AdmonDB();
                obj.Connect();

                // Verificar la cantidad de elementos en la base de datos
                int count = obj.ContarProductos();

                if (count <= 6)
                {
                    MessageBox.Show("No se pueden eliminar productos. La base de datos tiene 6 o menos elementos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.TextBoxID_Eliminar.Clear();
                    this.textBoxTitulo_E.Clear();
                    this.textBoxPrecio_E.Clear();
                    this.textBoxStock_E.Clear();
                    this.textBoxDescripcion_E.Clear();
                    obj.Disconnect();

                    // Ocultar Pnl_Info y mostrar PnlAddData
                    Pnl_Info.Visible = false;
                    PnlAddData.Visible = true;

                    return;
                }

                Products aux = obj.consultaProductos(id);

                if (aux == null)
                {
                    MessageBox.Show("El ID ingresado no existe en la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.TextBoxID_Eliminar.Clear();
                }
                else
                {
                    DialogResult result = MessageBox.Show($"¿Está seguro de que desea eliminar la película '{aux.Name}'?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        // Código para eliminar el producto
                        obj.eliminarProducto(id);
                        MessageBox.Show("Producto eliminado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.TextBoxID_Eliminar.Clear();
                        fill_table2();

                        // Ocultar Pnl_Info y mostrar PnlAddData
                        Pnl_Info.Visible = false;
                        PnlAddData.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("Eliminación cancelada", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.TextBoxID_Eliminar.Clear();
                        this.textBoxTitulo_E.Clear();
                        this.textBoxPrecio_E.Clear();
                        this.textBoxStock_E.Clear();
                        this.textBoxDescripcion_E.Clear();
                    }
                }

                obj.Disconnect();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("El ID ingresado no es válido: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al eliminar el producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        MySqlConnection conexion2 = new MySqlConnection("Server=localhost; Database=cine; User=root; Password=; SslMode=none;");

        public void fill_table2()
        {
            string consulta2 = "SELECT * FROM products";
            MySqlDataAdapter adapter2 = new MySqlDataAdapter(consulta2, conexion2);
            DataTable dt2 = new DataTable();
            adapter2.Fill(dt2);
            gridB.DataSource = dt2;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string consulta2 = "SELECT * FROM products";
            MySqlDataAdapter adapter2 = new MySqlDataAdapter(consulta2, conexion2);
            DataTable dt2 = new DataTable();
            adapter2.Fill(dt2);
            gridB.DataSource = dt2;
        }
    }
}
