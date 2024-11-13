namespace Clave_Grupo2
{
    partial class Form2
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
            this.btnReservar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblOrigen = new System.Windows.Forms.Label();
            this.lblInformacio = new System.Windows.Forms.Label();
            this.lblDestino = new System.Windows.Forms.Label();
            this.lblHoraPartida = new System.Windows.Forms.Label();
            this.lblHoraLlegada = new System.Windows.Forms.Label();
            this.lblPreico = new System.Windows.Forms.Label();
            this.lblAsientos = new System.Windows.Forms.Label();
            this.txtAsientos = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnReservar
            // 
            this.btnReservar.Location = new System.Drawing.Point(412, 159);
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.Size = new System.Drawing.Size(75, 37);
            this.btnReservar.TabIndex = 0;
            this.btnReservar.Text = "Confirmar y pagar";
            this.btnReservar.UseVisualStyleBackColor = true;
            this.btnReservar.Click += new System.EventHandler(this.btnReservar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(297, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 2;
            // 
            // lblOrigen
            // 
            this.lblOrigen.AutoSize = true;
            this.lblOrigen.Location = new System.Drawing.Point(75, 72);
            this.lblOrigen.Name = "lblOrigen";
            this.lblOrigen.Size = new System.Drawing.Size(44, 13);
            this.lblOrigen.TabIndex = 3;
            this.lblOrigen.Text = "Origen: ";
            // 
            // lblInformacio
            // 
            this.lblInformacio.AutoSize = true;
            this.lblInformacio.Location = new System.Drawing.Point(51, 36);
            this.lblInformacio.Name = "lblInformacio";
            this.lblInformacio.Size = new System.Drawing.Size(135, 13);
            this.lblInformacio.TabIndex = 4;
            this.lblInformacio.Text = "Informacion sobre tu vuelo:";
            // 
            // lblDestino
            // 
            this.lblDestino.AutoSize = true;
            this.lblDestino.Location = new System.Drawing.Point(69, 104);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(49, 13);
            this.lblDestino.TabIndex = 5;
            this.lblDestino.Text = "Destino: ";
            // 
            // lblHoraPartida
            // 
            this.lblHoraPartida.AutoSize = true;
            this.lblHoraPartida.Location = new System.Drawing.Point(32, 132);
            this.lblHoraPartida.Name = "lblHoraPartida";
            this.lblHoraPartida.Size = new System.Drawing.Size(86, 13);
            this.lblHoraPartida.TabIndex = 6;
            this.lblHoraPartida.Text = "Hora de partida: ";
            // 
            // lblHoraLlegada
            // 
            this.lblHoraLlegada.AutoSize = true;
            this.lblHoraLlegada.Location = new System.Drawing.Point(30, 159);
            this.lblHoraLlegada.Name = "lblHoraLlegada";
            this.lblHoraLlegada.Size = new System.Drawing.Size(88, 13);
            this.lblHoraLlegada.TabIndex = 7;
            this.lblHoraLlegada.Text = "Hora de llegada: ";
            // 
            // lblPreico
            // 
            this.lblPreico.AutoSize = true;
            this.lblPreico.Location = new System.Drawing.Point(75, 183);
            this.lblPreico.Name = "lblPreico";
            this.lblPreico.Size = new System.Drawing.Size(43, 13);
            this.lblPreico.TabIndex = 8;
            this.lblPreico.Text = "Precio: ";
            // 
            // lblAsientos
            // 
            this.lblAsientos.AutoSize = true;
            this.lblAsientos.Location = new System.Drawing.Point(530, 97);
            this.lblAsientos.Name = "lblAsientos";
            this.lblAsientos.Size = new System.Drawing.Size(47, 13);
            this.lblAsientos.TabIndex = 10;
            this.lblAsientos.Text = "Asientos";
            // 
            // txtAsientos
            // 
            this.txtAsientos.Location = new System.Drawing.Point(428, 97);
            this.txtAsientos.Name = "txtAsientos";
            this.txtAsientos.Size = new System.Drawing.Size(59, 20);
            this.txtAsientos.TabIndex = 11;
            this.txtAsientos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAsientos_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(342, 65);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(145, 20);
            this.txtNombre.TabIndex = 12;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(530, 65);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 13;
            this.lblNombre.Text = "Nombre";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 292);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtAsientos);
            this.Controls.Add(this.lblAsientos);
            this.Controls.Add(this.lblPreico);
            this.Controls.Add(this.lblHoraLlegada);
            this.Controls.Add(this.lblHoraPartida);
            this.Controls.Add(this.lblDestino);
            this.Controls.Add(this.lblInformacio);
            this.Controls.Add(this.lblOrigen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReservar);
            this.Name = "Form2";
            this.Text = "Completa tu reserva";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReservar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblOrigen;
        private System.Windows.Forms.Label lblInformacio;
        private System.Windows.Forms.Label lblDestino;
        private System.Windows.Forms.Label lblHoraPartida;
        private System.Windows.Forms.Label lblHoraLlegada;
        private System.Windows.Forms.Label lblPreico;
        private System.Windows.Forms.Label lblAsientos;
        private System.Windows.Forms.TextBox txtAsientos;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
    }
}