using IlkaPoint.Data.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IlkaPoint.Clases
{
    public class TransaccionService
    {
        //TRANSACCION DB SERVICE :<
        public DetallesTransaccion CrearDetalle(int productoId, int cantidad)
        {
            using (AppDBContext db = new AppDBContext())
            {
                Producto producto = db.Productos.Find(productoId);

                if (producto == null)
                {
                    throw new Exception("El Producto no fue encontrado");
                }
                return new DetallesTransaccion(producto, cantidad);
            }
        }

        public void RegistrarTransaccion(Transaccion transaccion)
        {
            using (AppDBContext db = new AppDBContext())
            {
                transaccion.Total = transaccion.CalcularTotal();
                db.Transacciones.Add(transaccion);
                db.SaveChanges();
            }
        }
    }
}
