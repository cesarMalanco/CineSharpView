using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Runtime.Intrinsics.Arm;
using Mysqlx.Crud;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.Devices;
using System.Xml.Linq;
using Microsoft.VisualBasic.ApplicationServices;
using static iTextSharp.text.pdf.XfaForm;

namespace WinFormsFinalProyect
{
    public class AdmonDB
    {
        private MySqlConnection connection;

        public void Connect()
        {
            string cadena = "Server=localhost; Database=cine; User=root; Password=; SslMode=none;";
            try
            {
                connection = new MySqlConnection(cadena);
                connection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al conectar con la base de datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Disconnect()
        {
            if (connection != null && connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public AdmonDB()
        {
            this.Connect();
        }

        public int ContarProductos()
        {
            int count = 0;

            try
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM Products", this.connection))
                {
                    count = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            catch (Exception ex)
            {
                // Manejo del error
                MessageBox.Show("Error al contar productos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return count;
        }

        /*public int ContarDulces()
        {
            int count = 0;

            try
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM Sweets", this.connection))
                {
                    count = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            catch (Exception ex)
            {
                // Manejo del error
                MessageBox.Show("Error al contar productos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return count;
        }*/

        public void insertarProducto(int idp, string name, string img, string about, float precio, int stock)
        {
            string query = "";
            try
            {
                query = "INSERT INTO products (id,name,img,about,precio,stock) VALUES ("
                  + "'" + idp + "',"
                  + "'" + name + "',"
                  + "'" + img + "',"
                  + "'" + about + "',"
                  + "'" + precio + "', "
                  + "'" + stock + "')";

                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro Agregado");
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: Clave duplicada");
                this.Disconnect();
            }
        }

        public void eliminarProducto(int idp)
        {
            string query = "";
            try
            {
                query = "DELETE FROM products WHERE id=" + idp + ";";

                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro Eliminado");
            }
            catch (Exception ex)
            {
                MessageBox.Show(query + "\nError " + ex.Message);
                this.Disconnect();
            }
        }

        public Products consultaProductos(int id_search)
        {
            Products item = null;

            int id;
            string name;
            string about;
            float precio;
            int stock;

            try
            {
                string query = "SELECT * FROM products where id=" + id_search + ";";
                MySqlCommand command = new MySqlCommand(query, this.connection);

                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    // Ejemplo: mostrar los datos de las columnas
                    id = Convert.ToInt32(reader["id"]);
                    name = Convert.ToString(reader["name"]) ?? "";
                    about = Convert.ToString(reader["about"]) ?? "";
                    precio = Convert.ToSingle(reader["precio"]);
                    stock = Convert.ToInt32(reader["stock"]);

                    item = new Products(id, name, about, precio, stock);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer la tabla de la base de datos: " + ex.Message);
                this.Disconnect();
            }
            return item;
        }

        public void insertarDulce(int idp, string name, int stock, string about, float price)
        {
            string query = "";
            try
            {
                query = "INSERT INTO sweets (id,name,stock,about,price) VALUES ("
                  + "'" + idp + "',"
                  + "'" + name + "',"
                  + "'" + stock + "',"
                  + "'" + about + "',"
                  + "'" + price + "')";

                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro Agregado");
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: Clave duplicada");
                this.Disconnect();
            }
        }
        public void eliminarDulce(int idp)
        {
            string query = "";
            try
            {
                query = "DELETE FROM sweets WHERE id=" + idp + ";";

                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro Eliminado");
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: Clave duplicada");
                this.Disconnect();
            }
        }

        public Products consultaProductosImg(string img)
        {
            Products item = null;

            int id;
            string name;
            string about;
            float precio;
            int stock;

            try
            {
                string query = "SELECT * FROM products WHERE img = @img;";
                MySqlCommand command = new MySqlCommand(query, this.connection);

                command.Parameters.AddWithValue("@img", img);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // Ejemplo: mostrar los datos de las columnas
                        id = Convert.ToInt32(reader["id"]);
                        name = Convert.ToString(reader["name"]) ?? "";
                        about = Convert.ToString(reader["about"]) ?? "";
                        precio = Convert.ToSingle(reader["precio"]);
                        stock = Convert.ToInt32(reader["stock"]);

                        item = new Products(id, name, about, precio, stock);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer la tabla de la base de datos: " + ex.Message);
                this.Disconnect();
            }
            return item;
        }

        public Sweets consultarDulce(int id_search)
        {
            Sweets item = null;

            int id;
            string name;
            int stock;
            string about;
            float price;

            try
            {
                string query = "SELECT * FROM sweets where id=" + id_search + ";";
                MySqlCommand command = new MySqlCommand(query, this.connection);

                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    // Ejemplo: mostrar los datos de las columnas
                    id = Convert.ToInt32(reader["id"]);
                    name = Convert.ToString(reader["name"]) ?? "";
                    stock = Convert.ToInt32(reader["stock"]);
                    about = Convert.ToString(reader["about"]) ?? "";
                    price = Convert.ToSingle(reader["price"]);

                    item = new Sweets(id, name, price, stock, about);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer la tabla de la base de datos: " + ex.Message);
                this.Disconnect();
            }
            return item;
        }

        public void modificarDulce(int idp, string name, int stock, string about, float price)
        {
            try
            {
                string query = "UPDATE sweets SET id=" + "'" + idp + "'" + ",name=" + "'" + name + "'" + ",stock=" + "'" + stock + "'" + ",about=" + "'" + about + "'" + ",price=" + "'" + price + "'" + "where id=" + idp + ";";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro modificado");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update error: " + ex.Message);
                this.Disconnect();
            }
        }

        public void modificarCantidadProducto(int idp, int stock)
        {
            try
            {
                //UPDATE `products` SET `Stock` = '2' WHERE `products`.`ID` = 1;
                string query = "UPDATE products SET Stock=" + "'" + stock + "'" + "where products.ID=" + idp + ";";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                //MessageBox.Show("Registro modificado");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update error: " + ex.Message);
                this.Disconnect();
            }
        }

        public void modificarCantidadDulce(int idp, int stock)
        {
            try
            {
                string query = "UPDATE sweets SET Stock=" + "'" + stock + "'" + "where sweets.ID=" + idp + ";";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                //MessageBox.Show("Registro modificado");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update error: " + ex.Message);
                this.Disconnect();
            }
        }

        public void modificarMontoUser(int idp, float monto)
        {
            try
            {
                //UPDATE `users` SET `Monto` = '20' WHERE `users`.`ID` = 2;
                string query = "UPDATE users SET Monto=" + "'" + monto + "'" + "where users.ID=" + idp + ";";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                //MessageBox.Show("Registro modificado");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update error: " + ex.Message);
                this.Disconnect();
            }
        }

        public List<Users> consultaUsuarios()
        {
            List<Users> data = new List<Users>();
            Users item;

            int id;
            string cuenta;
            string nombre;
            string pword;
            float monto;

            try
            {
                string query = "SELECT * FROM users";
                MySqlCommand command = new MySqlCommand(query, this.connection);

                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    // Ejemplo: mostrar los datos de las columnas
                    id = Convert.ToInt32(reader["id"]);
                    cuenta = Convert.ToString(reader["cuenta"]) ?? "";
                    nombre = Convert.ToString(reader["nombre"]) ?? "";
                    pword = Convert.ToString(reader["pword"]) ?? "";
                    monto = Convert.ToSingle(reader["monto"]);

                    item = new Users(id, cuenta, nombre, pword, monto);
                    data.Add(item);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer la tabla de la base de datos: " + ex.Message);
                this.Disconnect();
            }

            return data;
        }

        public List<string> consultarPeliculas()
        {
            List <string> movies = new List<string>();

            string image;
            try
            {
                string query = "SELECT * FROM products";
                MySqlCommand command = new MySqlCommand(query, this.connection);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    image = Convert.ToString(reader["img"]) ?? "";
                    movies.Add(image);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer la tabla de la base de datos: " + ex.Message);
                this.Disconnect();
            }

            return movies;
        }
       
        internal Users consultarMonto(float monto_search)
        {
            Users item = null;

            int id;
            string cuenta;
            string name;
            string pword;
            float monto;

            try
            {
                string query = "SELECT * FROM users where monto=" + monto_search + ";";
                MySqlCommand command = new MySqlCommand(query, this.connection);

                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    // Ejemplo: mostrar los datos de las columnas
                    id = Convert.ToInt32(reader["id"]);
                    cuenta = Convert.ToString(reader["cuenta"]) ?? "";
                    name = Convert.ToString(reader["nombre"]) ?? "";
                    pword = Convert.ToString(reader["pword"]) ?? "";
                    monto = Convert.ToSingle(reader["monto"]);

                    item = new Users(id, cuenta, name, pword, monto);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer la tabla de la base de datos: " + ex.Message);
                this.Disconnect();
            }
            return item;
        }
    }
}
