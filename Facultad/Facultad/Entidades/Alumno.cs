using Facultad.Entidades;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Alumno : Persona
    {
        // ATRIBUTOS
        private int _codigo;

        public Alumno(string registro)
        {
            String[] datos = registro.Split(';');
            this.Codigo = int.Parse(datos[0]);  
            this.Nombre = datos[1];
            this.Apellido = datos[2];
            this.FechaNac = DateTime.ParseExact(datos[3], "d/M/yyyy", CultureInfo.InvariantCulture);

        }

        // PROPIEDADES
        public int Codigo { get => _codigo; set => _codigo = value; }

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
