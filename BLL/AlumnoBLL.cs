using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{

    public class AlumnoBLL
    {
        private AlumnoDAL alumnoDAL;

        public AlumnoBLL() {
            alumnoDAL = new AlumnoDAL();
        }
            public List<Alumno> ListaAlumnos()
        {
            try
            {
                return alumnoDAL.ObtenerAlumnos();
            }catch(Exception ex)
            {
                throw new Exception("Error al obtener alumnos. Error:" + ex.Message);
            }
            
        }
    }
}
