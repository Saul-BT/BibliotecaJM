using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BibliotecaJM
{
    public partial class FM_Prestamos : FM_Modelo
    {
        private UsuarioActual usuarioActual;

        public FM_Prestamos()
        {
            InitializeComponent();
        }

        public FM_Prestamos(UsuarioActual usuarioActual)
        {
            InitializeComponent();
            this.usuarioActual = usuarioActual;
        }

        private void FM_Prestamos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dS_Lectores.lectores' Puede moverla o quitarla según sea necesario.
            this.lectoresTableAdapter.Fill(this.dS_Lectores.lectores);
            // TODO: esta línea de código carga datos en la tabla 'dS_Libros.libros' Puede moverla o quitarla según sea necesario.
            this.librosTableAdapter.Fill(this.dS_Libros.libros);
            // TODO: esta línea de código carga datos en la tabla 'dS_Prestamos.prestamos' Puede moverla o quitarla según sea necesario.
            this.prestamosTableAdapter.Fill(this.dS_Prestamos.prestamos);

        }

        private void prestamosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.prestamosBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.dS_Prestamos);

        }

        private void bBuscarLectorId_Click(object sender, EventArgs e)
        {
            lectoresTableAdapter.FillByID(dS_Lectores.lectores, int.Parse(tbIdLector.Text));
            //librosPrestadosTableAdapter.FillByID(dS_LibrosPrestados.LibrosPrestados, int.Parse(label6.Text));
        }

        private void bBuscarLectorNombre_Click(object sender, EventArgs e)
        {
            lectoresTableAdapter.FillByNombre(dS_Lectores.lectores, tbNombreLector.Text);
        }

        private void label6_TextChanged(object sender, EventArgs e)
        {
            //librosPrestadosTableAdapter.FillByID(dS_LibrosPrestados.LibrosPrestados, int.Parse(label6.Text));
        }

        private void bBuscarLibro_Click(object sender, EventArgs e)
        {
            int idLib = 0;

            librosTableAdapter.FillBySearch(
                dS_Libros.libros,
                int.TryParse(tbIdLibro.Text, out idLib) ? idLib : 0,
                tbNombreLibro.Text == string.Empty ? null : tbNombreLibro.Text,
                tbAutorLibro.Text == string.Empty ? null : tbAutorLibro.Text
                );
        }

        private void bPrestar_Click(object sender, EventArgs e)
        {
            int libroSeleccionado = librosBindingSource.Position;

            int idLec = int.Parse(label6.Text);
            int idLib = int.Parse(librosDataGridView[0, libroSeleccionado].Value.ToString());
            DateTime fechaPresta = DateTime.Now;
            DateTime fechaDevol = fechaPresta.AddDays(30);



            prestamosTableAdapter.Insert(idLec, idLib, fechaPresta, fechaDevol);

            MessageBox.Show("El prestamo se ha realizado correctamente");
        }
    }
}
