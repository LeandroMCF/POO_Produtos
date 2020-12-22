using System;
using POO_Produtos.Classes;

namespace POO_Produtos
{
    class Program
    {
        static void Main(string[] args)
        {
            Marca marca = new Marca();
            Usuario usuario = new Usuario();
            Login login = new Login();
            Produto produto = new Produto();

            string ops = "", ops2 = "";
            int cod, contProduto = 0, contMarca = 0, ops3 = 0;


            //login.Logar(usuario);
            do
            {
                cod = 0;
                Console.WriteLine($"Escolha uma opção:\n[1] Cadastrar Produto\n[2] Listar Produto\n[3] Deletar produto\n[4] Cadastrar Marca\n[5] Listar Marca\n[6] Deletar Marca\n[0] Deslogar e sair");
                ops = Console.ReadLine();
                while (ops == "1" && ops == "2" && ops == "3" && ops == "4" && ops == "5" && ops == "6" && ops == "0")
                {
                    Console.WriteLine($"Opção inválida.\nEscolha uma opção:\n[1] Cadastrar Produto\n[2] Listar Produto\n[3] Deletar produto\n[4] Cadastrar Marca\n[5] Listar Marca\n[6] Deletar Marca\n[0] Deslogar e sair");
                    ops = Console.ReadLine();
                }
                switch (ops)
                {
                    case "1":
                        produto.Cadastrar(ops3);
                        contProduto++;
                    break;

                    case "2":
                        if (contProduto == 0)
                        {
                            Console.WriteLine($"Você ainda não cadastrou nenhum produto.");
                        }
                        else
                        {
                            produto.Listar();
                        }

                    break;

                    case "3":
                        if (contProduto == 0)
                        {
                            Console.WriteLine($"Você ainda não cadastrou nenhum produto.");
                        }
                        else
                        {
                            Console.Write($"Digite o código do produto que deseja excluir: ");
                            cod = int.Parse(Console.ReadLine());
                            bool resposta = produto.MostrarProduto(cod, ops2);
                            produto.Deletar(cod, resposta);
                        }
                    break;

                    case "4":
                        marca.CadastrarMarca();
                        contMarca++;
                    break;

                    case "5":
                    if (contMarca == 0)
                    {
                        Console.WriteLine($"Você ainda não cadastrou nenhuma marca.");
                    }
                    else
                    {
                        marca.Listar();
                    }
                    break;

                    case "6":
                        if (contMarca == 0)
                        {
                            Console.WriteLine($"Você ainda não cadastrou nenhuma marca.");
                        }
                        else
                        {
                            Console.Write($"Digite o codigo da marca que deseja excluir: ");
                            cod = int.Parse(Console.ReadLine());
                        }
                    break;

                    case "0":
                        login.Deslogar(usuario);
                    break;  
                }
                
            } while (ops != "0");
        }
    }
}
