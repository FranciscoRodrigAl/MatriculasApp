using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.SqlClient;

namespace DAL
{
    public class AlumnoDAL
    {
        private string _connectionString = "data source=MELISSAMF\\SQLEXPRESS;initial catalog=MatriculaApp;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework";

        public bool GuardarAlumno(Alumno alumno)
        {
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("INSERT INTO Alumno(FechaIngreso, CarreraActual, EstadoAcademico, PersonaId) VALUES (@FechaIngreso, @CarreraActual, @EstadoAcademico, @PersonaId)", con))
                {
                    cmd.Parameters.AddWithValue("@FechaIngreso", alumno.FechaIngreso);
                    cmd.Parameters.AddWithValue("@CarreraActual", alumno.CarreraActual);
                    cmd.Parameters.AddWithValue("@EstadoAcademico", alumno.EstadoAcademico);
                    cmd.Parameters.AddWithValue("@PersonaId", alumno.PersonaId);
                    int rows = cmd.ExecuteNonQuery();
                    return rows > 0;
                }
            }
        }

        public Alumno ObtenerAlumnoPorId(int id)
        {
            Alumno alumno = null;

            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Alumno WHERE AlumnoId = @id", con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            alumno = new Alumno
                            {
                                AlumnoId = Convert.ToInt32(reader["AlumnoId"]),
                                FechaIngreso = Convert.ToDateTime(reader["FechaIngreso"]),
                                CarreraActual = reader["CarreraActual"].ToString(),
                                EstadoAcademico = reader["EstadoAcademico"].ToString(),
                                PersonaId = Convert.ToInt32(reader["PersonaId"])
                            };
                        }
                    }
                }
            }

            return alumno;
        }

        public List<Alumno> ObtenerAlumnos()
        {
            List<Alumno> alumnos = new List<Alumno>();

            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Alumno", con))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Alumno alumno = new Alumno
                            {
                                AlumnoId = Convert.ToInt32(reader["AlumnoId"]),
                                FechaIngreso = Convert.ToDateTime(reader["FechaIngreso"]),
                                CarreraActual = reader["CarreraActual"].ToString(),
                                EstadoAcademico = reader["EstadoAcademico"].ToString(),
                                PersonaId = Convert.ToInt32(reader["PersonaId"])
                            };

                            alumnos.Add(alumno);
                        }
                    }
                }
            }

            return alumnos;
        }

        public bool EliminarAlumno(int id)
        {
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("DELETE FROM Alumno WHERE AlumnoId = @id", con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    int rows = cmd.ExecuteNonQuery();
                    return rows > 0;
                }
            }
        }
    }
}
