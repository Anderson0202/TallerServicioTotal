using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Factura
    {
        public string Codigo { get; set; }
        public string IdCliente { get; set; }
        public Persona Persona { get; set; }
        public Vehiculo Vehiculo { get; set; }
        public DateTime Fecha { get; set; }
        public Servicio Servicio { get; set; }
        public List<DetalleFactura> DetallesFactura { get; set; }
        public double Total { get; set; }
        //public DateTime FechaVencimiento { get; set; }

        public void CalcularSubTotal()
        {
            double subTotal = 0;
            foreach (var item in DetallesFactura)
            {
                subTotal += item.Total;
            }
        }

        public void AgregarDetalles(DetalleFactura detalle)
        {
            DetallesFactura.Add(detalle);
        }

        public void GuardarFactura()
        {

        }

        public void ConsultarFactura()
        {

        }

    }
}
