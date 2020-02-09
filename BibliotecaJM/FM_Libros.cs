using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BibliotecaJM
{
    public partial class FM_Libros : BibliotecaJM.FM_Modelo
    {
        private UsuarioActual usuarioActual;

        public FM_Libros()
        {
            InitializeComponent();
        }

        public FM_Libros(UsuarioActual usuarioActual)
        {
            InitializeComponent();
            this.usuarioActual = usuarioActual;
            ModoBusqueda();
        }

        private void librosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.librosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS_Libros);

        }

        private void FM_Libros_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dS_Libros.libros' Puede moverla o quitarla según sea necesario.
            this.librosTableAdapter.Fill(this.dS_Libros.libros);

        }

        private void bBuscarLibro_Click(object sender, EventArgs e)
        {
            int idLib = 0;
            librosTableAdapter.FillByIDoTitulo(dS_Libros.libros,
                int.TryParse(tbIdLibro.Text, out idLib) ? idLib : 0,
                tbTituloLibro.Text == string.Empty ? null : tbTituloLibro.Text);
        }
        private void ModoBusqueda()
        {
            gbBusqueda.Enabled = true;
            gbEdicion.Enabled = false;
        }

        private void ModoEdicion()
        {
            gbBusqueda.Enabled = false;
            gbEdicion.Enabled = true;
        }

        private void bModificar_Click(object sender, EventArgs e)
        {
            ModoEdicion();
        }

        private void bBorrar_Click(object sender, EventArgs e)
        {
            DialogResult resultadoDialogoConfirmacion = MessageBox.Show(
                "¿Desea eliminar el registro seleccionado?",
                "Confirmacion",
                MessageBoxButtons.YesNo);

            if (resultadoDialogoConfirmacion == DialogResult.Yes)
            {
                try
                {
                    librosBindingSource.RemoveCurrent();

                    librosTableAdapter.Update(dS_Libros.libros);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void bNuevo_Click(object sender, EventArgs e)
        {
            librosBindingSource.AddNew();
            ModoEdicion();
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            librosBindingSource.CancelEdit();
            ModoBusqueda();
        }

        private void bAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                librosBindingSource.EndEdit();
                librosTableAdapter.Update(dS_Libros.libros);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            ModoBusqueda();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FD_Secciones fdSecciones = new FD_Secciones();
            fdSecciones.ShowDialog();

            seccion_libTextBox.Text = fdSecciones.idSeccion;
            tbNombreSeccion.Text = fdSecciones.seccion;
        }
    }
 }
