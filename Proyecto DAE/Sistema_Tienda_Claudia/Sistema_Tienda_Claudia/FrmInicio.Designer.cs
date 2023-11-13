namespace Sistema_Tienda_Claudia
{
    partial class FrmInicioAdmin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.StripMenu = new System.Windows.Forms.MenuStrip();
            this.agregarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarProductoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.quitarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mOdificarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarPedidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.busquedaDeProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturasClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regristrosDeEntradaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarProveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarDescuentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarCategoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StripMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // StripMenu
            // 
            this.StripMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(59)))), ((int)(((byte)(49)))));
            this.StripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarProductoToolStripMenuItem,
            this.verToolStripMenuItem,
            this.opcionesToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.StripMenu.Location = new System.Drawing.Point(0, 0);
            this.StripMenu.Name = "StripMenu";
            this.StripMenu.Size = new System.Drawing.Size(1064, 24);
            this.StripMenu.TabIndex = 0;
            // 
            // agregarProductoToolStripMenuItem
            // 
            this.agregarProductoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarProductoToolStripMenuItem1,
            this.quitarProductoToolStripMenuItem,
            this.mOdificarProductoToolStripMenuItem,
            this.agregarPedidoToolStripMenuItem});
            this.agregarProductoToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.agregarProductoToolStripMenuItem.Name = "agregarProductoToolStripMenuItem";
            this.agregarProductoToolStripMenuItem.RightToLeftAutoMirrorImage = true;
            this.agregarProductoToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.agregarProductoToolStripMenuItem.Text = "Productos";
            // 
            // agregarProductoToolStripMenuItem1
            // 
            this.agregarProductoToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(59)))), ((int)(((byte)(49)))));
            this.agregarProductoToolStripMenuItem1.ForeColor = System.Drawing.Color.Snow;
            this.agregarProductoToolStripMenuItem1.Name = "agregarProductoToolStripMenuItem1";
            this.agregarProductoToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.agregarProductoToolStripMenuItem1.Text = "Agregar Producto";
            this.agregarProductoToolStripMenuItem1.Click += new System.EventHandler(this.agregarProductoToolStripMenuItem1_Click);
            // 
            // quitarProductoToolStripMenuItem
            // 
            this.quitarProductoToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(59)))), ((int)(((byte)(49)))));
            this.quitarProductoToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.quitarProductoToolStripMenuItem.Name = "quitarProductoToolStripMenuItem";
            this.quitarProductoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.quitarProductoToolStripMenuItem.Text = "Quitar Producto";
            this.quitarProductoToolStripMenuItem.Click += new System.EventHandler(this.quitarProductoToolStripMenuItem_Click);
            // 
            // mOdificarProductoToolStripMenuItem
            // 
            this.mOdificarProductoToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(59)))), ((int)(((byte)(49)))));
            this.mOdificarProductoToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.mOdificarProductoToolStripMenuItem.Name = "mOdificarProductoToolStripMenuItem";
            this.mOdificarProductoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mOdificarProductoToolStripMenuItem.Text = "Modificar Producto";
            this.mOdificarProductoToolStripMenuItem.Click += new System.EventHandler(this.mOdificarProductoToolStripMenuItem_Click);
            // 
            // agregarPedidoToolStripMenuItem
            // 
            this.agregarPedidoToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(59)))), ((int)(((byte)(49)))));
            this.agregarPedidoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.agregarPedidoToolStripMenuItem.Name = "agregarPedidoToolStripMenuItem";
            this.agregarPedidoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.agregarPedidoToolStripMenuItem.Text = "Agregar Pedido";
            this.agregarPedidoToolStripMenuItem.Click += new System.EventHandler(this.agregarPedidoToolStripMenuItem_Click);
            // 
            // verToolStripMenuItem
            // 
            this.verToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.busquedaDeProductosToolStripMenuItem,
            this.registrosToolStripMenuItem});
            this.verToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.verToolStripMenuItem.Text = "Ver";
            // 
            // busquedaDeProductosToolStripMenuItem
            // 
            this.busquedaDeProductosToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(59)))), ((int)(((byte)(49)))));
            this.busquedaDeProductosToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.busquedaDeProductosToolStripMenuItem.Name = "busquedaDeProductosToolStripMenuItem";
            this.busquedaDeProductosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.busquedaDeProductosToolStripMenuItem.Text = "Productos";
            this.busquedaDeProductosToolStripMenuItem.Click += new System.EventHandler(this.busquedaDeProductosToolStripMenuItem_Click);
            // 
            // registrosToolStripMenuItem
            // 
            this.registrosToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(59)))), ((int)(((byte)(49)))));
            this.registrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.facturasClientesToolStripMenuItem,
            this.regristrosDeEntradaToolStripMenuItem});
            this.registrosToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.registrosToolStripMenuItem.Name = "registrosToolStripMenuItem";
            this.registrosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.registrosToolStripMenuItem.Text = "Registros";
            // 
            // facturasClientesToolStripMenuItem
            // 
            this.facturasClientesToolStripMenuItem.Name = "facturasClientesToolStripMenuItem";
            this.facturasClientesToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.facturasClientesToolStripMenuItem.Text = "Facturas Clientes";
            // 
            // regristrosDeEntradaToolStripMenuItem
            // 
            this.regristrosDeEntradaToolStripMenuItem.Name = "regristrosDeEntradaToolStripMenuItem";
            this.regristrosDeEntradaToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.regristrosDeEntradaToolStripMenuItem.Text = "Regristros de entrada";
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarUsuariosToolStripMenuItem,
            this.agregarProveedoresToolStripMenuItem,
            this.agregarDescuentosToolStripMenuItem,
            this.agregarCategoriasToolStripMenuItem});
            this.opcionesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // agregarUsuariosToolStripMenuItem
            // 
            this.agregarUsuariosToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(59)))), ((int)(((byte)(49)))));
            this.agregarUsuariosToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.agregarUsuariosToolStripMenuItem.Name = "agregarUsuariosToolStripMenuItem";
            this.agregarUsuariosToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.agregarUsuariosToolStripMenuItem.Text = "Agregar Usuarios";
            this.agregarUsuariosToolStripMenuItem.Click += new System.EventHandler(this.agregarUsuariosToolStripMenuItem_Click);
            // 
            // agregarProveedoresToolStripMenuItem
            // 
            this.agregarProveedoresToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(59)))), ((int)(((byte)(49)))));
            this.agregarProveedoresToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.agregarProveedoresToolStripMenuItem.Name = "agregarProveedoresToolStripMenuItem";
            this.agregarProveedoresToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.agregarProveedoresToolStripMenuItem.Text = "Agregar Proveedores";
            this.agregarProveedoresToolStripMenuItem.Click += new System.EventHandler(this.agregarProveedoresToolStripMenuItem_Click);
            // 
            // agregarDescuentosToolStripMenuItem
            // 
            this.agregarDescuentosToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(59)))), ((int)(((byte)(49)))));
            this.agregarDescuentosToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.agregarDescuentosToolStripMenuItem.Name = "agregarDescuentosToolStripMenuItem";
            this.agregarDescuentosToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.agregarDescuentosToolStripMenuItem.Text = "Agregar Descuentos";
            this.agregarDescuentosToolStripMenuItem.Click += new System.EventHandler(this.agregarDescuentosToolStripMenuItem_Click);
            // 
            // agregarCategoriasToolStripMenuItem
            // 
            this.agregarCategoriasToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(59)))), ((int)(((byte)(49)))));
            this.agregarCategoriasToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.agregarCategoriasToolStripMenuItem.Name = "agregarCategoriasToolStripMenuItem";
            this.agregarCategoriasToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.agregarCategoriasToolStripMenuItem.Text = "Agregar Categorias";
            this.agregarCategoriasToolStripMenuItem.Click += new System.EventHandler(this.agregarCategoriasToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // FrmInicioAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 559);
            this.Controls.Add(this.StripMenu);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(165)))), ((int)(((byte)(141)))));
            this.IsMdiContainer = true;
            this.Name = "FrmInicioAdmin";
            this.Text = "Bienvenido a Tienda Claudia";
            this.StripMenu.ResumeLayout(false);
            this.StripMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip StripMenu;
        private System.Windows.Forms.ToolStripMenuItem agregarProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarProductoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem quitarProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mOdificarProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem busquedaDeProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturasClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem regristrosDeEntradaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarProveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarDescuentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarCategoriasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarPedidoToolStripMenuItem;
    }
}

