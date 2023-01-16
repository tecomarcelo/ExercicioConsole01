using System;
using ProjetoDOS01.Entities;
using ProjetoDOS01.Repositories;

//definea localização da classe dentro do projeto
namespace ProjetoDOS01
{
    //definição da classe
    class Program
    {
        //metodo (funções) executar o projeto
        static void Main(string[] args) 
        {

            Console.WriteLine("\n ####  ENTRE COM OS DADOS DO FUNCIONÁRIO  ####\n");

            //criando o objeto para a classe Funcionario (varialvel de instancia)
            var funcionario = new Funcionario();

            //acessando as propriedades da classe
            funcionario.IdFuncionario = Guid.NewGuid();
            Console.Write("Informe o nome do funcionario..............: "); funcionario.Nome = Console.ReadLine();
            Console.Write("Informe o CPF do funcionario...............: "); funcionario.CPF = Console.ReadLine();
            Console.Write("Informe a matricula do funcionario.........: "); funcionario.Matricula = Console.ReadLine();
            Console.Write("Informe a Data de Admissão.................: "); funcionario.DataAdmissao = DateTime.Parse(Console.ReadLine());
            Console.Write("Informe o Cargo............................: "); funcionario.Cargo = Console.ReadLine();
            Console.Write("Informe o Salário..........................: "); funcionario.Salario = Decimal.Parse(Console.ReadLine());

            //imprimir os dados do cliente no console
            Console.WriteLine("\n\n-------------------------------------------------------------------\n");
            Console.WriteLine("\nDADOS DO FUNCIONARIO:\n");
            Console.WriteLine("ID...............: " + funcionario.IdFuncionario);
            Console.WriteLine("NOME.............: " + funcionario.Nome);
            Console.WriteLine("CPF..............: " + funcionario.CPF);
            Console.WriteLine("MATRICULA........: " + funcionario.Matricula);
            Console.WriteLine("DATA DE ADMISSÃO.: " + funcionario.DataAdmissao);
            Console.WriteLine("CARGO............: " + funcionario.Cargo);
            Console.WriteLine("SALARIO..........: " + funcionario.Salario);
            Console.WriteLine("\n\n-------------------------------------------------------------------\n");

            try //tentativa
            {
                //criando um objeto para classe FuncionarioRepository
                var funcionarioRepository = new FuncionarioRepository("C:\\teste", "funcionario.txt");

                //executar a gravação do arquivo
                funcionarioRepository.ExportarDados(funcionario);

                //imprimir mensagem de suscesso
                Console.WriteLine("\n DADOS GRAVADOS COM SUCESSO! ");
            }
            catch(Exception e) //captura da exceção
            {
                Console.WriteLine("\n Ocorreu um erro: " + e.Message);
            }


            //pausar a execução do prompt
            Console.ReadKey();

        }
    
    }
}

