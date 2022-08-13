namespace TareaGestor
{
    partial class Form1
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btCrear = new System.Windows.Forms.Button();
            this.btEditar = new System.Windows.Forms.Button();
            this.btBorrar = new System.Windows.Forms.Button();
            this.btBuscarFecha = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBox_Nombre = new System.Windows.Forms.TextBox();
            this.txtBox_Descripcion = new System.Windows.Forms.TextBox();
            this.dtLimite = new System.Windows.Forms.DateTimePicker();
            this.dtCreacion = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.dtBuscarFecha = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBuscarEstado = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dgTareas = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btBuscarEstado = new System.Windows.Forms.Button();
            this.btTerminarBusqueda = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgTareas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoEllipsis = true;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Poppins Black", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(72, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(409, 74);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "GESTOR DE TAREA";
            // 
            // btCrear
            // 
            this.btCrear.Location = new System.Drawing.Point(41, 565);
            this.btCrear.Name = "btCrear";
            this.btCrear.Size = new System.Drawing.Size(123, 34);
            this.btCrear.TabIndex = 1;
            this.btCrear.Text = "Crear";
            this.btCrear.UseVisualStyleBackColor = true;
            this.btCrear.Click += new System.EventHandler(this.button1_Click);
            // 
            // btEditar
            // 
            this.btEditar.Location = new System.Drawing.Point(210, 565);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(123, 34);
            this.btEditar.TabIndex = 1;
            this.btEditar.Text = "Editar";
            this.btEditar.UseVisualStyleBackColor = true;
            this.btEditar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btBorrar
            // 
            this.btBorrar.Location = new System.Drawing.Point(376, 565);
            this.btBorrar.Name = "btBorrar";
            this.btBorrar.Size = new System.Drawing.Size(123, 34);
            this.btBorrar.TabIndex = 1;
            this.btBorrar.Text = "Borrar";
            this.btBorrar.UseVisualStyleBackColor = true;
            this.btBorrar.Click += new System.EventHandler(this.btBorrar_Click);
            // 
            // btBuscarFecha
            // 
            this.btBuscarFecha.Location = new System.Drawing.Point(561, 137);
            this.btBuscarFecha.Name = "btBuscarFecha";
            this.btBuscarFecha.Size = new System.Drawing.Size(281, 34);
            this.btBuscarFecha.TabIndex = 1;
            this.btBuscarFecha.Text = "Buscar Por Fecha";
            this.btBuscarFecha.UseVisualStyleBackColor = true;
            this.btBuscarFecha.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(81, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descripcion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(81, 325);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha creación";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(81, 396);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 30);
            this.label4.TabIndex = 2;
            this.label4.Text = " Fecha límite";
            // 
            // txtBox_Nombre
            // 
            this.txtBox_Nombre.Location = new System.Drawing.Point(86, 216);
            this.txtBox_Nombre.Name = "txtBox_Nombre";
            this.txtBox_Nombre.Size = new System.Drawing.Size(362, 22);
            this.txtBox_Nombre.TabIndex = 4;
            // 
            // txtBox_Descripcion
            // 
            this.txtBox_Descripcion.Location = new System.Drawing.Point(85, 282);
            this.txtBox_Descripcion.Name = "txtBox_Descripcion";
            this.txtBox_Descripcion.Size = new System.Drawing.Size(362, 22);
            this.txtBox_Descripcion.TabIndex = 4;
            // 
            // dtLimite
            // 
            this.dtLimite.CustomFormat = "ddMMyyyy";
            this.dtLimite.Location = new System.Drawing.Point(85, 429);
            this.dtLimite.Name = "dtLimite";
            this.dtLimite.Size = new System.Drawing.Size(361, 22);
            this.dtLimite.TabIndex = 5;
            // 
            // dtCreacion
            // 
            this.dtCreacion.CustomFormat = "dd-MM-yyyy";
            this.dtCreacion.Location = new System.Drawing.Point(87, 358);
            this.dtCreacion.Name = "dtCreacion";
            this.dtCreacion.Size = new System.Drawing.Size(361, 22);
            this.dtCreacion.TabIndex = 5;
            this.dtCreacion.Value = new System.DateTime(2022, 8, 16, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(81, 472);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 30);
            this.label5.TabIndex = 2;
            this.label5.Text = "Estado";
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(86, 505);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(362, 22);
            this.txtEstado.TabIndex = 4;
            // 
            // dtBuscarFecha
            // 
            this.dtBuscarFecha.CustomFormat = "dd-MM-yyyy";
            this.dtBuscarFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtBuscarFecha.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtBuscarFecha.Location = new System.Drawing.Point(561, 97);
            this.dtBuscarFecha.Name = "dtBuscarFecha";
            this.dtBuscarFecha.Size = new System.Drawing.Size(281, 22);
            this.dtBuscarFecha.TabIndex = 7;
            this.dtBuscarFecha.Value = new System.DateTime(2022, 8, 13, 3, 15, 13, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poppins Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(624, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 30);
            this.label6.TabIndex = 6;
            this.label6.Text = "Fecha creación";
            // 
            // txtBuscarEstado
            // 
            this.txtBuscarEstado.Location = new System.Drawing.Point(873, 97);
            this.txtBuscarEstado.Name = "txtBuscarEstado";
            this.txtBuscarEstado.Size = new System.Drawing.Size(298, 22);
            this.txtBuscarEstado.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Poppins Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(986, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 30);
            this.label7.TabIndex = 8;
            this.label7.Text = "Estado";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Poppins Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(722, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(266, 30);
            this.label8.TabIndex = 6;
            this.label8.Text = "Busqueda Por Fecha y Estado";
            // 
            // dgTareas
            // 
            this.dgTareas.AllowUserToAddRows = false;
            this.dgTareas.AllowUserToDeleteRows = false;
            this.dgTareas.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgTareas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTareas.Location = new System.Drawing.Point(561, 233);
            this.dgTareas.Name = "dgTareas";
            this.dgTareas.ReadOnly = true;
            this.dgTareas.RowHeadersWidth = 51;
            this.dgTareas.RowTemplate.Height = 24;
            this.dgTareas.Size = new System.Drawing.Size(610, 352);
            this.dgTareas.TabIndex = 10;
            this.dgTareas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgTareas_CellClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Poppins Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(81, 110);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 30);
            this.label9.TabIndex = 2;
            this.label9.Text = "Id";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(86, 143);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(362, 22);
            this.txtId.TabIndex = 4;
            // 
            // btBuscarEstado
            // 
            this.btBuscarEstado.Location = new System.Drawing.Point(873, 137);
            this.btBuscarEstado.Name = "btBuscarEstado";
            this.btBuscarEstado.Size = new System.Drawing.Size(298, 34);
            this.btBuscarEstado.TabIndex = 11;
            this.btBuscarEstado.Text = "Buscar por Estado";
            this.btBuscarEstado.UseVisualStyleBackColor = true;
            this.btBuscarEstado.Click += new System.EventHandler(this.btBuscarEstado_Click);
            // 
            // btTerminarBusqueda
            // 
            this.btTerminarBusqueda.Location = new System.Drawing.Point(727, 183);
            this.btTerminarBusqueda.Name = "btTerminarBusqueda";
            this.btTerminarBusqueda.Size = new System.Drawing.Size(264, 37);
            this.btTerminarBusqueda.TabIndex = 12;
            this.btTerminarBusqueda.Text = "Terminar Busqueda";
            this.btTerminarBusqueda.UseVisualStyleBackColor = true;
            this.btTerminarBusqueda.Click += new System.EventHandler(this.btTerminarBusqueda_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 666);
            this.Controls.Add(this.btTerminarBusqueda);
            this.Controls.Add(this.btBuscarEstado);
            this.Controls.Add(this.dgTareas);
            this.Controls.Add(this.txtBuscarEstado);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtBuscarFecha);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtCreacion);
            this.Controls.Add(this.dtLimite);
            this.Controls.Add(this.txtBox_Descripcion);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtBox_Nombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btBorrar);
            this.Controls.Add(this.btBuscarFecha);
            this.Controls.Add(this.btEditar);
            this.Controls.Add(this.btCrear);
            this.Controls.Add(this.lblTitulo);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgTareas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btCrear;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.Button btBorrar;
        private System.Windows.Forms.Button btBuscarFecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBox_Nombre;
        private System.Windows.Forms.TextBox txtBox_Descripcion;
        private System.Windows.Forms.DateTimePicker dtLimite;
        private System.Windows.Forms.DateTimePicker dtCreacion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.DateTimePicker dtBuscarFecha;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBuscarEstado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgTareas;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btBuscarEstado;
        private System.Windows.Forms.Button btTerminarBusqueda;
    }
}

