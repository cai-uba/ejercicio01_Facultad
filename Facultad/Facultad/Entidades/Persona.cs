using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facultad.Entidades
{
    public abstract class Persona
    {
        // ATRIBUTOS
        private string _apellido;
        private DateTime _fechaNac;
        protected string _nombre;

        // PROPIEDADES
        public string Apellido { get => _apellido; set => _apellido = value; }
        public DateTime FechaNac { get => _fechaNac; set => _fechaNac = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }

        protected abstract void GetCredencial();

        protected virtual void GetNombreCompleto()
        {

        }

        protected void GetSaludoInformal()
        {

        }

    }
}
