using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Itinerario3
{
   public class Partido
   {
      public DateTime Fecha { get; set; }
      public string EquipoLocal { get; set; }
      public string EquipoVisitante { get; set; }
      public int GolesEquipoLocal { get; set; }
      public int GolesEquipoVisitante { get; set; }
      public bool Finalizado { get; set; }
   }
}
