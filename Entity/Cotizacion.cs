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
        public string IdCliente { get; set; }
        public Cliente Cliente { get; set; }
        public List<DetalleCotizacion> DetallesCotizacion { get; set; }
        public decimal Total { get; set; }

        public Cotizacion()
        {

        }

        public void AgregarDetalles(DetalleCotizacion detalle)
        {
            DetallesCotizacion.Add(detalle);
        }

        public void GuardarCotizacion()
        {

        }

        public void ConsultarCotizacion()
        {

        }

    }
}
