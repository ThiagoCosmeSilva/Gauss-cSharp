using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Cadastro
{
    internal class Program
    {
        static List<Funcionarios> listaFuncionarios = new List<Funcionarios>();
        static void Main(string[] args)
        {
            Menu();
        }


        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Seleciona uma opção");
            Console.WriteLine("1.Adicionar funcionario:");
            Console.WriteLine("2.Consultar todos funcionarios");
            Console.WriteLine("3.Consultar funcionarios por setor:");
            Console.WriteLine("4.Sair");
            Console.WriteLine("");
            string opcao = Console.ReadLine();
            
                switch (opcao)
                {
                    case "1": CadastroFuncionarios(); break;
                    case "2": ConsultarFuncionario(); break;
                    case "3":
                        Console.WriteLine("Qual setor deseja consultar?");
                        Console.WriteLine("1. Vendas");
                        Console.WriteLine("2. Fincaneiro");
                        string setorID = Console.ReadLine();
                        if (setorID == "1")
                        {
                            SetorVendas();
                        }
                        else if (setorID == "2")
                        {
                            SetorFincaneiro();
                        }
                        else
                        {
                            Console.WriteLine("Opçao invalida");
                            Menu();
                        }
                        break;
                    case "4": System.Environment.Exit(0); break;
                }


            
        }


        static void CadastroFuncionarios()
        {

           


            var funcionarios = new Funcionarios();

                
            Console.WriteLine("--Adicionar Funcionarios--");
            Console.WriteLine("Nome do funcionario");
            funcionarios.Nome = (Console.ReadLine());
            Console.WriteLine("Setor do funcionario");
            Console.WriteLine("1.Vendas");
            Console.WriteLine("2.Financeiro");
            int setor = Convert.ToInt32(Console.ReadLine());

            if (setor == 1)
            {
                funcionarios.Setor = "Vendas";
            }
            else if (setor == 2)
            {
                funcionarios.Setor = "Financeiro";
            }

            else
            {
                Console.WriteLine("Opção invalida");
            }

            Console.WriteLine("Qual o salario do funcionario? ");
            funcionarios.Salario = Convert.ToDecimal(Console.ReadLine());


            listaFuncionarios.Add(funcionarios);

            Console.WriteLine("Usuario cadastrado com sucesso!");

            Console.ReadKey();
            Menu();


        }

        static void ConsultarFuncionario()
        {
            

            foreach (Funcionarios funcionario in listaFuncionarios)
            {
                Console.WriteLine(funcionario.Nome);
            }
            Console.ReadKey();
            Menu();

        }

        static void SetorVendas()
        {

            

            List<Funcionarios> funcionariosVendas = listaFuncionarios.Where(funcionario => funcionario.Setor == "Vendas").ToList();

            if (funcionariosVendas.Count == 0)
            {
                Console.WriteLine("Nenhum funcionário no setor de vendas");
            }
            else
            
                Console.WriteLine("-- Funcionários do Setor de Vendas --");
                foreach (Funcionarios funcionario in funcionariosVendas)
                {
                    Console.WriteLine("Nome: " + funcionario.Nome);
                    Console.WriteLine("Salário: " + funcionario.Salario);
                    Console.WriteLine("---------------------------");
                }

                Console.ReadKey();
            Menu();
        }

        static void SetorFincaneiro()
        {

            List<Funcionarios> listaFuncionarios = new List<Funcionarios>();

            List<Funcionarios> funcionariosFinanceiro = listaFuncionarios.Where(funcionario => funcionario.Setor.StartsWith("Financeiro")).ToList();

            if (funcionariosFinanceiro.Count == 0)
            {
                Console.WriteLine("Nenhum funcionário no setor de vendas");
            }
            else

                Console.WriteLine("-- Funcionários do Setor de Vendas --");
            foreach (Funcionarios funcionario in funcionariosFinanceiro)
            {
                Console.WriteLine("Nome: " + funcionario.Nome);
                Console.WriteLine("Salário: " + funcionario.Salario);
                Console.WriteLine("---------------------------");
            }


            Console.ReadKey(); Menu();

        }
    }

}
