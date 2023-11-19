using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    internal class PersonaDAL
    {
        private string _connectionString = "data source=MELISSAMF\\SQLEXPRESS;initial catalog=MatriculaApp;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework";
        public bool GuardarPersona(Persona persona)
        {
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("INSERT INTO Persona(Run, Nombre, Apellido, FechaNacimiento, Direccion, EstadoCivil) VALUES (@Run, @Nombre, @Apellido, @FechaNacimiento, @Direccion, @EstadoCivil)", con))
                {
                    cmd.Parameters.AddWithValue("@Run", persona.Run);
                    cmd.Parameters.AddWithValue("@Nombre", persona.Nombre);
                    cmd.Parameters.AddWithValue("@Apellido", persona.Apellido);
                    cmd.Parameters.AddWithValue("@FechaNacimiento", persona.FechaNacimiento);
                    cmd.Parameters.AddWithValue("@Direccion", persona.Direccion);
                    cmd.Parameters.AddWithValue("@EstadoCivil", persona.EstadoCivil);
                    int rows = cmd.ExecuteNonQuery();
                    return rows > 0;
                }
            }
        }

        public List<Persona> ObtenerPersonas()
        {
            List<Persona> personas = new List<Persona>();

            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Persona", con))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Persona persona = new Persona
                            {
                                PersonaId = Convert.ToInt32(reader["PersonaId"]),
                                Run = reader["Run"].ToString(),
                                Nombre = reader["Nombre"].ToString(),
                                Apellido = reader["Apellido"].ToString(),
                                FechaNacimiento = Convert.ToDateTime(reader["FechaNacimiento"]),
                                Direccion = reader["Direccion"].ToString(),
                                EstadoCivil = reader["EstadoCivil"].ToString()
                            };

                            personas.Add(persona);
                        }
                    }
                }
            }

            return personas;
        }

        public Persona ObtenerPersonaPorId(int id)
        {
            Persona persona = null;

            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Persona WHERE PersonaId = @id", con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            persona = new Persona
                            {
                                PersonaId = Convert.ToInt32(reader["PersonaId"]),
                                Run = reader["Run"].ToString(),
                                Nombre = reader["Nombre"].ToString(),
                                Apellido = reader["Apellido"].ToString(),
                                FechaNacimiento = Convert.ToDateTime(reader["FechaNacimiento"]),
                                Direccion = reader["Direccion"].ToString(),
                                EstadoCivil = reader["EstadoCivil"].ToString()
                            };
                        }
                    }
                }
            }

            return persona;
        }

        public bool EliminarPersona(int id)
        {
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("DELETE FROM Persona WHERE PersonaId = @id", con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    int rows = cmd.ExecuteNonQuery();
                    return rows > 0;
                }
            }
        }
    }
}

