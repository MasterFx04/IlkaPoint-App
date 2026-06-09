using IlkaPoint.Data.Modelos;
using IlkaPoint.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IlkaPoint
{

    public partial class ucAgregarProducto : UserControl
    {
        private string rutaImagen = "";
        public ucAgregarProducto()
        {
            InitializeComponent();
            CargarCategorias();
            // 1. Evitar que herede escalados raros de la pantalla de inventario
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;

            // 2. Congelar el tamaño exacto que le diste en tu diseño
            // Pon aquí los pixeles exactos que mide tu panel lateral (ejemplo: 350 de ancho por 700 de alto)
            this.MinimumSize = new Size(456, 968);
            this.MaximumSize = new Size(480, 1018);
            this.Size = new Size(456, 968);

            // 3. Forzar que el botón Añadir mantenga su posición abajo
            btnAgregarProducto.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        }
     

        //Este evento lo geeneré por error mientras diseñaba, pueden borrarlo.
        private void label2_Click(object sender, EventArgs e)
        {

        }

        //ESTE CÓDIGO NO SE UTILIZA ORIGINALMENTE!!
        //Aquí se configura el evento del botón para subir la imagen pero ese botón
        //lo eliminé porque en el diseño de tu Figma, la imagen se sube al hacer
        //clic directamente sobre el PictureBox.
        private void btnSubirImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrir = new OpenFileDialog();

            abrir.Filter =
                "Archivos de Imagen|*.jpg;*.jpeg;*.png;*.bmp";

            if (abrir.ShowDialog() == DialogResult.OK)
            {
                rutaImagen = abrir.FileName;

                pbProducto.Image =
                    Image.FromFile(rutaImagen);
            }
        }

        //ESTE ES EL EVENTO CORRECTO PARA SUBIR LA IMAGEN HACIENDO CLIC EN EL PICTUREBOX!!
        //DISEÑO CÓDIGO (LÍNEA 50 A 65)
        private void pbProducto_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrir =
      new OpenFileDialog();

            abrir.Filter =
                "Imágenes|*.jpg;*.jpeg;*.png;*.bmp";

            if (abrir.ShowDialog() == DialogResult.OK)
            {
                rutaImagen = abrir.FileName;

                pbProducto.Image =
                    Image.FromFile(rutaImagen);
            }
        }

        //DISEÑO CÓDIGO (LÍNEA 69 A 70)
        //Este evento configura la "X" para cerrar la ventana de agregar producto.
        private void btnCerrarPanel_Click(object sender, EventArgs e)
        {
            this.FindForm()?.Close();
        }

        private void CargarCategorias()
        {
            ServicioInventario servicio = new ServicioInventario();
            List<string> categorias = servicio.ObtenerCategorias();

            cmbCategorías.DataSource = null;
            cmbCategorías.Items.Clear();
            cmbCategorías.DataSource = categorias;
        }

        //Lo genero back-end por error
        private void panelContenidoUC_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevaVenta_Click(object sender, EventArgs e)
        {

        }

        private void cmbCategorías_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            // Expresiones regulares para el análisis defensivo
            //Va a detectar si el texto tiene AL MENOS una letra (para evitar puros números o puros símbolos)
            var tieneLetras = new System.Text.RegularExpressions.Regex(@"[a-zA-ZáéíóúÁÉÍÓÚñÑ]");

            // Detecta si hay caracteres especiales prohibidos en nombres 
            var tieneSimbolosProhibidos = new System.Text.RegularExpressions.Regex(@"[<>{}*\[\]\\\/^~_]");

            // Validación para categoría de producto
            string categoriaText = cmbCategorías.Text.Trim();

            if (cmbCategorías.SelectedIndex == -1 && string.IsNullOrEmpty(categoriaText))
            {
                MessageBox.Show("Por favor, seleccione o ingrese una categoría válida.", "Categoría Vacía", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbCategorías.Focus();
                return;
            }

            // Si escriben algo, obligamos a que no sean puros números o puros símbolos
            if (!tieneLetras.IsMatch(categoriaText) || tieneSimbolosProhibidos.IsMatch(categoriaText))
            {
                MessageBox.Show("La categoría debe contener palabras. No se permiten solo números ni símbolos extraños.", "Categoría Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbCategorías.Focus();
                return;
            }

            // validación para el nombre del producto. no puede estar vacio, no puede ser solamente númeroa o caracteres especiales 
            string nombreProd = txtNombreProducto.Text.Trim();

            if (string.IsNullOrEmpty(nombreProd))
            {
                MessageBox.Show("El nombre del producto no puede estar vacío.", "Nombre Vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombreProducto.Focus();
                return;
            }

            // regla: se va a permitir que el nombre tenga númeors como: "Naranjas 8000", pero bloquea si son puros números o puros caracteres especiales
            if (!tieneLetras.IsMatch(nombreProd) || tieneSimbolosProhibidos.IsMatch(nombreProd))
            {
                MessageBox.Show("El nombre del producto debe incluir letras (Ej. 'Naranjas 8000'). No puede ser puramente numérico ni contener símbolos raros como *, /, ^, etc.", "Nombre Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombreProducto.Focus();
                return;
            }


            //blindamos directamente desde el código para que no acepte negativo para el precio por unidad 
            inputNumberCantProducto.Minimum = 0;

            int cantidad1 = (int)inputNumberCantProducto.Value;
            if (cantidad1 <= 0)
            {
                MessageBox.Show("La cantidad por unidad debe ser un número entero mayor a 0.", "Cantidad Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                inputNumberCantProducto.Focus();
                return;
            }

            //validación para el precio unitario y evitamos que el programa se cierre forzozamente por haber introducido un numero raor 
            decimal precioUnitario = 0;

            // Con TryParse filtramos de un solo golpe letras infiltradas y símbolos raros
            if (string.IsNullOrEmpty(input1.Text) || !decimal.TryParse(input1.Text, out precioUnitario))
            {
                MessageBox.Show("Por favor, introduzca un precio unitario aceptable (Ejemplo: 1.75). No coloque símbolos de moneda ni letras.", "Precio Inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                input1.Focus();
                return;
            }

            // Evitamos precios de cero o negativos
            if (precioUnitario <= 0)
            {
                MessageBox.Show("El precio unitario no puede ser cero ni un número negativo. El negocio tiene que ganar.", "Precio Fuera de Rango", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                input1.Focus();
                return;
            }

            //si logro pasar todos los filtros se guarde de forma segura 
            // Aquí pones tu código para guardar en la Base de Datos con Entity Framework...
            MessageBox.Show("¡Producto verificado y agregado con éxito al inventario!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ServicioInventario servicio = new ServicioInventario();

            string categoria = cmbCategorías.Text;
            string nombre = txtNombreProducto.Text;
            int cantidad = int.Parse(inputNumberCantProducto.Text);
            decimal precio = decimal.Parse(input1.Text, System.Globalization.CultureInfo.InvariantCulture);
            //Image imagen = pbProducto.Image; TRANSFORMAMOS LA IMAGEN A BYTES PARA QUE EL EF PUEDA LEERLO :D
            byte[] imagen = null;
            if (pbProducto.Image != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    pbProducto.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    imagen = ms.ToArray();
                }
            }

            Producto producto = new Producto(nombre, categoria, "Ilca", precio, imagen);
            servicio.AgregarProducto(producto);
            servicio.AgregarCantidadStock(producto.id, cantidad);
            MessageBox.Show("Producto guardado con ID: P" + producto.id.ToString("D4"));
            this.FindForm()?.Close();
        }

        private void input1_TextChanged(object sender, EventArgs e)
        {

        }

        private void inputNumberCantProducto_ValueChanged(object sender, AntdUI.DecimalEventArgs e)
        {

        }
    }
}


