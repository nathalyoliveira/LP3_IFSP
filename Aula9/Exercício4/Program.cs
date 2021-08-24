using System;
using System.Collections;

namespace Exercício4
{
    class Program
    {
        static void Main(string[] args)
        {
            Postagem p1 = new Postagem();
            p1.Titulo = "Postagem 1";
            p1.Data = "21/08/2021";
            p1.Conteudo = "Conteudo 1";
            p1.Visitas = 100;

            Postagem p2 = new Postagem();
            p2.Titulo = "Postagem 2";
            p2.Data = "22/08/2021";
            p2.Conteudo = "Conteudo 2";
            p2.Visitas = 200;

            Postagem p3 = new Postagem();
            p3.Titulo = "Postagem 3";
            p3.Data = "23/08/2021";
            p3.Conteudo = "Conteudo 3";
            p3.Visitas = 300;

            Usuario u1 = new Usuario();
            u1.Nome = "Nathaly";
            u1.Sobrenome = "Oliveira";
            u1.Senha = "00000000";
            u1.Postagens[0] = p1;
            u1.Postagens[1] = p2;
            u1.Postagens[2] = p3;


            Console.WriteLine("__________ Usuário __________ \nNome : " + u1.Nome + "\nSobrenome : " + u1.Sobrenome + "\nSenha : " + u1.Senha);
            Console.WriteLine("\n__________ Postagens __________");
            for (int i = 0; i < 3; ++i)
            {
                Console.WriteLine("Título" + (i + 1) + " : " + u1.Postagens[i].Titulo);
                Console.WriteLine("Data" + (i + 1) + " : " + u1.Postagens[i].Data);
                Console.WriteLine("Conteúdo" + (i + 1) + " : " + u1.Postagens[i].Conteudo);
                Console.WriteLine("Visitas" + (i + 1) + " : " + u1.Postagens[i].Visitas);
                Console.WriteLine("\n");
            }
        }
    }
}
