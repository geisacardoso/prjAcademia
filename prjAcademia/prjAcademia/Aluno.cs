using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace prjAcademia2J
{
    class Aluno
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public double Peso { get; set; }
        public double Altura { get; set; }
        public Aluno(int Id, string Nome, int Idade, double Peso, double Altura)
        {
            this.Id = Id;
            this.Nome = Nome;
            this.Idade = Idade;
            this.Peso = Peso;
            this.Altura = Altura;
        }
        public Aluno()
            : this(0, "Novo Aluno", 15, 0f, 0f)
        {
        }
        public double imc()
        {
            return this.Peso / Math.Pow(this.Altura, 2);
        }
        public string Classificacao()
        {
            double indice = imc();
            if (indice < 18.5) return "BAIXO PESO";
            else if (indice >= 18.5 && indice <= 24.9) return "PESO NORMAL";
            else if (indice >= 25 && indice <= 29.9) return "SOBREPESO";
            else if (indice >= 30 && indice <= 39.9) return "OBESIDADE I";
            else if (indice >= 40 && indice <= 49.9) return "OBESIDADE II";
            else return "OBESIDADE III";
        }
        public string Imprimir()
        {
            return String.Format("ID: {0}\tNOME: {1}\tIDADE: {2}", Id, Nome, Idade);
        }
    }
}