using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace proyecto1VanessaAlvaradoS
{
    public partial class Registrarse : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void bIngresar_Click(object sender, EventArgs e)
        {
            ClaseUsurios.nombre= tNombre.Text;
            ClaseUsurios.cedula = tCedula.Text;
            ClaseUsurios.apellido = tApellido.Text;
            ClaseUsurios.correo= tCorreo.Text;
            ClaseUsurios.clave = tContraseña.Text;
            ClaseUsurios.direccion = tdireccion.Text;
            ClaseUsurios.telefono = ttel.Text;


            int resultado =ClaseUsurios.RegitroUsuario();
            if (resultado > 0)
            {
             ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Notify", "alert(Notification : Usuario ha sido ingresado ", true);
             
            }
            else
            {
             ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Notify", "alert(Notification : Usuario no ha sido ingresado", true);
            }
            return;  
        }
        protected void bVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("login.aspx");
        }
    }
   
}