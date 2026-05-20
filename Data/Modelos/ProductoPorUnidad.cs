using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IlkaPoint.Data.Modelos
{
    internal class ProductoPorUnidad : Producto
    {
        public override decimal calcularPrecio()
        {
            return calcularPrecio * cantidad;
        }
    }
}
