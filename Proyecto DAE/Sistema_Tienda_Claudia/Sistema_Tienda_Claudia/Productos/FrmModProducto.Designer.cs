namespace Sistema_Tienda_Claudia
{
    partial class ModificarProduc
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
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxProd = new System.Windows.Forms.ComboBox();
            this.comboBoxPedido = new System.Windows.Forms.ComboBox();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.comboBoxCategoria = new System.Windows.Forms.ComboBox();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.numericCantidadProducto = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.numericPrecioProducto = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.idP = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_Pedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCantidadProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPrecioProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Button2
            // 
            this.guna2Button2.BorderRadius = 10;
            this.guna2Button2.BorderThickness = 1;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(133)))), ((int)(((byte)(123)))));
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Location = new System.Drawing.Point(578, 12);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(180, 45);
            this.guna2Button2.TabIndex = 27;
            this.guna2Button2.Text = "Ver Productos";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 10;
            this.guna2Button1.BorderThickness = 1;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(133)))), ((int)(((byte)(123)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(578, 182);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(180, 45);
            this.guna2Button1.TabIndex = 26;
            this.guna2Button1.Text = "Actualizar Producto";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idP,
            this.Numero,
            this.Nombre,
            this.Precio,
            this.cantidad,
            this.id_Categoria,
            this.id_Pedido});
            this.dataGridView1.Location = new System.Drawing.Point(15, 233);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(743, 289);
            this.dataGridView1.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 18);
            this.label1.TabIndex = 23;
            this.label1.Text = "Seleccione la Categoria que desea ver:";
            // 
            // comboBoxProd
            // 
            this.comboBoxProd.FormattingEnabled = true;
            this.comboBoxProd.Location = new System.Drawing.Point(320, 23);
            this.comboBoxProd.Name = "comboBoxProd";
            this.comboBoxProd.Size = new System.Drawing.Size(197, 21);
            this.comboBoxProd.TabIndex = 35;
            // 
            // comboBoxPedido
            // 
            this.comboBoxPedido.FormattingEnabled = true;
            this.comboBoxPedido.Location = new System.Drawing.Point(637, 125);
            this.comboBoxPedido.Name = "comboBoxPedido";
            this.comboBoxPedido.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPedido.TabIndex = 45;
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(378, 124);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(253, 22);
            this.guna2HtmlLabel4.TabIndex = 44;
            this.guna2HtmlLabel4.Text = "Seleccione la fecha del pedido:";
            // 
            // comboBoxCategoria
            // 
            this.comboBoxCategoria.FormattingEnabled = true;
            this.comboBoxCategoria.Location = new System.Drawing.Point(637, 85);
            this.comboBoxCategoria.Name = "comboBoxCategoria";
            this.comboBoxCategoria.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCategoria.TabIndex = 43;
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(433, 84);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(198, 22);
            this.guna2HtmlLabel5.TabIndex = 42;
            this.guna2HtmlLabel5.Text = "Seleccione la Categoria:";
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Location = new System.Drawing.Point(207, 85);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(156, 20);
            this.txtNombreProducto.TabIndex = 41;
            // 
            // numericCantidadProducto
            // 
            this.numericCantidadProducto.BackColor = System.Drawing.Color.Transparent;
            this.numericCantidadProducto.BorderColor = System.Drawing.Color.Black;
            this.numericCantidadProducto.BorderRadius = 2;
            this.numericCantidadProducto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numericCantidadProducto.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numericCantidadProducto.Location = new System.Drawing.Point(207, 141);
            this.numericCantidadProducto.Name = "numericCantidadProducto";
            this.numericCantidadProducto.Size = new System.Drawing.Size(85, 21);
            this.numericCantidadProducto.TabIndex = 37;
            this.numericCantidadProducto.UpDownButtonFillColor = System.Drawing.Color.Yellow;
            // 
            // numericPrecioProducto
            // 
            this.numericPrecioProducto.BackColor = System.Drawing.Color.Transparent;
            this.numericPrecioProducto.BorderColor = System.Drawing.Color.Black;
            this.numericPrecioProducto.BorderRadius = 2;
            this.numericPrecioProducto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numericPrecioProducto.DecimalPlaces = 2;
            this.numericPrecioProducto.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numericPrecioProducto.Location = new System.Drawing.Point(207, 112);
            this.numericPrecioProducto.Name = "numericPrecioProducto";
            this.numericPrecioProducto.Size = new System.Drawing.Size(85, 21);
            this.numericPrecioProducto.TabIndex = 36;
            this.numericPrecioProducto.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(15, 140);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(186, 22);
            this.guna2HtmlLabel3.TabIndex = 40;
            this.guna2HtmlLabel3.Text = "Cantidad del Producto:";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(15, 112);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(164, 22);
            this.guna2HtmlLabel2.TabIndex = 39;
            this.guna2HtmlLabel2.Text = "Precio del Producto:";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(15, 84);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(176, 22);
            this.guna2HtmlLabel1.TabIndex = 38;
            this.guna2HtmlLabel1.Text = "Nombre del Producto:";
            // 
            // idP
            // 
            this.idP.DataPropertyName = "idP";
            this.idP.HeaderText = "#";
            this.idP.Name = "idP";
            this.idP.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idP.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Numero
            // 
            this.Numero.DataPropertyName = "id_Producto";
            this.Numero.HeaderText = "Numero";
            this.Numero.Name = "Numero";
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Precio
            // 
            this.Precio.DataPropertyName = "Precio";
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            // 
            // cantidad
            // 
            this.cantidad.DataPropertyName = "cantidad";
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            // 
            // id_Categoria
            // 
            this.id_Categoria.DataPropertyName = "id_Categoria";
            this.id_Categoria.HeaderText = "Categoria";
            this.id_Categoria.Name = "id_Categoria";
            // 
            // id_Pedido
            // 
            this.id_Pedido.DataPropertyName = "id_Pedido";
            this.id_Pedido.HeaderText = "Pedido";
            this.id_Pedido.Name = "id_Pedido";
            // 
            // ModificarProduc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(234)))), ((int)(((byte)(223)))));
            this.ClientSize = new System.Drawing.Size(779, 531);
            this.Controls.Add(this.comboBoxPedido);
            this.Controls.Add(this.guna2HtmlLabel4);
            this.Controls.Add(this.comboBoxCategoria);
            this.Controls.Add(this.guna2HtmlLabel5);
            this.Controls.Add(this.txtNombreProducto);
            this.Controls.Add(this.numericCantidadProducto);
            this.Controls.Add(this.numericPrecioProducto);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.comboBoxProd);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "ModificarProduc";
            this.Text = "ModificarProducto";
            this.Load += new System.EventHandler(this.ModificarProduc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCantidadProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPrecioProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxProd;
        private System.Windows.Forms.ComboBox comboBoxPedido;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private System.Windows.Forms.ComboBox comboBoxCategoria;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private Guna.UI2.WinForms.Guna2NumericUpDown numericCantidadProducto;
        private Guna.UI2.WinForms.Guna2NumericUpDown numericPrecioProducto;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn idP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_Pedido;
    }
}