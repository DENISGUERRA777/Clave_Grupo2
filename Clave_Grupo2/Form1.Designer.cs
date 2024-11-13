namespace Clave_Grupo2
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
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblOrigen = new System.Windows.Forms.Label();
            this.lblDestino = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.cboxOrigen = new System.Windows.Forms.ComboBox();
            this.cboxDestino = new System.Windows.Forms.ComboBox();
            this.dtpickFecha = new System.Windows.Forms.DateTimePicker();
            this.cboxHora = new System.Windows.Forms.ComboBox();
            this.dgviwVuelos = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.btnBusqueda = new System.Windows.Forms.Button();
            this.lblBusqueda = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgviwVuelos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Location = new System.Drawing.Point(26, 22);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(111, 13);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Reserva tu vuelo aqui";
            // 
            // lblOrigen
            // 
            this.lblOrigen.AutoSize = true;
            this.lblOrigen.Location = new System.Drawing.Point(12, 64);
            this.lblOrigen.Name = "lblOrigen";
            this.lblOrigen.Size = new System.Drawing.Size(41, 13);
            this.lblOrigen.TabIndex = 1;
            this.lblOrigen.Text = "Origen:";
            // 
            // lblDestino
            // 
            this.lblDestino.AutoSize = true;
            this.lblDestino.Location = new System.Drawing.Point(225, 64);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(46, 13);
            this.lblDestino.TabIndex = 2;
            this.lblDestino.Text = "Destino:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(13, 109);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(40, 13);
            this.lblFecha.TabIndex = 3;
            this.lblFecha.Text = "Fecha:";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(278, 109);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(78, 13);
            this.lblHora.TabIndex = 4;
            this.lblHora.Text = "Hora de salida:";
            // 
            // cboxOrigen
            // 
            this.cboxOrigen.FormattingEnabled = true;
            this.cboxOrigen.Location = new System.Drawing.Point(59, 64);
            this.cboxOrigen.Name = "cboxOrigen";
            this.cboxOrigen.Size = new System.Drawing.Size(121, 21);
            this.cboxOrigen.TabIndex = 5;
            this.cboxOrigen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboxOrigen_KeyPress);
            // 
            // cboxDestino
            // 
            this.cboxDestino.FormattingEnabled = true;
            this.cboxDestino.Items.AddRange(new object[] {
            "Los Angeles, California",
            "New York, New York",
            "Mexico DF, Mexico",
            "Toronto, Canada",
            "Madrid, España"});
            this.cboxDestino.Location = new System.Drawing.Point(295, 64);
            this.cboxDestino.Name = "cboxDestino";
            this.cboxDestino.Size = new System.Drawing.Size(121, 21);
            this.cboxDestino.TabIndex = 6;
            this.cboxDestino.SelectedIndexChanged += new System.EventHandler(this.cboxDestino_SelectedIndexChanged);
            this.cboxDestino.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboxDestino_KeyPress);
            // 
            // dtpickFecha
            // 
            this.dtpickFecha.Location = new System.Drawing.Point(59, 103);
            this.dtpickFecha.Name = "dtpickFecha";
            this.dtpickFecha.Size = new System.Drawing.Size(200, 20);
            this.dtpickFecha.TabIndex = 7;
            // 
            // cboxHora
            // 
            this.cboxHora.FormattingEnabled = true;
            this.cboxHora.Items.AddRange(new object[] {
            "1:00",
            "2:00",
            "3:00",
            "4:00",
            "5:00",
            "6:00",
            "7:00",
            "8:00",
            "9:00",
            "10:00",
            "11:00",
            "12:00"});
            this.cboxHora.Location = new System.Drawing.Point(362, 101);
            this.cboxHora.Name = "cboxHora";
            this.cboxHora.Size = new System.Drawing.Size(78, 21);
            this.cboxHora.TabIndex = 8;
            this.cboxHora.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboxHora_KeyPress);
            // 
            // dgviwVuelos
            // 
            this.dgviwVuelos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgviwVuelos.Location = new System.Drawing.Point(29, 194);
            this.dgviwVuelos.Name = "dgviwVuelos";
            this.dgviwVuelos.Size = new System.Drawing.Size(622, 219);
            this.dgviwVuelos.TabIndex = 10;
            this.dgviwVuelos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgviwVuelos_CellDoubleClick);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(92, 153);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(88, 23);
            this.btnBuscar.TabIndex = 11;
            this.btnBuscar.Text = "Buscar vuelo";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(209, 153);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 12;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(327, 153);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 13;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(562, 77);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(100, 20);
            this.txtBusqueda.TabIndex = 14;
            this.txtBusqueda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBusqueda_KeyPress);
            // 
            // btnBusqueda
            // 
            this.btnBusqueda.Location = new System.Drawing.Point(576, 103);
            this.btnBusqueda.Name = "btnBusqueda";
            this.btnBusqueda.Size = new System.Drawing.Size(75, 37);
            this.btnBusqueda.TabIndex = 15;
            this.btnBusqueda.Text = "Cancelar reserva";
            this.btnBusqueda.UseVisualStyleBackColor = true;
            this.btnBusqueda.Click += new System.EventHandler(this.btnBusqueda_Click);
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.AutoSize = true;
            this.lblBusqueda.Location = new System.Drawing.Point(559, 39);
            this.lblBusqueda.Name = "lblBusqueda";
            this.lblBusqueda.Size = new System.Drawing.Size(103, 13);
            this.lblBusqueda.TabIndex = 16;
            this.lblBusqueda.Text = "Ingrese id de reseva";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 450);
            this.Controls.Add(this.lblBusqueda);
            this.Controls.Add(this.btnBusqueda);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dgviwVuelos);
            this.Controls.Add(this.cboxHora);
            this.Controls.Add(this.dtpickFecha);
            this.Controls.Add(this.cboxDestino);
            this.Controls.Add(this.cboxOrigen);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblDestino);
            this.Controls.Add(this.lblOrigen);
            this.Controls.Add(this.lblHeader);
            this.Name = "Form1";
            this.Text = "Reserva de vuelos";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgviwVuelos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblOrigen;
        private System.Windows.Forms.Label lblDestino;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.ComboBox cboxOrigen;
        private System.Windows.Forms.ComboBox cboxDestino;
        private System.Windows.Forms.DateTimePicker dtpickFecha;
        private System.Windows.Forms.ComboBox cboxHora;
        private System.Windows.Forms.DataGridView dgviwVuelos;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Button btnBusqueda;
        private System.Windows.Forms.Label lblBusqueda;
    }
}

