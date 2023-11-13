using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; //Consultar la base de datos
using System.Drawing; //Dibujar el documento
using System.Drawing.Printing; //Imprimir el documento

namespace Sistema_Tienda_Claudia.Productos
{
    public partial class Factura : Form
    {
        public Factura()
        {
            InitializeComponent();
        }
        int.TryParse(txtPedido.Text, out idPedido)
        static string conexionstring = "server= DESKTOP-GHK5CVV\\MSSQLSERVER04 ; database = TiendaClaudia; integrated security = true";
        SqlConnection conexion = new SqlConnection(conexionstring);

        string consulta = "SELECT Nombre, Precio, cantidad, (Precio * cantidad) AS Total FROM Producto WHERE id_Pedido = @idPedido"

        //Crear un comando SQL
        SqlCommand comando = new SqlCommand(consulta, conexion);
        comando.Parameters.AddWithValue("@idPedido", Pedido.idPedido);

        //Abrir conexion
        conexion.Open();

        //Ejecutar consulta y obtener datos
        SqlDataReader lector = comando.ExecuteReader();

        //Leer datos
        if(lector.Read()){

        //Obtener los valores
        string nombre = lector["Nombre"].ToString();
        decimal precio = (decimal)lector["Precio"];
        decimal totalPedido = (decimal)lector["Total"];
        string fechaPedido = DateTime.Now.ToString("dd/MM/yyyy");

        //Mostrar datos en pantalla
        //Se puede asignar a labels, texbox, etc.
    }

    conexion.Close();

        private void MostrarDatosEnFormulario()
    {
        //Reemplazar labels cuando retraiga la informacion de la base de datos
        lblNombre.Text = nombre;
        lblPrecio.Text = precio.ToString();
        lblCantidad.Text = cantidad.ToString();
        lblTotal.Text = totalPedido.ToString();
    }

    private void btnImprimir_Click(object sender, EventArgs e)
    {
        
        if (int.TryParse(txtPedido.Text, out idPedido))
        {
            PrintDocument documento = new PrintDocument(); //Crear objeto documento
            documento.PrintPage += new PrintPageEventHandler(Imprimir); //Agregar manejador de evento

            PrintDialog dialogo = new PrintDialog(); //Crear objeto dialogo
            dialogo.Document = documento; //Asignar documento al dialogo

            if (dialogo.ShowDialog() == DialogResult.OK)
            {
                //La funcion ImprimiContenido es llamada automaticamente al imprimir
                documento.Print(); //Imprimir documento
            }
        }
        else
        {
            MessageBox.Show("Ingrese un numero valido");
        }
    }

    private void ImprimirContenido(object sender, PrintPageEventArgs e)
    {

        //Dibujar el contenido de la pagina
        //Aqui se usa e.Graphics.DrawString para dibujar texto en la pagina
        //Se puede usar tambien e.Graphics.DrawImage para dibujar imagenes

        e.Graphics.DrawString("Factura", new Font("Arial", 16, FontStyle.Bold), Brushes.Black, new Point(100, 50));
        e.Graphics.DrawString("Nombre: " + nombre, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(100, 100));
        e.Graphics.DrawString("Precio: " + precio, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(100, 150));
        e.Graphics.DrawString("Total: " + totalPedido, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(100, 200));
        e.Graphics.DrawString("Fecha: " + fechaPedido, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(100, 250));

    }
}
}
