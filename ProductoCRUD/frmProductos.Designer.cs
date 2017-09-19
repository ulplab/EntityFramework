namespace ProductoCRUD
{
    partial class frmProductos
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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.tbBuscar = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.btnListar = new System.Windows.Forms.Button();
            this.tbDescripcion = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.cbEstado = new System.Windows.Forms.CheckBox();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblCosto = new System.Windows.Forms.Label();
            this.tbCosto = new System.Windows.Forms.TextBox();
            this.tbUtilidad = new System.Windows.Forms.TextBox();
            this.lblUtilidad = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.cboCategorias = new System.Windows.Forms.ComboBox();
            this.ProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CoefUtil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(328, 11);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(67, 23);
            this.btnBuscar.TabIndex = 21;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // tbBuscar
            // 
            this.tbBuscar.Location = new System.Drawing.Point(94, 14);
            this.tbBuscar.Name = "tbBuscar";
            this.tbBuscar.Size = new System.Drawing.Size(228, 20);
            this.tbBuscar.TabIndex = 20;
            // 
            // lblBuscar
            // 
            this.lblBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBuscar.Location = new System.Drawing.Point(13, 14);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(75, 23);
            this.lblBuscar.TabIndex = 19;
            this.lblBuscar.Text = "Id";
            this.lblBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToDeleteRows = false;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductId,
            this.Categoria,
            this.Nombre,
            this.Costo,
            this.CoefUtil,
            this.Estado});
            this.dgvProductos.Location = new System.Drawing.Point(13, 207);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.Size = new System.Drawing.Size(383, 150);
            this.dgvProductos.TabIndex = 18;
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(252, 162);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(144, 23);
            this.btnListar.TabIndex = 17;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.Location = new System.Drawing.Point(94, 49);
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.Size = new System.Drawing.Size(228, 20);
            this.tbDescripcion.TabIndex = 16;
            // 
            // lblNombre
            // 
            this.lblNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNombre.Location = new System.Drawing.Point(13, 49);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(75, 23);
            this.lblNombre.TabIndex = 15;
            this.lblNombre.Text = "Descripcion";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbEstado
            // 
            this.cbEstado.AutoSize = true;
            this.cbEstado.Checked = true;
            this.cbEstado.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbEstado.Location = new System.Drawing.Point(337, 49);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(56, 17);
            this.cbEstado.TabIndex = 14;
            this.cbEstado.Text = "Activo";
            this.cbEstado.UseVisualStyleBackColor = true;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(171, 162);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(72, 23);
            this.btnBorrar.TabIndex = 13;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(92, 162);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(73, 23);
            this.btnActualizar.TabIndex = 12;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(13, 161);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(71, 25);
            this.btnAgregar.TabIndex = 11;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblCosto
            // 
            this.lblCosto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCosto.Location = new System.Drawing.Point(14, 120);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(75, 23);
            this.lblCosto.TabIndex = 22;
            this.lblCosto.Text = "Costo";
            this.lblCosto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbCosto
            // 
            this.tbCosto.Location = new System.Drawing.Point(95, 120);
            this.tbCosto.Name = "tbCosto";
            this.tbCosto.Size = new System.Drawing.Size(147, 20);
            this.tbCosto.TabIndex = 23;
            // 
            // tbUtilidad
            // 
            this.tbUtilidad.Location = new System.Drawing.Point(329, 120);
            this.tbUtilidad.Name = "tbUtilidad";
            this.tbUtilidad.Size = new System.Drawing.Size(65, 20);
            this.tbUtilidad.TabIndex = 25;
            // 
            // lblUtilidad
            // 
            this.lblUtilidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblUtilidad.Location = new System.Drawing.Point(248, 120);
            this.lblUtilidad.Name = "lblUtilidad";
            this.lblUtilidad.Size = new System.Drawing.Size(75, 23);
            this.lblUtilidad.TabIndex = 24;
            this.lblUtilidad.Text = "Utilidad";
            this.lblUtilidad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCategoria
            // 
            this.lblCategoria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCategoria.Location = new System.Drawing.Point(13, 83);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(75, 23);
            this.lblCategoria.TabIndex = 26;
            this.lblCategoria.Text = "Categoría";
            this.lblCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboCategorias
            // 
            this.cboCategorias.FormattingEnabled = true;
            this.cboCategorias.Location = new System.Drawing.Point(94, 83);
            this.cboCategorias.Name = "cboCategorias";
            this.cboCategorias.Size = new System.Drawing.Size(299, 21);
            this.cboCategorias.TabIndex = 27;
            this.cboCategorias.SelectedIndexChanged += new System.EventHandler(this.cboCategorias_SelectedIndexChanged);
            // 
            // ProductId
            // 
            this.ProductId.DataPropertyName = "ProductoId";
            this.ProductId.HeaderText = "Id";
            this.ProductId.Name = "ProductId";
            this.ProductId.ReadOnly = true;
            this.ProductId.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ProductId.Width = 30;
            // 
            // Categoria
            // 
            this.Categoria.DataPropertyName = "Categoria";
            this.Categoria.HeaderText = "Categoría";
            this.Categoria.Name = "Categoria";
            this.Categoria.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Descripcion";
            this.Nombre.HeaderText = "Descripción";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Costo
            // 
            this.Costo.DataPropertyName = "Costo";
            this.Costo.HeaderText = "Costo";
            this.Costo.Name = "Costo";
            this.Costo.ReadOnly = true;
            this.Costo.Width = 50;
            // 
            // CoefUtil
            // 
            this.CoefUtil.DataPropertyName = "CoefUtil";
            this.CoefUtil.HeaderText = "CoefUtil";
            this.CoefUtil.Name = "CoefUtil";
            this.CoefUtil.ReadOnly = true;
            this.CoefUtil.Width = 50;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "Estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // frmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 405);
            this.Controls.Add(this.cboCategorias);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.tbUtilidad);
            this.Controls.Add(this.lblUtilidad);
            this.Controls.Add(this.tbCosto);
            this.Controls.Add(this.lblCosto);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.tbBuscar);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.tbDescripcion);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnAgregar);
            this.Name = "frmProductos";
            this.Text = "Producto";
            this.Load += new System.EventHandler(this.frmProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox tbBuscar;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.TextBox tbDescripcion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.CheckBox cbEstado;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblCosto;
        private System.Windows.Forms.TextBox tbCosto;
        private System.Windows.Forms.TextBox tbUtilidad;
        private System.Windows.Forms.Label lblUtilidad;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ComboBox cboCategorias;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Costo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CoefUtil;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Estado;
    }
}

