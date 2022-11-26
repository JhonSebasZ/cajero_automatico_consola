using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroAutomatico
{
    internal class FacturaTransferencia:Factura
    {
        //Atributos
        public Cuenta CuentaDestino { get; set; }

        //Constructor
        public FacturaTransferencia(Cuenta cuenta, double monto, Cuenta cuentaDestino) :
                            base(cuenta, monto)
        {
            this.CuentaDestino = cuentaDestino;
        }

        //Metodo
        override
        public void GenerarFactura()
        {
            StreamWriter factura = File.AppendText("factura.txt");

            factura.WriteLine("------------FACTURA------------\n");
            factura.WriteLine("_________________________________");
            factura.WriteLine("Fecha                 " + fecha);
            factura.WriteLine("Hora                  " + hora);
            factura.WriteLine("_________________________________");
            factura.WriteLine("Cuenta Origen         " + cuenta.Id);
            factura.WriteLine("Cuenta Destino        " + CuentaDestino.Id);
            factura.WriteLine("Tipo Operacion        " + "Trasferencia");
            factura.WriteLine("Monto                 " + monto);

            factura.Close();
        }
    }
}
