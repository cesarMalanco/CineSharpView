using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsFinalProyect
{
    public class Users
    {
        private int id;
        private string cuenta;
        private string nombre;
        private string pword;
        private float monto;

        public int Id { get => id; set => id = value; }
        public string Cuenta { get => cuenta; set => cuenta = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Pword { get => pword; set => pword = value; }
        public float Monto { get => monto; set => monto = value; }

        public Users(int id, string cuenta, string nombre, string pword, float monto)
        {
            this.Id = id;
            this.Cuenta = cuenta;
            this.Nombre = nombre;
            this.Pword = pword;
            this.Monto = monto;
        }
    }
}
