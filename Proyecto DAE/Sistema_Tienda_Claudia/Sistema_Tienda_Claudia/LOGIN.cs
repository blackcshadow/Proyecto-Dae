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

namespace Sistema_Tienda_Claudia
{
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-GHK5CVV\MSSQLSERVER04;Initial Catalog=TiendaClaudia;Integrated Security=True");

        //creamos un metodo login
        public void logear(string usuario, string contrasena)
        {
            try {
                con.Open();
                SqlCommand cmd = new SqlCommand("select Nombre,Tipo_usuario from Usuarios where Usuario = @usuario and Contrasenia = @contrasena", con);
                cmd.Parameters.AddWithValue("usuario", usuario);
                cmd.Parameters.AddWithValue("contrasena", contrasena);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    this.Hide();
                    if (dt.Rows[0][1].ToString() == "Administrador")
                    {
                        new FrmInicioAdmin().Show();
                    }
                    else if(dt.Rows[0][1].ToString() == "Usuario")
                    {
                        new FrmInicioUsuario().Show();
                    }
                }
                else
                {
                    MessageBox.Show("Usuario y Contraseña incorrectos","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }

            } 
            catch (Exception e){
                MessageBox.Show(e.Message);
            }
            finally {
                con.Close();
            }

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {

        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {

        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {

        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (this.txtUsuario.Text == "")
            {
                MessageBox.Show("Debe ingresar un nombre de usuario","Error en Usuario",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                
            }
            else if (this.txtPassword.Text == "")
            {
                MessageBox.Show("Debe ingresar una contraseña", "Error en Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                
                logear(this.txtUsuario.Text, this.txtPassword.Text);
            }
        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void LOGIN_Load(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
