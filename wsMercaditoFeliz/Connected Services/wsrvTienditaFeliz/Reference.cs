﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace wsMercaditoFeliz.wsrvTienditaFeliz {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="wsrvTienditaFeliz.svcConexionesSoap")]
    public interface svcConexionesSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/sp_InsCliente", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet sp_InsCliente(string RFC, string nombre, string apPat, string apMat, string tel);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/sp_InsCliente", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> sp_InsClienteAsync(string RFC, string nombre, string apPat, string apMat, string tel);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/sp_DelCliente", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet sp_DelCliente(string RFC);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/sp_DelCliente", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> sp_DelClienteAsync(string RFC);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/sp_UpdCliente", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet sp_UpdCliente(string RFC, string nombre, string apPat, string apMat, string tel);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/sp_UpdCliente", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> sp_UpdClienteAsync(string RFC, string nombre, string apPat, string apMat, string tel);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/sp_InsEmpleado", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet sp_InsEmpleado(string RFC, string nombre, string apPat, string apMat, string tel, string usuario, string contrasena);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/sp_InsEmpleado", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> sp_InsEmpleadoAsync(string RFC, string nombre, string apPat, string apMat, string tel, string usuario, string contrasena);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/sp_DelEmpleado", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet sp_DelEmpleado(string RFC);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/sp_DelEmpleado", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> sp_DelEmpleadoAsync(string RFC);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/sp_UpdEmpleado", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet sp_UpdEmpleado(string RFC, string nombre, string apPat, string apMat, string tel, string usuario, string contrasena);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/sp_UpdEmpleado", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> sp_UpdEmpleadoAsync(string RFC, string nombre, string apPat, string apMat, string tel, string usuario, string contrasena);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/sp_InsProducto", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet sp_InsProducto(string nombre, string existencia, string PrecioCompra, string PrecioVenta, string tipo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/sp_InsProducto", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> sp_InsProductoAsync(string nombre, string existencia, string PrecioCompra, string PrecioVenta, string tipo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/sp_DelProducto", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet sp_DelProducto(string ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/sp_DelProducto", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> sp_DelProductoAsync(string ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/sp_UpdProducto", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet sp_UpdProducto(string nombre, string existencia, string PrecioCompra, string PrecioVenta, string tipo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/sp_UpdProducto", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> sp_UpdProductoAsync(string nombre, string existencia, string PrecioCompra, string PrecioVenta, string tipo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/vw_Productos", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet vw_Productos();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/vw_Productos", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> vw_ProductosAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/vw_Empleado", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet vw_Empleado();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/vw_Empleado", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> vw_EmpleadoAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/vw_detalle_venta", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet vw_detalle_venta();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/vw_detalle_venta", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> vw_detalle_ventaAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/sp_Acceso", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet sp_Acceso(string usuario, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/sp_Acceso", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> sp_AccesoAsync(string usuario, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/sp_ConsultaProductoVenta", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet sp_ConsultaProductoVenta(string nomProducto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/sp_ConsultaProductoVenta", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> sp_ConsultaProductoVentaAsync(string nomProducto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/sp_InsVenta", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet sp_InsVenta(string nomempleado);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/sp_InsVenta", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> sp_InsVentaAsync(string nomempleado);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/sp_InsDetalleVenta", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet sp_InsDetalleVenta(string nombre, decimal cantidad);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/sp_InsDetalleVenta", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> sp_InsDetalleVentaAsync(string nombre, decimal cantidad);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface svcConexionesSoapChannel : wsMercaditoFeliz.wsrvTienditaFeliz.svcConexionesSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class svcConexionesSoapClient : System.ServiceModel.ClientBase<wsMercaditoFeliz.wsrvTienditaFeliz.svcConexionesSoap>, wsMercaditoFeliz.wsrvTienditaFeliz.svcConexionesSoap {
        
        public svcConexionesSoapClient() {
        }
        
        public svcConexionesSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public svcConexionesSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public svcConexionesSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public svcConexionesSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Data.DataSet sp_InsCliente(string RFC, string nombre, string apPat, string apMat, string tel) {
            return base.Channel.sp_InsCliente(RFC, nombre, apPat, apMat, tel);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> sp_InsClienteAsync(string RFC, string nombre, string apPat, string apMat, string tel) {
            return base.Channel.sp_InsClienteAsync(RFC, nombre, apPat, apMat, tel);
        }
        
        public System.Data.DataSet sp_DelCliente(string RFC) {
            return base.Channel.sp_DelCliente(RFC);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> sp_DelClienteAsync(string RFC) {
            return base.Channel.sp_DelClienteAsync(RFC);
        }
        
        public System.Data.DataSet sp_UpdCliente(string RFC, string nombre, string apPat, string apMat, string tel) {
            return base.Channel.sp_UpdCliente(RFC, nombre, apPat, apMat, tel);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> sp_UpdClienteAsync(string RFC, string nombre, string apPat, string apMat, string tel) {
            return base.Channel.sp_UpdClienteAsync(RFC, nombre, apPat, apMat, tel);
        }
        
        public System.Data.DataSet sp_InsEmpleado(string RFC, string nombre, string apPat, string apMat, string tel, string usuario, string contrasena) {
            return base.Channel.sp_InsEmpleado(RFC, nombre, apPat, apMat, tel, usuario, contrasena);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> sp_InsEmpleadoAsync(string RFC, string nombre, string apPat, string apMat, string tel, string usuario, string contrasena) {
            return base.Channel.sp_InsEmpleadoAsync(RFC, nombre, apPat, apMat, tel, usuario, contrasena);
        }
        
        public System.Data.DataSet sp_DelEmpleado(string RFC) {
            return base.Channel.sp_DelEmpleado(RFC);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> sp_DelEmpleadoAsync(string RFC) {
            return base.Channel.sp_DelEmpleadoAsync(RFC);
        }
        
        public System.Data.DataSet sp_UpdEmpleado(string RFC, string nombre, string apPat, string apMat, string tel, string usuario, string contrasena) {
            return base.Channel.sp_UpdEmpleado(RFC, nombre, apPat, apMat, tel, usuario, contrasena);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> sp_UpdEmpleadoAsync(string RFC, string nombre, string apPat, string apMat, string tel, string usuario, string contrasena) {
            return base.Channel.sp_UpdEmpleadoAsync(RFC, nombre, apPat, apMat, tel, usuario, contrasena);
        }
        
        public System.Data.DataSet sp_InsProducto(string nombre, string existencia, string PrecioCompra, string PrecioVenta, string tipo) {
            return base.Channel.sp_InsProducto(nombre, existencia, PrecioCompra, PrecioVenta, tipo);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> sp_InsProductoAsync(string nombre, string existencia, string PrecioCompra, string PrecioVenta, string tipo) {
            return base.Channel.sp_InsProductoAsync(nombre, existencia, PrecioCompra, PrecioVenta, tipo);
        }
        
        public System.Data.DataSet sp_DelProducto(string ID) {
            return base.Channel.sp_DelProducto(ID);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> sp_DelProductoAsync(string ID) {
            return base.Channel.sp_DelProductoAsync(ID);
        }
        
        public System.Data.DataSet sp_UpdProducto(string nombre, string existencia, string PrecioCompra, string PrecioVenta, string tipo) {
            return base.Channel.sp_UpdProducto(nombre, existencia, PrecioCompra, PrecioVenta, tipo);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> sp_UpdProductoAsync(string nombre, string existencia, string PrecioCompra, string PrecioVenta, string tipo) {
            return base.Channel.sp_UpdProductoAsync(nombre, existencia, PrecioCompra, PrecioVenta, tipo);
        }
        
        public System.Data.DataSet vw_Productos() {
            return base.Channel.vw_Productos();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> vw_ProductosAsync() {
            return base.Channel.vw_ProductosAsync();
        }
        
        public System.Data.DataSet vw_Empleado() {
            return base.Channel.vw_Empleado();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> vw_EmpleadoAsync() {
            return base.Channel.vw_EmpleadoAsync();
        }
        
        public System.Data.DataSet vw_detalle_venta() {
            return base.Channel.vw_detalle_venta();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> vw_detalle_ventaAsync() {
            return base.Channel.vw_detalle_ventaAsync();
        }
        
        public System.Data.DataSet sp_Acceso(string usuario, string password) {
            return base.Channel.sp_Acceso(usuario, password);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> sp_AccesoAsync(string usuario, string password) {
            return base.Channel.sp_AccesoAsync(usuario, password);
        }
        
        public System.Data.DataSet sp_ConsultaProductoVenta(string nomProducto) {
            return base.Channel.sp_ConsultaProductoVenta(nomProducto);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> sp_ConsultaProductoVentaAsync(string nomProducto) {
            return base.Channel.sp_ConsultaProductoVentaAsync(nomProducto);
        }
        
        public System.Data.DataSet sp_InsVenta(string nomempleado) {
            return base.Channel.sp_InsVenta(nomempleado);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> sp_InsVentaAsync(string nomempleado) {
            return base.Channel.sp_InsVentaAsync(nomempleado);
        }
        
        public System.Data.DataSet sp_InsDetalleVenta(string nombre, decimal cantidad) {
            return base.Channel.sp_InsDetalleVenta(nombre, cantidad);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> sp_InsDetalleVentaAsync(string nombre, decimal cantidad) {
            return base.Channel.sp_InsDetalleVentaAsync(nombre, cantidad);
        }
    }
}
