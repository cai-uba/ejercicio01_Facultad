using Facultad.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Facultad
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


    }
}
