using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using Dominio;

namespace Presentacion
{
    public partial class ComprarPasaje : System.Web.UI.Page
    
 
    {

        PasajeroNego pasajeroNego = new PasajeroNego();
        LineasAereasNego lineaNego = new LineasAereasNego();
        CompraPasajeNego compraNego = new CompraPasajeNego();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["idPasajero"] != null)
                {
                    int idPasajero = int.Parse(Request.QueryString["idPasajero"]);
                    CargarPasajero(idPasajero);

                }
            }
        }

        //protected void BtnListLineas_Click(object sender, EventArgs e)
        //{
        //    DDL.DataSource = lineaNego.ListarLineas();
        //    DDL.DataTextField = "nombre";
        //    DDL.DataValueField = "idLineaAerea";
        //    DDL.DataBind();
        //    DDL.Items.Insert(0, new ListItem("seleccione opcion", "0"));
        //}

        //protected void DDL_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    int idLineaAerea = int.Parse(DDL.SelectedValue);
        //    listarLineaAerea(idCliente);
        //}

        protected void BtnComprar_Click(object sender, EventArgs e)
        {
            completarCompra();
        }

        protected void BtnListarCompras_Click(object sender, EventArgs e)
        {
            GdvVentas.DataSource = compraNego.ListarCompras();
            GdvVentas.DataBind();
        }

        public void CargarPasajero(int idPasajero)
        {
            DataTable dataTable = new DataTable();
            dataTable = pasajeroNego.ListarPasajeroId(idPasajero);
            HFIdPasajero.Value = dataTable.Rows[0]["idPasajero"].ToString();
            LblNombre.Text = dataTable.Rows[0]["nombre"].ToString();
            LblApellido.Text = dataTable.Rows[0]["apellido"].ToString();
            LblEdad.Text = dataTable.Rows[0]["edad"].ToString();
            LblFechaNacimiento.Text = dataTable.Rows[0]["fechaNacimiento"].ToString();
        }

        public void completarCompra()
        {
            CompraPasaje compra = new CompraPasaje();
            compra.IdPasajero = int.Parse(HFIdPasajero.Value);
            compra.IdLineaAerea = int.Parse(HFIdLienea.Value);
            compra.Origen = TbxOrigen.Text;
            compra.Destino = TbxDestino.Text;
            compra.FechaViaje = Convert.ToDateTime(tbxFechaViaje.Text);
            compraNego.GuardarCompra(compra);

        }

    }
}