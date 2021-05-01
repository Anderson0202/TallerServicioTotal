using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Mecanico : Persona
    {

        public string Especialidad { get; set; }
        public List<Vehiculo> Vehiculos { get; set; }
        public void AgregarVehiculos(Vehiculo vehiculo)
        {
            Vehiculos.Add(vehiculo);
        }

    }
}
