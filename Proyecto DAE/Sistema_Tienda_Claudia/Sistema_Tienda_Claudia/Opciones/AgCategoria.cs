using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Tienda_Claudia
{
    public partial class AgCategoria : Form
    {

        static string conexionstring = "server= DESKTOP-GHK5CVV\\MSSQLSERVER04 ; database = TiendaClaudia; integrated security = true";
        SqlConnection conexion = new SqlConnection(conexionstring);

        public void consulta()
        {
            string query = "select * from Categoria";
            SqlCommand comando = new SqlCommand(query, conexion);
            SqlDataAdapter data = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            GridCatego.DataSource = tabla;
        }

        public AgCategoria()
        {
            InitializeComponent();
        }

        private void AgCategoria_Load(object sender, EventArgs e)
        {
            consulta();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conexion.Open();

            string nom = this.txtNombre.Text;
            string cadena = "insert into Categoria (Nombrecatego) values ('" + nom + "')";
            SqlCommand comando = new SqlCommand(cadena, conexion);
            comando.ExecuteNonQuery();
            consulta();

            conexion.Close();
        }
    }
}
