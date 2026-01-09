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
using static System.Windows.Forms.DataFormats;

namespace WinFormsFinalProject
{
    public partial class FormMovies : Form
    {
        private string userHere;
        private FormMainPage MainPage;
        List<string> images;

        public FormMovies(FormMainPage mainPage, string user)
        {
            userHere = user;
            InitializeComponent();
            MainPage = mainPage;
            AdmonDB obj = new AdmonDB();
            images = obj.consultarPeliculas();
            
            PictureBox[] pictureBoxes = { pictureBoxMovie1, pictureBoxMovie2, pictureBoxMovie3, 
                                          pictureBoxMovie4, pictureBoxMovie5, pictureBoxMovie6, pictureBoxMovie7 };
            
            for (int i = 0; i < images.Count && i < pictureBoxes.Length; i++)
            {
                string imagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images", images[i]);
                if (File.Exists(imagePath))
                {
                    pictureBoxes[i].Image = System.Drawing.Image.FromFile(imagePath);
                }
                else
                {
                    pictureBoxes[i].Visible = false;
                }
            }
        }

        private void pictureBoxMovie1_Click(object sender, EventArgs e)
        {
            string img = images[0].ToString();
            try
            {
                AdmonDB obj = new AdmonDB();
                obj.Connect();

                Products aux = obj.consultaProductosImg(images[0]);

                if (aux == null)
                {
                    // Ocultar las imágenes si no se encuentra el producto
                    this.pictureBox1.Visible = false;
                    this.pictureBoxMovie1.Visible = false;
                }
                else
                {
                    if (aux.Stock == 0)
                    {
                        // Si la película existe pero no hay stock
                        this.pictureBox1.Visible = true;
                        this.pictureBoxMovie1.Visible = true;
                        MessageBox.Show("Entradas Agotadas!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        // Si la película existe y hay stock
                        this.pictureBox1.Visible = false;
                        this.pictureBoxMovie1.Visible = true;

                        // Mostrar formulario para la película 1
                        foreach (Control control in MainPage.panelMP.Controls)
                        {
                            if (control is FormMovie1)
                            {
                                return;
                            }
                        }

                        Panel nuevoPanel = new Panel();
                        nuevoPanel.Dock = DockStyle.Fill;
                        nuevoPanel.BackColor = Color.LightBlue;

                        FormMovie1 movie1 = new FormMovie1(img, userHere);
                        movie1.TopLevel = false;
                        movie1.FormBorderStyle = FormBorderStyle.None;
                        movie1.Dock = DockStyle.Fill;

                        if (MainPage != null)
                        {
                            MainPage.panelMP.Controls.Clear();
                            MainPage.panelMP.Controls.Add(nuevoPanel);
                            nuevoPanel.Controls.Add(movie1);
                            movie1.Show();
                        }
                    }
                }

                obj.Disconnect();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al encontrar la película: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void pictureBoxMovie2_Click(object sender, EventArgs e)
        {
            string img = images[1].ToString();
            try
            {
                AdmonDB obj = new AdmonDB();
                obj.Connect();

                Products aux = obj.consultaProductosImg(images[1]);

                if (aux == null)
                {
                    // Ocultar las imágenes si no se encuentra el producto
                    this.pictureBox2.Visible = false;
                    this.pictureBoxMovie2.Visible = false;
                }
                else
                {
                    if (aux.Stock == 0)
                    {
                        // Si la película existe pero no hay stock
                        this.pictureBox2.Visible = true;
                        this.pictureBoxMovie2.Visible = true;
                        MessageBox.Show("Entradas Agotadas!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        // Si la película existe y hay stock
                        this.pictureBox2.Visible = false;
                        this.pictureBoxMovie2.Visible = true;

                        // Mostrar formulario para la película 1
                        foreach (Control control in MainPage.panelMP.Controls)
                        {
                            if (control is FormMovie2)
                            {
                                return;
                            }
                        }

                        Panel nuevoPanel = new Panel();
                        nuevoPanel.Dock = DockStyle.Fill;
                        nuevoPanel.BackColor = Color.LightBlue;

                        FormMovie2 movie1 = new FormMovie2(img, userHere);
                        movie1.TopLevel = false;
                        movie1.FormBorderStyle = FormBorderStyle.None;
                        movie1.Dock = DockStyle.Fill;

                        if (MainPage != null)
                        {
                            MainPage.panelMP.Controls.Clear();
                            MainPage.panelMP.Controls.Add(nuevoPanel);
                            nuevoPanel.Controls.Add(movie1);
                            movie1.Show();
                        }
                    }
                }

                obj.Disconnect();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al encontrar la película: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBoxMovie3_Click(object sender, EventArgs e)
        {
            string img = images[2].ToString();
            try
            {
                AdmonDB obj = new AdmonDB();
                obj.Connect();

                Products aux = obj.consultaProductosImg(images[2]);

                if (aux == null)
                {
                    // Ocultar las imágenes si no se encuentra el producto
                    this.pictureBox3.Visible = false;
                    this.pictureBoxMovie3.Visible = false;
                }
                else
                {
                    if (aux.Stock == 0)
                    {
                        // Si la película existe pero no hay stock
                        this.pictureBox3.Visible = true;
                        this.pictureBoxMovie3.Visible = true;
                        MessageBox.Show("Entradas Agotadas!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        // Si la película existe y hay stock
                        this.pictureBox3.Visible = false;
                        this.pictureBoxMovie3.Visible = true;

                        // Mostrar formulario para la película 1
                        foreach (Control control in MainPage.panelMP.Controls)
                        {
                            if (control is FormMovie2)
                            {
                                return;
                            }
                        }

                        Panel nuevoPanel = new Panel();
                        nuevoPanel.Dock = DockStyle.Fill;
                        nuevoPanel.BackColor = Color.LightBlue;

                        FormMovie3 movie1 = new FormMovie3(img, userHere);
                        movie1.TopLevel = false;
                        movie1.FormBorderStyle = FormBorderStyle.None;
                        movie1.Dock = DockStyle.Fill;

                        if (MainPage != null)
                        {
                            MainPage.panelMP.Controls.Clear();
                            MainPage.panelMP.Controls.Add(nuevoPanel);
                            nuevoPanel.Controls.Add(movie1);
                            movie1.Show();
                        }
                    }
                }

                obj.Disconnect();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al encontrar la película: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBoxMovie4_Click(object sender, EventArgs e)
        {
            string img = images[3].ToString();
            try
            {
                AdmonDB obj = new AdmonDB();
                obj.Connect();

                Products aux = obj.consultaProductosImg(images[3]);

                if (aux == null)
                {
                    // Ocultar las imágenes si no se encuentra el producto
                    this.pictureBox4.Visible = false;
                    this.pictureBoxMovie4.Visible = false;
                }
                else
                {
                    if (aux.Stock == 0)
                    {
                        // Si la película existe pero no hay stock
                        this.pictureBox4.Visible = true;
                        this.pictureBoxMovie4.Visible = true;
                        MessageBox.Show("Entradas Agotadas!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        // Si la película existe y hay stock
                        this.pictureBox4.Visible = false;
                        this.pictureBoxMovie4.Visible = true;

                        // Mostrar formulario para la película 1
                        foreach (Control control in MainPage.panelMP.Controls)
                        {
                            if (control is FormMovie2)
                            {
                                return;
                            }
                        }

                        Panel nuevoPanel = new Panel();
                        nuevoPanel.Dock = DockStyle.Fill;
                        nuevoPanel.BackColor = Color.LightBlue;

                        FormMovie4 movie1 = new FormMovie4(img, userHere);
                        movie1.TopLevel = false;
                        movie1.FormBorderStyle = FormBorderStyle.None;
                        movie1.Dock = DockStyle.Fill;

                        if (MainPage != null)
                        {
                            MainPage.panelMP.Controls.Clear();
                            MainPage.panelMP.Controls.Add(nuevoPanel);
                            nuevoPanel.Controls.Add(movie1);
                            movie1.Show();
                        }
                    }
                }

                obj.Disconnect();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al encontrar la película: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBoxMovie5_Click(object sender, EventArgs e)
        {
            string img = images[4].ToString();
            try
            {
                AdmonDB obj = new AdmonDB();
                obj.Connect();

                Products aux = obj.consultaProductosImg(images[4]);

                if (aux == null)
                {
                    // Ocultar las imágenes si no se encuentra el producto
                    this.pictureBox5.Visible = false;
                    this.pictureBoxMovie5.Visible = false;
                }
                else
                {
                    if (aux.Stock == 0)
                    {
                        // Si la película existe pero no hay stock
                        this.pictureBox5.Visible = true;
                        this.pictureBoxMovie5.Visible = true;
                        MessageBox.Show("Entradas Agotadas!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        // Si la película existe y hay stock
                        this.pictureBox4.Visible = false;
                        this.pictureBoxMovie5.Visible = true;

                        // Mostrar formulario para la película 1
                        foreach (Control control in MainPage.panelMP.Controls)
                        {
                            if (control is FormMovie2)
                            {
                                return;
                            }
                        }

                        Panel nuevoPanel = new Panel();
                        nuevoPanel.Dock = DockStyle.Fill;
                        nuevoPanel.BackColor = Color.LightBlue;

                        FormMovie4 movie1 = new FormMovie4(img, userHere);
                        movie1.TopLevel = false;
                        movie1.FormBorderStyle = FormBorderStyle.None;
                        movie1.Dock = DockStyle.Fill;

                        if (MainPage != null)
                        {
                            MainPage.panelMP.Controls.Clear();
                            MainPage.panelMP.Controls.Add(nuevoPanel);
                            nuevoPanel.Controls.Add(movie1);
                            movie1.Show();
                        }
                    }
                }

                obj.Disconnect();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al encontrar la película: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBoxMovie6_Click(object sender, EventArgs e)
        {
            string img = images[5].ToString();
            try
            {
                AdmonDB obj = new AdmonDB();
                obj.Connect();

                Products aux = obj.consultaProductosImg(images[5]);

                if (aux == null)
                {
                    // Ocultar las imágenes si no se encuentra el producto
                    this.pictureBox6.Visible = false;
                    this.pictureBoxMovie6.Visible = false;
                }
                else
                {
                    if (aux.Stock == 0)
                    {
                        // Si la película existe pero no hay stock
                        this.pictureBox6.Visible = true;
                        this.pictureBoxMovie6.Visible = true;
                        MessageBox.Show("Entradas Agotadas!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        // Si la película existe y hay stock
                        this.pictureBox4.Visible = false;
                        this.pictureBoxMovie6.Visible = true;

                        // Mostrar formulario para la película 1
                        foreach (Control control in MainPage.panelMP.Controls)
                        {
                            if (control is FormMovie2)
                            {
                                return;
                            }
                        }

                        Panel nuevoPanel = new Panel();
                        nuevoPanel.Dock = DockStyle.Fill;
                        nuevoPanel.BackColor = Color.LightBlue;

                        FormMovie4 movie1 = new FormMovie4(img, userHere);
                        movie1.TopLevel = false;
                        movie1.FormBorderStyle = FormBorderStyle.None;
                        movie1.Dock = DockStyle.Fill;

                        if (MainPage != null)
                        {
                            MainPage.panelMP.Controls.Clear();
                            MainPage.panelMP.Controls.Add(nuevoPanel);
                            nuevoPanel.Controls.Add(movie1);
                            movie1.Show();
                        }
                    }
                }

                obj.Disconnect();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al encontrar la película: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBoxMovie7_Click(object sender, EventArgs e)
        {
            string img = images[6].ToString();
            try
            {
                AdmonDB obj = new AdmonDB();
                obj.Connect();

                Products aux = obj.consultaProductosImg(images[6]);

                if (aux == null)
                {
                    // Ocultar las imágenes si no se encuentra el producto
                    this.pictureBox7.Visible = false;
                    this.pictureBoxMovie7.Visible = false;
                }
                else
                {
                    if (aux.Stock == 0)
                    {
                        // Si la película existe pero no hay stock
                        this.pictureBox7.Visible = true;
                        this.pictureBoxMovie7.Visible = true;
                        MessageBox.Show("Entradas Agotadas!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        // Si la película existe y hay stock
                        this.pictureBox4.Visible = false;
                        this.pictureBoxMovie6.Visible = true;

                        // Mostrar formulario para la película 1
                        foreach (Control control in MainPage.panelMP.Controls)
                        {
                            if (control is FormMovie2)
                            {
                                return;
                            }
                        }

                        Panel nuevoPanel = new Panel();
                        nuevoPanel.Dock = DockStyle.Fill;
                        nuevoPanel.BackColor = Color.LightBlue;

                        FormMovie4 movie1 = new FormMovie4(img, userHere);
                        movie1.TopLevel = false;
                        movie1.FormBorderStyle = FormBorderStyle.None;
                        movie1.Dock = DockStyle.Fill;

                        if (MainPage != null)
                        {
                            MainPage.panelMP.Controls.Clear();
                            MainPage.panelMP.Controls.Add(nuevoPanel);
                            nuevoPanel.Controls.Add(movie1);
                            movie1.Show();
                        }
                    }
                }

                obj.Disconnect();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al encontrar la película: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBoxSoldOut1_Click(object sender, EventArgs e)
        {

        }

        private void FormMovies_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
