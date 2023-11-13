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
    public partial class AgPedido : Form
    {

        static string conexionstring = "server= DESKTOP-GHK5CVV\\MSSQLSERVER04 ; database = TiendaClaudia; integrated security = true";
        SqlConnection conexion = new SqlConnection(conexionstring);

        public void consulta()
        {
            string query = "select * from Pedido";
            SqlCommand comando = new SqlCommand(query, conexion);
            SqlDataAdapter data = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            GridPedido.DataSource = tabla;
        }

        public AgPedido()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conexion.Open();

            int pro = 0, indice = 0;
            indice = comboBoxcat.SelectedIndex;

            for (int i = 0; i <= indice; i++)
            {
                pro = pro + 1;
            }

            string fec = this.txtFecha.Text;
            double total = Convert.ToDouble(this.txtTotal.Text);
            string cadena = "insert into Pedido (Fecha_pedido, Totalpedido, id_Proveedor) values ('" + fec + "','" + total + "','" + pro + "')";
            SqlCommand comando = new SqlCommand(cadena, conexion);
            comando.ExecuteNonQuery();
            consulta();

            conexion.Close();
        }

        private void AgPedido_Load(object sender, EventArgs e)
        {
            conexion.Open();
            SqlCommand pd = new SqlCommand("select * from Proveedor", conexion);
            SqlDataReader dp = pd.ExecuteReader();
            while (dp.Read())
            {
                this.comboBoxcat.Items.Add(dp["Nombre"].ToString());
            }
            conexion.Close();
            consulta();
        }
    }
}
