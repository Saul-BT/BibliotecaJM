using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BibliotecaJM
{
    public partial class FM_Lectores : BibliotecaJM.FM_Modelo
    {
        private UsuarioActual usuarioActual;

        public FM_Lectores()
        {
            InitializeComponent();
        }

        public FM_Lectores(UsuarioActual usuarioActual)
        {
            InitializeComponent();
            this.usuarioActual = usuarioActual;
        }

        private void lectoresBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lectoresBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.dS_Lectores);

        }

        private void FM_Lectores_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dS_Lectores.lectores' Puede moverla o quitarla según sea necesario.
            this.lectoresTableAdapter.Fill(this.dS_Lectores.lectores);
            ModoBusqueda();

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

        private void bBuscarId_Click(object sender, EventArgs e)
        {
            if (tbBuscarId.Text == string.Empty)
            {
                this.lectoresTableAdapter.Fill(this.dS_Lectores.lectores);
                return;
            }

            lectoresTableAdapter.FillByID(
                dS_Lectores.lectores,
                int.Parse(tbBuscarId.Text));
        
    
    }

        private void BBuscarNombre_Click(object sender, EventArgs e)
        {
            lectoresTableAdapter.FillByNombre(
                dS_Lectores.lectores,
                tbBuscarNombre.Text);
        }

        private void bNuevo_Click(object sender, EventArgs e)
        {
            ModoEdicion();
            provincia_nombre_lecTextBox.Text = null;
            nombre_lecTextBox.Focus();
            lectoresBindingSource.AddNew();
        }

        private void bModificar_Click(object sender, EventArgs e)
        {
            ModoEdicion();
        }

        private void bEliminar_Click(object sender, EventArgs e)
        {
            DialogResult resultadoDialogoConfirmacion = MessageBox.Show(
                "¿Desea eliminar el registro seleccionado?",
                "Confirmacion",
                MessageBoxButtons.YesNo);

            if (resultadoDialogoConfirmacion == DialogResult.Yes)
            {
                    try
                    {
                        lectoresBindingSource.RemoveCurrent();

                        lectoresTableAdapter.Update(dS_Lectores.lectores);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            lectoresBindingSource.CancelEdit();
            ModoBusqueda();
        }

        private void bAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                lectoresBindingSource.EndEdit();
                lectoresTableAdapter.Update(dS_Lectores.lectores);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            ModoBusqueda();
        }

        private void lectoresDataGridView_CurrentCellChanged(object sender, EventArgs e)
        {
            provinciasTableAdapter.FillByID(dS_Provincias.provincias, int.Parse(provincia_lecTextBox.Text));
            
            provincia_nombre_lecTextBox.Text = dS_Provincias.provincias.Rows[0][1].ToString();
        }

        private void bAssistProvincia_Click(object sender, EventArgs e)
        {
            FD_ListadoProvincias listado = new FD_ListadoProvincias();
            listado.ShowDialog();
            provincia_lecTextBox.Text = listado.idProvincia;
            provincia_nombre_lecTextBox.Text = listado.Provincia;
        }
    }
}
