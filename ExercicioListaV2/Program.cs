using System;
using System.Collections.Generic;

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
            {   //Cursor para entrada dos dados dos funcionários
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
                //Captura do id do profissionais
                Console.Write("Entre com o ID do funcionário que terá o Salário alterado: ");
                int findid = int.Parse(Console.ReadLine());

                //Procurando a posição do profissional pelo ID
                var pos1 = ListaFuncionario.FindIndex(x => x.Id == findid);

                //Checagem se encontrou o ID do profissional
                //Se for maior que -1 é que achou
                if(pos1 != -1)
                {
                    Console.Write("Entre com a porcentagem: ");
                    double porc = double.Parse(Console.ReadLine());

                    List<Funcionario> ListaFuncionario2 = ListaFuncionario.FindAll(x => x.Id == findid);

                    foreach (Funcionario z in ListaFuncionario2)
                    {
                        z.AumentoSalario(porc);
                    }
                }
                else
                {
                    Console.WriteLine("Não existe este ID.");
                }

                if(pos1 != -1)
                {
                    //Impressao dos dados               
                    foreach (Funcionario f in ListaFuncionario)
                    {
                        posicao = posicao + 1; //Para mostrar de forma dinâmica a posição do funcionario
                        Console.WriteLine("Employee #" + posicao + ":"
                                         + "\n"
                                         + f
                                         );
                    }
                }
                else
                {
                    //Impressao dos dados               
                    foreach (Funcionario f in ListaFuncionario)
                    {
                        posicao = posicao + 1; //Para mostrar de forma dinâmica a posição do funcionario
                        Console.WriteLine("Dados atualizados #" + posicao + ":"
                                         + "\n"
                                         + f
                                         );
                    }
                }                
            }
            else
            {
                Console.WriteLine("Nenhum funcionário registrado.");
            }
        }
    }
}
