using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroAutomatico
{
    public class Cajero
    {
        //Atributos
        public double Saldo { get; set; } 
        public int Id { get; } 
        public int TipoOperacion { get; set; }
        public double MontoOperacion { get; set; } 
        public Cuenta? Cuenta { get; set; }
        public Cuenta? CuentaDestino { get; set; }

        //Constructor
        public Cajero(int id)
        {
            this.Id = id;
            this.Saldo = 100000000;
            this.Id = 0;
            this.TipoOperacion = 0;
            this.MontoOperacion = 0;
        }

        //Metodos
        public void ValidarCuenta(int numeroCuenta, int clave = 0)
        {
            for (int i = 0; i < Banco.cuentas.Length; i++)
            {
                int nCuenta = Banco.cuentas[i].Id;
                int password = Banco.cuentas[i].Clave;
                if (nCuenta == numeroCuenta && password == clave)
                {
                    Cuenta = Banco.cuentas[i];
                }
                else if (nCuenta == numeroCuenta)
                {
                    CuentaDestino = Banco.cuentas[i];
                }
            }
        }

        public double RealizarOperacion(int tipoOperacion, double monto=0)
        {
            this.TipoOperacion = tipoOperacion;
            this.MontoOperacion = monto;
            double resultado = 0;
            switch (tipoOperacion)
            {
                case 1:
                    Cuenta.Usuario.Retirar(Cuenta, monto);
                    break;
                case 2:
                    resultado = Cuenta.Usuario.VerSaldo(Cuenta);
                    break;
                case 3:
                    Cuenta.Usuario.Transferir(Cuenta, CuentaDestino, monto);
                    break;
                case 4:
                    resultado = Cuenta.Usuario.consultarPuntosViveColombia(Cuenta);
                    break;
                case 5:
                    Cuenta.Usuario.canjearPuntosViveColombia(Cuenta);
                    break;
            }

            return resultado;
        }
        
        public void GenerarFactura()
        {
            File.Delete("factura.txt");
            Factura factura;
            switch (TipoOperacion)
            {
                case 1:
                    factura = new FacturaRetiro(Cuenta, MontoOperacion);
                    factura.GenerarFactura();
                    break;
                case 3:
                    factura = new FacturaTransferencia(Cuenta, MontoOperacion, CuentaDestino);
                    factura.GenerarFactura();
                    break;
            }
        }
        public void DisminuirSaldo(int monto)
        {
            Saldo -= monto;
        }
    }
}
