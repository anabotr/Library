using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    internal class Livros
    {
        private string Titulo;
        private string Autor;
        private string Id;
        private string Descricao;
        private int Disponivel; //0 para disponível e 1 para indisponível
        private DateOnly TempoDevolucao;

        //essa variável vai atribuir id aos livros registrados, começando do 1 e indo até o número de livros do sistema
        private int idcontador = 0;

        //cria uma lista com os livros registrados
        private List<Livros> func = new List<Livros>();


        //pega as informações do livro e chama a funçaõ addLivroNaLista
        public void registraLivroNovo()
        {
            Console.WriteLine("\nInforme o título:");
            this.Titulo = Console.ReadLine();

            Console.WriteLine("\nInforme o autor:");
            this.Autor = Console.ReadLine();


            Console.WriteLine("\nInforme a descrição do livro:");
            this.Descricao = Console.ReadLine();


            this.addLivroNaLista();
            Console.WriteLine("\n----------------------------------------\nLivro registrado com sucesso!");

        }



        //pega as informações inseridas e coloca um novo livro na lista
        private void addLivroNaLista()
        {
            this.func.Add(new Livros()
            {
                Titulo = this.Titulo,
                Autor = this.Autor,

                //o ++ garante que os ids não se repitam e sejam registrados em ordem crescente
                Id = $"{++this.idcontador}",
                Descricao = this.Descricao,
                Disponivel = this.Disponivel,
                TempoDevolucao = this.TempoDevolucao
            });
        }



        //exibe todos os livros da lista
        public void exibeLivros()
        {
            Console.WriteLine("\n-----------------Livros-----------------");
            foreach (var Livros in this.func)
            {
                Console.WriteLine($"Título: {Livros.Titulo} \nAutor: {Livros.Autor} \nId: {Livros.Id} \nDescrição: {Livros.Descricao} \nDisponibilidade: {Livros.Disponivel} \nData de devolução: {Livros.TempoDevolucao}");
                Console.WriteLine("----------------------------------------");
            }
        }



        //atualiza o status de disponibilidade do livro 0(disponível) -> 1 (indisponível)
        public Boolean update(int id, DateOnly tempoDevolucao)
        {
            int cont = 0;
            //verifica cada id se é igual ao inserido na função de empréstimo
            foreach (var item in this.func)
            {
                if (int.Parse(item.Id) != id)
                {
                    cont++;
                }
                else
                {
                    this.func[cont].Disponivel = 1;
                    this.func[cont].TempoDevolucao = tempoDevolucao;
                    return true;
                }
            }
            Console.WriteLine("/nO livro não está resgitrado!");
            return false;
        }


        //atualiza o status de disponibilidade do livro 1(indisponível) -> 0 (disponível)
        public Boolean updatedev(int id)
        {
            int cont = 0;
            //verifica cada id se é igual ao inserido na função de devolução
            foreach (var item in this.func)
            {
                if (int.Parse(item.Id) != id)
                {
                    cont++;
                }
                else
                {
                    this.func[cont].Disponivel = 0;
                    this.func[cont].TempoDevolucao = new DateOnly(0001, 01, 01);
                    return true;
                }
            }
            Console.WriteLine("/nO livro não está resgitrado!");
            return false;
        }

    }
}
