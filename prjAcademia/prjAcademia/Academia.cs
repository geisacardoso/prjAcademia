using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace prjAcademia2J
{
    class Academia
    {
        private List<Aluno> Alunos;
        public Academia(List<Aluno> Alunos)
        {
            this.Alunos = Alunos;
        }
        public string imprimirClassificacao()
        {
            string texto = "\nCLASSIFICACAO DOS ALUNOS DA ACADEMIA\n";
            foreach (Aluno reg in Alunos)
            {
                texto += "\n" + reg.Imprimir();
                texto += "\nIMC:" + reg.imc().ToString("N2") +
                    "\nCLASSIFICACAO: " + reg.Classificacao() + "\n";
            }
            return texto;
        }
        public void incluirAluno()
        {
            Aluno reg = new Aluno();
            Console.Clear();
            reg.Id = Alunos.Count + 1;
            Console.Write("DIGITE NOME:");
            reg.Nome = Console.ReadLine();
            Console.Write("DIGITE PESO:");
            reg.Peso = Double.Parse(Console.ReadLine());
            Console.Write("DIGITE ALTURA:");
            reg.Altura = Double.Parse(Console.ReadLine());
            Console.Write("DIGITE IDADE:");
            reg.Idade = Int16.Parse(Console.ReadLine());
            Alunos.Add(reg);
            Console.WriteLine("Aluno matriculado com sucesso!");
            Console.ReadKey();
        }
        public void excluirAluno()
        {
            Console.Clear();
            Console.Write("DIGITE ID:");
            int id = Int16.Parse(Console.ReadLine());
            Aluno reg = Alunos.FirstOrDefault(i => i.Id == id);
            if (reg != null)
            {
                Alunos.Remove(reg);
                Console.WriteLine("Matricula cancelada:{0}", reg.Nome);
            }
            else
            {
                Console.WriteLine("Matricula inválida");
            }
            Console.WriteLine("pressione uma tecla");
            Console.ReadKey();
        }
        public void editarAluno()
        {
            Console.Clear();
            Console.Write("DIGITE ID:");
            int id = Int16.Parse(Console.ReadLine());
            Aluno reg = Alunos.FirstOrDefault(i => i.Id == id);
            if (reg != null)
            {

                Console.Write("\tMatricula :{0}", reg.Id);
                Console.Write("\tNOME :{0}", reg.Nome);
                Console.Write("\tIDADE :{0}", reg.Idade);
                Console.Write("\tPESO :{0}", reg.Peso);
                Console.WriteLine("\tALTURA :{0}", reg.Altura);
                Console.Write("DIGITE NOME:");
                reg.Nome = Console.ReadLine();
                Console.Write("DIGITE PESO:");
                reg.Peso = Double.Parse(Console.ReadLine());
                Console.Write("DIGITE ALTURA:");
                reg.Altura = Double.Parse(Console.ReadLine());
                Console.Write("DIGITE IDADE:");
                reg.Idade = Int16.Parse(Console.ReadLine());
                Console.WriteLine("Matricula editada!");
            }
            else
            {
                Console.WriteLine("Matricula inválida");
            }
            Console.WriteLine("pressione uma tecla");
            Console.ReadKey();
        }
    }
}