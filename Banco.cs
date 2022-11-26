using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroAutomatico
{
    internal class Banco
    {
        //Atributo
        public static Cuenta[] cuentas = new Cuenta[5];

        //Constructor
        public Banco()
        {
        
            Cliente usuario1 = new Cliente("Jhon Zuñiga", "19074821");
            Cuenta cuenta1 = new Cuenta(97259657, 7865, usuario1, 1000000, 2590);

            Cliente usuario2 = new Cliente("Maria Rodriguez", "99013828");
            Cuenta cuenta2 = new Cuenta(23456897, 2321, usuario2, 12000000, 3500);

            Cliente usuario3 = new Cliente("Mario Lopez", "23456785");
            Cuenta cuenta3 = new Cuenta(38561374, 4532, usuario3, 50000000, 3500);

            Cliente usuario4 = new Cliente("Lorena Narvaez", "98765356");
            Cuenta cuenta4 = new Cuenta(83751398, 6556, usuario4, 500000, 2700);

            Cliente usuario5 = new Cliente("karol Nuñez", "68420823");
            Cuenta cuenta5 = new Cuenta(45678923, 9832, usuario5, 18000000, 2510);

            cuentas[0] = cuenta1;
            cuentas[1] = cuenta2;
            cuentas[2] = cuenta3;
            cuentas[3] = cuenta4;
            cuentas[4] = cuenta5;
        }
    }
}
