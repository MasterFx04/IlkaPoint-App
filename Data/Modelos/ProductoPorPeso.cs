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

        public ProductoPorPeso() { }
        public ProductoPorPeso(string nombre, string categoria, string proveedor, decimal precio, string rutaImagenPng, decimal peso): base(nombre, categoria, proveedor, precio, rutaImagenPng)
        {
            this.peso = peso;
        }


        //public float peso { get; set; }

        //c0f397cb5dcca31adba192f7e36aa458bce2f444
        public override decimal CalcularPrecio()
            {
                return precio * peso;
            }
    }
    
}
