using System;

namespace POO_Produtos.Classes
{
    public class Usuario
    {
        public Usuario(){
            //Cadastrar usuário automaticamente quando essa classe for instanciada
            Cadastrar();
        }
        int Codigo { get; set; }
    
        string Nome { get; set; }
    
        public string Email { get; set; }
    
        public string Senha { get; set; }
    
        DateTime DataCadastro { get; set; }
        
        public void Cadastrar(){
            Nome = "Paulo";
            Email = "admin@admin.com";
            Senha = "123123123";
            DataCadastro = DateTime.UtcNow;
        }
        public void Deletar(){
            Nome = "";
            Email = "";
            Senha = "";
        }
    }
}