using System;
using System.Windows.Forms;

namespace Reto_2_Busqueda_de_tesoro
{
    public partial class FrmRutaTesoro : Form
    {
        private ListaSimple rutaTesoro = new ListaSimple();

        public FrmRutaTesoro()
        {
            InitializeComponent();
        }

        private void ActualizarGrid()
        {
            dgvRuta.DataSource = null;

            dgvRuta.DataSource = rutaTesoro.Recorrer();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtId.Text);
                string nombre = txtNombre.Text;
                string pista = txtPista.Text;
                int peligro = (int)numPeligro.Value;

                bool insertado = rutaTesoro.Insertar(id, nombre, pista, peligro);

                if (insertado)
                {
                    ActualizarGrid();

                    txtId.Clear();
                    txtNombre.Clear();
                    txtPista.Clear();
                    numPeligro.Value = 1;

                    MessageBox.Show("Ubicación agregada correctamente a la ruta.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("El ID ingresado ya existe en la ruta. Por favor, asigna un ID único.", "ID Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, verifica que el ID sea un número entero válido.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtId.Text, out int idEliminar))
            {
                bool eliminado = rutaTesoro.Eliminar(idEliminar);

                if (eliminado)
                {
                    ActualizarGrid();
                    txtId.Clear();
                    MessageBox.Show("Ubicación eliminada con éxito de la ruta.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se encontró ninguna ubicación con el ID especificado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Ingresa un número de ID válido para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtId.Text, out int idModificar))
            {
                string nuevoNombre = txtNombre.Text;
                string nuevaPista = txtPista.Text;
                int nuevoPeligro = (int)numPeligro.Value;

                bool modificado = rutaTesoro.Modificar(idModificar, nuevoNombre, nuevaPista, nuevoPeligro);

                if (modificado)
                {
                    ActualizarGrid();

                    txtId.Clear();
                    txtNombre.Clear();
                    txtPista.Clear();
                    numPeligro.Value = 1;

                    MessageBox.Show("La ubicación fue modificada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se encontró ninguna ubicación con el ID ingresado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un ID válido para modificar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtId.Text, out int idBuscar))
            {
                Nodo encontrado = rutaTesoro.Buscar(idBuscar);

                if (encontrado != null)
                {
                    txtNombre.Text = encontrado.Nombre;
                    txtPista.Text = encontrado.Pista;
                    numPeligro.Value = encontrado.Peligro;

                    MessageBox.Show($"¡Ubicación encontrada!\n\n" +
                                    $"ID: {encontrado.Id}\n" +
                                    $"Nombre: {encontrado.Nombre}\n" +
                                    $"Pista: {encontrado.Pista}\n" +
                                    $"Peligro: {encontrado.Peligro}",
                                    "Ubicación Encontrada",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se encontró ninguna ubicación con ese ID en la ruta.",
                                    "Sin resultados",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Ingresa un ID válido para buscar.",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }
        private void dgvRuta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow filaSeleccionada = dgvRuta.Rows[e.RowIndex];

                string nombre = filaSeleccionada.Cells["Nombre"].Value?.ToString().ToLower() ?? "";

                if (nombre.Contains("playa"))
                {
                    picUbicacion.Image = Properties.Resources.playa;
                }
                else if (nombre.Contains("campo"))
                {
                    picUbicacion.Image = Properties.Resources.campo;
                }
                else if (nombre.Contains("casa"))
                {
                    picUbicacion.Image = Properties.Resources.casa;
                }
                else if (nombre.Contains("edificio"))
                {
                    picUbicacion.Image = Properties.Resources.edificio;
                }
                else if (nombre.Contains("cueva"))
                {
                    picUbicacion.Image = Properties.Resources.cueva;
                }
                else if (nombre.Contains("isla"))
                {
                    picUbicacion.Image = Properties.Resources.isla;
                }
                else if (nombre.Contains("templo"))
                {
                    picUbicacion.Image = Properties.Resources.templo;
                }
                else
                {
                    picUbicacion.Image = Properties.Resources.nosignal;
                }
            }
        }
    }
}