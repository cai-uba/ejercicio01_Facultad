using Facultad.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Docente : Empleado
    {
        public override string GetNombreCompleto()
        {
            return string.Format("Docent {0}", this.Nombre);
        }

        public string toSting()
        {
            return GetNombreCompleto();
        }
        public Docente(int legajo, string nombre, string apellido, DateTime fechaNacimiento, DateTime fechaIngreso) : base(legajo, nombre, apellido, fechaNacimiento, fechaIngreso)
        {
        }
    }
}
