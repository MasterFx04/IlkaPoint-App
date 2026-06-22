using IlkaPoint.Data.Modelos;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace IlkaPoint.Clases
{
    public class Stock
    {
        [Key]
        public int Id { get; set; }

        public int ProductoId { get; set; }

        //[ForeignKey("ProductoId")]
        public string productoNombre { get; set; }

        //public decimal Cantidad { get; set; } La cantidad no es un decimal
        public int Cantidad { get; set; }
        //public string producto_nombre{  get; set; }

        public Stock() { }
        public Stock(int productoId, int cantidad, string productoNombre)
        {
            //producto_nombre = producto.nombre;
            //ProductoId = producto.id;


            ProductoId = productoId;
            Cantidad = cantidad;
            this.productoNombre = productoNombre;
        }

    }
}
