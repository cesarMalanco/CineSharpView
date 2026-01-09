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
    public partial class FormLoginPage : Form
    {
        private List<Users> usuarios = new List<Users>();
        private string username = "";
        private string password = "";

        public FormLoginPage()
        {
            InitializeComponent();

            AdmonDB obj = new AdmonDB();
            obj.Connect();
            usuarios = obj.consultaUsuarios();
            obj.Disconnect();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Store textBox's content in a class attribute
            this.username = txtUsername.Text;
            this.password = txtPassword.Text;

            if (username == usuarios[0].Cuenta)
            {
                if (password == usuarios[0].Pword)
                {
                    Frm_Main adminPage = new Frm_Main();
                    this.Hide();
                    adminPage.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Contraseña incorrecta", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtPassword.Clear();
                }
            }
            else if (username == usuarios[1].Cuenta)
            {
                if (password == usuarios[1].Pword)
                {
                    this.username = usuarios[1].Nombre;
                    FormMainPage mainPage = new FormMainPage(username); // Create an instance for Main Page
                    this.Hide(); // Hide Login Page
                    mainPage.ShowDialog(); // Show Main Page  
                }
                else
                {
                    MessageBox.Show("Contraseña incorrecta", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtPassword.Clear();
                }
            }
            else if (username == usuarios[2].Cuenta)
            {
                if (password == usuarios[2].Pword)
                {
                    this.username = usuarios[2].Nombre;
                    FormMainPage mainPage = new FormMainPage(username); // Create an instance for Main Page
                    this.Hide(); // Hide Login Page
                    mainPage.ShowDialog(); // Show Main Page  
                }
                else
                {
                    MessageBox.Show("Contraseña incorrecta", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtPassword.Clear();
                }
            }
            else if (username == usuarios[3].Cuenta)
            {
                if (password == usuarios[3].Pword)
                {
                    this.username = usuarios[3].Nombre;
                    FormMainPage mainPage = new FormMainPage(username); // Create an instance for Main Page
                    this.Hide(); // Hide Login Page
                    mainPage.ShowDialog(); // Show Main Page  
                }
                else
                {
                    MessageBox.Show("Contraseña incorrecta", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtPassword.Clear();
                }
            }
            else if (username == usuarios[4].Cuenta)
            {
                if (password == usuarios[4].Pword)
                {
                    this.username = usuarios[4].Nombre;
                    FormMainPage mainPage = new FormMainPage(username); // Create an instance for Main Page
                    this.Hide(); // Hide Login Page
                    mainPage.ShowDialog(); // Show Main Page  
                }
                else
                {
                    MessageBox.Show("Contraseña incorrecta", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtPassword.Clear();
                }
            }
            else if (username == usuarios[5].Cuenta)
            {
                if (password == usuarios[5].Pword)
                {
                    this.username = usuarios[5].Nombre;
                    FormMainPage mainPage = new FormMainPage(username); // Create an instance for Main Page
                    this.Hide(); // Hide Login Page
                    mainPage.ShowDialog(); // Show Main Page  
                }
                else
                {
                    MessageBox.Show("Contraseña incorrecta", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtPassword.Clear();
                }
            }
            else if (username == usuarios[6].Cuenta)
            {
                if (password == usuarios[6].Pword)
                {
                    this.username = usuarios[6].Nombre;
                    FormMainPage mainPage = new FormMainPage(username); // Create an instance for Main Page
                    this.Hide(); // Hide Login Page
                    mainPage.ShowDialog(); // Show Main Page  
                }
                else
                {
                    MessageBox.Show("Contraseña incorrecta", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtPassword.Clear();
                }
            }
            else
            {
                MessageBox.Show("Usuario no válido", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtUsername.Clear();
                this.txtPassword.Clear();
                return;
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblLP_Clear_Click(object sender, EventArgs e)
        {
            // Resets username
            txtUsername.Text = "Username"; // Clears username field by reseting it
            txtUsername.ForeColor = Color.Gray; // Sets color gray back

            // Resets password
            txtPassword.UseSystemPasswordChar = false; // Turns off '*'
            txtPassword.Text = "Password"; // Clears username field by reseting it
            txtPassword.ForeColor = Color.Gray; // Sets color gray back

            this.ActiveControl = null; // Turns off focus so the cursor doesnt stay on the field

        }

        private void FormLoginPage_Load(object sender, EventArgs e)
        {

        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Username")
            {
                txtUsername.Text = "";  // Clears default text
                txtUsername.ForeColor = Color.Black;  // From gray to black
            }
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                txtUsername.Text = "Username";  // Resets the textBox 
                txtUsername.ForeColor = Color.Gray;  // Puts it back to gray
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password")
            {
                txtPassword.Text = "";  // Clears default text
                txtPassword.ForeColor = Color.Black;  // Changes from gray to black
                txtPassword.UseSystemPasswordChar = true;  // Turns on '*'
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                txtPassword.UseSystemPasswordChar = false;  // Turns off '*'
                txtPassword.Text = "Password";  // Resets default text
                txtPassword.ForeColor = Color.Gray;  // From black to gray
            }
        }

        private void btnGuest_Click(object sender, EventArgs e) // Guest account
        {
            this.username = "guest";
            FormMainPage mainPage = new FormMainPage(username); // Create an instance for Main Page
            this.Hide(); // Hide Login Page
            mainPage.ShowDialog(); // Show Main Page   
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBoxLP_Title_Click(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
