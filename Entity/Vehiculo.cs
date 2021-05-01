using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Vehiculo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Año { get; set; }
        public int Cilindraje { get; set; }
        public string IdCliente { get; set; }
        public Cliente Cliente { get; set; }

    }
}
