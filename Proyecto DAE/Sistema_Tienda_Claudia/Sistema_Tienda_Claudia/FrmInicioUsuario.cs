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
    public partial class FrmInicioUsuario : Form
    {
        public FrmInicioUsuario()
        {
            InitializeComponent();
        }

        private void agregarProductoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmAgProducto ventana1 = new FrmAgProducto();
            ventana1.MdiParent = this;
            ventana1.Show();
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
