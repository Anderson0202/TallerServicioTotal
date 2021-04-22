using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Factura
    {
        public string IdCliente { get; set; }
        public Persona Persona { get; set; }
        public long Codigo { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public string NumeroServicio { get; set; }
        public List<DetalleFactura> DetallesFactura { get; set; }
        public double Total { get; set; }


        public void CalcularSubtotal()
        {
            double subtotal = 0;
            foreach (var item in DetallesFactura)
            {
                subtotal += item.Total;
            }

        }

    }
}
