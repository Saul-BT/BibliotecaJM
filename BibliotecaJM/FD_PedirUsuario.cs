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
    public partial class FD_PedirUsuario : Form
    {
        int numIntentos = 1;

        public string Usuario { get; set; }
        public string TipoUsuario { get; set; }

        public FD_PedirUsuario()
        {
            InitializeComponent();
        }

        private void bAceptar_Click(object sender, EventArgs e)
        {
            if (numIntentos == 3) this.Close();

            string usuario = tbUsuario.Text;
            string pass = tbContrasenia.Text;

            if (usuario == string.Empty || pass == string.Empty)
            {
                MessageBox.Show("Rellena todoooo");
            }

            usuariosTableAdapter1.Fill(dS_Usuarios.usuarios);
            DataRowCollection filas = dS_Usuarios.Tables[0].Rows;

            foreach (DataRow fila in filas)
            {
                if (fila["nombre_usu"].ToString().Trim().Equals(usuario)
                    && fila["password_usu"].ToString().Trim().Equals(pass))
                {
                    Usuario = usuario;
                    TipoUsuario = fila["tipo_usu"].ToString();
                    this.Close();
                }
            }
            numIntentos++;
        }
    }
}
