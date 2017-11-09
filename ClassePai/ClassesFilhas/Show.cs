using System;
using System.IO;

namespace ProjetoEvento.ClassePai.ClassesFilhas
{
    public class Show:Evento
    {
        public string Artista { get; set; }
        public string GeneroMusical { get; set; }
        
        public Show(){

        }

        public Show(string Titulo, string Local, int Lotacao, string Duracao, int Classificacao, DateTime Data, string Artista, string GeneroMusical){
            base.Titulo = Titulo;
            base.Local = Local;
            base.Duracao = Duracao;
            base.Classificacao = Classificacao;
            base.Data = Data;
            this.Artista = Artista;
            this.GeneroMusical = GeneroMusical;
        }

        public override bool Cadastrar(){


            bool efetuado = false;
            System.IO.StreamWriter arquivo = null;
            try
            {
                arquivo = new StreamWriter("show.csv", true); //true deixa cumulativo
                arquivo.WriteLine(Titulo+";"+
                Local+";"+
                Duracao+";"+
                Data+";"+
                Artista+";"+
                GeneroMusical+";"+
                Lotacao+";"+
                Classificacao);

                efetuado = true;
            }
            catch (Exception ex)
            {
                
                throw new Exception("Erro ao tentar grava o arquivo");
            }
            finally{
                arquivo.Close();
            }

            return efetuado;
        











        
        }
    
    }
}