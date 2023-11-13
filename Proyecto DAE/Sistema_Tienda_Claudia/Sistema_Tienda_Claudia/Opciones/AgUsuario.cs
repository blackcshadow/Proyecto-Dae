using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Sistema_Tienda_Claudia
{
    public partial class AgUsuario : Form
    {

        static string conexionstring = "server= DESKTOP-GHK5CVV\\MSSQLSERVER04 ; database = TiendaClaudia; integrated security = true";
        SqlConnection conexion = new SqlConnection(conexionstring);

        public void consulta()
        {
            string query = "select * from Usuarios";
            SqlCommand comando = new SqlCommand(query, conexion);
            SqlDataAdapter data = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            GridUsuarios.DataSource = tabla;
        }

        public AgUsuario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conexion.Open();

            string tipoU = "";
            int indice = 0;

            indice = this.comboBoxUsuario.SelectedIndex;

            switch (indice)
            {
                case 0:
                    tipoU = "Administrador";
                    break;
                case 1:
                    tipoU = "Usuario";
                    break;
            }

            string nom = this.txtNombre.Text;
            string usu = this.txtUsuario.Text;
            string contra = this.txtContra.Text;
            string cadena = "insert into Usuarios (Nombre, Usuario, Contrasenia, Tipo_usuario) values ('" + nom + "','" + usu + "','" + contra + "','" + tipoU + "')";
            SqlCommand comando = new SqlCommand(cadena, conexion);
            comando.ExecuteNonQuery();
            consulta();

            conexion.Close();
        }

        private void GridUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtContra_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AgUsuario_Load(object sender, EventArgs e)
        {
            consulta();
        }
    }
}
