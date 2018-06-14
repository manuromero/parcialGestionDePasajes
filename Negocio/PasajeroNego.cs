using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using Repositorio;
using System.Data;

namespace Negocio
{
    public class PasajeroNego
    {
        PasajeroRepo pasajeroRepo = new PasajeroRepo();

        public void GuardarPasajero(Pasajero pasajero)
        {
            pasajeroRepo.GuardarPasajero(pasajero);
        }

        public DataTable ListarPasajero()
        {

            return pasajeroRepo.ListarPasajero();
        }
        public DataTable ListarPasajeroId(int idPasajero)
        {

            return pasajeroRepo.ListarPasajeroID(idPasajero);
        }

        public void UpdatePasajero(Pasajero auto, int idPasajero)
        {
            pasajeroRepo.UpdatePasajerp(auto, idPasajero);
        }

    }
}
