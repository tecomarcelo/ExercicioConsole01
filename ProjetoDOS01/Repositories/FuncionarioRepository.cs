using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoDOS01.Entities;
using System.IO;

namespace ProjetoDOS01.Repositories
{
    public class FuncionarioRepository
    {
        //atributos privados
        private string _diretorio = "c:\\teste";
        private string _arquivo = "funcionario.txt";

        //metodo construtor
        public FuncionarioRepository()
        {
            CriarDiretorio();
        }
        //sobrecarga de construtor (OVERLOADING)
        public FuncionarioRepository(string diretorio, string arquivo)
        {
            _diretorio = diretorio;
            _arquivo = arquivo;

            CriarDiretorio();
        }

        //metodo para gravar os dados do cliente me um arquivo
        public void ExportarDados(Funcionario funcionario)
        {
            //abrindo modo de escrita
            var streamWriter = new StreamWriter(_diretorio + "\\" + _arquivo, true);

            //excrevendo os dados do cliente no arquivo
            streamWriter.WriteLine("\nID DO FUNCIONARIO.:" + funcionario.IdFuncionario);
            streamWriter.WriteLine("NOME.:" + funcionario.Nome);
            streamWriter.WriteLine("CPF.:" + funcionario.CPF);
            streamWriter.WriteLine("MATRICULA.:" + funcionario.Matricula);
            streamWriter.WriteLine("DATA DE ADMISSÃO.:" + funcionario.DataAdmissao);
            streamWriter.WriteLine("CARGO.:" + funcionario.Cargo);
            streamWriter.WriteLine("SALARIO.:" + funcionario.Salario);
            streamWriter.WriteLine("__________________________________________________________");

            //salvando e fechado o arquivo
            streamWriter.Flush();
            streamWriter.Close();
        }
        
        //metodo para criar a pasta na maquina do usuario
        private void CriarDiretorio()
        {
            //verificando se a pasta não existe
            if (!Directory.Exists(_diretorio))
            {
                //criando a pasta na maquina do usuario
                Directory.CreateDirectory(_diretorio);
            }
        }
    }
}

