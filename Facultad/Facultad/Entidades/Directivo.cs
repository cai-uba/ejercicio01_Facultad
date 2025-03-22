using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Directivo : Empleado
    {
        public override string GetNombreCompleto()
        {
            return string.Format("Sr. Director {0}", this._apellido);
        }

        public string toSting()
        {
            return GetNombreCompleto();
        }

        public Directivo(int legajo, string nombre, string apellido, DateTime fechaNacimiento, DateTime fechaIngreso) : base(legajo, nombre, apellido, fechaNacimiento, fechaIngreso)
        {
        }
    }
}
