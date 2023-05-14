namespace pantallaMaestra
{
    partial class frmPantallaMaestra
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
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cbDatoAEliminar = new System.Windows.Forms.ComboBox();
            this.lblEliminar = new System.Windows.Forms.Label();
            this.txtDatoAEliminar = new System.Windows.Forms.TextBox();
            this.lblDatoAEliminar = new System.Windows.Forms.Label();
            this.lblProducto = new System.Windows.Forms.Label();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.lblPrecioProducto = new System.Windows.Forms.Label();
            this.txtPrecioProducto = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDatos
            // 
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Location = new System.Drawing.Point(234, 144);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.Size = new System.Drawing.Size(353, 285);
            this.dgvDatos.TabIndex = 0;
            // 
            // btnRead
            // 
            this.btnRead.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRead.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRead.Location = new System.Drawing.Point(27, 69);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(94, 31);
            this.btnRead.TabIndex = 1;
            this.btnRead.Text = "Traer datos";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCreate.Location = new System.Drawing.Point(234, 69);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(94, 31);
            this.btnCreate.TabIndex = 2;
            this.btnCreate.Text = "Crear dato";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Location = new System.Drawing.Point(462, 41);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(94, 31);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Modificar dato";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Location = new System.Drawing.Point(683, 79);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 31);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Eliminar dato";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // cbDatoAEliminar
            // 
            this.cbDatoAEliminar.FormattingEnabled = true;
            this.cbDatoAEliminar.Location = new System.Drawing.Point(623, 41);
            this.cbDatoAEliminar.Name = "cbDatoAEliminar";
            this.cbDatoAEliminar.Size = new System.Drawing.Size(102, 21);
            this.cbDatoAEliminar.TabIndex = 5;
            // 
            // lblEliminar
            // 
            this.lblEliminar.AutoSize = true;
            this.lblEliminar.Location = new System.Drawing.Point(623, 24);
            this.lblEliminar.Name = "lblEliminar";
            this.lblEliminar.Size = new System.Drawing.Size(88, 13);
            this.lblEliminar.TabIndex = 6;
            this.lblEliminar.Text = "Eliminar dato por:";
            // 
            // txtDatoAEliminar
            // 
            this.txtDatoAEliminar.Location = new System.Drawing.Point(736, 42);
            this.txtDatoAEliminar.Name = "txtDatoAEliminar";
            this.txtDatoAEliminar.Size = new System.Drawing.Size(100, 20);
            this.txtDatoAEliminar.TabIndex = 7;
            // 
            // lblDatoAEliminar
            // 
            this.lblDatoAEliminar.AutoSize = true;
            this.lblDatoAEliminar.Location = new System.Drawing.Point(736, 24);
            this.lblDatoAEliminar.Name = "lblDatoAEliminar";
            this.lblDatoAEliminar.Size = new System.Drawing.Size(30, 13);
            this.lblDatoAEliminar.TabIndex = 8;
            this.lblDatoAEliminar.Text = "Dato";
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Location = new System.Drawing.Point(157, 9);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(89, 13);
            this.lblProducto.TabIndex = 10;
            this.lblProducto.Text = "Nombre producto";
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Location = new System.Drawing.Point(160, 27);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(100, 20);
            this.txtNombreProducto.TabIndex = 9;
            // 
            // lblPrecioProducto
            // 
            this.lblPrecioProducto.AutoSize = true;
            this.lblPrecioProducto.Location = new System.Drawing.Point(307, 6);
            this.lblPrecioProducto.Name = "lblPrecioProducto";
            this.lblPrecioProducto.Size = new System.Drawing.Size(82, 13);
            this.lblPrecioProducto.TabIndex = 12;
            this.lblPrecioProducto.Text = "Precio producto";
            // 
            // txtPrecioProducto
            // 
            this.txtPrecioProducto.Location = new System.Drawing.Point(310, 24);
            this.txtPrecioProducto.Name = "txtPrecioProducto";
            this.txtPrecioProducto.Size = new System.Drawing.Size(100, 20);
            this.txtPrecioProducto.TabIndex = 11;
            // 
            // frmPantallaMaestra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 510);
            this.Controls.Add(this.lblPrecioProducto);
            this.Controls.Add(this.txtPrecioProducto);
            this.Controls.Add(this.lblProducto);
            this.Controls.Add(this.txtNombreProducto);
            this.Controls.Add(this.lblDatoAEliminar);
            this.Controls.Add(this.txtDatoAEliminar);
            this.Controls.Add(this.lblEliminar);
            this.Controls.Add(this.cbDatoAEliminar);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.dgvDatos);
            this.Name = "frmPantallaMaestra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pantalla maestra";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox cbDatoAEliminar;
        private System.Windows.Forms.Label lblEliminar;
        private System.Windows.Forms.TextBox txtDatoAEliminar;
        private System.Windows.Forms.Label lblDatoAEliminar;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.Label lblPrecioProducto;
        private System.Windows.Forms.TextBox txtPrecioProducto;
    }
}

