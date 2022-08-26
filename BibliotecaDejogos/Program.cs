using BibliotecaDejogos.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDejogos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Jogo> listaDeJogos = new List<Jogo>();
            Console.ForegroundColor = ConsoleColor.Green;

            while (true)
            {

                Console.WriteLine("======BIBLIOTECA DE JOGOS======");

                Console.WriteLine("1 - Adicionar Jogo");
                Console.WriteLine("2 - Listar Jogos");
                Console.WriteLine("3 - Editar Jogo");
                Console.WriteLine("4 - Remover Jogo");
                Console.Write("Opcao: ");

                bool resultado;
                String opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        resultado = AdicionarJogo(listaDeJogos);
                        if (resultado == true)
                        {
                            Console.WriteLine("Cadastrado com sucesso!");
                        }
                        else
                        {
                            Console.WriteLine("Erro no cadastro.");
                        }
                        break;

                    case "2":
                        resultado = ListarJogos(listaDeJogos);
                        if (resultado == true)
                        {
                            Console.WriteLine("Listado com sucesso!");
                        }
                        else
                        {
                            Console.WriteLine("Erro na listagem.");
                        }
                        break;

                    case "3":
                        resultado = EditarJogos(listaDeJogos);
                        if (resultado == true)
                        {
                            Console.WriteLine("Editado com sucesso!");
                        }
                        else
                        {
                            Console.WriteLine("Erro em editar.");
                        }
                        break;

                    case "4":
                        resultado = DeletarJogos(listaDeJogos);
                        if (resultado == true)
                        {
                            Console.WriteLine("Deletado com sucesso!");
                        }
                        else
                        {
                            Console.WriteLine("Erro em deletar.");
                        }
                        break;

                    default:
                        Console.WriteLine("Opção Inválida!");
                        break;
                }

                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadLine();
                Console.Clear();
            }
        }

        public static bool AdicionarJogo(List<Jogo> listaDejogos)
        {
            Console.Clear();
            Console.Write("Titulo: ");
            String titulo = Console.ReadLine();
            Console.Write("Ano: ");
            int ano = Convert.ToInt32(Console.ReadLine());

            if (titulo == "") return false;
            if (ano < 1950) return false;

            Jogo novoJogo = new Jogo(titulo, ano, "teste", 1);

            listaDejogos.Add(novoJogo);
            Console.Beep();

            return true;
        }

        public static bool ListarJogos (List <Jogo> listaJogos)
        {
            Console.WriteLine("=============== Lista de Jogos ================");

            foreach (Jogo jogo in listaJogos)
            {
                Console.Write("Titulo: ");
                Console.WriteLine(jogo.getTitulo());
                Console.Write("Ano: ");
                Console.WriteLine(jogo.getAno());
                Console.WriteLine("==========");
                Console.WriteLine("");
            }

            Console.Beep();

            return true;
        }

        public static bool EditarJogos (List <Jogo> listaJogos)
        {
            Console.WriteLine("=============== Editar Jogo ================");

            Console.Write("Nome do jogo a ser editado: ");
            String Editar = Console.ReadLine();

            foreach (Jogo jogo in listaJogos)
            {

                if (Editar == jogo.getTitulo())
                {
                    Console.Write(" Novo Titulo: ");
                    String TituloEdit = Console.ReadLine();
                    jogo.setTitulo(TituloEdit);
                    Console.Write(" Novo Ano: ");
                    int AnoEdit = Convert.ToInt32(Console.ReadLine());
                    jogo.setAno(AnoEdit);
                    return true;
                }

                else
                {
                    Console.WriteLine("Jogo não encontrado");
                    return false;
                }

            }

            Console.Beep();

            return true;
        }

        public static bool DeletarJogos(List <Jogo> listaJogos)
        {
            Console.WriteLine("=============== Deletar Jogo ================");

            Console.Write("Nome do jogo a ser excluido: ");
            String Deletar = Console.ReadLine();

            foreach (Jogo jogo in listaJogos)
            {


                if (Deletar == jogo.getTitulo())
                {
                    listaJogos.Remove(jogo);
                    return true;
                   

                }

            }

            Console.Beep();

            return true;



        }
    }
}
