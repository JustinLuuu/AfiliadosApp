using Microsoft.Data.SqlClient;
using Prueba_Tecnica_ARS.Models.Abstraccion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prueba_Tecnica_ARS.Models
{
    public class Planes : Entidades, IOperacionesComunes
    {
        public int Id { get; set; }
        public int Id_Estatus { get; set; }
        public string Nombre { get; set; }
        public decimal Monto_Cobertura { get; set; }
        public DateTime Fecha_Registro { get; set; }


        public void Insertar()
        {
            try
            {
                COMANDO = new SqlCommand("insert into Planes (Nombre, Monto_Cobertura, Fecha_Registro," +
                " Id_Estatus) " +
                " values (@nombre, @montoCobertura, @fechaRegistro, @idEstatus)", CONEXION);
                COMANDO.Parameters.AddWithValue("@nombre", Nombre.Trim());
                COMANDO.Parameters.AddWithValue("@montoCobertura", Monto_Cobertura);
                COMANDO.Parameters.AddWithValue("@fechaRegistro", DateTime.Today);
                COMANDO.Parameters.AddWithValue("@idEstatus", Id_Estatus);

                CONEXION.Open();
                COMANDO.ExecuteNonQuery();
                CONEXION.Close();
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

        public void Actualizar()
        {
            try
            {
                COMANDO = new SqlCommand("update Planes set Nombre=@nombre, Monto_Cobertura=@montoCobertura," +
                    " Id_Estatus=@idEstatus where Id=@id", CONEXION);

                COMANDO.Parameters.AddWithValue("@nombre", Nombre.Trim());
                COMANDO.Parameters.AddWithValue("@montoCobertura", Monto_Cobertura);
                COMANDO.Parameters.AddWithValue("@idEstatus", Id_Estatus);
                COMANDO.Parameters.AddWithValue("@id", Id);

                CONEXION.Open();
                COMANDO.ExecuteNonQuery();
                CONEXION.Close();
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

        public override IEnumerable<Entidades> ObtenerListado()
        {
            List<Planes> planesLista = new List<Planes>();

            try
            {
                COMANDO = new SqlCommand("select * from Planes", CONEXION);
                CONEXION.Open();
                LECTOR = COMANDO.ExecuteReader();

                while (LECTOR.Read())
                {                       
                    planesLista.Add(new Planes
                    {
                        Id = int.Parse(LECTOR["Id"].ToString()),
                        Nombre = LECTOR["Nombre"].ToString(),
                        Monto_Cobertura = decimal.Parse(LECTOR["Monto_Cobertura"].ToString()),
                        Fecha_Registro = DateTime.Parse(LECTOR["Fecha_Registro"].ToString()),
                        Id_Estatus = int.Parse(LECTOR["Id_Estatus"].ToString()),
                    });
                }

                CONEXION.Close();
                return planesLista;
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

        public Planes ObtenerPlanPorId(int id)
        {
            try
            {
                COMANDO = new SqlCommand("select * from Planes where Id=@id", CONEXION);
                COMANDO.Parameters.AddWithValue("@id", id);

                CONEXION.Open();
                LECTOR = COMANDO.ExecuteReader();

                while (LECTOR.Read())
                {
                    Id = int.Parse(LECTOR["Id"].ToString());
                    Nombre = LECTOR["Nombre"].ToString();
                    Monto_Cobertura = decimal.Parse(LECTOR["Monto_Cobertura"].ToString());
                    Fecha_Registro = DateTime.Parse(LECTOR["Fecha_Registro"].ToString());
                    Id_Estatus = int.Parse(LECTOR["Id_Estatus"].ToString());
                }

                CONEXION.Close();
                return this;
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
