using Facultad.Entidades;
using Facultad.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facultad.Entidades
{
    public class Universidad
    {
        // ATRIBUTOS
        private List<Alumno> _alumnos;
        private int _cantidadSedes;
        private List<Empleado> _empleados;
        private string _nombre;

        // PROPIEDADES
        public List<Alumno> Alumnos { get => _alumnos; set => _alumnos = value; }
        public int CantidadSedes { get => _cantidadSedes; set => _cantidadSedes = value; }
        public List<Empleado> Empleados { get => _empleados; set => _empleados = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }

        public Universidad() {
            this._alumnos = cargarAlumnos();
            this._cantidadSedes = 5;
            this._empleados= new List<Empleado>();
            this._nombre = "Universidad de Buenos Aires";
        
        }

        private List<Alumno> cargarAlumnos()
        {
            List<Alumno> listadoAlumnos = new List<Alumno>();

            PersistenciaUtils persistenciaUtils = new PersistenciaUtils();
            List<String> listado = persistenciaUtils.LeerRegistro("alumnos.csv");

            int contador = 0;
            foreach (String registro in listado)
            {
                if(contador == 0)
                {
                    contador++;
                    continue;
                }
                Alumno alumno = new Alumno(registro);

                listadoAlumnos.Add(alumno);
            }

            return listadoAlumnos;
        }



    }
}
