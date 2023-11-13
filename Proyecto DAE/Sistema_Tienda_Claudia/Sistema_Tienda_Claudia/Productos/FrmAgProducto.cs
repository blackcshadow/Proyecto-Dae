using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Sistema_Tienda_Claudia
{
    public partial class FrmAgProducto : Form
    {

        static string conexionstring = "server= DESKTOP-GHK5CVV\\MSSQLSERVER04 ; database = TiendaClaudia; integrated security = true";
        SqlConnection conexion = new SqlConnection(conexionstring);


        public FrmAgProducto()
        {
            InitializeComponent();
        }

        private void AgregarProduc_Load(object sender, EventArgs e)
        {
            conexion.Open();
            SqlCommand ct = new SqlCommand("select * from Categoria", conexion);
            SqlDataReader dr = ct.ExecuteReader();
            while (dr.Read())
            {
                this.comboBoxCategoria.Items.Add(dr["Nombrecatego"].ToString());
            }
            conexion.Close();
            conexion.Open();
            SqlCommand pd = new SqlCommand("select * from Pedido", conexion);
            SqlDataReader dp = pd.ExecuteReader();
            while (dp.Read())
            {
                this.comboBoxPedido.Items.Add(dp["Fecha_pedido"].ToString());
            }
            conexion.Close();
            consulta();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void consulta()
        {
            string query = "select * from Producto";
            SqlCommand comando = new SqlCommand(query, conexion);
            SqlDataAdapter data = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            GridProductos.DataSource = tabla;
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            conexion.Open();

            int idcat = 0, indice = 0;
            indice = comboBoxCategoria.SelectedIndex;

            for (int i = 0; i <= indice; i++)
            {
                idcat = idcat + 1;
            }

            int idpe = 0, indice1 = 0;
            indice1 = comboBoxPedido.SelectedIndex;

            for (int i = 0; i <= indice1; i++)
            {
                idpe = idpe + 1;
            }

            string nom = this.txtNombreProducto.Text;
            decimal pre = Convert.ToDecimal(this.numericPrecioProducto.Value);
            int cant = Convert.ToInt32(this.numericCantidadProducto.Value);
            string cadena = "insert into Producto (Precio, Nombre, id_Categoria, cantidad, id_Pedido) values ('"+pre+"','"+nom+"','"+idcat+"','"+cant+"','"+idpe+"')";
            SqlCommand comando = new SqlCommand(cadena, conexion);
            comando.ExecuteNonQuery();
            consulta();

            conexion.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
