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
    public partial class VerProductos : Form
    {
        static string conexionstring = "server= DESKTOP-GHK5CVV\\MSSQLSERVER04; database = TiendaClaudia; integrated security = true";
        SqlConnection conexion = new SqlConnection(conexionstring);

        public void consulta1()
        {
            int cat = 0, indice = 0;
            indice = this.comboBoxProd.SelectedIndex;
            for (int i = 0; i <= indice; i++)
            {
                cat = cat + 1;
            }

            string query = "select * from Producto where id_Categoria = " + cat + "";
            SqlCommand comando = new SqlCommand(query, conexion);
            SqlDataAdapter data = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            GridProducto.DataSource = tabla;
        }

        public VerProductos()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            conexion.Open();
            consulta1();
            conexion.Close();
        }

        private void VerProductos_Load(object sender, EventArgs e)
        {
            conexion.Open();
            SqlCommand pd = new SqlCommand("select * from Categoria", conexion);
            SqlDataReader dp = pd.ExecuteReader();
            while (dp.Read())
            {
                this.comboBoxProd.Items.Add(dp["Nombrecatego"].ToString());
            }
            conexion.Close();
        }
    }
}
