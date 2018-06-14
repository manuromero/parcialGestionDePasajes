using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositorio;
using Dominio;
using System.Data;

namespace Negocio
{
    public class CompraPasajeNego

    {
        CompraPasajeRepo compraRepo = new CompraPasajeRepo();
        //CompraPasaje compraPasaje = new CompraPasaje();
        public void GuardarCompra(CompraPasaje compraPasaje)
        {
            compraRepo.GuardarCompra(compraPasaje);
        }
        public DataTable ListarCompras()
        {

            return compraRepo.ListarCompras();
        }
    }
}
