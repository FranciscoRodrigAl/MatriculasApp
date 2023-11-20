using BLL;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Alumno : Form
    {
        AlumnoBLL alumnoBLL;
        public Alumno()
        {
            InitializeComponent();
            alumnoBLL = new AlumnoBLL();
            CargarAlumnos();
        }

        private void Alumno_Load(object sender, EventArgs e)
        {

        }

        public void CargarAlumnos()
        {
            List<DAL.Alumno> list = alumnoBLL.ListaAlumnos();
            dataGridAlumnos.DataSource= list;
            dataGridAlumnos.Columns["PersonaId"].Visible= false;
            dataGridAlumnos.Columns["Matricula"].Visible= false;
            dataGridAlumnos.Columns["Persona"].Visible= false;
        }

        private void dataGridAlumnos_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection selectedRows = dataGridAlumnos.SelectedRows;
            List<DAL.Alumno> lista = dataGridAlumnos.DataSource as List<DAL.Alumno>;
            if(selectedRows.Count > 0 && lista != null)
            {
                var index = selectedRows[0].Index;
                DAL.Alumno seleccionado = lista.ElementAt(index);
                tbIdAlumno.Text = seleccionado.AlumnoId.ToString();
                dtPickerNacimiento.Text = seleccionado.FechaIngreso.ToString();
                tbCarrera.Text = seleccionado.CarreraActual;
                tbEstadoAcademico.Text = seleccionado.EstadoAcademico;
            }

        }

        private void btnMostrarMatriculas_Click(object sender, EventArgs e)
        {

            int alumnoId = !String.IsNullOrEmpty(tbIdAlumno.Text) ? int.Parse(tbIdAlumno.Text):-1;
            if(alumnoId >= 0)
            {
                Matricula formMatricula = Matricula.ObtenerInstancia(alumnoId);
                formMatricula.Show();
            }
        }

        private void btLimpiar_Click(object sender, EventArgs e)
        {
            tbIdAlumno.Clear();
            dtPickerNacimiento.ResetText();
            tbCarrera.Clear();
            tbEstadoAcademico.Clear();
        }

        private void btCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
