using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Banco
{
    public class Conta
    {
        public int NumConta { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; set; }

        public Conta()
        {
        }

        public Conta (int numero, string titular)
        {
            NumConta = numero;
            Titular = titular;
        }

        public Conta (int numero, string titular, double saldo) : this (numero, titular)
        {
            Saldo = saldo;
        }

        public void Deposito(double valor)
        {
            Saldo += valor;
        }

        public void Saque(double valor)
        {
            Saldo -= valor;
            Saldo -= 5.0; /*  Taxa de saque= R$ 5.0 */
        }

        public override string ToString()
        {
            return "Conta: "
                + NumConta
                + ", Titular: "
                + Titular
                + ", Saldo: $"
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
