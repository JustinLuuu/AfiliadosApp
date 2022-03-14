using Microsoft.Data.SqlClient;
using Prueba_Tecnica_ARS.Models.Abstraccion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prueba_Tecnica_ARS.Models
{
    public class Estatus : Entidades
    {
        public int Id { get; set; }
        public string Estatus_Nombre { get; set; }
        public static int Activo { get; internal set; }

        public override IEnumerable<Entidades> ObtenerListado()
        {
            List<Estatus> estatusLista = new List<Estatus>();

            try
            {
                COMANDO = new SqlCommand("select * from Estatus", CONEXION);
                CONEXION.Open();
                LECTOR = COMANDO.ExecuteReader();

                while (LECTOR.Read())
                {                       
                    estatusLista.Add(new Estatus
                    {
                        Id = int.Parse(LECTOR["Id"].ToString()),
                        Estatus_Nombre = LECTOR["Estatus"].ToString(),
                    });
                }

                CONEXION.Close();
                return estatusLista;
            }
            catch (SqlException e)
            {
                throw new Exception(e.Message);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }              
    }
}
