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
            public decimal peso { get; set; }
            public override decimal calcularPrecio()
            {
            return precio * (decimal)peso;
            }
        }
    
}
