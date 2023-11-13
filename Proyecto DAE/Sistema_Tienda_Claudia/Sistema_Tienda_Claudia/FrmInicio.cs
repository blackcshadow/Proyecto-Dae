using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Tienda_Claudia
{
    public partial class FrmInicioAdmin : Form
    {
        public FrmInicioAdmin()
        {
            InitializeComponent();
        }

        private void agregarProductoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmAgProducto ventana1 = new FrmAgProducto();
            ventana1.MdiParent = this;
            ventana1.Show();
        }

        private void quitarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuitarProduc ventana2 = new QuitarProduc();
            ventana2 .MdiParent = this;
            ventana2.Show();
        }

        private void mOdificarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModificarProduc ventana3 = new ModificarProduc();
            ventana3.MdiParent = this;
            ventana3.Show();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void agregarUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgUsuario ventana = new AgUsuario();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void agregarProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgProveedor ventana = new AgProveedor();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void agregarCategoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgCategoria ventana = new AgCategoria();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void agregarDescuentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgDescuento ventana = new AgDescuento();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void agregarPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgPedido ventana = new AgPedido();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void busquedaDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VerProductos ventana = new VerProductos();
            ventana.MdiParent = this;
            ventana.Show();
        }
    }
}
