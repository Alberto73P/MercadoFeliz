using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using wsMercaditoFeliz.wsrvTienditaFeliz;
using System.Data;

namespace wsMercaditoFeliz
{
    public partial class wpAcceso : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // Creacion del objeto del servicio Web
            svcConexionesSoapClient objServ = new svcConexionesSoapClient();
            DataSet ds = new DataSet();
            ds = objServ.sp_Acceso(TextBox1.Text, TextBox2.Text);
            //--------------------------------------

            // Analizar los datos recibidos y enviar respuesta al usuario
            string ban;
            string usuario;
            ban = ds.Tables[0].Rows[0][0].ToString();
            Response.Write("ban -> " + ban);

            if (ban == "1")
            {
                usuario = ds.Tables[0].Rows[0][1].ToString() + " (" +
                          ds.Tables[0].Rows[0][2].ToString() + ")";

                //-------------------------------------------------------
                // Actualizar las variables de sesion
                Session["nombre"] = ds.Tables[0].Rows[0][1].ToString();
                Session["usuario"] = ds.Tables[0].Rows[0][2].ToString();
                //-------------------------------------------------------
                Response.Write("<script language='javascript'> " +
                    "alert('Bienvenido(a): " + usuario + "')" +
                    "</script>");
                Response.Write("<script language='javascript'> " +
                    "document.location.href='fwProductos.aspx'" +
                    "</script>");
            }
            else
            {
                usuario = "";
                Response.Write("<script language='javascript'> " +
                    "alert('Usuario Incorrecto...')" +
                    "</script>");
                //-------------------------------------------------------
                Session["nombre"] = "";
                Session["usuario"] = "";
                //-------------------------------------------------------
            }


        }
    }
}