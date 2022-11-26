using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CajeroAutomatico
{
    internal class FacturaRetiro : Factura
    {
        //Constructor
        public FacturaRetiro(Cuenta cuenta, double monto):
                            base(cuenta, monto)
        {

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
            factura.WriteLine("Cuenta                " + cuenta.Id);
            factura.WriteLine("Tipo Operacion        " + "Retiro");
            factura.WriteLine("Monto                 " + monto);

            factura.Close();
        }
    }
}
