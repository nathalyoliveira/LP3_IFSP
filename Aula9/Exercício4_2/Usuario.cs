using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício4_2
{
    class Usuario
    {
        private string nome;
        private string sobrenome;
        private string senha;
        private Postagem postagens = new Postagem();

        public string getNome()
        {
            return this.nome;
        }

        public string getSobrenome()
        {
            return this.sobrenome;
        }

        public string getSenha()
        {
            return this.senha;
        }

        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public void setSobrenome(string sobrenome)
        {
            this.sobrenome = sobrenome;
        }

        public void setSenha(string senha)
        {
            this.senha = senha;
        }

        public Postagem getPostagens()
        {
            return this.postagens;
        }

        public void setPostagens(Postagem postagens)
        {
            this.postagens = postagens;
        }
    }
}
