using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace Facultad.Entidades
{
    public class Examen
    {
        int _id;
        int _idMateria;
        String _tipo;
        DateTime _fecha;
        int _nota;

        public int Id { get => _id; set => _id = value; }
        public int IdMateria { get => _idMateria; set => _idMateria = value; }
        public string Tipo { get => _tipo; set => _tipo = value; }
        public DateTime Fecha { get => _fecha; set => _fecha = value; }
        public int Nota { get => _nota; set => _nota = value; }

        public Examen(string registro)
        {
            String[] datos = registro.Split(';');
            this._id = int.Parse(datos[0]);
            this._idMateria = int.Parse(datos[1]);  
            this._tipo = datos[2];
            this._fecha = DateTime.Parse(datos[3]);
            this._nota= int.Parse(datos[4]);
        
        }

    }
}
