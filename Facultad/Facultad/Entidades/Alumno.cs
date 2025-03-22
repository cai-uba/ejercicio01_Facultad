using Facultad.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Alumno : Persona
    {
        // ATRIBUTOS
        private int _codigo;

        // PROPIEDADES
        public int Codigo { get => _codigo; set => _codigo = value; }

        // METODOS
        protected override void GetCredencial()
        {

        }


    }
}
