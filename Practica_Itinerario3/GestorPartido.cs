using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Itinerario3
{
   public static class GestorPartido
   {
      public static List<Partido> getAllPartido()
      {
       
         string connectionString = "Data Source=LAPTOP-A3HABLR6\\SQLEXPRESS;Initial Catalog=Partido;Integrated Security=True;";

     
         using (SqlConnection conexion = new SqlConnection(connectionString))
         {
            try
            {
              
               string query = "SELECT * FROM Partido";

              
               SqlDataAdapter adapter = new SqlDataAdapter(query, conexion);

               DataSet dataSet = new DataSet();
           
               adapter.Fill(dataSet);

               List<Partido> listaPartido = new List<Partido>();

               foreach (DataRow row in dataSet.Tables[0].Rows)
               {
                  Partido partido = new Partido
                  {
                     Fecha = Convert.ToDateTime(row["FECHA_PARTIDO"]),
                     EquipoLocal = row["EQUIPO_LOCAL"].ToString(),
                     EquipoVisitante = row["EQUIPO_VISITANTE"].ToString(),
                     GolesEquipoLocal = Convert.ToInt32(row["GOLES_EQUIPO_LOCAL"]),
                     GolesEquipoVisitante = Convert.ToInt32(row["GOLES_EQUIPO_VISITANTE"]),
                     Finalizado = Convert.ToBoolean(row["FINALIZADO"])
                  };

                  listaPartido.Add(partido);
               }

               return listaPartido;
            }
            catch (Exception ex)
            {
               throw new Exception("Error al obtener los partidos de la base de datos", ex);
            }
         } 
      }
   }
}
