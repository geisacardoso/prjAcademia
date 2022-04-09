using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace prjAcademia2J
{
    class MainClass
    {
        static Academia smartFit;
        static void Main(string[] args)
        {
            List<Aluno> Lista = new List<Aluno>();
            smartFit = new Academia(Lista);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();
            ConsoleKeyInfo tecla;
            do
            {
                Menu();
                Console.Write("Escolha opcao:");
                tecla = Console.ReadKey(true);
                if (tecla.Key == ConsoleKey.D1) smartFit.incluirAluno();
                if (tecla.Key == ConsoleKey.D2) smartFit.editarAluno();
                if (tecla.Key == ConsoleKey.D3) smartFit.excluirAluno();
                if (tecla.Key == ConsoleKey.D4)
                {
                    Console.Clear();
                    Console.Clear();
                    Console.WriteLine(smartFit.imprimirClassificacao());
                    Console.WriteLine("Pressione uma tecla para continuar...");
                    Console.ReadKey();
                }
            } while (tecla.Key != ConsoleKey.D5);
            Console.Clear();
        }
        private static void Menu()
        {
            Console.Clear();
            Console.WriteLine("-------------------------------");
            Console.WriteLine("CADASTRO DE ALUNOS DA ACADEMIA ");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("1 - MATRICULA DE ALUNOS");
            Console.WriteLine("2 - EDITAR DADOS DA MATRICULA DO ALUNO");
            Console.WriteLine("3 - EXCLUIR A MATRICULA DO ALUNO");
            Console.WriteLine("4 - IMPRIMIR IMC E CLASSIFICACAO");
            Console.WriteLine("5 - SAIR DO SISTEMA");
        }
    }
}