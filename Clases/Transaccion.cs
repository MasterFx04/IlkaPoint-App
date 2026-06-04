using IlkaPoint.Data.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace IlkaPoint.Clases
{
    public class Transaccion
    {
        [Key] //AQUI INDICA QUE LA LLAVE PARA QUE EL EF LO RECONOZCA AL CREAR SUS TABLAS RELACIONALES 
        public int idTransaccion { get; set; }

        private DateTime fecha;
        private string metodoPago;
        private bool esJubilado;
        private decimal total;

        //Todos los atributos necesitan get y set en su encapsulamiento
        public DateTime Fecha
        {
            get
            {
                return fecha;
            }

            set
            {
                fecha = value;
            }
        }

        public string MetodoPago
        {
            get
            {
                return metodoPago;
            }

            set
            {
                metodoPago = value;
            }
        }

        private bool EsJubilado
        {
            get
            {
                return esJubilado;
            }

            set
            {
                esJubilado = value;
            }
        }
        
        public decimal Total
        {
            get
            {
                return total;
            }

            set
            {
                total = value;
            }
        }



        public List<DetallesTransaccion> Detalles {  get; set; }



        //Constructor
        public Transaccion(bool esJubilado) //registrarTransaccion()
        {
            //this.metodoPago = metodoPago;
            this.esJubilado = esJubilado;

            fecha = DateTime.Now; //Cada vez que alguien haga una transaccion, la fecha va a ser hoy.

            Detalles = new List<DetallesTransaccion>();

            total = 0;
        }

        /*
        private decimal CalcularDescuento() //Funcion privada por que se llama solo en la clase, un forms no llamara a la funcion
        {
            decimal descuento = Convert.ToDecimal(Convert.ToDouble(total) * 0.15);
            decimal subResultado;
            decimal itbms = Convert.ToDecimal(Convert.ToDouble(total) * 0.07);
            decimal resultadoFinal;
            if (esJubilado)
            {
                subResultado = total - descuento;
            }
            else
            {
                subResultado = total;
            }
            resultadoFinal = subResultado + itbms;
            return resultadoFinal;
        }
        */

        public decimal CalcularTotal()
        {
            if (Detalles == null || Detalles.Count == 0)
            {
                return 0;
            }
            decimal total = 0;
            foreach(DetallesTransaccion detalle in Detalles)
            {
                total += detalle.SubTotal;
            }
            return total;

        }
        
        public void ActualizarCantidad(decimal cantidadNueva)
        {
            //NECESITO LA DB DE Inventario PARA INICIAR
        }
        
    }
}
