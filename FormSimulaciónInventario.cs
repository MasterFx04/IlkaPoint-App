using IlkaPoint.Clases;
using IlkaPoint.Data;
using IlkaPoint.Data.Modelos;
using IlkaPoint.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace IlkaPoint
{
    public partial class FormSimulaciónInventario : Form
    {
        private readonly ServicioInventario _servicioInventario;

        public FormSimulaciónInventario()
        {
            InitializeComponent();
            _servicioInventario = new ServicioInventario();
        }

        private void FormSimulaciónInventario_Load(object sender, EventArgs e)
        {

        }

        
            private void btnSimular_Click(object sender, EventArgs e)
         { 
        
            // Validar que los campos básicos no estén vacíos
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtCategoria.Text))
            {
                MessageBox.Show("Por favor, llena al menos el Nombre y la Categoría para la prueba.",
                                "Datos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validación defensiva del Precio para que el sistema no se rompa con letras
            if (!decimal.TryParse(txtPrecio.Text, out decimal precio))
            {
                MessageBox.Show("Por favor, introduce un formato de precio válido (Ej: 2.50).",
                                "Precio Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Capturamos los datos de tus TextBox
                string nombre = txtNombre.Text;
                string categoria = txtCategoria.Text;
                string proveedor = txtProveedor.Text;
                string imagen = txtImagen.Text;
                int cantidadAAgregar = (int)nudCantidad.Value;

                //CREAR EL OBJETO PRODUCTO DESDE CERO
                Producto nuevoProducto = new Producto
                {
                    nombre = nombre,
                    categoria = categoria,
                    proveedor = proveedor,
                    rutaImagenPng = imagen,
                    precio = precio
                };

                // Manda el objeto directamente al servicio consolidado
 
                int nuevoId = _servicioInventario.registrarStock(nuevoProducto);

                // Asignarle el stock usando el ID recién generado
                bool exitoStock = _servicioInventario.AgregarCantidadStock(nuevoId, cantidadAAgregar);

                // Verificación final
                if (exitoStock)
                {
                    MessageBox.Show($"¡Simulación Completa Exitosamente!\n\n" +
                                    $" Producto: {nombre} (ID asignado: {nuevoId})\n" +
                                    $" Stock Inicial Inyectado: {cantidadAAgregar} unidades.\n\n" 
                                    "Éxito de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Limpiar los campos para una nueva prueba
                    txtNombre.Clear();
                    txtCategoria.Clear();
                    txtProveedor.Clear();
                    txtImagen.Clear();
                    txtPrecio.Clear();
                    nudCantidad.Value = 0;
                }
                else
                {
                    MessageBox.Show("El producto se creó, pero ServicioInventario no pudo asignarle el stock.",
                                    "Fallo Parcial", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                // Alerta defensiva por si el motor de datos falla
                MessageBox.Show($"Error en el circuito de datos: {ex.Message}", "Error Técnico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

  
    
    }
}
