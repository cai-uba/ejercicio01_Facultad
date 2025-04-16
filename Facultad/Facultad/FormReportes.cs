using System;
using Facultad.Persistencia;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Facultad.Entidades;
using System.Runtime.CompilerServices;

namespace Facultad
{
    public partial class FormReportes : Form
    {
        public FormReportes()
        {
            InitializeComponent();
        }

        Universidad uba = new Universidad();

        private void button1_Click(object sender, EventArgs e)
        {

            int cantidadExamenes = obtenerExamenesPorAlumno(16198);

            MessageBox.Show("El alumno 16198 tiene rendido " + cantidadExamenes + " examenes.");
        }

        private int obtenerExamenesPorAlumno(int idAlumno)
        {

            Alumno alumno = buscarAlumno(idAlumno);
            return alumno.Examenes.Count;
        
        }

        private Alumno buscarAlumno(int codigo)
        {
            Alumno alumnoBuscado = null;
            List<Alumno> listadoAlumnos = uba.Alumnos;

            foreach (Alumno alumno in listadoAlumnos)
            {
                if (alumno.Codigo == 16198)
                {
                    alumnoBuscado = alumno;
                    break;
                }
            }

            return alumnoBuscado;
        }
    }
}
