using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Conta_Bancaria
{
    class ContaBancaria
    {
        public int Numero_Conta { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }
        double taxa = -5.0;

        public ContaBancaria(int numero, string titular)
        {
            Numero_Conta = numero;
            Titular = titular;
        }
        public ContaBancaria(int numero, string titular, double saldo) : this(numero, titular)
        {
            Saldo = saldo;
        }
            
        public void Deposito(double quantia)
        {
            Saldo = Saldo + quantia;
        }
        public void Saque(double quantia)
        {
            Saldo = Saldo - quantia + taxa;
        }

        public override string ToString()
        {
            return "Conta " + Numero_Conta + ", Titular: " + Titular + ", Saldo: $ " + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
