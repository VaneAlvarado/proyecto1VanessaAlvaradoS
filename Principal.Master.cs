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
    public partial class Principal : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Listado();
            }
        }
        protected void Listado()
        {
            String strConnString = ConfigurationManager.ConnectionStrings["UHPROYECTOConnectionString"].ConnectionString;
            SqlConnection con = new SqlConnection(strConnString);
            con.Open();
            SqlCommand command = new SqlCommand("SP_ConsultarUsuario", con);
            command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
             
            tcorreo.Text = "";
            tdescripcion.Text = "";
            tmonto.Text = "";
            tfecha.Text = "";
        }
        protected void bAgregar_Click(object sender, EventArgs e)
        {

        }
    }
}