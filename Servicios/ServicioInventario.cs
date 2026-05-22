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
        //este es el primer nivel de validación
        public bool AgregarProducto(Producto nuevoProducto)
        {
            if (string.IsNullOrEmpty(nuevoProducto.nombre))
                throw new Exception("El nombre del producto es obligatorio para continuar.");

            if (nuevoProducto.precio <= 0)
                throw new Exception("Elprecio debe ser un valor mayor a 0.");

            using (var db = new AppDBContext())
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
            using (var db = new AppDBContext())
            {
                return db.Productos
                        .Where(p => p.nombre.Contains(nombreBusqueda))
                        .ToList();
            }
        }

        //trabajar en la logica para cuando se agrega la cantidad de los productos 

        public bool AgregarCantidadStock(int productoId, decimal cantidadAgregar)
        {
            if (cantidadAgregar <= 0)
                throw new Exception("La cantidad agregar debe ser mayor a 0");

            using (var db = new AppDBContext()) 
            {

                try
                {
                    Stock registrarStock = db.Stocks.FirstOrDefault(s => s.ProductoId == productoId);
                    if (registrarStock == null)
                    {
                        //por si no existe un registro previo de stock del objeto prodcuto (ejemplo manzana) lo creamos
                        Stock nuevoStock = new Stock()
                        {
                            ProductoId = productoId,
                            Cantidad = cantidadAgregar,
                        };

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

