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
    public partial class AgDescuento : Form
    {
        static string conexionstring = "server= DESKTOP-GHK5CVV\\MSSQLSERVER04 ; database = TiendaClaudia; integrated security = true";
        SqlConnection conexion = new SqlConnection(conexionstring);

        public void consulta()
        {
            string query = "select * from Descuento";
            SqlCommand comando = new SqlCommand(query, conexion);
            SqlDataAdapter data = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            GridDesc.DataSource = tabla;
        }


        public AgDescuento()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conexion.Open();

            string nom = this.txtDesc.Text;
            string cadena = "insert into Descuento (Descuento) values ('" + nom + "')";
            SqlCommand comando = new SqlCommand(cadena, conexion);
            comando.ExecuteNonQuery();
            consulta();

            conexion.Close();
        }

        private void AgDescuento_Load(object sender, EventArgs e)
        {
            consulta();
        }
    }
}
