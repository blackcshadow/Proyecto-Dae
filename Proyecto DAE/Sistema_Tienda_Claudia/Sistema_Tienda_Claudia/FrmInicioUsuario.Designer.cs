namespace Sistema_Tienda_Claudia
{
    partial class FrmInicioUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.StripMenu = new System.Windows.Forms.MenuStrip();
            this.agregarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarProductoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarPedidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.busquedaDeProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturasClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regristrosDeEntradaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StripMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // StripMenu
            // 
            this.StripMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(59)))), ((int)(((byte)(49)))));
            this.StripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarProductoToolStripMenuItem,
            this.verToolStripMenuItem});
            this.StripMenu.Location = new System.Drawing.Point(0, 0);
            this.StripMenu.Name = "StripMenu";
            this.StripMenu.Size = new System.Drawing.Size(800, 24);
            this.StripMenu.TabIndex = 1;
            // 
            // agregarProductoToolStripMenuItem
            // 
            this.agregarProductoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarProductoToolStripMenuItem1,
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
            this.registrosToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
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
            // FrmInicioUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.StripMenu);
            this.IsMdiContainer = true;
            this.Name = "FrmInicioUsuario";
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
        private System.Windows.Forms.ToolStripMenuItem agregarPedidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem busquedaDeProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturasClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem regristrosDeEntradaToolStripMenuItem;
    }
}