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
            this.cbProdAEliminar = new System.Windows.Forms.ComboBox();
            this.lblEliminar = new System.Windows.Forms.Label();
            this.lblProducto = new System.Windows.Forms.Label();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.lblPrecioProducto = new System.Windows.Forms.Label();
            this.txtPrecioProducto = new System.Windows.Forms.TextBox();
            this.lblNuevoPrecio = new System.Windows.Forms.Label();
            this.txtNuevoPrecio = new System.Windows.Forms.TextBox();
            this.lblNuevoNombre = new System.Windows.Forms.Label();
            this.txtNuevoNombre = new System.Windows.Forms.TextBox();
            this.lblIdAEditar = new System.Windows.Forms.Label();
            this.cbIdAEditar = new System.Windows.Forms.ComboBox();
            this.BtnPrincipio = new System.Windows.Forms.Button();
            this.BtnAtras = new System.Windows.Forms.Button();
            this.BtnSiguiente = new System.Windows.Forms.Button();
            this.BtnFinal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDatos
            // 
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Location = new System.Drawing.Point(353, 49);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.Size = new System.Drawing.Size(421, 410);
            this.dgvDatos.TabIndex = 0;
            this.dgvDatos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatos_CellClick_1);
            // 
            // btnRead
            // 
            this.btnRead.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRead.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRead.Location = new System.Drawing.Point(112, 31);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(94, 31);
            this.btnRead.TabIndex = 1;
            this.btnRead.Text = "Traer datos";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.BtnRead_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCreate.Location = new System.Drawing.Point(113, 159);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(94, 31);
            this.btnCreate.TabIndex = 2;
            this.btnCreate.Text = "Crear dato";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Location = new System.Drawing.Point(112, 329);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(94, 31);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Modificar dato";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Location = new System.Drawing.Point(112, 444);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 31);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Eliminar dato";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // cbProdAEliminar
            // 
            this.cbProdAEliminar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProdAEliminar.FormattingEnabled = true;
            this.cbProdAEliminar.Location = new System.Drawing.Point(105, 417);
            this.cbProdAEliminar.Name = "cbProdAEliminar";
            this.cbProdAEliminar.Size = new System.Drawing.Size(106, 21);
            this.cbProdAEliminar.TabIndex = 5;
            // 
            // lblEliminar
            // 
            this.lblEliminar.AutoSize = true;
            this.lblEliminar.Location = new System.Drawing.Point(101, 401);
            this.lblEliminar.Name = "lblEliminar";
            this.lblEliminar.Size = new System.Drawing.Size(110, 13);
            this.lblEliminar.TabIndex = 6;
            this.lblEliminar.Text = "ID producto a eliminar";
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Location = new System.Drawing.Point(36, 99);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(89, 13);
            this.lblProducto.TabIndex = 10;
            this.lblProducto.Text = "Nombre producto";
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Location = new System.Drawing.Point(39, 117);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(100, 20);
            this.txtNombreProducto.TabIndex = 9;
            // 
            // lblPrecioProducto
            // 
            this.lblPrecioProducto.AutoSize = true;
            this.lblPrecioProducto.Location = new System.Drawing.Point(186, 96);
            this.lblPrecioProducto.Name = "lblPrecioProducto";
            this.lblPrecioProducto.Size = new System.Drawing.Size(82, 13);
            this.lblPrecioProducto.TabIndex = 12;
            this.lblPrecioProducto.Text = "Precio producto";
            // 
            // txtPrecioProducto
            // 
            this.txtPrecioProducto.Location = new System.Drawing.Point(189, 114);
            this.txtPrecioProducto.Name = "txtPrecioProducto";
            this.txtPrecioProducto.Size = new System.Drawing.Size(100, 20);
            this.txtPrecioProducto.TabIndex = 11;
            // 
            // lblNuevoPrecio
            // 
            this.lblNuevoPrecio.AutoSize = true;
            this.lblNuevoPrecio.Location = new System.Drawing.Point(186, 270);
            this.lblNuevoPrecio.Name = "lblNuevoPrecio";
            this.lblNuevoPrecio.Size = new System.Drawing.Size(71, 13);
            this.lblNuevoPrecio.TabIndex = 16;
            this.lblNuevoPrecio.Text = "Nuevo precio";
            // 
            // txtNuevoPrecio
            // 
            this.txtNuevoPrecio.Location = new System.Drawing.Point(189, 288);
            this.txtNuevoPrecio.Name = "txtNuevoPrecio";
            this.txtNuevoPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtNuevoPrecio.TabIndex = 15;
            // 
            // lblNuevoNombre
            // 
            this.lblNuevoNombre.AutoSize = true;
            this.lblNuevoNombre.Location = new System.Drawing.Point(36, 270);
            this.lblNuevoNombre.Name = "lblNuevoNombre";
            this.lblNuevoNombre.Size = new System.Drawing.Size(77, 13);
            this.lblNuevoNombre.TabIndex = 14;
            this.lblNuevoNombre.Text = "Nuevo nombre";
            // 
            // txtNuevoNombre
            // 
            this.txtNuevoNombre.Location = new System.Drawing.Point(39, 288);
            this.txtNuevoNombre.Name = "txtNuevoNombre";
            this.txtNuevoNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNuevoNombre.TabIndex = 13;
            // 
            // lblIdAEditar
            // 
            this.lblIdAEditar.AutoSize = true;
            this.lblIdAEditar.Location = new System.Drawing.Point(106, 232);
            this.lblIdAEditar.Name = "lblIdAEditar";
            this.lblIdAEditar.Size = new System.Drawing.Size(101, 13);
            this.lblIdAEditar.TabIndex = 18;
            this.lblIdAEditar.Text = "ID producto a editar";
            // 
            // cbIdAEditar
            // 
            this.cbIdAEditar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIdAEditar.FormattingEnabled = true;
            this.cbIdAEditar.Location = new System.Drawing.Point(105, 248);
            this.cbIdAEditar.Name = "cbIdAEditar";
            this.cbIdAEditar.Size = new System.Drawing.Size(106, 21);
            this.cbIdAEditar.TabIndex = 19;
            // 
            // BtnPrincipio
            // 
            this.BtnPrincipio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPrincipio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnPrincipio.Location = new System.Drawing.Point(482, 467);
            this.BtnPrincipio.Name = "BtnPrincipio";
            this.BtnPrincipio.Size = new System.Drawing.Size(49, 31);
            this.BtnPrincipio.TabIndex = 20;
            this.BtnPrincipio.Text = "<<";
            this.BtnPrincipio.UseVisualStyleBackColor = true;
            this.BtnPrincipio.Click += new System.EventHandler(this.BtnPrincipio_Click);
            // 
            // BtnAtras
            // 
            this.BtnAtras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAtras.Location = new System.Drawing.Point(537, 467);
            this.BtnAtras.Name = "BtnAtras";
            this.BtnAtras.Size = new System.Drawing.Size(49, 31);
            this.BtnAtras.TabIndex = 21;
            this.BtnAtras.Text = "<";
            this.BtnAtras.UseVisualStyleBackColor = true;
            this.BtnAtras.Click += new System.EventHandler(this.BtnAtras_Click);
            // 
            // BtnSiguiente
            // 
            this.BtnSiguiente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSiguiente.Location = new System.Drawing.Point(592, 467);
            this.BtnSiguiente.Name = "BtnSiguiente";
            this.BtnSiguiente.Size = new System.Drawing.Size(49, 31);
            this.BtnSiguiente.TabIndex = 22;
            this.BtnSiguiente.Text = ">";
            this.BtnSiguiente.UseVisualStyleBackColor = true;
            this.BtnSiguiente.Click += new System.EventHandler(this.BtnSiguiente_Click);
            // 
            // BtnFinal
            // 
            this.BtnFinal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnFinal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnFinal.Location = new System.Drawing.Point(647, 467);
            this.BtnFinal.Name = "BtnFinal";
            this.BtnFinal.Size = new System.Drawing.Size(49, 31);
            this.BtnFinal.TabIndex = 23;
            this.BtnFinal.Text = ">>";
            this.BtnFinal.UseVisualStyleBackColor = true;
            this.BtnFinal.Click += new System.EventHandler(this.BtnFinal_Click);
            // 
            // frmPantallaMaestra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 510);
            this.Controls.Add(this.BtnFinal);
            this.Controls.Add(this.BtnSiguiente);
            this.Controls.Add(this.BtnAtras);
            this.Controls.Add(this.BtnPrincipio);
            this.Controls.Add(this.cbIdAEditar);
            this.Controls.Add(this.lblIdAEditar);
            this.Controls.Add(this.lblNuevoPrecio);
            this.Controls.Add(this.txtNuevoPrecio);
            this.Controls.Add(this.lblNuevoNombre);
            this.Controls.Add(this.txtNuevoNombre);
            this.Controls.Add(this.lblPrecioProducto);
            this.Controls.Add(this.txtPrecioProducto);
            this.Controls.Add(this.lblProducto);
            this.Controls.Add(this.txtNombreProducto);
            this.Controls.Add(this.lblEliminar);
            this.Controls.Add(this.cbProdAEliminar);
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
        private System.Windows.Forms.ComboBox cbProdAEliminar;
        private System.Windows.Forms.Label lblEliminar;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.Label lblPrecioProducto;
        private System.Windows.Forms.TextBox txtPrecioProducto;
        private System.Windows.Forms.Label lblNuevoPrecio;
        private System.Windows.Forms.TextBox txtNuevoPrecio;
        private System.Windows.Forms.Label lblNuevoNombre;
        private System.Windows.Forms.TextBox txtNuevoNombre;
        private System.Windows.Forms.Label lblIdAEditar;
        private System.Windows.Forms.ComboBox cbIdAEditar;
        private System.Windows.Forms.Button BtnPrincipio;
        private System.Windows.Forms.Button BtnAtras;
        private System.Windows.Forms.Button BtnSiguiente;
        private System.Windows.Forms.Button BtnFinal;
    }
}

