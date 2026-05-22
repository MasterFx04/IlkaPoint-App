using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IlkaPoint.Data.Modelos
{
    // esta clase hija es cuando en el inventario hay productos que se venden por peso en kilogramo, libras, etc.   
    public class ProductoPorPeso : Producto
        {
<<<<<<< HEAD
            public decimal peso { get; set; }
            public override decimal calcularPrecio()
=======
            public float peso { get; set; }
            public override decimal CalcularPrecio()
>>>>>>> c0f397cb5dcca31adba192f7e36aa458bce2f444
            {
            return precio * (decimal)peso;
            }
        }
    
}
