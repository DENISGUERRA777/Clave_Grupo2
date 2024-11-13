namespace Clave_Grupo2
{
    partial class Form3
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
            this.btnPagar = new System.Windows.Forms.Button();
            this.lblCofirmar = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblOrogen = new System.Windows.Forms.Label();
            this.lblDestino2 = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.cboxEquipaje = new System.Windows.Forms.ComboBox();
            this.cboxPago = new System.Windows.Forms.ComboBox();
            this.lblEquipaje = new System.Windows.Forms.Label();
            this.lblMetodo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPagar
            // 
            this.btnPagar.Location = new System.Drawing.Point(144, 358);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(99, 23);
            this.btnPagar.TabIndex = 0;
            this.btnPagar.Text = "Efectuar Pago";
            this.btnPagar.UseVisualStyleBackColor = true;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // lblCofirmar
            // 
            this.lblCofirmar.AutoSize = true;
            this.lblCofirmar.Location = new System.Drawing.Point(156, 28);
            this.lblCofirmar.Name = "lblCofirmar";
            this.lblCofirmar.Size = new System.Drawing.Size(87, 13);
            this.lblCofirmar.TabIndex = 1;
            this.lblCofirmar.Text = "Confirma tu pago";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(105, 173);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(53, 13);
            this.lblCantidad.TabIndex = 2;
            this.lblCantidad.Text = "Asientos: ";
            // 
            // lblOrogen
            // 
            this.lblOrogen.AutoSize = true;
            this.lblOrogen.Location = new System.Drawing.Point(105, 69);
            this.lblOrogen.Name = "lblOrogen";
            this.lblOrogen.Size = new System.Drawing.Size(35, 13);
            this.lblOrogen.TabIndex = 3;
            this.lblOrogen.Text = "label1";
            // 
            // lblDestino2
            // 
            this.lblDestino2.AutoSize = true;
            this.lblDestino2.Location = new System.Drawing.Point(105, 100);
            this.lblDestino2.Name = "lblDestino2";
            this.lblDestino2.Size = new System.Drawing.Size(35, 13);
            this.lblDestino2.TabIndex = 4;
            this.lblDestino2.Text = "label2";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(105, 140);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(81, 13);
            this.lblHora.TabIndex = 5;
            this.lblHora.Text = "Hora de salida: ";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(105, 205);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(52, 13);
            this.lblSubtotal.TabIndex = 6;
            this.lblSubtotal.Text = "Subtotal: ";
            // 
            // cboxEquipaje
            // 
            this.cboxEquipaje.FormattingEnabled = true;
            this.cboxEquipaje.Items.AddRange(new object[] {
            "Sin equipaje",
            "Equipaje de mano(10%extra)",
            "Equipaje de bodega(20% extra)"});
            this.cboxEquipaje.Location = new System.Drawing.Point(108, 238);
            this.cboxEquipaje.Name = "cboxEquipaje";
            this.cboxEquipaje.Size = new System.Drawing.Size(121, 21);
            this.cboxEquipaje.TabIndex = 7;
            // 
            // cboxPago
            // 
            this.cboxPago.FormattingEnabled = true;
            this.cboxPago.Items.AddRange(new object[] {
            "Tarjeta de credito/debito",
            "Bitcoin",
            "Cuenta de ahorro",
            "Paypal"});
            this.cboxPago.Location = new System.Drawing.Point(108, 284);
            this.cboxPago.Name = "cboxPago";
            this.cboxPago.Size = new System.Drawing.Size(121, 21);
            this.cboxPago.TabIndex = 8;
            // 
            // lblEquipaje
            // 
            this.lblEquipaje.AutoSize = true;
            this.lblEquipaje.Location = new System.Drawing.Point(254, 238);
            this.lblEquipaje.Name = "lblEquipaje";
            this.lblEquipaje.Size = new System.Drawing.Size(48, 13);
            this.lblEquipaje.TabIndex = 9;
            this.lblEquipaje.Text = "Equipaje";
            // 
            // lblMetodo
            // 
            this.lblMetodo.AutoSize = true;
            this.lblMetodo.Location = new System.Drawing.Point(254, 287);
            this.lblMetodo.Name = "lblMetodo";
            this.lblMetodo.Size = new System.Drawing.Size(85, 13);
            this.lblMetodo.TabIndex = 10;
            this.lblMetodo.Text = "Metodo de pago";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 450);
            this.Controls.Add(this.lblMetodo);
            this.Controls.Add(this.lblEquipaje);
            this.Controls.Add(this.cboxPago);
            this.Controls.Add(this.cboxEquipaje);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.lblDestino2);
            this.Controls.Add(this.lblOrogen);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblCofirmar);
            this.Controls.Add(this.btnPagar);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.Label lblCofirmar;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblOrogen;
        private System.Windows.Forms.Label lblDestino2;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.ComboBox cboxEquipaje;
        private System.Windows.Forms.ComboBox cboxPago;
        private System.Windows.Forms.Label lblEquipaje;
        private System.Windows.Forms.Label lblMetodo;
    }
}