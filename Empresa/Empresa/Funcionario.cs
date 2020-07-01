using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Empresa
{
    class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Salario { get; set; }

        public Funcionario (int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public Funcionario (int id, string nome, double salario) : this (id, nome)
        {
            Salario = salario;
        }

        public void aumentarSalario(double porcentagem)
        {
            Salario += Salario * porcentagem / 100.0;
        }

        public override string ToString()
        {
            return Id + ", " + Nome + ", " + "R$ " + Salario.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
