using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsFinalProyect
{
    public class Products
    {
        private int id;
        private string name;
        private string about;
        private float precio;
        private int stock;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string About { get => about; set => about = value; }
        public float Precio { get => precio; set => precio = value; }
        public int Stock { get => stock; set => stock = value; }

        public Products(int id, string name, string about, float precio, int stock)
        {
            this.Id = id;
            this.Name = name;
            this.About = about;
            this.Precio = precio;
            this.Stock = stock;
        }
    }
}
