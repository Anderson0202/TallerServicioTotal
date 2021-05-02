using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Agenda
    {
        public DateTime FechaInicio { get; set; }
        public DateTime FechaEntrega { get; set; }
        public List<Mecanico> Mecanicos { get; set; }
        public void AgregarMecanicos(Mecanico mecanico)
        {
            Mecanicos.Add(mecanico);
        }

    }
}
