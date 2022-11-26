using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroAutomatico
{
    internal abstract class Factura
    {
        //Atributos
        protected DateOnly fecha = DateOnly.FromDateTime(DateTime.Now);
        protected TimeOnly hora = TimeOnly.FromDateTime(DateTime.Now);
        protected Cuenta cuenta;
        protected double monto;

        //Constructor
        public Factura(Cuenta cuenta, double monto)
        {
            this.cuenta = cuenta;
            this.monto = monto;
        }

        //Metodo 
        public abstract void GenerarFactura();

    }
}
