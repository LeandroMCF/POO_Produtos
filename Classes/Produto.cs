using System;
using System.Collections.Generic;

namespace POO_Produtos.Classes
{
    public class Produto
    {
        int Codigo { get; set; }
    
        string NomeProduto { get; set; }
    
        float Preco { get; set; }
    
        DateTime DataCadastro { get; set; }
    
        public Marca Marca = new Marca();
    
        Usuario CadastrarPor { get; set; }
    
        List<Produto> ListaDeProduto = new List<Produto>();
        
        public void Cadastrar(int ops){

            Console.WriteLine($"Quantos produtos deseja adicionar?");
            ops = int.Parse(Console.ReadLine());
            while (ops <= 0)
            {
                Console.WriteLine($"Número inválido.\nQuantos produtos deseja adicionar?");
                ops = int.Parse(Console.ReadLine());
            }
            int cont = 0;
            do
            {
                Produto novoProduto = new Produto();
                Console.Write($"Digite o codigo do produto: ");
                novoProduto.Codigo = int.Parse(Console.ReadLine());

                Console.Write($"Digite o nome do produto: ");
                novoProduto.NomeProduto = Console.ReadLine();

                Console.Write($"Digite o preço do produto: ");
                novoProduto.Preco = float.Parse(Console.ReadLine());
                
                novoProduto.Marca = Marca.CadastrarMarca();

                CadastrarPor = new Usuario();

                ListaDeProduto.Add(novoProduto);
                cont++;
            } while (cont < ops);

        }
        public void Listar(){
            Console.ForegroundColor = ConsoleColor.Green;
            foreach (var item in ListaDeProduto)
            {
                Console.WriteLine($"Código: {item.Codigo}");
                Console.WriteLine($"Produto: {item.NomeProduto}");
                Console.WriteLine($"Preço: {item.Preco}");
                Console.WriteLine($"Data de cadatro: {item.DataCadastro}");
                Console.WriteLine($"Marca: {item.Marca.NomeMarca}");
                Console.WriteLine($"");
            }
            Console.ResetColor();
        }
        public void Deletar(int cod, bool resposta){
            if (resposta == true)
            {
                Produto produtoDelet = ListaDeProduto.Find(p => p.Codigo == cod);
                ListaDeProduto.Remove(produtoDelet);
            }
            else
            {
                Console.WriteLine($"Ok!");
                
            }
        }

        public bool MostrarProduto(int cod, string ops){
            Produto escolhaProduto = new Produto();
            foreach (var item in ListaDeProduto)
            {
                if (item.Codigo == cod)
                {
                    Console.WriteLine($"Tem certeza que deseja excluir esse produto [S] Sim ou [N] Não: \nNome: {item.NomeProduto}\nPreço: {item.Preco}");
                    ops = Console.ReadLine();
                    ops = ops.ToUpper();
                    while (ops != "S" && ops != "N")
                    {
                        Console.WriteLine($"Opção inválida.\nTem certeza que deseja excluir esse produto [S] Sim ou [N] Não");
                        ops = Console.ReadLine();
                        ops = ops.ToUpper();
                    }
                }
            }
            if (ops == "S")
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}