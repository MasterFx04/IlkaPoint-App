using System;
using System.Collections.Generic;
using System.Linq;
using IlkaPoint.Data;
using IlkaPoint.Data.Modelos;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using IlkaPoint.Clases;


namespace IlkaPoint.Servicios
{
    public class ServicioInventario
    {
        public int Id { get; set; }

        //este es el primer nivel de validación
        public bool AgregarProducto(Producto nuevoProducto)
        {
            if (string.IsNullOrEmpty(nuevoProducto.nombre))
                throw new Exception("El nombre del producto es obligatorio para continuar.");

            if (nuevoProducto.precio <= 0)
                throw new Exception("El precio debe ser un valor mayor a 0");

            using (AppDBContext db = new AppDBContext())
            {
                try
                {
                    db.Productos.Add(nuevoProducto);
                    db.SaveChanges(); //esta función guardara la información del nuevo producto creado 
                    return true;

                }

                catch (Exception)
                {
                    return false;

                }
            }
        }
        //llamado para ver el listado completo del inventario
        public List<Producto> ObtenerTodoElInventario()
        {
            using (var db = new AppDBContext())
            {
                return db.Productos.ToList();
            }
        }

        //Filtro para buscar en el inventario los producto por nombre 
        public List<Producto> BuscarProductoPorNombre(string nombreBusqueda)
        {
            using (AppDBContext db = new AppDBContext())
            {
                return db.Productos
                        .Where(p => p.nombre.Contains(nombreBusqueda))
                        .ToList();
            }
        }

        public List<Stock> BuscarStockPorNombre(string nombreDeBusqueda)
        {
            using (AppDBContext db = new AppDBContext())
            {
                return db.Stocks
                        .Where(s => s.productoNombre.Contains(nombreDeBusqueda))
                        .ToList();
            }
        }

        
        public Producto BuscarProductoPorId(int idProducto)
        {
            using (AppDBContext db = new AppDBContext())
            {
                return db.Productos.Find(idProducto);
            }
        }

        /*
        public List<ProductoPorPeso> BuscarProductosTipoPeso()
        {
            using (AppDBContext db = new AppDBContext())
            {
                return db.Productos
                        .OfType<ProductoPorPeso>()
                        .ToList();
            }
        }
        */

        public void EditarProducto(Producto productoEditado, Stock stockEditado)
        {
            using (AppDBContext db = new AppDBContext())
            {
                
                Producto producto = db.Productos.Find(productoEditado.id);

                if (producto == null)
                {
                    throw new Exception("Producto no Encontrado");
                }

                producto.nombre = productoEditado.nombre;
                producto.precio = productoEditado.precio;
                producto.categoria = productoEditado.categoria;

                db.SaveChanges();

            }
            using (AppDBContext db = new AppDBContext())
            {


                Stock stock = db.Stocks.Find(stockEditado.Id);
                if (stock == null)
                {
                    throw new Exception("Producto no Encontrado");

                }

                stock.Cantidad = stockEditado.Cantidad;

                db.SaveChanges();
            }
        }

        public void EliminarProducto(int idProducto)
        {
            using (AppDBContext db = new AppDBContext())
            {
                //ELIMINAMOS EL STOCK
                Stock stock = db.Stocks.FirstOrDefault(s => s.ProductoId == idProducto);
                if (stock != null)
                {
                    db.Stocks.Remove(stock);
                }

                //LUEGO ELIMINAMOS EL PRODUCTO
                Producto producto = db.Productos.Find(idProducto);
                if (producto != null)
                {
                    db.Productos.Remove(producto);
                }

                db.SaveChanges();
            }
        }
        

        //trabajar en la logica para cuando se agrega la cantidad de los productos 
        public bool AgregarCantidadStock(int productoId, int cantidadAgregar)
        {
            if (cantidadAgregar <= 0)
                throw new Exception("La cantidad agregar debe ser mayor a 0");

            using (AppDBContext db = new AppDBContext()) 
            {

                try
                {
                    Stock registrarStock = db.Stocks.FirstOrDefault(s => s.ProductoId == productoId);
                    if (registrarStock == null)
                    {
                        //por si no existe un registro previo de stock del objeto prodcuto (ejemplo manzana) lo creamos
                        Stock nuevoStock = new Stock(productoId, cantidadAgregar, db.Productos.Find(productoId).nombre);

                        db.Stocks.Add(nuevoStock);
                    }

                    else
                    {
                        //si ya existe (cuando se hace la funcion AgregarCantidad += CantidadProducto )
                        registrarStock.Cantidad += cantidadAgregar;
                    }
                    //guardar los cambios en la base de datos 
                    db.SaveChanges();
                    return true;
                }

                catch (Exception)
                {
                    return false;
                }







            }
        }

        public List<Stock> ObtenerElStockActual()
        {
            using (AppDBContext db = new AppDBContext())
            {
                return db.Stocks.ToList();
            }
        }


    }   


        //servicio inventario para que se comunique con la base de datos 
        //public bool RegistrarStock(int productoId, decimal cantidadAgregar)
        // Validación 
        /* if (cantidadAgregar <= 0)
        throw new Exception ("La cantidad a agregar debe ser mayor a 0");
         using (var db = new AppDBContext())
        {
        try
        {
        //para que el usuario busque el producto en la base de datos segun el Id
        var producto = db.Producto.Find(productoId);

        //Agregar o sumar la nueva cantidad al stock siendo el caso de que tenia una cantidad previamente 
        producto.cantidadStock += cantidadAgregar;

        //guardar los cambios en la base de datos 
        db.SaveChanges();
        return true; 
        }
        catch (Exception)
        {
        retun false
        }
        }
        }
        */



       

    
}

