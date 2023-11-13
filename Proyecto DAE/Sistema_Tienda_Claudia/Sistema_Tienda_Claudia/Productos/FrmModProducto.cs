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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Sistema_Tienda_Claudia
{
    public partial class ModificarProduc : Form
    {
        static string conexionstring = "server= DESKTOP-GHK5CVV\\MSSQLSERVER04 ; database = TiendaClaudia; integrated security = true";
        SqlConnection conexion = new SqlConnection(conexionstring);


        public ModificarProduc()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            conexion.Open();
            DialogResult respuesta;
            string mensaje = "Confirme la actualización del Producto";
            MessageBoxIcon icono = MessageBoxIcon.Question;
            respuesta = MessageBox.Show(mensaje, "Confirmar", MessageBoxButtons.YesNo, icono);
            if (respuesta == DialogResult.Yes)
            {
                foreach (DataGridViewRow fila in this.dataGridView1.Rows)
                {
                    DataGridViewCheckBoxCell ck = (DataGridViewCheckBoxCell)fila.Cells["idP"];
                    if (Convert.ToBoolean(ck.Value))
                    {
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
                        string id = fila.Cells[1].Value.ToString();
                        string cadena = "update Producto set Nombre = '" + nom + "', Precio ='" + pre + "',cantidad = '" + cant + "',id_Categoria = '" + idcat + "',id_Pedido = '" + idpe + "' where id_Producto = '" + id + "'";
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
            dataGridView1.DataSource = tabla;
        }

        private void ModificarProduc_Load(object sender, EventArgs e)
        {
            conexion.Open();
            SqlCommand pd = new SqlCommand("select * from Categoria", conexion);
            SqlDataReader dp = pd.ExecuteReader();
            while (dp.Read())
            {
                this.comboBoxProd.Items.Add(dp["Nombrecatego"].ToString());
            }
            conexion.Close();
            conexion.Open();
            SqlCommand ct = new SqlCommand("select * from Categoria", conexion);
            SqlDataReader dr = ct.ExecuteReader();
            while (dr.Read())
            {
                this.comboBoxCategoria.Items.Add(dr["Nombrecatego"].ToString());
            }
            conexion.Close();
            conexion.Open();
            SqlCommand hd = new SqlCommand("select * from Pedido", conexion);
            SqlDataReader gg = hd.ExecuteReader();
            while (gg.Read())
            {
                this.comboBoxPedido.Items.Add(gg["Fecha_pedido"].ToString());
            }
            conexion.Close();
            consulta1();
        }
    }
}
