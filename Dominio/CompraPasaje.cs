using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class CompraPasaje
    {
        private int idCompraPasaje;
        private int idPasajero;
        private string origen;
        private string destino;
        private DateTime fechaViaje;
        private int idLineaAerea;

        public int IdCompraPasaje
        {
            get
            {
                return idCompraPasaje;
            }

       }

        public int IdPasajero
        {
            get
            {
                return idPasajero;
            }

            set
            {
                idPasajero = value;
            }
        }

        public string Origen
        {
            get
            {
                return origen;
            }

            set
            {
                origen = value;
            }
        }

        public string Destino
        {
            get
            {
                return destino;
            }

            set
            {
                destino = value;
            }
        }

        public DateTime FechaViaje
        {
            get
            {
                return fechaViaje;
            }

            set
            {
                fechaViaje = value;
            }
        }

        public int IdLineaAerea
        {
            get
            {
                return idLineaAerea;
            }

            set
            {
                idLineaAerea = value;
            }
        }

        public CompraPasaje()
        {
          
        }
    }
}
