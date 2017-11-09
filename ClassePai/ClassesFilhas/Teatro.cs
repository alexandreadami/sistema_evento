using System;

namespace ProjetoEvento.ClassePai.ClassesFilhas
{
    public class Teatro:Evento
    {
        public string[] Elenco { get; set; } //vetor de strings

        public string Diretor { get; set; }
        

        public Teatro(){

        }


       public Teatro(string Titulo, string Local, int Lotacao, string Duracao, int Classificacao, DateTime Data, string[] Elenco, string Diretor){
            base.Titulo = Titulo;
            base.Local = Local;
            base.Duracao = Duracao;
            base.Classificacao = Classificacao;
            base.Data = Data;
            this.Elenco = Elenco;
            this.Diretor = Diretor;
        }



































    }
}