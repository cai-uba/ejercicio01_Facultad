using Facultad.Entidades;
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

    }
}
