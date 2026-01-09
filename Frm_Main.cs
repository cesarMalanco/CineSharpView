using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using WinFormsFinalProject;
using Microsoft.VisualBasic.ApplicationServices;

namespace WinFormsFinalProyect
{
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
            MessageBox.Show("Welcome, admin!");
        }
        private void Frm_Main_Load(object sender, EventArgs e)
        {
            Timer_Hora.Enabled = true;
            PanelPrincipal.Visible = true;
            Timer_Hora.Start();
        }


        private void AbrirFormInPanel(object Formhijo)
        {
            if (this.PanelContenedor.Controls.Count > 0)
            {
                this.PanelContenedor.Controls.RemoveAt(0);
            }
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(fh);
            this.PanelContenedor.Tag = fh;
            fh.Show();
        }
        private void BtnDulceria_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Frm_Dulceria());
            PanelPrincipal.Visible = false;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormLoginPage mainPage = new FormLoginPage();
            this.Hide();
            mainPage.ShowDialog();
        }

        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /*
        private void Btn_Maximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            IconRestaurar.Visible = true;
            Btn_Maximizar.Visible = false;
        }
        */

        private void Btn_Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        /*
        private void IconRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            IconRestaurar.Visible = false;
            Btn_Maximizar.Visible = true;
        }
        */
        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Frm_Agregar());
            PanelPrincipal.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Eliminar());
            PanelPrincipal.Visible = false;
        }

        private void Btn_Productos_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Frm_Productos());
            PanelPrincipal.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Frm_Consultas());
            PanelPrincipal.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Frm_Grafica());
            PanelPrincipal.Visible = false;
        }

        private void PanelPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Timer_Hora_Tick(object sender, EventArgs e)
        {
            label7.Text = DateTime.Now.ToLongDateString();
            label6.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
