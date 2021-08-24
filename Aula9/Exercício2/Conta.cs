using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício2
{
    class Conta
    {
        private string agencia;
        private int numero;
        private float saldo;

        public string getAgencia()
        {
            return this.agencia;
        }

        public int getNumero()
        {
            return this.numero;
        }

        public float getSaldo()
        {
            return this.saldo;
        }

        public void setAgencia(string agencia)
        {
            this.agencia = agencia;
        }

        public void setNumero(int numero)
        {
            this.numero = numero;
        }

        public void setSaldo(float saldo)
        {
            this.saldo = saldo;
        }
    }
}
