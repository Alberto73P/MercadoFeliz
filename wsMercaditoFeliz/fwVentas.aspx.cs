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
    public partial class fwVentas : System.Web.UI.Page
    {
        int i = 0;
        private List<Producto> Productos
        {
            get
            {
                if (Session["productos"] == null)
                    Session["productos"] = new List<Producto>();
                return (List<Producto>)Session["productos"];
            }
            set
            {
                Session["productos"] = value;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {                
                InicializarTabla();
            }
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            svcConexionesSoapClient objServ = new svcConexionesSoapClient();
            DataSet ds = objServ.sp_ConsultaProductoVenta(txtProducto.Text);

            if (ds.Tables[0].Rows[0][0].ToString() == "0")
            {
                
            }
            else
            {
                string nombre = ds.Tables[0].Rows[0][0].ToString();
                decimal precio = (decimal)ds.Tables[0].Rows[0][1];
                Producto producto = new Producto(nombre, precio, 1);
                Productos.Add(producto);
                InicializarTabla();
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            if (EsTablaValida())
            {
                try
                {
                    svcConexionesSoapClient objServ = new svcConexionesSoapClient();
                    DataSet ds = objServ.sp_InsVenta(Session["usuario"].ToString());
                    Response.Write("<script>alert('Venta registrada');</script>");

                    foreach (TableRow row in tblVenta.Rows.Cast<TableRow>().Skip(1))
                    {
                        TextBox txtCantidad = (TextBox)row.Cells[0].FindControl("txtCantidad");
                        int cantidad = int.Parse(txtCantidad.Text);
                        string nombreProducto = row.Cells[1].Text;

                        // Llama al procedimiento almacenado para insertar el detalle de la venta
                        DataSet ds2 = objServ.sp_InsDetalleVenta( nombreProducto, cantidad);
                    }
                }
                catch (Exception ex)
                {
                    Response.Write("<script>alert('Ocurrió un error al registrar la venta: " + ex.Message + "');</script>");
                }
                finally
                {
                    Productos.Clear();
                }
            }
            else
            {
                Response.Write("<script>alert('La tabla no es válida. Asegúrate de que todas las filas tengan una cantidad mayor o igual a 1.');</script>");
            }
        }

        private void InicializarTabla()
        {
            foreach (Producto producto in Productos)
            {
                AgregarFilaATabla(producto);
            }
        }

        private void AgregarFilaATabla(Producto producto)
        {
            i++;
            TableRow fila = new TableRow();
            TableCell celdaCantidad = new TableCell();
            TextBox txtCantidad = new TextBox { ID = "txtCantidad"+i, Text = producto.Cantidad.ToString()};
            celdaCantidad.Controls.Add(txtCantidad);
            fila.Cells.Add(celdaCantidad);

            // Celda para el nombre del producto
            fila.Cells.Add(new TableCell { Text = producto.Nombre });

            // Celda para el precio
            fila.Cells.Add(new TableCell { Text = producto.Precio.ToString("F2") });

            // Celda para el total
            TableCell celdaTotal = new TableCell();
            decimal total = producto.Precio * producto.Cantidad;
            celdaTotal.Text = total.ToString("F2");
            fila.Cells.Add(celdaTotal);
            tblVenta.Rows.Add(fila);
        }
        protected void txtCantidad_KeyPress(object sender, EventArgs e)
        {
            Response.Write("<script>alert('Venta registrada');</script>");
        }

        private void CalcularTotal(TableRow fila, decimal precio)
        {
            TextBox txtCantidad = (TextBox)fila.Cells[0].FindControl("txtCantidad");
            decimal cantidad;

            if (decimal.TryParse(txtCantidad.Text, out cantidad))
            {
                decimal total = cantidad * precio;
                fila.Cells[3].Text = total.ToString("F2");
            }
        }

        private bool EsTablaValida()
        {
           
            return true;
        }
    }

    public class Producto
    {
        public string Nombre { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Precio { get; set; }

        public Producto(string nombre, decimal precio, decimal cantidad)
        {
            Nombre = nombre;
            Precio = precio;
            Cantidad = cantidad;
        }
    }
}
