using Facultad.Entidades;
using Facultad.Persistencia;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace Facultad.Entidades
{
    public class Alumno : Persona
    {
        // ATRIBUTOS
        private int _codigo;
        private List<Carrera> _carreras;
        private List<Examen> _examenes;

        public Alumno(string registro)
        {
            String[] datos = registro.Split(';');
            this.Codigo = int.Parse(datos[0]);  
            this.Nombre = datos[1];
            this.Apellido = datos[2];
            this.FechaNac = DateTime.ParseExact(datos[3], "d/M/yyyy", CultureInfo.InvariantCulture);
            this.Carreras = obtenerCarreras(datos[4]);
            this.Examenes = obtenerExamenes(this.Codigo);
        }

        private List<Examen> obtenerExamenes(int idAlumno)
        {

            List<Examen> examenes = new List<Examen>();

            PersistenciaUtils persistenciaUtils = new PersistenciaUtils();

            List<String> listadoExamenes= persistenciaUtils.LeerRegistro("examenes.csv");

            int contador = 0;
            foreach (String registro in listadoExamenes)
            {
                if(contador == 0)
                {
                    contador++;
                    continue;
                }
                int idAlumnoExamen = int.Parse(registro.Split(';')[5]); 
                if (idAlumnoExamen == idAlumno)
                {
                    examenes.Add(new Examen(registro));
                }
            }

            return examenes;
        }

        private List<Carrera> obtenerCarreras(String idCarreras)
        {
            List<Carrera> carrerasAlumno = new List<Carrera>();
            
            String[] idCarrerasAlumno = idCarreras.Split(',');
            for (int i = 0; i < idCarrerasAlumno.Length; i++)
            {
                Carrera carrera = buscarCarrera(idCarrerasAlumno[i]);
                carrerasAlumno.Add(carrera);
            }

            return carrerasAlumno;
        }

        private Carrera buscarCarrera(String idCarrera)
        {
            Carrera carrera = null;

            PersistenciaUtils persistenciaUtils = new PersistenciaUtils();

            List<String> listadoCarreras = persistenciaUtils.LeerRegistro("carreras.csv");

            int contador = 0;
            foreach (String registro in listadoCarreras)
            {
                if(contador== 0)
                {
                    contador++;
                    continue;
                }
                if (registro[0].Equals(idCarrera))
                {
                    carrera = new Carrera(registro);
                }
            }

            return carrera;
        }

        // PROPIEDADES
        public int Codigo { get => _codigo; set => _codigo = value; }
        public List<Carrera> Carreras { get => _carreras; set => _carreras = value; }
        public List<Examen> Examenes { get => _examenes; set => _examenes = value; }

        // METODOS
        protected override void GetCredencial()
        {

        }

        public override String ToString()
        {
            return this.Apellido + ", " + this.Nombre + " (" + this.Codigo + ")";
        }

    }
}
