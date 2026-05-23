using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IlkaPoint.Data.Modelos
{
<<<<<<< HEAD
    internal class ProductoPorUnidad : Producto
    {// se cambio la funcion de esta clase, ahora sera un identificado del tipo de producto 
        //cuando el sistema necesite saber como se vendera el producto digamos 5latas

        
        public override decimal calcularPrecio()
        {
            return precio;
=======
    public class ProductoPorUnidad : Producto
    {
        public override decimal CalcularPrecio()
        {
            //ARREGLAR
            return 0;
>>>>>>> c0f397cb5dcca31adba192f7e36aa458bce2f444
        }
    }
}
