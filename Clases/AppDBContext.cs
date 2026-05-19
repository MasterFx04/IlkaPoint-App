using IlkaPoint.Data.Modelos;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IlkaPoint.Clases
{
    public class AppDBContext : DbContext
    {
        public AppDBContext() : base("AbarroteriaContext")
        {

        }

        //AQUI VA PRODUCTO E INVENTARIO
        public DbSet<Inventario> Movimientos { get; set; }
        //public DbSet<Producto> Productos { get; set; }

        //ACA TODO LO QUE SEA ALMACENAR LA INFORMACION DE LAS TRANSACCIONES
        public DbSet<Transaccion> Transacciones { get; set; }
       
    }
}
