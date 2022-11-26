using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroAutomatico
{
    public class Cliente
    {
        //Atributos
        public String Identificacion { get; set; }
        public String NombreApellido { get; set; }

        //Constructor
        public Cliente(String identificacion, String nombreApellido)
        {
            this.Identificacion = identificacion;
            this.NombreApellido = nombreApellido;
        }

        //Metodos
        public void Retirar(Cuenta cuenta, double monto)
        {
            double topeDiario = cuenta.TopeRetiroDiario;
            double saldo = cuenta.Saldo;

            if (monto <= topeDiario && monto <= saldo)
            {
                cuenta.DisminuirSaldo(monto);
                cuenta.DisminuirTopeDiario(monto);
            }
            else if (monto >= saldo)
            {
                MessageBox.Show("Saldo insuficiente");
                throw new Exception("No se puede generar el retiro");
            }
            else if (monto >= topeDiario)
            {
                MessageBox.Show("Ha superado el monto de retiro diario");
                throw new Exception("No se puede generar el retiro");
            }
        }

        public double VerSaldo(Cuenta cuenta)
        {
            return cuenta.Saldo;
        }

        public void Transferir(Cuenta cuenta, Cuenta cuentaDestino, double monto)
        {
            if (monto <= cuenta.Saldo)
            {
                cuenta.DisminuirSaldo(monto);
                cuentaDestino.AumentarSaldo(monto);

                MessageBox.Show("Transaccion Exitosa");
            }
            else
            {
                MessageBox.Show("Saldo insuficiente");
            }
        }

        public int consultarPuntosViveColombia(Cuenta cuenta)
        {
            return cuenta.PuntosViveColombia;
        }

        public void canjearPuntosViveColombia(Cuenta cuenta)
        {
            int monto = cuenta.PuntosViveColombia * 7;

            cuenta.AumentarSaldo(monto);
        }
    }
}
