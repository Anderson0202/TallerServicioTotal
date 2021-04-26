using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class DetalleFactura
    {
        public string IdFactura { get; set; }
        public Factura Factura { get; set; }
        public string IdServicio { get; set; }
        public Servicio Servicio { get; set; }
        public int Cantidad { get; set; }
        public string Descripcion { get; set; }
        public double PrecioUnitario { get; set; }
        public double Importe { get; set; }
        public double Total { get; set; }

        /*public void AgregarDetalleFactura()
        {
            Factura factura = new Factura();

        }*/

    }
}
