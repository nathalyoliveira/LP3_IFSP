using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício4_2
{
    class Postagem
    {
        private string titulo;
        private string data;
        private string conteudo;
        private int visitas;

        public Postagem(string titulo, string data, string conteudo, int visitas)
        {
            this.titulo = titulo;
            this.data = data;
            this.conteudo = conteudo;
            this.visitas = visitas;
        }

        public Postagem()
        {
        }

        public String getTitulo()
        {
            return this.titulo;
        }

        public string getData()
        {
            return this.data;
        }

        public string getConteudo()
        {
            return this.conteudo;
        }

        public int getVisitas()
        {
            return this.visitas;
        }

        public void setTitulo(string titulo)
        {
            this.titulo = titulo;
        }

        public void setData(string data)
        {
            this.data = data;
        }

        public void setConteudo(string conteudo)
        {
            this.conteudo = conteudo;
        }

        public void setVisitas(int visitas)
        {
            this.visitas = visitas;
        }
    }
}
