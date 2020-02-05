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
    public partial class FD_ListadoProvincias : Form
    {
        public string Provincia
        {
            get;
            set;
        }
        public string idProvincia
        {
            get;
            set;
        }

        public FD_ListadoProvincias()
        {
            InitializeComponent();
        }

        private void provinciasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.provinciasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS_Provincias);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dS_Provincias.provincias' Puede moverla o quitarla según sea necesario.
            this.provinciasTableAdapter.Fill(this.dS_Provincias.provincias);

        }

        private void provinciasDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
             Provincia = dS_Provincias.provincias[provinciasBindingSource.Position][1].ToString();
            idProvincia = dS_Provincias.provincias[provinciasBindingSource.Position][0].ToString();
            this.Close();

        }
    }
}
