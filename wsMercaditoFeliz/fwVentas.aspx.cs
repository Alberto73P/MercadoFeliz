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
            if (!IsPostBack)
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
                    foreach (Producto producto in Productos)
                    {                       
                        DataSet ds2 = objServ.sp_InsDetalleVenta(producto.Nombre, producto.Cantidad);
                    }
                    Response.Write("<script>alert('Venta registrada');</script>");
                }
                catch (Exception ex)
                {
                    // Maneja cualquier excepción que ocurra durante la inserción
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
            TableRow fila = new TableRow();
            TableCell celdaCantidad = new TableCell();
            TextBox txtCantidad = new TextBox { ID = "txtCantidad", Text = producto.Cantidad.ToString()};
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
        protected void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            TextBox txtCantidad = (TextBox)sender;
            TableRow fila = (TableRow)txtCantidad.NamingContainer;
            int rowIndex = tblVenta.Rows.GetRowIndex(fila);
            if (rowIndex > 0) // Ignorar la fila de encabezado
            {
                Producto producto = Productos[rowIndex - 1];
                producto.Cantidad = decimal.Parse(txtCantidad.Text);
                CalcularTotal(fila, producto.Precio);
            }
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
