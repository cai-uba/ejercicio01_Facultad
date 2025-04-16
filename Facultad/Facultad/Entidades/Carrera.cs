using Facultad.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facultad.Entidades
{
    public class Carrera
    {
        int _id;
        List<Materia> _materias;
        String _nombre;

        public int Id { get => _id; set => _id = value; }
        public List<Materia> Materias { get => _materias; set => _materias = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }

        public Carrera(string registro)
        {
            String[] datos = registro.Split(';');
            this.Id = int.Parse(datos[0]);
            this._materias = buscarMaterias(this.Id);
            this.Nombre = datos[1];
        }

        private List<Materia> buscarMaterias(int idCarrera)
        {
            List<Materia> materias = new List<Materia>();

            PersistenciaUtils persistenciaUtils = new PersistenciaUtils();

            List<String> listadoMaterias = persistenciaUtils.LeerRegistro("materias.csv");

            int contador = 0;
            foreach (String registro in listadoMaterias)
            {
                if(contador== 0)
                {
                    contador++;
                    continue;
                }
                if (registro[0].Equals(idCarrera))
                {
                    Materia materia = new Materia(registro);
                    materias.Add(materia);
                }
            }

            return materias;
        }
    }
}
