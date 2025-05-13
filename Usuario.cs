using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    internal class Usuario
    {
        private string Nome;
        private string Email;
        private string Senha;
        private List<Usuario> func = new List<Usuario>();


        //pega as informações inseridas e chama a função addUsuarioNaLista
        public void registraUsuario()
        {
            Console.WriteLine("\nInforme o nome do novo usuário:");
            this.Nome = Console.ReadLine();

            Console.WriteLine("\nInforme o e-mail do novo usuário:");
            this.Email = Console.ReadLine();

            Console.WriteLine("\nInforme a senha para o cadastro:");
            this.Senha = Console.ReadLine();


            Console.WriteLine("\n----------------------------------------\nUsuário registrado com sucesso!");

            this.addUsuarioNaLista();

        }


        //pega as informações inseridas e coloca um novo usuário na lista
        private void addUsuarioNaLista()
        {
            this.func.Add(new Usuario()
            {
                Nome = this.Nome,
                Email = this.Email,
                Senha = this.Senha,
            });
        }


        //exibe os funcionários registrados na lista
        public void exibeUsuarios()
        {
            Console.WriteLine("\n-----------------Usuários-----------------");
            foreach (var Usuario in this.func)
            {
                Console.WriteLine($"Nome: {Usuario.Nome} \nEmail: {Usuario.Email}");
                Console.WriteLine("----------------------------------------");
            }
        }
    }
}
