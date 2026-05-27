using IlkaPoint.Clases;
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
using IlkaPoint.Data;



namespace IlkaPoint
{
    public partial class FormSimulaciónInventario : Form
    {
        public FormSimulaciónInventario()
        {
            InitializeComponent();
        }

        private void FormSimulaciónInventario_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
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

            try
            {
                using (var contexto = new AppDBContext())
                {
                    // 1. Instanciamos tus dos servicios hermanos
                    var creadorProducto = new NuevoProducto(contexto);
                    var servicioInventario = new ServicioInventario();

                    // 2. PASO A: Crear el producto con los datos de los TextBox
                    string nombre = txtNombre.Text;
                    string categoria = txtCategoria.Text;
                    string proveedor = txtProveedor.Text;
                    string imagen = txtImagen.Text;
                    decimal precio = decimal.Parse(txtPrecio.Text);

                    int nuevoId = creadorProducto.RegistrarNuevoProducto(nombre, categoria, proveedor, imagen, precio);

                    // 3. PASO B: Tomar la cantidad del control numérico y sumársela usando el ID recién generado
                    int cantidadAAgregar = (int)nudCantidad.Value;
                    bool exitoStock = servicioInventario.AgregarCantidadStock(nuevoId, cantidadAAgregar);

                    // 4. Verificación final en pantalla
                    if (exitoStock)
                    {
                        MessageBox.Show($"¡Simulación Completa Exitosamente!\n\n" +
                                        $"📊 Producto: {nombre} (ID asignado: {nuevoId})\n" +
                                        $"📦 Stock Inicial Inyectado: {cantidadAAgregar} unidades.\n\n" +
                                        $"El flujo FISC-BANK ha respondido correctamente.",
                                        "Éxito de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Limpiar los campos para una nueva prueba
                        txtNombre.Clear();
                        txtCategoria.Clear();
                        txtProveedor.Clear();
                        txtImagen.Clear();
                        nudCantidad.Value = 0;
                    }
                    else
                    {
                        MessageBox.Show("El producto se creó, pero ServicioInventario no pudo asignarle el stock.",
                                        "Fallo Parcial", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error en el circuito de datos: {ex.Message}", "Error Técnico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
