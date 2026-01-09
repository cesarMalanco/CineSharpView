using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WinFormsFinalProyect
{
    public partial class Frm_Grafica : Form
    {
        public Frm_Grafica()
        {
            InitializeComponent();
            Cargar_Grafica();
        }

        private void Btn_Close_Page_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Cargar_Grafica()
        {
            // Indicamos nuestra conexion a la base de datos
            MySqlConnection conexion = new MySqlConnection("Server=localhost; Database=cine; User=root; Password=; SslMode=none;");
            conexion.Open();

            // Obtener la suma de los montos
            string consultaSuma = "SELECT SUM(monto) AS total FROM users WHERE ID NOT IN (1, 7)";
            MySqlCommand comandoSuma = new MySqlCommand(consultaSuma, conexion);
            object resultado = comandoSuma.ExecuteScalar();
            double sumaTotal = resultado != DBNull.Value ? Convert.ToDouble(resultado) : 0;
            label2.Text = $"{sumaTotal:F2}";

            // Consulta para los montos por usuario
            string consulta = "SELECT nombre, monto FROM users WHERE ID NOT IN (1, 7)";
            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            MySqlDataReader lector = comando.ExecuteReader();

            // Inicializar variables para encontrar el monto máximo
            string nombreMax = string.Empty;
            double montoMax = 0;

            // Al iniciar la grafica, se limpian los datos
            chart_Admin.Series.Clear();
            Series serie = new Series("Montos por Usuario");
            serie.ChartType = SeriesChartType.Pie;

            while (lector.Read())
            {
                string nombre = lector["Nombre"].ToString();
                double monto = Convert.ToDouble(lector["Monto"]);

                // Comparar si el monto actual es mayor que el máximo encontrado
                if (monto > montoMax)
                {
                    montoMax = monto;
                    nombreMax = nombre;
                }

                // Agregar el punto al gráfico
                DataPoint punto = new DataPoint(0, monto);
                punto.LegendText = nombre;
                serie.Points.Add(punto);
            }

            // Después de llenar la gráfica, agregarla a chart_Admin
            chart_Admin.Series.Add(serie);
            chart_Admin.Legends[0].Docking = Docking.Bottom;

            // No mostrar las etiquetas sobre los puntos
            foreach (var point in serie.Points)
            {
                point.IsValueShownAsLabel = false;
            }

            // Mostrar el nombre de la persona con el monto mayor en label3
            label3.Text = $"{nombreMax}";

            conexion.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
