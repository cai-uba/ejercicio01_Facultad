using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facultad.Entidades
{
    public class Materia
    {
        int _id;
        String _nombre;
        
        public Materia(string registro)
        {
            String[] datos = registro.Split(';');
            this._id = int.Parse(datos[0]);
            this._nombre = datos[1];
        }

        public int Id { get => _id; set => _id = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
    }
}
