
using Datos;
using Entidades;
using Negocio.Validadores;
using Presentacion.Utilidades;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class frmProducto : Form
    {
        private List<E_Producto> listaProductos;
        private Image imagenPlaceholder;

        private Dictionary<string, object> myProducto =
            new Dictionary<string, object>();

        private List<(TextBox txt, IValidador validador)> camposValidar =
            new List<(TextBox txt, IValidador validador)>();

        public frmProducto()
        {
            InitializeComponent();
            listaProductos = new List<E_Producto>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                imagenPlaceholder = new Bitmap(pictureBox1.Image);
            }

            DataGridViewImageColumn columnaImagen =
                (DataGridViewImageColumn)dgvProductos.Columns["Imagen"];

            if (columnaImagen != null)
            {
                columnaImagen.ImageLayout = DataGridViewImageCellLayout.Zoom;
                dgvProductos.Columns["Imagen"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
            }

            cargarProductos();
        }

        private void cargarProductos(string filtro = "")
        {
            try
            {
                dgvProductos.Rows.Clear();

                listaProductos = D_Producto.GetProductos(filtro);

                foreach (E_Producto prod in listaProductos)
                {
                    Bitmap img = null;

                    if (prod.Imagen != null && prod.Imagen.Length > 0)
                    {
                        img = ConversorImagen.ByteArrayToBitmap(prod.Imagen);
                    }

                    dgvProductos.Rows.Add(
                        prod.Id,
                        prod.Nombre,
                        prod.Precio,
                        prod.Cantidad,
                        img
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar los productos: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void dataGridView1_CellContentClick(
            object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow fila = dgvProductos.Rows[e.RowIndex];

            txtFolio.Text = Convert.ToString(fila.Cells["Folio"].Value);
            txtNombre.Text = Convert.ToString(fila.Cells["Nombre"].Value);
            txtPrecio.Text = Convert.ToString(fila.Cells["Precio"].Value);
            txtCantidad.Text = Convert.ToString(fila.Cells["Cantidad"].Value);

            if (fila.Cells["Imagen"].Value is Image imgGrid)
            {
                pictureBox1.Image = new Bitmap(imgGrid);
            }
            else
            {
                pictureBox1.Image = null;
            }

            btnAgregar.Enabled = false;
            btnModificar.Enabled = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Seleccionar imagen del producto";
                openFileDialog.Filter =
                    "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (Image tempImg = Image.FromFile(openFileDialog.FileName))
                    {
                        pictureBox1.Image = new Bitmap(tempImg);
                    }

                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            cargarProductos(txtBusqueda.Text.Trim());
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!datosCorrectos())
                return;

            CargarDatosProductos();

            try
            {
                if (D_Producto.InsertSeguro(myProducto))
                {
                    MessageBox.Show("Se ha guardado satisfactoriamente el registro");

                    cargarProductos();
                    limpiarCampos();
                }
                else
                {
                    MessageBox.Show("No se pudo guardar el producto.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el producto: " + ex.Message);
            }
        }

        private void CargarDatosProductos()
        {
            string nombreNormalizado = NormalizarNombre(txtNombre.Text);

            myProducto.Clear();

            myProducto["cantidad"] = int.Parse(txtCantidad.Text.Trim());
            myProducto["precio"] = decimal.Parse(txtPrecio.Text.Trim());
            myProducto["nombre"] = nombreNormalizado;
            myProducto["imagen"] =
                ConversorImagen.ImageToByteArray(pictureBox1.Image);
        }

        private bool datosCorrectos()
        {
            camposValidar.Clear();

            camposValidar.Add((txtNombre, new ValidadorTexto()));
            camposValidar.Add((txtPrecio, new ValidadorDecimal()));
            camposValidar.Add((txtCantidad, new ValidadorEntero()));

            foreach (var item in camposValidar)
            {
                if (!item.validador.EsValido(item.txt.Text))
                {
                    errorProvider1.SetError(
                        item.txt,
                        item.validador.MensajeError
                    );

                    return false;
                }

                errorProvider1.SetError(item.txt, string.Empty);
            }

            return true;
        }

        private string NormalizarNombre(string texto)
        {
            texto = texto.Trim();

            texto = System.Text.RegularExpressions.Regex.Replace(
                texto,
                @"\s+",
                " "
            );

            return System.Globalization.CultureInfo.CurrentCulture
                .TextInfo.ToTitleCase(texto.ToLower());
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ModificarDatosBD();
        }

        private void ModificarDatosBD()
        {
            if (!datosCorrectos())
                return;

            if (!int.TryParse(txtFolio.Text.Trim(), out int folio))
            {
                MessageBox.Show("El Folio no es válido.");
                return;
            }

            CargarDatosProductos();

            try
            {
                bool resultado = D_Producto.UpdateSeguro(myProducto, folio);

                if (resultado)
                {
                    MessageBox.Show("Actualización exitosa");

                    cargarProductos();
                    limpiarCampos();
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar el producto.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el producto: " + ex.Message);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        private void limpiarCampos()
        {
            txtFolio.Text = "";
            txtNombre.Text = "";
            txtCantidad.Text = "";
            txtPrecio.Text = "";

            pictureBox1.Image = imagenPlaceholder != null
                ? new Bitmap(imagenPlaceholder)
                : null;

            btnAgregar.Enabled = true;
            btnModificar.Enabled = false;

            errorProvider1.Clear();
        }

        private void btnEiminar_Click(object sender, EventArgs e)
        {
            EliminarDatosBD();
        }

        private void EliminarDatosBD()
        {
            if (!int.TryParse(txtFolio.Text.Trim(), out int folio))
            {
                MessageBox.Show("Seleccione un producto para eliminar.");
                return;
            }

            DialogResult respuesta = MessageBox.Show(
                "¿Está seguro de que desea eliminar este producto?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (respuesta != DialogResult.Yes)
                return;

            try
            {
                bool resultado = D_Producto.DeleteSeguro(folio);

                if (resultado)
                {
                    MessageBox.Show("Producto eliminado correctamente.");

                    cargarProductos();
                    limpiarCampos();
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el producto.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el producto: " + ex.Message);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
