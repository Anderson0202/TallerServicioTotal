using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class VentaServicio : Factura
    {
        public VentaServicio(Persona cliente)
        {
            Persona = cliente;
        }

    }
}
