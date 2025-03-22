using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Bedel : Empleado
    {
        private string _apodo;

        public string Apodo { get => _apodo; set => _apodo = value; }

        public override string GetNombreCompleto()
        {
            return string.Format("Bedel {0}", this._apodo);
        }

        public string toSting()
        {
            return GetNombreCompleto();
        }

        public Bedel(int legajo, string nombre, string apellido, DateTime fechaNacimiento, DateTime fechaIngreso, string apodo) : base(legajo, nombre, apellido, fechaNacimiento, fechaIngreso)
        {
            this._apodo = apodo;
        }
    }
}
