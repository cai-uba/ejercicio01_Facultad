using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facultad.Entidades
{
    public class Credencial
    {
        String usuario;
        String password;
        DateTime fechaAlta;
        DateTime fechaUltimoIngreso;

        public Credencial(string registro)
        {
            String[] datos = registro.Split(';');
            this.Usuario = datos[0];
            this.Password = datos[1];
            this.FechaAlta = DateTime.ParseExact(datos[2], "d/M/yyyy", CultureInfo.InvariantCulture);
            this.FechaUltimoIngreso = DateTime.ParseExact(datos[3], "d/M/yyyy", CultureInfo.InvariantCulture);

        }

        public string Usuario { get => usuario; set => usuario = value; }
        public string Password { get => password; set => password = value; }
        public DateTime FechaAlta { get => fechaAlta; set => fechaAlta = value; }
        public DateTime FechaUltimoIngreso { get => fechaUltimoIngreso; set => fechaUltimoIngreso = value; }
    }
}
