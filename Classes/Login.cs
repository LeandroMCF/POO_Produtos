using System;

namespace POO_Produtos.Classes
{
    public class Login
    {       
        bool Logado { get; set; }
        public void Logar(Usuario usuario){
            if (Logado == false)
            {  
                Console.Write($"Digite seu Email: ");
                string emailLog = Console.ReadLine();
                Console.Write($"Digite sua senha: ");
                string senhaLog = Console.ReadLine();
                while (emailLog != usuario.Email || senhaLog != usuario.Senha)
                {
                    Console.WriteLine($"Usuário ou senha incorreto.\n");
                    Console.Write($"Digite seu Email: ");
                    emailLog = Console.ReadLine();
                    Console.Write($"Digite sua senha: ");
                    senhaLog = Console.ReadLine();
                }
                Console.WriteLine($"Login efetuado com sucesso.");
                Logado = true;
            }
            else
            {
                Console.WriteLine($"Você já está Logado.");
            }

        }
        public void Deslogar(Usuario usuario){
            if (Logado == false)
            {
                Console.WriteLine($"Você já está deslogado.");
            }
            else
            {
                Logado = false;
            }
        }
    }
}