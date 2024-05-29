using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace wsMercaditoFeliz
{
    public partial class principal : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Vlaidacion de usuario en sesión
            if (Session["nombre"].ToString() == "" &&
               Session["usuario"].ToString() == "")
            {
                Response.Write("<script language='javascript'> " +
                    "alert('Acceso restringido, debe iniciar sesión')" +
                    "</script>");
                Response.Write("<script language='javascript'> " +
                        "document.location.href='wpAcceso.aspx';" +
                        "</script>");
            }
            //-------------------------------------------------------
            Label2.Text = Session["nombre"].ToString() + "  (" +
                         Session["usuario"].ToString() + "  )";

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            //Cerrar sesion de usuario
            Session["nombre"] = "";
            Session["usuario"] = "";
            Response.Write("<script language='javascript'> " +
                    "alert('Sesion cerrada exitosamente')" +
                    "</script>");
            Response.Write("<script language='javascript'> " +
                    "document.location.href='wpAcceso.aspx';" +
                    "</script>");
        }
    }
}