using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Cliente : Persona
    {
        public string Usuario { get; set; }
        public string Password { get; set; }
        public string CorreoElectronico { get; set; }
        public List<Vehiculo> Vehiculos { get; set; }

        public void IniciarSesion()
        {

        }
        
        public void ConsultarServicios()
        {

        }

        public void AgregarVehiculos(Vehiculo vehiculo)
        {
            Vehiculos.Add(vehiculo);
        }

    }
}
