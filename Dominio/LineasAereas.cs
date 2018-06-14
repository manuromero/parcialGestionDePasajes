using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class LineasAereas
    {
        private int idLineaAerea;
        private string nombre;

        public int IdLineaAerea
        {
            get
            {
                return idLineaAerea;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public LineasAereas(int idLineaAerea, string nombre)
        {
            this.idLineaAerea = idLineaAerea;
            this.nombre = nombre;
        }
        public LineasAereas()
        {
        }

    }
}
