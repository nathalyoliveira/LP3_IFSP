using System;
using System.Collections;

namespace Exercício4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayList postagens = new ArrayList();
            //postagens.Add(new Postagem("Postagem 5", "21/08/2021", "Conteudo 5", 500));
            //postagens.Add(new Postagem("Postagem 6", "21/08/2021", "Conteudo 6", 500));

            Postagem p1 = new Postagem("Postagem 1", "21/08/2021", "Conteudo 1", 100);
            Postagem p2 = new Postagem("Postagem 2", "21/08/2021", "Conteudo 2", 200);
            Postagem p3 = new Postagem("Postagem 3", "21/08/2021", "Conteudo 2", 300);
            Postagem p4 = new Postagem("Postagem 4", "21/08/2021", "Conteudo 4", 400);

            Usuario u1 = new Usuario();
            u1.setNome("Nathaly");
            u1.setSobrenome("Oliveira");
            u1.setSenha("00000000");
            u1.setPostagens(p1);
            u1.setPostagens(p2);
            u1.setPostagens(p3);
            u1.setPostagens(p4);
            //u1.setPostagens(postagens());

            //Console.WriteLine("Nome: " + u1.getNome); -> Fala que não pode usar "+"
            Console.WriteLine("Postagens: ");

            for (int i = 0; i < 3; ++i)
            {   //Só busca a postagem 4
                Console.WriteLine("Postagem " + (i + 1) + ": " + u1.getPostagens().getConteudo());
            }

            

        }
    }
}
