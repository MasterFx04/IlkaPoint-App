using IlkaPoint.Clases;
using IlkaPoint.Data.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace IlkaPoint.Servicios
{
    internal class NuevoProducto
    {//esto le die a visual studio donde esta el localdb y como se llama la base de datos
        private readonly string cadenaConexión = @"Server=(localdb)/mssqllocaldb;Database=IlkaPointDB;Trusted_Connection=True;";

        // Constructor para recibir la base de datos
        public NuevoProducto() //AppDBContext contexto
        {
            //_contexto = contexto;
        }
        // Registra un producto desde cero en la base de datos y devuelve su ID único.

        public int RegistrarNuevoProducto(string nombre, string categoria, string proveedor, string rutaImagen, decimal precio)
        {
            try
            {
                // Datos que se deben llenar para crear el nuevo onbeto/producto
                var nuevoProducto = new Producto
                {
                    nombre = nombre, 
                    categoria = categoria,// ya sea limpieza,hogar,lacteo,etc.
                    proveedor = proveedor,
                    rutaImagenPng = rutaImagen,
                    precio = precio
                };

                // Para añadirlo a la Clase padre Producto y se guarde en la base de datos.
                /*_contexto.Productos.Add(nuevoProducto);
                _contexto.SaveChanges();*/

                // Se genera automaticamente el Id del producto y lo devulve una vez se guarde 
                return nuevoProducto.id;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al registrar el producto en la base de datos: {ex.Message}");
            }
        }
    }
}

