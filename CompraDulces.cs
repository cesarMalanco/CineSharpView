using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsFinalProyect
{
    public class CompraDulces
    {
        public int id { get; set; }
        public int cant { get; set; }

        public CompraDulces(int id, int cant)
        {
            this.id = id;
            this.cant = cant;
        }
    }
}
