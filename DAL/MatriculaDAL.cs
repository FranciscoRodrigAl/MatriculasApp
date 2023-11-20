using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MatriculaDAL
    {
        private string _connectionString = "data source=DESKTOP-CHERF4D\\SQLEXPRESS;initial catalog=MatriculaApp;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework";

        public bool GuardarMatricula(Matricula matricula)
        {
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("INSERT INTO Matricula(Codigo, Fecha, Carrera, AnioMatricula, SegmentoAcademico, AlumnoId) VALUES (@Codigo, @Fecha, @Carrera, @AnioMatricula, @SegmentoAcademico, @AlumnoId)", con))
                {
                    cmd.Parameters.AddWithValue("@Codigo", matricula.Codigo);
                    cmd.Parameters.AddWithValue("@Fecha", matricula.Fecha);
                    cmd.Parameters.AddWithValue("@Carrera", matricula.Carrera);
                    cmd.Parameters.AddWithValue("@AnioMatricula", matricula.AnioMatricula);
                    cmd.Parameters.AddWithValue("@SegmentoAcademico", matricula.SegmentoAcademico);
                    cmd.Parameters.AddWithValue("@AlumnoId", matricula.AlumnoId);
                    int rows = cmd.ExecuteNonQuery();
                    return rows > 0;
                }
            }
        }

        public Matricula ObtenerMatriculaPorId(int id)
        {
            Matricula matricula = null;

            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Matricula WHERE MatriculaId = @id", con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            matricula = new Matricula
                            {
                                MatriculaId = Convert.ToInt32(reader["MatriculaId"]),
                                Codigo = reader["Codigo"].ToString(),
                                Fecha = Convert.ToDateTime(reader["Fecha"]),
                                Carrera = reader["Carrera"].ToString(),
                                AnioMatricula = Convert.ToInt32(reader["AnioMatricula"]),
                                SegmentoAcademico = reader["SegmentoAcademico"].ToString(),
                                AlumnoId = Convert.ToInt32(reader["AlumnoId"])
                            };
                        }
                    }
                }
            }

            return matricula;
        }

        public List<Matricula> ObtenerMatriculaPorAlumnoId(int alumnoId)
        {
            List<Matricula> matriculas = new List<Matricula>();

            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Matricula WHERE AlumnoId = @alumnoId", con))
                {
                    cmd.Parameters.AddWithValue("@alumnoId", alumnoId);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Matricula matricula = new Matricula
                            {
                                MatriculaId = Convert.ToInt32(reader["MatriculaId"]),
                                Codigo = reader["Codigo"].ToString(),
                                Fecha = Convert.ToDateTime(reader["Fecha"]),
                                Carrera = reader["Carrera"].ToString(),
                                AnioMatricula = Convert.ToInt32(reader["AnioMatricula"]),
                                SegmentoAcademico = reader["SegmentoAcademico"].ToString(),
                                AlumnoId = Convert.ToInt32(reader["AlumnoId"])
                            };

                            matriculas.Add(matricula);
                        }
                    }
                }
            }

            return matriculas;
        }

        public List<Matricula> ObtenerMatriculas()
        {
            List<Matricula> matriculas = new List<Matricula>();

            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Matricula", con))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Matricula matricula = new Matricula
                            {
                                MatriculaId = Convert.ToInt32(reader["MatriculaId"]),
                                Codigo = reader["Codigo"].ToString(),
                                Fecha = Convert.ToDateTime(reader["Fecha"]),
                                Carrera = reader["Carrera"].ToString(),
                                AnioMatricula = Convert.ToInt32(reader["AnioMatricula"]),
                                SegmentoAcademico = reader["SegmentoAcademico"].ToString(),
                                AlumnoId = Convert.ToInt32(reader["AlumnoId"])
                            };

                            matriculas.Add(matricula);
                        }
                    }
                }
            }

            return matriculas;
        }

        public bool EliminarMatricula(int id)
        {
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("DELETE FROM Matricula WHERE MatriculaId = @id", con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    int rows = cmd.ExecuteNonQuery();
                    return rows > 0;
                }
            }
        }

        public bool EditarMatricula(Matricula matricula)
        {
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("UPDATE Matricula SET Fecha = @Fecha, Carrera = @Carrera, AnioMatricula = @AnioMatricula, SegmentoAcademico = @SegmentoAcademico, AlumnoId = @AlumnoId WHERE MatriculaId = @MatriculaId", con))
                {
                    cmd.Parameters.AddWithValue("@Codigo", matricula.Codigo);
                    cmd.Parameters.AddWithValue("@Fecha", matricula.Fecha);
                    cmd.Parameters.AddWithValue("@Carrera", matricula.Carrera);
                    cmd.Parameters.AddWithValue("@AnioMatricula", matricula.AnioMatricula);
                    cmd.Parameters.AddWithValue("@SegmentoAcademico", matricula.SegmentoAcademico);
                    cmd.Parameters.AddWithValue("@AlumnoId", matricula.AlumnoId);
                    cmd.Parameters.AddWithValue("@MatriculaId", matricula.MatriculaId);

                    int rows = cmd.ExecuteNonQuery();
                    return rows > 0;
                }
            }
        }

    }
}
