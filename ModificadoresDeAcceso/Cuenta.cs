using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModificadoresDeAcceso
{
    class Cuenta
    {
        public Cliente Propietario { get; set; }
        private string _certificador;
        public float saldo { get; set; }
        public float saldoretirado { get; set; }
        public float saldodepositado { get; set; }
        public float saldoR1 { get; set; }
        public float saldoR2 { get; set; }
        private string _id;
        public string identificador
        {
            get
            {
                return _id;
            }
            set
            {
                if (value.Length == 14)
                {
                    _id = value;
                }
                else
                {
                    throw new Exception("ID invalido");
                }
            }
        }

        public Retirar ()
        {
            saldo - saldodepositado = saldoR1;
            
        }

        public Depositar()
        {

        }
    }
}
