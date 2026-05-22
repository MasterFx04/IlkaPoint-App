using IlkaPoint.Data.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IlkaPoint.Clases
{
    public class DetallesTransaccion
    {
        private int _id;
        private int _transaccionId;
        private int _productoId;

        private int cantidad;
        private decimal precioUnitario;
        private decimal subTotal;

        //Encapsulamiento
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public int TransaccionId
        {
            get { return _transaccionId; }
            set { _transaccionId = value; }
        }
        public int ProductoId
        {
            get { return _productoId; }
            set { _productoId = value; }
        }
        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }
        public decimal SubTotal
        {
            get { return subTotal; }
            set { subTotal = value; }
        }
        public decimal PrecioUnitario
        {
            get { return precioUnitario; }
            set { precioUnitario = value; }
        }

        public DetallesTransaccion(int productoId, int cantidad, decimal precioUnitario)
        {
            _productoId = productoId;
            this.cantidad = cantidad;
            this.precioUnitario = precioUnitario;

            //ESTA FUNCION VOID CALCULA EL SUBTOTAL DEPENDIENDO DEL PRECIO Y CANTIDAD DEL PRODUCTO
            CalcularSubtotal();
        }

        private void CalcularSubtotal()
        {
            subTotal = cantidad * precioUnitario;
        }

        //NAVEGACION ENTRE CLASES, ESTO PERMITE QUE UN OBJETO ALMACENE VARIOS OBJETOS Y PODER HACER CONSULTAS
        public Transaccion Transaccion
        {
            get;
            set;
        }
        
        public Producto Producto
        {
            get;
            set;
        }
        
    }
}
