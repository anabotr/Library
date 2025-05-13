using System;

using Biblioteca;


internal class Program
{
    private static void Main(string[] args)
    {

        //instanciona todas as classes que vão ser utilizadas
        Livros l1 = new Livros();
        Usuario u1 = new Usuario();
        Emprestimo e1 = new Emprestimo();

        //varável para o menu ficar reaparecendo
        bool executar = true;


        //menu de ações
        while (executar)
        {
            Console.WriteLine("\nQue ação você deseja executar? \n----------------------------------------\nRegistrar livro: Pressione 1 \nRegistrar novo usuário: Pressione 2 \nRealizar um empréstimo: Pressione 3 \nRealizar uma devolução: Pressione 4 \nExibir livros: Pressisone 5 \nExibir usuários: Pressione 6\nSair do programa: Pressione 0 \n----------------------------------------");
            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    l1.registraLivroNovo();
                    break;
                case 2:
                    u1.registraUsuario();
                    break;
                case 3:
                    e1.emprestaLivro(l1);
                    break;
                case 4:
                    e1.devolveLivro(l1);
                    break;
                case 5:
                    l1.exibeLivros();
                    break;
                case 6:
                    u1.exibeUsuarios();
                    break;
                case 0:
                    //executar fica falso e o loop é encerrado
                    executar = false;
                    break;
            }
        }

    }
}
