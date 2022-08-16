using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace proyecto1VanessaAlvaradoS
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void bRegistro_Click(object sender, EventArgs e)
        {
            /*  ClaseUsurios.Getcorreo();
              ClaseUsurios.Getclave();
              String strConnString = ConfigurationManager.ConnectionStrings["UHPROYECTOConnectionString"].ConnectionString;
              SqlConnection con = new SqlConnection(strConnString);
              con.Open();
              SqlCommand command = new SqlCommand("sp_AgregarCliente", con);
              command.Parameters.Add(new SqlParameter("correo", ClaseUsurios.Getcorreo()));
              command.Parameters.Add(new SqlParameter("clave", ClaseUsurios.Getclave()));
              command.CommandType = CommandType.StoredProcedure;
              SqlDataAdapter da = new SqlDataAdapter(command);
              Response.Redirect("master.aspx");
            */
            Response.Redirect("principal.Master");
        }


        protected void bRegistro_Click1(object sender, EventArgs e)
        {
            Response.Redirect("Registrarse.aspx");
        }
    }
}