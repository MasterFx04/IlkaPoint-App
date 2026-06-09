using IlkaPoint.Data.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Windows;

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
                foreach (DetallesTransaccion detalle in transaccion.Detalles)
                {
                    detalle.Producto = null;
                    detalle.Transaccion = null;

                    // busca el stock del producto
                    Stock stock = db.Stocks.FirstOrDefault(s => s.ProductoId == detalle.ProductoId);

                    if (stock == null)
                        throw new Exception($"No existe stock registrado para el producto {detalle.Producto.nombre}");

                    if (stock.Cantidad < detalle.Cantidad)
                    {
                        MessageBox.Show("No hay stock disponible para el deseado");
                        return;
                    }
                        //throw new Exception($"Stock insuficiente para {detalle.Producto.nombre}. Disponible: {stock.Cantidad}");

                    // reduce la cantidad
                    stock.Cantidad -= detalle.Cantidad;
                }

                transaccion.Total = transaccion.CalcularTotal();
                db.Transacciones.Add(transaccion);
                db.SaveChanges();
            }
        }

        public List<Transaccion> ObtenerTodasLasTransacciones()
        {
            using (AppDBContext db = new AppDBContext())
            {
                return db.Transacciones
                         .Include(c => c.Detalles)
                         .OrderByDescending(c => c.Fecha)
                         .ToList();
            }
        }
    }
}
