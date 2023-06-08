using cadastro;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
    public static void Main(string[] args)
    {
        

        Console.WriteLine("-------------------");
        Console.WriteLine("-------------------");
        Console.WriteLine("Cadastro de usuarios");

        List<Funcionarios> funcionarios = new List<Funcionarios>();

        while (true)
        {
            Console.WriteLine("Seleciona uma opção");
            Console.WriteLine("1.Adicionar funcionario:");
            Console.WriteLine("2.Consultar todos funcionarios");
            Console.WriteLine("3.Consultar funcionarios por setor:");
            Console.WriteLine("4.Sair");
            string opcao = Console.ReadLine();

            switch (opcao) {

                case "1":

                    Console.WriteLine("--Adicionar Funcionarios--");

                    Console.WriteLine("Nome do funcionario");
                    string nome = Console.ReadLine();

                    Console.WriteLine("Setor do funcionario");
                    Console.WriteLine("1.Vendas");
                    Console.WriteLine("2.Financeiro");
                    string setorId = Console.ReadLine();
                    

                    switch (setorId)
                    {
                        case "1":
                            setorId = "Vendas";
                            break;
                        case "2":
                            setorId = "Financeiro";
                        break;
                    }

                    Console.WriteLine("Qual o salario do funcionario");
                    decimal salario = Convert.ToDecimal(Console.ReadLine());

                    funcionarios.Add(new Funcionarios { Nome = nome, Setor = setorId, Salario = salario});

                    

                    break;

                case "2":

                    Console.WriteLine("Consultar funcionarios");

                    for (int i = 0; i < funcionarios.Count; i++) 
                    {

                        Funcionarios funcionario = funcionarios[i];

                        Console.WriteLine($"Nome: {funcionario.Nome}, Setor: {funcionario.Setor}");

                   }                    
                    break;

                    case "3":

                    Console.WriteLine("Quantidade de funcionarios por setor");
                    Console.WriteLine($"Total de funcinonarios cadastrado: {funcionarios.Count}");

                    int contadorVendas = 0;
                    int contadorFinanceiro = 0;

                    foreach (var funcinario in funcionarios)
                    {
                        if (funcinario.Setor == "Vendas")
                        {
                            contadorVendas++;

                        }

                        else if (funcinario.Setor == "Fincaneiro")
                        {
                            contadorFinanceiro++;
                        }

                    }

                    break ;


                    case "4":

                    Console.WriteLine("Programa encerrado");
                    return;


                     default: Console.WriteLine("Opçao invalida");
                    break;
                
            }
        }

        Console.ReadKey();



    }

}
