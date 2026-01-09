using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WinFormsFinalProyect
{
    public partial class Frm_Consultas : Form
    {
        private const string V = "Monto";
        private bool isOpening; // Controla si el panel se está mostrando u ocultando
        private int gridOriginalTop = 66; // Posición original del grid (ajustado a 66)
        private int gridCurrentTop;  // La posición actual del grid

        public Frm_Consultas()
        {
            InitializeComponent();
            fill_TableUsers();
        }

        private void Frm_Consultas_Load(object sender, EventArgs e)
        {
            timer1.Interval = 10; // Velocidad del timer
            gridCurrentTop = gridOriginalTop; // La posición actual del grid también comienza en la posición original
            PnlAddData.Visible = false; // Panel no visible al inicio
            PnlAddData.Height = 300; // Fijar altura del panel (siempre estático)
        }

        private void Btn_Consultas_Click(object sender, EventArgs e)
        {
            isOpening = true; // Configurar para abrir el panel
            PnlAddData.Visible = true; // Mostrar el panel
            timer1.Start(); // Iniciar la animación
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            isOpening = false; // Configurar para cerrar el panel
            timer1.Start(); // Iniciar la animación de regreso
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int gridSpeed = 15; // Velocidad del desplazamiento del grid
            int additionalDrop = 20; // Incremento adicional para que el grid baje más (ajustar según sea necesario)

            if (isOpening)
            {
                // Desplazar el grid hacia abajo para mostrar el panel
                if (gridCurrentTop < gridOriginalTop + PnlAddData.Height + additionalDrop)
                {
                    gridCurrentTop += gridSpeed; // Mover el grid hacia abajo
                    Grid_Usuarios.Top = gridCurrentTop; // Actualizar la posición del grid
                }
                else
                {
                    Grid_Usuarios.Top = gridOriginalTop + PnlAddData.Height + additionalDrop; // Fijar posición final del grid
                    timer1.Stop(); // Detener la animación
                }
            }
            else
            {
                // Desplazar el grid hacia arriba para regresar a la posición original
                if (gridCurrentTop > gridOriginalTop)
                {
                    gridCurrentTop -= gridSpeed; // Mover el grid hacia arriba
                    Grid_Usuarios.Top = gridCurrentTop; // Actualizar la posición del grid
                }
                else
                {
                    // Al llegar a la posición original, detener la animación
                    gridCurrentTop = gridOriginalTop; // Asegurarse de que el grid quede exactamente en la posición original
                    Grid_Usuarios.Top = gridOriginalTop; // Restaurar posición original del grid
                    PnlAddData.Visible = false; // Ocultar el panel
                    timer1.Stop(); // Detener la animación
                }
            }
        }


        MySqlConnection conexion = new MySqlConnection("Server=localhost; Database=cine; User=root; Password=; SslMode=none;");


        public void fill_TableUsers()
        {
            string consulta = "SELECT id, nombre, monto FROM users WHERE id NOT IN (1, 7) ORDER BY monto DESC";
            MySqlDataAdapter adapter1 = new MySqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();
            adapter1.Fill(dt);
            gridPelicula.DataSource = dt;
        }

        public void fill_Tableus(float monto)
        {
            string consulta = "SELECT id,nombre,monto FROM users where monto=" + monto + ";";
            MySqlDataAdapter adapter1 = new MySqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();
            adapter1.Fill(dt);
            gridPelicula.DataSource = dt;
        }

        private void Grid_Usuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.TextBoxID.Text))
            {
                MessageBox.Show("Por favor, ingrese un monto para buscar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                float monto = Convert.ToSingle(this.TextBoxID.Text);

                AdmonDB obj = new AdmonDB();
                obj.Connect();

                Users aux = obj.consultarMonto(monto);

                if (aux == null)
                {
                    MessageBox.Show("El monto ingresado no existe en la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.TextBoxID.Clear();
                }
                else
                {
                    fill_Tableus(monto);
                }


                obj.Disconnect();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("El monto ingresado no es válido: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al consultar el monto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_Close_Page_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridPelicula_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            fill_TableUsers();
            this.TextBoxID.Clear();
        }

        private void gridPelicula_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
