using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsFinalProyect
{
    public class CompraPeliculas
    {
        public int id {  get; set; }
        public int cant {  get; set; }

        public CompraPeliculas(int id, int cant) { 
            this.id = id;
            this.cant = cant;
        }
    }
}
