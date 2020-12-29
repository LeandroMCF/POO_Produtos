using System;
using System.Collections.Generic;

namespace POO_Produtos.Classes
{
    public class Marca
    {
        int Codigo  { get; set; }
        public string NomeMarca { get; set; }
        DateTime DataCadastro { get; set; }
        

        List<Marca> Marcas = new List<Marca>();

        public Marca CadastrarMarca(int ops){

            Marca novaMarca = new Marca();
            Console.WriteLine($"Quantas marcas você deseja adicionar?");
            ops = int.Parse(Console.ReadLine());
            while (ops <= 0)
            {
                Console.WriteLine($"Opção inválida.\nQuantas marcas você deseja adicionar?");
                ops = int.Parse(Console.ReadLine());
            }
            int cont = 0;
            do
            {
                Console.Write($"Digite o cod da marca: ");
                novaMarca.Codigo = int.Parse(Console.ReadLine());

                Console.Write("Digite o nome da marca: ");
                novaMarca.NomeMarca = Console.ReadLine();
                Console.WriteLine($"");

                novaMarca.DataCadastro = DateTime.UtcNow;
                
                Marcas.Add(novaMarca);
                cont++;

                return novaMarca;
                
            } while (cont < ops);
        }
        public void Listar(){

            Console.WriteLine($"Marcas cadastradas: ");
            foreach (Marca item in Marcas)
            {
                Console.WriteLine($"Código: {item.Codigo}");
                Console.WriteLine($"Marca: {item.NomeMarca}");
                Console.WriteLine($"Data de cadastro: {item.DataCadastro}");
            }

        }
        public void Deletar(int cod){

            Marca deletarMarca = Marcas.Find(m => m.Codigo == cod);
            Marcas.Remove(deletarMarca);
            
        }
    }
}