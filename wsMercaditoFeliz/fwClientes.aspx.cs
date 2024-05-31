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
    public partial class fwClientes : System.Web.UI.Page
    {
        svcConexionesSoapClient objCrud = new svcConexionesSoapClient();
        protected void Page_Load(object sender, EventArgs e)
        {

            GridView2.PageIndexChanging += GridView2_PageIndexChanging;
            GridView2.DataSource = objCrud.vw_Clientes();
            GridView2.DataMember = "vw_Clientes";
            GridView2.DataBind();

        }

        private void GridView2_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView2.PageIndex = e.NewPageIndex;
            GridView2.DataBind();
        }

        private void GridView1_PageIndexChanging1(object sender, GridViewPageEventArgs e)
        {
            
        }

  
        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtRFC.Text == "")
            {
                
                Response.Write("<script language='javascript'>" +
                                        "alert('No se ingreso el RFC ');" +
                                        "</script>");
            }
            else
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
                        if (txtTelefono.Text == "")
                        {
                            Response.Write("<script language='javascript'>" +
                                        "alert('No se ingreso el numero Telefonico');" +
                                        "</script>");
                        }
                        else
                        {
                            DataSet ds = new DataSet();
                            ds = objCrud.sp_InsCliente(txtRFC.Text, txtNombre.Text, txtApellidoP.Text, txtApellidoM.Text, txtTelefono.Text);
                            Response.Write("Estado InsCliente --> " + ds.Tables[0].Rows[0][0].ToString());

                            // Envio de mensajes de salida al usuario
                            string ban = ds.Tables[0].Rows[0][0].ToString();
                            if (ban == "0")
                            {
                                Response.Write("<script language='javascript'>" +
                                                       "alert('Cliente agregado exitosamente');" +
                                                       "</script>");
                                Response.Write("<script language='javascript'>" +
                                               "document.location.href='fwClientes.aspx';" +
                                               "</script>");
                            }
                            if (ban == "1")
                            {
                                Response.Write("<script language='javascript'>" +
                                                "alert('No se puedo agregar al cliente');" +
                                                "</script>");
                            }
                        }
                    }
                }
            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
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
                ds = objCrud.sp_DelCliente(txtRFCDel.Text);
                Response.Write("Estado DelCliente --> " + ds.Tables[0].Rows[0][0].ToString());

                // Envio de mensajes de salida al usuario
                string ban = ds.Tables[0].Rows[0][0].ToString();
                if (ban == "0")
                {
                    Response.Write("<script language='javascript'>" +
                                                       "alert('Cliente eliminado exitosamente');" +
                                                       "</script>");
                    Response.Write("<script language='javascript'>" +
                                   "document.location.href='fwClientes.aspx';" +
                                   "</script>");
                }
                if (ban == "1")
                {
                    Response.Write("<script language='javascript'>" +
                    "alert('No se logro eleiminar el cliente');" +
                    "</script>");
                }

            }
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            if (txtRFC.Text == "")
            {
                Response.Write("<script language='javascript'>" +
                                        "alert('Es necesario ingresar el RFC ');" +
                                        "</script>");               
            }
            else
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
                        if (txtTelefono.Text == "")
                        {
                            Response.Write("<script language='javascript'>" +
                                        "alert('No se ingreso el numero Telefonico');" +
                                        "</script>");
                        }
                        else
                        {
                            DataSet ds = new DataSet();
                            ds = objCrud.sp_UpdCliente(txtRFC.Text, txtNombre.Text, txtApellidoP.Text, txtApellidoM.Text, txtTelefono.Text);
                            Response.Write("Estado InsCliente --> " + ds.Tables[0].Rows[0][0].ToString());

                            // Envio de mensajes de salida al usuario
                            string ban = ds.Tables[0].Rows[0][0].ToString();
                            if (ban == "0")
                            {
                                Response.Write("<script language='javascript'>" +
                                                       "alert('Cliente actualizado exitosamente');" +
                                                       "</script>");
                                Response.Write("<script language='javascript'>" +
                                               "document.location.href='fwClientes.aspx';" +
                                               "</script>");
                            }
                            if (ban == "1")
                            {
                                Response.Write("<script language='javascript'>" +
                                                "alert('No se puedo actualizar el cliente');" +
                                                "</script>");
                            }
                        }
                    }

                }
            }
        }
    }
}