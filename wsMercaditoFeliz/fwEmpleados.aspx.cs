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
    public partial class fwEmpelados : System.Web.UI.Page
    {
        svcConexionesSoapClient objCrud = new svcConexionesSoapClient();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAgregarEmp_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                Response.Write("<script language='javascript'>" +
                               "alert('No se ingreso el nombre');" +
                               "</script>");
            }
            else
            {
                if (txtApellidoP.Text == "")
                {
                    Response.Write("<script language='javascript'>" +
                                    "alert('No se ingreso el apellido paterno ');" +
                                    "</script>");
                }
                else
                {
                    if (txtRFC.Text == "")
                    {
                        Response.Write("<script language='javascript'>" +
                                        "alert('No se ingreso el RFC ');" +
                                        "</script>");
                    }
                    else
                    {
                        if (txtTelefono.Text == "")
                        {
                            Response.Write("<script language='javascript'>" +
                                        "alert('No se ingreso el numero Telefonico');" +
                                        "</script>");
                        }
                        else
                        {
                            if (txtUsuario.Text == "")
                            {
                                Response.Write("<script language='javascript'>" +
                                        "alert('No se ingreso el nombre del usuario');" +
                                        "</script>");
                            }
                            else {
                                if (txtContrasena.Text == "")
                                {
                                    Response.Write("<script language='javascript'>" +
                                        "alert('No se ingreso la contraseña del usuario');" +
                                        "</script>");

                                }
                                else {
                                    DataSet ds = new DataSet();
                                    ds = objCrud.sp_InsEmpleado(txtRFC.Text, txtNombre.Text, txtApellidoP.Text, txtApellidoM.Text, txtTelefono.Text, txtUsuario.Text, txtContrasena.Text);
                                    Response.Write("Estado InsEmpleado --> " + ds.Tables[0].Rows[0][0].ToString());

                                    // Envio de mensajes de salida al usuario
                                    string ban = ds.Tables[0].Rows[0][0].ToString();
                                    if (ban == "0")
                                    {
                                        Response.Write("<script language='javascript'>" +
                                                               "alert('Empleado agregado exitosamente');" +
                                                               "</script>");
                                        Response.Write("<script language='javascript'>" +
                                                       "document.location.href='fwEmpleados.aspx';" +
                                                       "</script>");
                                    }
                                    if (ban == "1")
                                    {
                                        Response.Write("<script language='javascript'>" +
                                                        "alert('No se puede agregar, ya que el RFC ingresado ya existe');" +
                                                        "</script>");
                                    }
                                }                            
                            }                           
                        }
                    }
                }
            }
        }

        protected void btnEliminarEmp_Click(object sender, EventArgs e)
        {
            if (txtRFCDel.Text == "")
            {
                Response.Write("<script language='javascript'>" +
                                        "alert('No se ingreso el RFC ');" +
                                        "</script>");
            }
            else
            {
                DataSet ds = new DataSet();
                ds = objCrud.sp_DelEmpleado(txtRFCDel.Text);
                Response.Write("Estado DelEmpleado --> " + ds.Tables[0].Rows[0][0].ToString());

                // Envio de mensajes de salida al usuario
                string ban = ds.Tables[0].Rows[0][0].ToString();
                if (ban == "0")
                {
                    Response.Write("<script language='javascript'>" +
                                                       "alert('Empleado eliminado exitosamente');" +
                                                       "</script>");
                    Response.Write("<script language='javascript'>" +
                                   "document.location.href='fwEmpleados.aspx';" +
                                   "</script>");
                }
                if (ban == "1")
                {
                    Response.Write("<script language='javascript'>" +
                    "alert('No existe ningún RFC ingresado');" +
                    "</script>");
                }

            }
        }

        protected void btnActualizarEmp_Click(object sender, EventArgs e)
        {
            if (txtRFCUpd.Text == "")
            {
                Response.Write("<script language='javascript'>" +
                                        "alert('Es necesario ingresar el RFC ');" +
                                        "</script>");
            }
            else
            {
                if (txtNombreUpd.Text == "")
                {
                    Response.Write("<script language='javascript'>" +
                               "alert('No se ingreso el nombre');" +
                               "</script>");
                }
                else
                {
                    if (txtApellidoPUpd.Text == "")
                    {
                        Response.Write("<script language='javascript'>" +
                                   "alert('No se ingreso el apellido paterno ');" +
                                   "</script>");
                    }
                    else
                    {
                        if (txtTelefonoUpd.Text == "")
                        {
                            Response.Write("<script language='javascript'>" +
                                        "alert('No se ingreso el numero Telefonico');" +
                                        "</script>");
                        }
                        else
                        {
                            if (txtUsuarioUpd.Text == "") {
                                Response.Write("<script language='javascript'>" +
                                        "alert('No se ingreso el nombre del usuario');" +
                                        "</script>");
                            }
                            else
                            {
                                if (txtContrasenaUpd.Text == "")
                                {
                                    Response.Write("<script language='javascript'>" +
                                        "alert('No se ingreso la contraseña del usuario');" +
                                        "</script>");
                                }
                                else {
                                    DataSet ds = new DataSet();
                                    ds = objCrud.sp_UpdEmpleado(txtRFCUpd.Text, txtNombreUpd.Text, txtApellidoPUpd.Text, txtApellidoMUpd.Text, txtTelefonoUpd.Text,txtUsuarioUpd.Text,txtContrasenaUpd.Text);
                                    Response.Write("Estado InsCliente --> " + ds.Tables[0].Rows[0][0].ToString());

                                    // Envio de mensajes de salida al usuario
                                    string ban = ds.Tables[0].Rows[0][0].ToString();
                                    if (ban == "0")
                                    {
                                        Response.Write("<script language='javascript'>" +
                                                               "alert('Empleado actualizado exitosamente');" +
                                                               "</script>");
                                        Response.Write("<script language='javascript'>" +
                                                       "document.location.href='fwEmpleados.aspx';" +
                                                       "</script>");
                                    }
                                    if (ban == "1")
                                    {
                                        Response.Write("<script language='javascript'>" +
                                                        "alert('No existe ningún RFC ingresado');" +
                                                        "</script>");
                                    }
                                }
                            }                            
                        }
                    }
                }
            }
        }
    }
}