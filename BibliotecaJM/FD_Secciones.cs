using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaJM
{
    public partial class FD_Secciones : Form
    {
        public string idSeccion { get; set; }
        public string seccion { get; set; }

        public FD_Secciones()
        {
            InitializeComponent();
        }

        private void seccionesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.seccionesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS_Secciones);

        }

        private void FD_Secciones_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dS_Secciones.secciones' Puede moverla o quitarla según sea necesario.
            this.seccionesTableAdapter.Fill(this.dS_Secciones.secciones);

        }

        private void seccionesDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int posSeleccionada = seccionesBindingSource.Position;

            idSeccion = seccionesDataGridView[0, posSeleccionada].Value.ToString();
            seccion = seccionesDataGridView[1, posSeleccionada].Value.ToString();

            this.Close();
        }
    }
}
