using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    internal class Emprestimo
    {
        private string EmailUsuario;
        private string IdLivro;
        private DateOnly DataDevolucao;
        private List<Emprestimo> func = new List<Emprestimo>();

        //pega as informações e chama a função update (classe livros)
        public void emprestaLivro(Livros livro)
        {

            Console.WriteLine("\nInforme o email do usuário que pegará o livro:");
            this.EmailUsuario = Console.ReadLine();

            Console.WriteLine("\nInforme o Id do livro emprestado:");
            this.IdLivro = Console.ReadLine();

            Console.WriteLine("\nInforme o dia do mês (com dois dígitos) para a devolução do livro:");
            var dia = int.Parse(Console.ReadLine());
            Console.WriteLine("\nInforme o mês (com dois dígitos) para a devolução do livro:");
            var mes = int.Parse(Console.ReadLine());
            Console.WriteLine("\nInforme o ano (com quatro dígitos) para a devolução do livro:");
            var ano = int.Parse(Console.ReadLine());
            this.DataDevolucao = new DateOnly(ano, mes, dia);

            livro.update(int.Parse(this.IdLivro), this.DataDevolucao);

        }
        
        //pega as informações e chama a função updatedev (classe livros)
        public void devolveLivro(Livros livro)
        {

            Console.WriteLine("\nInforme o email do usuário que devolverá o livro:");
            this.EmailUsuario = Console.ReadLine();

            Console.WriteLine("\nInforme o Id do livro devolvido:");
            this.IdLivro = Console.ReadLine();


            livro.updatedev(int.Parse(this.IdLivro));

        }

    }
}


