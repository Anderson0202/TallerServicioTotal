using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Cotizacion
    {
        public long Codigo { get; set; }
        public List<DetalleCotizacion> DetallesCotizacion { get; set; }

    }
}
