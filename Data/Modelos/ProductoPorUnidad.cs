using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IlkaPoint.Data.Modelos
{
    internal class ProductoPorUnidad : Producto
    {// se cambio la funcion de esta clase, ahora sera un identificado del tipo de producto 
        //cuando el sistema necesite saber como se vendera el producto digamos 5latas

        
        public override decimal calcularPrecio()
        {
            return precio;
        }
    }
}
