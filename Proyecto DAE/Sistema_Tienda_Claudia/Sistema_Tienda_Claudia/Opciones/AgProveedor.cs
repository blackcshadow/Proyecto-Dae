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
    public partial class AgProveedor : Form
    {
        static string conexionstring = "server= DESKTOP-GHK5CVV\\MSSQLSERVER04 ; database = TiendaClaudia; integrated security = true";
        SqlConnection conexion = new SqlConnection(conexionstring);

        public void consulta()
        {
            string query = "select * from Proveedor";
            SqlCommand comando = new SqlCommand(query, conexion);
            SqlDataAdapter data = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            GridProveedor.DataSource = tabla;
        }

        public AgProveedor()
        {
            InitializeComponent();
        }

        private void AgProveedor_Load(object sender, EventArgs e)
        {
            consulta();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conexion.Open();

            string nom = this.txtNombre.Text;
            string dir = this.txtDireccion.Text;
            int tel = Convert.ToInt32(this.txtTel.Text);
            string cadena = "insert into Proveedor (Nombre, Direccion, Telefono) values ('" + nom + "','" + dir + "','" + tel + "')";
            SqlCommand comando = new SqlCommand(cadena, conexion);
            comando.ExecuteNonQuery();
            consulta();

            conexion.Close();
        }
    }
}
