using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExercicioListaV2
{
    class Program
    {
        static void Main(string[] args)
        {
            int id;
            string nm;
            double sal;
            int posicao = 0;

            Console.Write("Quando funcionários serão registrados? ");
            int n = int.Parse(Console.ReadLine());

            //Declaração da lista
            List<Funcionario> ListaFuncionario = new List<Funcionario>();

            if(n > 0)
            {
                for(int i = 0; i < n; i++)
                {
                    Console.Write("ID: ");
                    id = int.Parse(Console.ReadLine());
                    Console.Write("Nome: ");
                    nm = Console.ReadLine();
                    Console.WriteLine("Salario: ");
                    sal = double.Parse(Console.ReadLine());

                    //Adicionando item na lista e instanciando usando o construtor da classe
                    ListaFuncionario.Add(new Funcionario(id, nm, sal));                   

                }

                //Impressao dos dados               
                foreach(Funcionario f in ListaFuncionario)
                {
                    posicao = posicao + 1; //Para mostrar de forma dinâmica a posição do funcionario
                    Console.WriteLine("Employee #" + posicao + ":"
                                     + "\n"
                                     + f);                    
                }
            }
            else
            {
                Console.WriteLine("Nenhum funcionário registrado.");
            }
        }
    }
}
