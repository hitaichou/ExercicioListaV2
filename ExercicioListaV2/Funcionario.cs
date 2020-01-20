using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ExercicioListaV2
{
    class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Salario { get; set; }

        public Funcionario(int id, string nome, double salario)
        {
            Id = id;
            Nome = nome;
            Salario = salario;
        }

        public void AumentoSalario(double porcentagem)
        {
            //Regra para aumento salarial com entrada em porcentagem
            Salario = Salario + (Salario * (porcentagem / 100));
        }

        //public void Lista ()

        //Sobreposição
        public override string ToString()
        {
            return "Id: " + Id
                 + "\n"
                 + "Name: " + Nome
                 + "\n"
                 + "Salary: " + Salario.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
