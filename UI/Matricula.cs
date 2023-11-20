using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace UI
{
    public partial class Matricula : Form
    {
        private int alumnoId;
        private MatriculaBLL matriculaBLL;
        private DAL.Matricula matriculaSeleccionada;
        private static Matricula instancia;
        private Matricula(int alumnoIdSeleccionado)
        {
            InitializeComponent();
            matriculaBLL= new MatriculaBLL();
            alumnoId = alumnoIdSeleccionado;
            tbAlumnoId.Text = alumnoId.ToString();
            CargarMatriculas(alumnoId);
            ActualizarBoton();
        }

        public static Matricula ObtenerInstancia(int alumnoId)
        {
            if(instancia != null && instancia.alumnoId != alumnoId)
            {
                instancia.Dispose();
            }
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new Matricula(alumnoId);
            }
            return instancia;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void CargarMatriculas(int idAlumno)
        {
            List<DAL.Matricula> lista = obtenerMatriculasAlumno(idAlumno);
            dataGridMatriculas.DataSource = lista;
            dataGridMatriculas.Columns["AlumnoId"].Visible = false;
            dataGridMatriculas.Columns["Alumno"].Visible = false;
        }

        public List<DAL.Matricula> obtenerMatriculasAlumno(int idAlumno)
        {
            return matriculaBLL.BuscarMatriculaDeAlumno(idAlumno);
        }

        private void btnGuardarMatricula_Click(object sender, EventArgs e)
        {
            DAL.Matricula matricula = ObtenerDatosFormulario();
            bool exito;
            if (matricula == null) return;
            DAL.Matricula matriculaExiste = matriculaBLL.ListarMatriculas().Where(m => m.AlumnoId == alumnoId && m.AnioMatricula == matricula.AnioMatricula).FirstOrDefault();
            if(matriculaExiste != null)
            {
                MessageBox.Show("Ya existe una matricula para este alumno en el año ingresado");
                return;
            }
            if (matriculaSeleccionada != null)
            {
                exito = matriculaBLL.EditarMatricula(matricula);
            }
            else
            {
                exito = matriculaBLL.GuardarMatricula(matricula);
            }
            if (exito)
            {
                LimpiarFormulario();
                CargarMatriculas(alumnoId);
                MessageBox.Show("Operación realizada con éxito");
            }

        }

        private void btSelectEdit_Click(object sender, EventArgs e)
        {
            CargarMatriculaEdicion();
        }

        private void dataGridMatriculas_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection selectedRows = dataGridMatriculas.SelectedRows;
            List<DAL.Matricula> lista = dataGridMatriculas.DataSource as List<DAL.Matricula>;
            if(selectedRows.Count > 0)
            {
                matriculaSeleccionada = lista[selectedRows[0].Index];
            }
        }


        public void CargarMatriculaEdicion()
        {
            if(matriculaSeleccionada != null)
            {
                dtPickerIngreso.Text = matriculaSeleccionada.Fecha.ToString();
                tbCodigo.Text = matriculaSeleccionada.Codigo.ToString();
                tbCarrera.Text = matriculaSeleccionada.Carrera.ToString();
                tbAnio.Text = matriculaSeleccionada.AnioMatricula.ToString();
                tbSegmento.Text = matriculaSeleccionada.SegmentoAcademico.ToString();
                ActualizarBoton();
            }
        }
        public void LimpiarFormulario()
        {
            dtPickerIngreso.ResetText();
            tbCodigo.Clear();
            tbCarrera.Clear();
            tbAnio.Clear();
            tbSegmento.Clear();
            matriculaSeleccionada = null;
            ActualizarBoton();
        }

        private void dataGridMatriculas_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridMatriculas.ClearSelection();
            matriculaSeleccionada = null;
        }

        private void btnLimpiarMatricula_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        public void ActualizarBoton()
        {
            if(matriculaSeleccionada!= null)
            {
                btnGuardarMatricula.Text = "Guardar";
            }
            else
            {
                btnGuardarMatricula.Text = "Crear";
            }
        }

        public DAL.Matricula ObtenerDatosFormulario()
        {
            try
            {
                DAL.Matricula matricula = new DAL.Matricula();
                matricula.AlumnoId = alumnoId;
                if (matriculaSeleccionada != null)
                {
                    matricula.MatriculaId = matriculaSeleccionada.MatriculaId;
                }
                int anio = int.Parse(tbAnio.Text);
                string codigo = tbCodigo.Text;
                string segmento = tbSegmento.Text;
                string carrera = tbCarrera.Text;
                DateTime fecha = dtPickerIngreso.Value.Date;
                if (MatriculaValida(codigo, anio, fecha, segmento, carrera))
                {
                    matricula.AnioMatricula = anio;
                    matricula.Carrera = carrera;
                    matricula.Fecha = fecha;
                    matricula.SegmentoAcademico = segmento;
                    matricula.Codigo = codigo;
                    return matricula;

                }
                return null;
            }
            catch(Exception ex)
            {
                throw new Exception("Error al obtener datos");
            }   
        }

        public bool MatriculaValida(string codigo, int anio, DateTime fecha, string segmento,string carrera)
        {
            bool valido = false;
            valido = codigo.Trim().Length > 0 && codigo.Trim().Length <= 5;
            if (!valido)
            {
                MessageBox.Show("El código de la matricula debe tener entre 1 a 5 carácteres", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            valido = segmento.Trim().Length > 0 && segmento.Trim().Length <= 50;
            if (!valido)
            {
                MessageBox.Show("El segmento academico debe tener entre 1 a cincuenta carácteres", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            valido = carrera.Trim().Length > 0 && carrera.Trim().Length <= 50;
            if (!valido)
            {
                MessageBox.Show("La Carrera del empleado debe tener entre 1 a cincuenta carácteres", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            valido = fecha <= DateTime.Today;
            if (!valido)
            {
                MessageBox.Show("La fecha no puede ser mayor al día de hoy", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            valido = anio > 0;
            if (!valido)
            {
                MessageBox.Show("El año de matricula debe ser mayor a cero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return valido;
        }

        private void btCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
