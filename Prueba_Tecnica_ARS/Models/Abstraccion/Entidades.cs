using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prueba_Tecnica_ARS.Models.Abstraccion
{
    public abstract class Entidades
    {
        protected SqlCommand COMANDO { get; set; }
        protected SqlDataReader LECTOR { get; set; }
        protected SqlConnection CONEXION { get; } = new SqlConnection("Data source=.\\SQLEXPRESS; " +
        "initial catalog=AFILIADOS_JUSTIN_MINAYA; integrated security=true; TrustServerCertificate=true");

        public abstract IEnumerable<Entidades> ObtenerListado();
    }
}
