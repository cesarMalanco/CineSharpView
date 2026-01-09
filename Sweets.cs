using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsFinalProyect
{
    public class Sweets
    {
        private int id;
        private string name;
        private float price;
        private int stock;
        private string about;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public float Price { get => price; set => price = value; }
        public int Stock { get => stock; set => stock = value; }
        public string About { get => about; set => about = value; }

        public Sweets(int id, string name, float price, int stock, string about)
        {
            this.Id = id;
            this.Name = name;
            this.Price = price;
            this.Stock = stock;
            this.About = about;
        }
    }
}
