using Microsoft.Data.SqlClient;
using Prueba_Tecnica_ARS.Models.Abstraccion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prueba_Tecnica_ARS.Models
{
    public class Afiliados : Entidades, IOperacionesComunes
    {
        public int Id { get; set; }
        public int Id_Plan { get; set; }
        public int Id_Estatus { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public char Sexo { get; set; }
        public string Cedula { get; set; }
        public string Numero_Seguridad_Social { get; set; }
        public decimal Monto_Consumido { get; set; }
        public DateTime Fecha_Registro { get; set; }
        public DateTime Fecha_Nacimiento { get; set; }


        public void Insertar()
        {
            try
            {
                using (COMANDO = new SqlCommand("insert into Afiliados(Nombres, Apellidos, Fecha_Nacimiento, " +
                   "Sexo, Cedula, Numero_Seguridad_Social, Fecha_Registro, Monto_Consumido, Id_Estatus, Id_Plan)" +
                   " values (@nombres, @apellidos, @fechaNacimiento, @sexo, @cedula, @numeroSeguridadSocial, " +
                   " @fechaRegistro, @montoConsumido, @idEstatus, @idPlan)", CONEXION))
                {
                    COMANDO.Parameters.AddWithValue("@nombres", Nombres.Trim());
                    COMANDO.Parameters.AddWithValue("@apellidos", Apellidos.Trim());
                    COMANDO.Parameters.AddWithValue("@fechaNacimiento", Fecha_Nacimiento);
                    COMANDO.Parameters.AddWithValue("@sexo", Sexo);
                    COMANDO.Parameters.AddWithValue("@cedula", Cedula.Trim());
                    COMANDO.Parameters.AddWithValue("@numeroSeguridadSocial", Numero_Seguridad_Social.Trim());
                    COMANDO.Parameters.AddWithValue("@fechaRegistro", DateTime.Today);
                    COMANDO.Parameters.AddWithValue("@montoConsumido", Monto_Consumido);
                    COMANDO.Parameters.AddWithValue("@idEstatus", Id_Estatus);
                    COMANDO.Parameters.AddWithValue("@idPlan", Id_Plan);

                    CONEXION.Open();
                    COMANDO.ExecuteNonQuery();
                }
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
                using (COMANDO = new SqlCommand("update Afiliados set Nombres=@nombres, Apellidos=@apellidos, " +
                    "Fecha_Nacimiento=@fechaNacimiento, Sexo=@sexo, Cedula=@cedula, " +
                    "Numero_Seguridad_Social=@numeroSeguridadSocial, " +
                    "Monto_Consumido=@montoConsumido, Id_Estatus=@idEstatus " +
                    "where Id=@id", CONEXION))
                {
                    COMANDO.Parameters.AddWithValue("@nombres", Nombres.Trim());
                    COMANDO.Parameters.AddWithValue("@apellidos", Apellidos.Trim());
                    COMANDO.Parameters.AddWithValue("@fechaNacimiento", Fecha_Nacimiento);
                    COMANDO.Parameters.AddWithValue("@sexo", Sexo);
                    COMANDO.Parameters.AddWithValue("@cedula", Cedula.Trim());
                    COMANDO.Parameters.AddWithValue("@numeroSeguridadSocial", Numero_Seguridad_Social.Trim());
                    COMANDO.Parameters.AddWithValue("@montoConsumido", Monto_Consumido);
                    COMANDO.Parameters.AddWithValue("@idEstatus", Id_Estatus);
                    COMANDO.Parameters.AddWithValue("@idPlan", Id_Plan);
                    COMANDO.Parameters.AddWithValue("@id", Id);

                    CONEXION.Open();
                    COMANDO.ExecuteNonQuery();
                    CONEXION.Close();

                }
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
            List<Afiliados> afiliadosLista = new List<Afiliados>();

            try
            {
                using (COMANDO = new SqlCommand("select * from Afiliados", CONEXION))
                {
                    CONEXION.Open();
                    LECTOR = COMANDO.ExecuteReader();

                    while (LECTOR.Read())
                    {
                        afiliadosLista.Add(new Afiliados {
                            Id = int.Parse(LECTOR["Id"].ToString()),
                            Nombres = LECTOR["Nombres"].ToString(),
                            Apellidos = LECTOR["Apellidos"].ToString(),
                            Sexo = char.Parse(LECTOR["Sexo"].ToString()),
                            Cedula = LECTOR["Cedula"].ToString(),
                            Fecha_Nacimiento = DateTime.Parse(LECTOR["Fecha_Nacimiento"].ToString()),                            
                            Numero_Seguridad_Social = LECTOR["Numero_Seguridad_Social"].ToString(),
                            Fecha_Registro = DateTime.Parse(LECTOR["Fecha_Registro"].ToString()),
                            Monto_Consumido = decimal.Parse(LECTOR["Monto_Consumido"].ToString()),
                            Id_Estatus = int.Parse(LECTOR["Id_Estatus"].ToString()),
                            Id_Plan = int.Parse(LECTOR["Id_Plan"].ToString()),
                        });
                    }
                    CONEXION.Close();

                    return afiliadosLista;
                }
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

        public Afiliados ObtenerAfiliadoPorId(int id)
        {
            try
            {
                using (COMANDO = new SqlCommand("select * from Afiliados where Id=@id", CONEXION))
                {
                    COMANDO.Parameters.AddWithValue("@id", id);
                    CONEXION.Open();
                    LECTOR = COMANDO.ExecuteReader();

                    while (LECTOR.Read())
                    {
                        Id = int.Parse(LECTOR["Id"].ToString());
                        Nombres = LECTOR["Nombres"].ToString();
                        Apellidos = LECTOR["Apellidos"].ToString();
                        Sexo = char.Parse(LECTOR["Sexo"].ToString());
                        Cedula = LECTOR["Cedula"].ToString();
                        Fecha_Nacimiento = DateTime.Parse(LECTOR["Fecha_Nacimiento"].ToString());                        
                        Numero_Seguridad_Social = LECTOR["Numero_Seguridad_Social"].ToString();
                        Fecha_Registro = DateTime.Parse(LECTOR["Fecha_Registro"].ToString());
                        Monto_Consumido = decimal.Parse(LECTOR["Monto_Consumido"].ToString());
                        Id_Estatus = int.Parse(LECTOR["Id_Estatus"].ToString());
                        Id_Plan = int.Parse(LECTOR["Id_Plan"].ToString());
                    }
                    CONEXION.Close();
                    return this;
                }
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

        public IEnumerable<Afiliados> ObtenerAfiliadosPorPlan(int idPlan)
        {
            List<Afiliados> afiliadosListaConPlan = new List<Afiliados>();

            try
            {
                using (COMANDO = new SqlCommand("select * from Afiliados where Id_Plan=@idPlan", CONEXION))
                {
                    COMANDO.Parameters.AddWithValue("@idPlan", idPlan);
                    CONEXION.Open();
                    LECTOR = COMANDO.ExecuteReader();

                    while (LECTOR.Read())
                    {
                        afiliadosListaConPlan.Add(new Afiliados
                        {
                            Id = int.Parse(LECTOR["Id"].ToString()),
                            Nombres = LECTOR["Nombres"].ToString(),
                            Apellidos = LECTOR["Apellidos"].ToString(),
                            Sexo = char.Parse(LECTOR["Sexo"].ToString()),
                            Cedula = LECTOR["Cedula"].ToString(),
                            Fecha_Nacimiento = DateTime.Parse(LECTOR["Fecha_Nacimiento"].ToString()),
                            Numero_Seguridad_Social = LECTOR["Numero_Seguridad_Social"].ToString(),
                            Fecha_Registro = DateTime.Parse(LECTOR["Fecha_Registro"].ToString()),
                            Monto_Consumido = decimal.Parse(LECTOR["Monto_Consumido"].ToString()),
                            Id_Estatus = int.Parse(LECTOR["Id_Estatus"].ToString()),
                            Id_Plan = int.Parse(LECTOR["Id_Plan"].ToString()),
                        });
                    }
                    CONEXION.Close();

                    return afiliadosListaConPlan;
                }
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
       
        public void SwitchActivar(int id)
        {
            var afiliadoSwitch = ObtenerAfiliadoPorId(id);
            if(afiliadoSwitch.Id_Estatus == 1)
            {
                afiliadoSwitch.Id_Estatus = 2;
            } else
            {
                afiliadoSwitch.Id_Estatus = 1;
            }
            afiliadoSwitch.Actualizar();
        }
    }
}
