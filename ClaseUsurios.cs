using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace proyecto1VanessaAlvaradoS
{
    public class ClaseUsurios
    {
        public static string nombre { get; set; }
        public static string cedula { get; set; }
        public static string apellido { get; set; }
        public static string correo { get; set; }
        public static string clave { get; set; }
        public static string direccion { get; set; }
        public static string telefono { get; set; }

        //constructor
        public ClaseUsurios(string nom, string ced, string ap, string co, string cl, string di, string tel)
        {
            nombre = nom;
            cedula = ced;
            apellido = ap;
            correo = co;
            clave = cl;
            direccion = di;
            telefono = tel;
        }
        public static string Getnombre() { return nombre; }
        public static string Getapellido() { return apellido; }
        public static string Getcedula() { return cedula; }
        public static string Getcorreo() { return correo; }
        public static string Getclave() { return clave; }
        public static string Getdireccion() { return direccion; }
        public static string Gettelefono() { return telefono; }


        public static void Setcedula(string ced)
        {
            cedula = ced;
        }
        public static void Setnombre(string nom)
        {
            nombre = nom;
        }
        public static void Setapellido(string ap)
        {
            apellido = ap;
        }
        public static void Setcorreo(string co)
        {
            correo = co;
        }
        public static void Setclave(string cl)
        {
            clave = cl;
        }
        public static void Setdireccion(string di)
        {
            direccion = di;
        }
        public static void Settelefono(string tel)
        {
            telefono = tel;
        }

        public static int RegitroUsuario()
        {
            int retorno = 0;
            int tipo = 0;
            SqlConnection Conn = new SqlConnection();
            try
            {
                using (Conn = DBconn.obtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand("Registro", Conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new SqlParameter("@cedula", cedula));
                    cmd.Parameters.Add(new SqlParameter("@nombre", nombre));
                    cmd.Parameters.Add(new SqlParameter("@apellido", apellido));
                    cmd.Parameters.Add(new SqlParameter("@email", correo));
                    cmd.Parameters.Add(new SqlParameter("@clave", clave));
                    cmd.Parameters.Add(new SqlParameter("@direccion", direccion));
                    cmd.Parameters.Add(new SqlParameter("@telefono", telefono));
                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        if (rdr.Read())
                        {
                            retorno = 1;
                        }
                    }
                }
            }
            catch
            {
            }
            return tipo;
        }
        public void   Agregar()
        {
            String strConnString = ConfigurationManager.ConnectionStrings["UHPROYECTOConnectionString"].ConnectionString;
            SqlConnection con = new SqlConnection(strConnString);
            con.Open();
            SqlCommand command = new SqlCommand("sp_AgregarCliente", con);
            command.Parameters.Add(new SqlParameter("correo", correo));
            command.Parameters.Add(new SqlParameter("clave", clave));
            command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
        }

        public static int ConsultaUsuario()
        {
            int retorno = 0;
            int tipo = 0;
            SqlConnection Conn = new SqlConnection();
            try
            {
                using (Conn = DBconn.obtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand("ConsultaFiltro", Conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new SqlParameter("@tipotransaccion", cedula));
                    cmd.Parameters.Add(new SqlParameter("@usuario", nombre));
                    cmd.Parameters.Add(new SqlParameter("@mes", apellido));
                    //retorno = cmd.ExecuteNonQuery();
                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        if (rdr.Read())
                        {
                            retorno = 1;
                        }
                    }
                }
            }
            catch
            {

            }
            return tipo;
        }
    }
}


                


            
           
    

