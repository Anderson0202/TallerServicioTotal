using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Servicio
    {
        public string Nombre { get; set; }
        public string Estado { get; set; }
        public List<Mecanico> Mecanicos { get; set; }
        public void AgregarMecanicos(Mecanico mecanico)
        {
            Mecanicos.Add(mecanico);
        }

    }
}
