using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IlkaPoint.Data.Modelos
{
    //La clase padre va ser producto y dentro de esta se van a establecercomo las diferentes caracteristicas o parametros
    //en las que se segmentara el inventario dentro de la base de datos y la creación de los metodos.
    public class Producto
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string categoria { get; set; }
        public string proveedor { get; set; }
        public decimal precio { get; set; }
        
        public string rutaImagenPng { get; set; }

<<<<<<< HEAD
        //le permitira a las clases hijas aplicar un polimorfismo
        public virtual decimal calcularPrecio()
        { return precio; }
=======
        public virtual decimal CalcularPrecio()
        {
            //Aca para polimorfismo
            return precio;
        }
>>>>>>> c0f397cb5dcca31adba192f7e36aa458bce2f444
    }
   
} 


