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
        protected string Apellido { get => _apellido; set => _apellido = value; }
        protected DateTime FechaNac { get => _fechaNac; set => _fechaNac = value; }
        protected string NombrePersona { get => _nombre; set => _nombre = value; }

        protected abstract void GetCredencial();

        protected virtual void GetNombreCompleto()
        {

        }

        protected void GetSaludoInformal()
        {

        }

    }
}
