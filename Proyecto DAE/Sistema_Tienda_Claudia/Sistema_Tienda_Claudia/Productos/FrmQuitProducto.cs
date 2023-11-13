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
    public partial class QuitarProduc : Form
    {

        static string conexionstring = "server= DESKTOP-GHK5CVV\\MSSQLSERVER04 ; database = TiendaClaudia; integrated security = true";
        SqlConnection conexion = new SqlConnection(conexionstring);

        public void consulta1()
        {
            int cat = 0, indice = 0;
            indice = this.comboBoxCategoria.SelectedIndex;

            for (int i = 0; i <= indice; i++)
            {
                cat = cat + 1;
            }

            string query = "select * from Producto where id_Categoria = "+cat+"";
            SqlCommand comando = new SqlCommand(query, conexion);
            SqlDataAdapter data = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            GridProductos.DataSource = tabla;
        }

        public QuitarProduc()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            conexion.Open();
            DialogResult respuesta;
            string mensaje = "Confirme la eliminación del Producto";
            MessageBoxIcon icono = MessageBoxIcon.Question;
            respuesta = MessageBox.Show(mensaje, "Confirmar", MessageBoxButtons.YesNo, icono);
            if (respuesta == DialogResult.Yes)
            {
                foreach (DataGridViewRow fila in this.GridProductos.Rows)
                {
                    DataGridViewCheckBoxCell ck = (DataGridViewCheckBoxCell)fila.Cells["idP"];
                    if (Convert.ToBoolean(ck.Value))
                    {
                        string id = fila.Cells[1].Value.ToString();
                        string cadena = "delete from Producto where id_Producto = '" + id + "'";
                        SqlCommand comando = new SqlCommand(cadena, conexion);
                        comando.ExecuteNonQuery();
                        consulta1();
                    }
                }
            }
            conexion.Close();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            conexion.Open();

            consulta1();

            conexion.Close();
        }

        private void QuitarProduc_Load(object sender, EventArgs e)
        {
            conexion.Open();
            SqlCommand pd = new SqlCommand("select * from Categoria", conexion);
            SqlDataReader dp = pd.ExecuteReader();
            while (dp.Read())
            {
                this.comboBoxCategoria.Items.Add(dp["Nombrecatego"].ToString());
            }
            conexion.Close();
            consulta1();
        }
    }
}
