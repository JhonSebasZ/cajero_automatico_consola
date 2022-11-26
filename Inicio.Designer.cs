namespace CajeroAutomatico
{
    partial class Inicio
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
            this.lbBienvenido = new System.Windows.Forms.Label();
            this.btnRetirar = new System.Windows.Forms.Button();
            this.btnTransferencia = new System.Windows.Forms.Button();
            this.btnConsultaSaldo = new System.Windows.Forms.Button();
            this.btnConfirmarRetiro = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtMontoRetirar = new System.Windows.Forms.TextBox();
            this.lbMensajeTope = new System.Windows.Forms.Label();
            this.lbSaldo = new System.Windows.Forms.Label();
            this.txtCuentaTranferir = new System.Windows.Forms.TextBox();
            this.btnConfirmarTransaccion = new System.Windows.Forms.Button();
            this.btnConsultaPuntos = new System.Windows.Forms.Button();
            this.btnCanjearPuntos = new System.Windows.Forms.Button();
            this.lbCanjearPuntos = new System.Windows.Forms.Label();
            this.btnConfirmarCanjeo = new System.Windows.Forms.Button();
            this.btnFactura = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbBienvenido
            // 
            this.lbBienvenido.AutoSize = true;
            this.lbBienvenido.Font = new System.Drawing.Font("Segoe Script", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbBienvenido.Location = new System.Drawing.Point(156, 9);
            this.lbBienvenido.Margin = new System.Windows.Forms.Padding(0);
            this.lbBienvenido.Name = "lbBienvenido";
            this.lbBienvenido.Size = new System.Drawing.Size(185, 44);
            this.lbBienvenido.TabIndex = 0;
            this.lbBienvenido.Text = "Bienvenido";
            // 
            // btnRetirar
            // 
            this.btnRetirar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRetirar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRetirar.Font = new System.Drawing.Font("Segoe Script", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRetirar.Location = new System.Drawing.Point(14, 87);
            this.btnRetirar.Name = "btnRetirar";
            this.btnRetirar.Size = new System.Drawing.Size(184, 45);
            this.btnRetirar.TabIndex = 2;
            this.btnRetirar.Text = "Retirar";
            this.btnRetirar.UseVisualStyleBackColor = false;
            this.btnRetirar.Click += new System.EventHandler(this.btnRetirar_Click);
            // 
            // btnTransferencia
            // 
            this.btnTransferencia.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTransferencia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTransferencia.Font = new System.Drawing.Font("Segoe Script", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTransferencia.Location = new System.Drawing.Point(14, 189);
            this.btnTransferencia.Name = "btnTransferencia";
            this.btnTransferencia.Size = new System.Drawing.Size(184, 45);
            this.btnTransferencia.TabIndex = 3;
            this.btnTransferencia.Text = "Transferencia";
            this.btnTransferencia.UseVisualStyleBackColor = false;
            this.btnTransferencia.Click += new System.EventHandler(this.btnTransferencia_Click);
            // 
            // btnConsultaSaldo
            // 
            this.btnConsultaSaldo.AutoSize = true;
            this.btnConsultaSaldo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnConsultaSaldo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultaSaldo.Font = new System.Drawing.Font("Segoe Script", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConsultaSaldo.Location = new System.Drawing.Point(14, 140);
            this.btnConsultaSaldo.Name = "btnConsultaSaldo";
            this.btnConsultaSaldo.Size = new System.Drawing.Size(184, 43);
            this.btnConsultaSaldo.TabIndex = 4;
            this.btnConsultaSaldo.Text = "Consulta Saldo";
            this.btnConsultaSaldo.UseVisualStyleBackColor = false;
            this.btnConsultaSaldo.Click += new System.EventHandler(this.btnConsultaSaldo_Click);
            // 
            // btnConfirmarRetiro
            // 
            this.btnConfirmarRetiro.Location = new System.Drawing.Point(310, 369);
            this.btnConfirmarRetiro.Name = "btnConfirmarRetiro";
            this.btnConfirmarRetiro.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmarRetiro.TabIndex = 5;
            this.btnConfirmarRetiro.Text = "Confirmar";
            this.btnConfirmarRetiro.UseVisualStyleBackColor = true;
            this.btnConfirmarRetiro.Click += new System.EventHandler(this.btnConfirmarRetiro_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(428, 369);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtMontoRetirar
            // 
            this.txtMontoRetirar.Location = new System.Drawing.Point(310, 109);
            this.txtMontoRetirar.Name = "txtMontoRetirar";
            this.txtMontoRetirar.PlaceholderText = "Monto";
            this.txtMontoRetirar.Size = new System.Drawing.Size(193, 23);
            this.txtMontoRetirar.TabIndex = 7;
            // 
            // lbMensajeTope
            // 
            this.lbMensajeTope.AutoSize = true;
            this.lbMensajeTope.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbMensajeTope.Location = new System.Drawing.Point(310, 87);
            this.lbMensajeTope.Name = "lbMensajeTope";
            this.lbMensajeTope.Size = new System.Drawing.Size(18, 20);
            this.lbMensajeTope.TabIndex = 8;
            this.lbMensajeTope.Text = "d";
            // 
            // lbSaldo
            // 
            this.lbSaldo.AutoSize = true;
            this.lbSaldo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbSaldo.Location = new System.Drawing.Point(310, 107);
            this.lbSaldo.Name = "lbSaldo";
            this.lbSaldo.Size = new System.Drawing.Size(28, 25);
            this.lbSaldo.TabIndex = 10;
            this.lbSaldo.Text = "$ ";
            // 
            // txtCuentaTranferir
            // 
            this.txtCuentaTranferir.Location = new System.Drawing.Point(310, 175);
            this.txtCuentaTranferir.Name = "txtCuentaTranferir";
            this.txtCuentaTranferir.PlaceholderText = "Cuenta Destino";
            this.txtCuentaTranferir.Size = new System.Drawing.Size(193, 23);
            this.txtCuentaTranferir.TabIndex = 11;
            // 
            // btnConfirmarTransaccion
            // 
            this.btnConfirmarTransaccion.Location = new System.Drawing.Point(310, 369);
            this.btnConfirmarTransaccion.Name = "btnConfirmarTransaccion";
            this.btnConfirmarTransaccion.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmarTransaccion.TabIndex = 12;
            this.btnConfirmarTransaccion.Text = "Confirmar";
            this.btnConfirmarTransaccion.UseVisualStyleBackColor = true;
            this.btnConfirmarTransaccion.Click += new System.EventHandler(this.btnConfirmarTransaccion_Click);
            // 
            // btnConsultaPuntos
            // 
            this.btnConsultaPuntos.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnConsultaPuntos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultaPuntos.Font = new System.Drawing.Font("Segoe Script", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConsultaPuntos.Location = new System.Drawing.Point(14, 240);
            this.btnConsultaPuntos.Name = "btnConsultaPuntos";
            this.btnConsultaPuntos.Size = new System.Drawing.Size(184, 74);
            this.btnConsultaPuntos.TabIndex = 13;
            this.btnConsultaPuntos.Text = "Consulta P.\r\nViveColombia\r\n\r\n";
            this.btnConsultaPuntos.UseVisualStyleBackColor = false;
            this.btnConsultaPuntos.Click += new System.EventHandler(this.btnConsultaPuntos_Click);
            // 
            // btnCanjearPuntos
            // 
            this.btnCanjearPuntos.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCanjearPuntos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCanjearPuntos.Font = new System.Drawing.Font("Segoe Script", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCanjearPuntos.Location = new System.Drawing.Point(14, 320);
            this.btnCanjearPuntos.Name = "btnCanjearPuntos";
            this.btnCanjearPuntos.Size = new System.Drawing.Size(184, 74);
            this.btnCanjearPuntos.TabIndex = 14;
            this.btnCanjearPuntos.Text = "Canjear P.\r\nViveColombia\r\n\r\n";
            this.btnCanjearPuntos.UseVisualStyleBackColor = false;
            this.btnCanjearPuntos.Click += new System.EventHandler(this.btnCanjearPuntos_Click);
            // 
            // lbCanjearPuntos
            // 
            this.lbCanjearPuntos.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbCanjearPuntos.Location = new System.Drawing.Point(319, 251);
            this.lbCanjearPuntos.Name = "lbCanjearPuntos";
            this.lbCanjearPuntos.Size = new System.Drawing.Size(200, 80);
            this.lbCanjearPuntos.TabIndex = 15;
            this.lbCanjearPuntos.Text = "s";
            // 
            // btnConfirmarCanjeo
            // 
            this.btnConfirmarCanjeo.Location = new System.Drawing.Point(310, 369);
            this.btnConfirmarCanjeo.Name = "btnConfirmarCanjeo";
            this.btnConfirmarCanjeo.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmarCanjeo.TabIndex = 16;
            this.btnConfirmarCanjeo.Text = "Confirmar";
            this.btnConfirmarCanjeo.UseVisualStyleBackColor = true;
            this.btnConfirmarCanjeo.Click += new System.EventHandler(this.btnConfirmarCanjeo_Click);
            // 
            // btnFactura
            // 
            this.btnFactura.Location = new System.Drawing.Point(310, 369);
            this.btnFactura.Name = "btnFactura";
            this.btnFactura.Size = new System.Drawing.Size(75, 23);
            this.btnFactura.TabIndex = 17;
            this.btnFactura.Text = "Factura";
            this.btnFactura.UseVisualStyleBackColor = true;
            this.btnFactura.Click += new System.EventHandler(this.btnFactura_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 404);
            this.Controls.Add(this.btnFactura);
            this.Controls.Add(this.btnConfirmarCanjeo);
            this.Controls.Add(this.lbCanjearPuntos);
            this.Controls.Add(this.btnCanjearPuntos);
            this.Controls.Add(this.btnConsultaPuntos);
            this.Controls.Add(this.btnConfirmarTransaccion);
            this.Controls.Add(this.txtCuentaTranferir);
            this.Controls.Add(this.lbSaldo);
            this.Controls.Add(this.lbMensajeTope);
            this.Controls.Add(this.txtMontoRetirar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConfirmarRetiro);
            this.Controls.Add(this.btnConsultaSaldo);
            this.Controls.Add(this.btnTransferencia);
            this.Controls.Add(this.btnRetirar);
            this.Controls.Add(this.lbBienvenido);
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbBienvenido;
        private Button btnRetirar;
        private Button btnTransferencia;
        private Button btnConsultaSaldo;
        private Button btnConfirmarRetiro;
        private Button btnCancelar;
        private TextBox txtMontoRetirar;
        private Label lbMensajeTope;
        private Label lbSaldo;
        private TextBox txtCuentaTranferir;
        private Button btnConfirmarTransaccion;
        private Button btnConsultaPuntos;
        private Button btnCanjearPuntos;
        private Label lbCanjearPuntos;
        private Button btnConfirmarCanjeo;
        private Button btnFactura;
    }
}