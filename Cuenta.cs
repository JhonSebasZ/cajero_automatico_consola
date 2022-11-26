using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroAutomatico
{
    public class Cuenta
    {
        //Atributos
        public int Id { get; set; }
        public int Clave { get; set; }
        public Cliente Usuario { get; set; }
        public double Saldo { get; set; }
        public double TopeRetiroDiario { get; set; }
        public int PuntosViveColombia { get; set; }

        //Constructor
        public Cuenta(int id, int clave, Cliente usuario, double saldo, int puntosViveColombia)
        {
            this.Id = id;
            this.Clave = clave;
            this.Usuario = usuario;
            this.Saldo = saldo;
            this.PuntosViveColombia = puntosViveColombia;
            this.TopeRetiroDiario = 2000000;
        }

        //Metodos
        public void DisminuirSaldo(double monto)
        {
            Saldo -= monto;
        }

        public void DisminuirTopeDiario(double monto)
        {
            TopeRetiroDiario -= monto;   
        }

        public void AumentarSaldo(double monto)
        {
            Saldo += monto;
        }

        public void EliminarPuntos()
        {
            PuntosViveColombia = 0;
        }
    }
}
