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
    }
}

