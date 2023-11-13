namespace Sistema_Tienda_Claudia
{
    partial class AgDescuento
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
            this.button1 = new System.Windows.Forms.Button();
            this.GridDesc = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Porcentaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GridDesc)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(641, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 49);
            this.button1.TabIndex = 23;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GridDesc
            // 
            this.GridDesc.AllowUserToAddRows = false;
            this.GridDesc.AllowUserToDeleteRows = false;
            this.GridDesc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridDesc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Porcentaje});
            this.GridDesc.Location = new System.Drawing.Point(31, 107);
            this.GridDesc.Name = "GridDesc";
            this.GridDesc.Size = new System.Drawing.Size(714, 170);
            this.GridDesc.TabIndex = 22;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "id_Descuento";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // Porcentaje
            // 
            this.Porcentaje.DataPropertyName = "Descuento";
            this.Porcentaje.HeaderText = "Porcentaje";
            this.Porcentaje.Name = "Porcentaje";
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(31, 49);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(226, 20);
            this.txtDesc.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Agregue el porcentaje de descuento:";
            // 
            // AgDescuento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 305);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.GridDesc);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.label1);
            this.Name = "AgDescuento";
            this.Text = "AgDescuento";
            this.Load += new System.EventHandler(this.AgDescuento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridDesc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView GridDesc;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Porcentaje;
    }
}