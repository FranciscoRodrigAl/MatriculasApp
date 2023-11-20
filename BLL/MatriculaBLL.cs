using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class MatriculaBLL
    {
        private MatriculaDAL matriculaDAL;

        public MatriculaBLL()
        {
            matriculaDAL= new MatriculaDAL();
        }

        public List<Matricula> ListarMatriculas()
        {
            return matriculaDAL.ObtenerMatriculas();
        }

        public bool GuardarMatricula(Matricula nuevaMatricula)
        {
            try
            {
                //Validación de existencia de matricula
                Matricula matriculaExiste = (Matricula)ListarMatriculas().Where(m => m.AlumnoId == nuevaMatricula.AlumnoId && m.AnioMatricula == nuevaMatricula.AnioMatricula).FirstOrDefault();
                if (matriculaExiste != null)
                {
                    throw new Exception("El alumno ya posee una matrícula en el mismo año");
                }
                bool matriculaGuardada = matriculaDAL.GuardarMatricula(nuevaMatricula);
                if (!matriculaGuardada)
                {
                    throw new Exception("Error al guardar la matrícula");
                }
                return matriculaGuardada;
            }
            catch(Exception e)
            {
                throw new Exception("No se guardó la matrícula" + e.Message);
            }
          
        }

        public Matricula BuscarMatricula(int matriculaId)
        {
            try
            {
                return matriculaDAL.ObtenerMatriculaPorId(matriculaId);
            }catch(Exception e)
            {
                throw new Exception("Error al buscar matricula con id " + matriculaId.ToString() + " Error: " + e.Message);
            }
            
        }

        public List<Matricula> BuscarMatriculaDeAlumno(int alumnoId)
        {
            try
            {
                return matriculaDAL.ObtenerMatriculaPorAlumnoId(alumnoId);
            }
            catch (Exception e)
            {
                throw new Exception("Error al buscar matriculas con id " + alumnoId.ToString() + " Error: " + e.Message);
            }

        }

        public bool EditarMatricula(Matricula matriculaEditada)
        {
            try
            {
                Matricula matriculaExiste = (Matricula)ListarMatriculas().Where(m => m.MatriculaId == matriculaEditada.MatriculaId).FirstOrDefault();
                if (matriculaExiste == null)
                {
                    throw new Exception("La matricula a editar no fue encontrada");
                }
                bool editada = matriculaDAL.EditarMatricula(matriculaEditada);
                if (!editada)
                {
                    throw new Exception("Error al editar la matrícula");
                }
                return editada;
            }
            catch (Exception e) {
                throw new Exception("No se pudo editar la matrícula. Error: " + e.Message);
            }

        }


    }
}
