using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CajeroAutomatico
{
    public partial class Inicio : Form
    {
        Cajero? cajero;
        public Inicio()
        {
            InitializeComponent();

            txtMontoRetirar.Visible = false;
            txtCuentaTranferir .Visible = false;
            btnConfirmarRetiro.Visible = false;
            btnCancelar.Visible = false;
            btnConfirmarTransaccion.Visible = false;
            btnConfirmarCanjeo.Visible = false;
            btnFactura.Visible = false;
            lbMensajeTope.Visible = false;
            lbSaldo.Visible = false;
            lbCanjearPuntos.Visible = false;
        }

        public void setCajero(Cajero cajero)
        {
            this.cajero = cajero;
        }

        private void btnRetirar_Click(object sender, EventArgs e)
        {
            lbMensajeTope.Text = "Puede retirar hasta $";
            lbMensajeTope.Text += cajero.Cuenta.TopeRetiroDiario.ToString();

            btnConsultaSaldo.Enabled = false;
            btnTransferencia.Enabled = false;
            btnConsultaPuntos.Enabled = false;
            btnCanjearPuntos.Enabled = false;

            txtMontoRetirar.Visible = true;
            btnConfirmarRetiro.Visible = true;
            btnCancelar.Visible = true;
            lbMensajeTope.Visible = true;
        }

        private void btnConfirmarRetiro_Click(object sender, EventArgs e)
        {
            if(cajero.Saldo >= Convert.ToInt32(txtMontoRetirar.Text))
            {
                try
                {
                    cajero.RealizarOperacion(1, Convert.ToInt32(txtMontoRetirar.Text));

                    cajero.DisminuirSaldo(Convert.ToInt32(txtMontoRetirar.Text));

                    MessageBox.Show("Retiro exitoso");

                    txtMontoRetirar.Visible = false;
                    lbMensajeTope.Visible = false;
                    btnConfirmarRetiro.Visible = false;

                    btnFactura.Visible = true;

                    if (!btnFactura.Visible)
                    {
                        btnConsultaSaldo.Enabled = true;
                        btnTransferencia.Enabled = true;
                        btnConsultaPuntos.Enabled = true;
                        btnCanjearPuntos.Enabled = true;
                    }
                    txtMontoRetirar.Clear();
                }
                catch (System.FormatException)
                {
                    MessageBox.Show("Formato incorrecto");
                }
                catch
                {
                    MessageBox.Show("Error en el proceso");
                }
            }
            else
            {
                MessageBox.Show("Cajero con saldo insuficiente");
            }
        }

        private void btnConsultaSaldo_Click(object sender, EventArgs e)
        {
            double saldo = cajero.RealizarOperacion(2);

            btnRetirar.Enabled = false;
            btnTransferencia.Enabled = false;
            btnConsultaPuntos.Enabled = false;
            btnCanjearPuntos.Enabled = false;

            lbSaldo.Text = "$ ";
            lbSaldo.Text += saldo.ToString();
            lbSaldo.Visible = true;

            btnCancelar.Visible = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtMontoRetirar.Visible = false;
            txtCuentaTranferir.Visible = false;
            lbMensajeTope.Visible = false;
            lbSaldo.Visible = false;
            btnConfirmarTransaccion.Visible = false;
            btnConfirmarRetiro.Visible = false;
            btnCancelar.Visible = false;
            btnConfirmarCanjeo.Visible = false;
            btnFactura.Visible = false;
            lbCanjearPuntos.Visible = false;

            btnConsultaSaldo.Enabled = true;
            btnTransferencia.Enabled = true;
            btnRetirar.Enabled = true;
            btnCanjearPuntos.Enabled = true;
            btnConsultaPuntos.Enabled = true;

            txtMontoRetirar.Clear();
            txtCuentaTranferir.Clear();
        }

        private void btnTransferencia_Click(object sender, EventArgs e)
        {
            txtMontoRetirar.Visible = true;
            txtCuentaTranferir.Visible = true;
            btnConfirmarTransaccion.Visible = true;
            btnCancelar.Visible = true;

            btnRetirar.Enabled = false;
            btnConsultaSaldo.Enabled = false;
            btnCanjearPuntos.Enabled = false;
            btnConsultaPuntos.Enabled = false;
        }

        private void btnConfirmarTransaccion_Click(object sender, EventArgs e)
        {
            try
            {
                int cuentaDestino = Convert.ToInt32(txtCuentaTranferir.Text);
                double monto = Convert.ToDouble(txtMontoRetirar.Text);

                cajero.ValidarCuenta(cuentaDestino);

                if (cajero.CuentaDestino != null)
                {
                    cajero.RealizarOperacion(3, monto);

                    btnConfirmarTransaccion.Visible = false;
                    txtCuentaTranferir.Visible = false;
                    txtMontoRetirar.Visible = false;

                    btnFactura.Visible = true;

                    if (!btnFactura.Visible)
                    {
                        btnRetirar.Enabled = true;
                        btnConsultaSaldo.Enabled = true;
                        btnCanjearPuntos.Enabled = true;
                        btnConsultaPuntos.Enabled = true;
                    }
                }
                else
                {
                    MessageBox.Show("La cuenta no existe");
                }
            }
            catch
            {
                MessageBox.Show("Formato incorrecto");
            }
        }

        private void btnConsultaPuntos_Click(object sender, EventArgs e)
        {
            int puntos = Convert.ToInt32(cajero.RealizarOperacion(4));

            lbSaldo.Text = "";
            lbSaldo.Text += puntos.ToString() + " puntos";
            lbSaldo.Visible = true;

            btnRetirar.Enabled = false;
            btnConsultaSaldo.Enabled = false;
            btnCanjearPuntos.Enabled = false;
            btnTransferencia.Enabled = false;

            btnCancelar.Visible = true;
        }

        private void btnCanjearPuntos_Click(object sender, EventArgs e)
        {
            int puntos = Convert.ToInt32(cajero.RealizarOperacion(4));
            int monto = puntos * 7;

            lbCanjearPuntos.Text = "Se realizará el canje a " + puntos.ToString() + " puntos, equivalente a $ " + monto.ToString();
            lbCanjearPuntos.Visible = true;
            btnConfirmarCanjeo.Visible = true;
            btnCancelar.Visible = true;

            btnRetirar.Enabled = false;
            btnConsultaSaldo.Enabled = false;
            btnConsultaPuntos.Enabled = false;
            btnTransferencia.Enabled = false;
        }

        private void btnConfirmarCanjeo_Click(object sender, EventArgs e)
        {
            try
            {
                cajero.RealizarOperacion(5);

                MessageBox.Show("Canjeo exitoso");

                cajero.Cuenta.EliminarPuntos();

                btnConfirmarCanjeo.Visible = false;
                btnCancelar.Visible = false;
                lbCanjearPuntos.Visible = false;

                btnRetirar.Enabled = true;
                btnConsultaSaldo.Enabled = true;
                btnConsultaPuntos.Enabled = true;
                btnTransferencia.Enabled = true;
            }
            catch
            {
                MessageBox.Show("El canje falló");
            }
            
        }

        private void btnFactura_Click(object sender, EventArgs e)
        {
            try
            {
                cajero.GenerarFactura();
                MessageBox.Show("Factura Generada");

                btnFactura.Visible = false;
                btnCancelar.Visible = false;

                btnRetirar.Enabled = true;
                btnTransferencia.Enabled = true;
                btnConsultaSaldo.Enabled = true;
                btnCanjearPuntos.Enabled = true;
                btnConsultaPuntos.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Error en el proceso");
            }
        }
    }
}
