using System;
using System.IO;
using System.Text;

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




            public override bool Cadastrar(){


            bool efetuado = false;
            System.IO.StreamWriter arquivo = null;

            string integrantes = "";

           foreach(string conteudo in Elenco){

                    integrantes += conteudo + "-"; //A variavel integrantes vai acumulando todos os elementos numa mesma variavel separada por um traço
           }


            try
            {
                arquivo = new StreamWriter("tearo.csv", true); //true deixa cumulativo
                arquivo.WriteLine(Titulo+";"+
                Local+";"+
                Duracao+";"+
                Data+";"+
                integrantes+";"+  //tem que abrir em um array antes e criar uma variavel dinamica aqui no lugar
                Diretor+";"+
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


            public override string Pesquisar(string Titulo){
                string resultado = "Título não encontrado!";
                StreamReader ler = null;

                try
                {
                    ler = new StreamReader("teatro.csv",Encoding.Default);
                    string linha = "";
                    while((linha=ler.ReadLine())!=null){
                        string[] dados = linha.Split(';');
                        if(dados[0] == Titulo){
                            resultado = linha;
                            break;
                        }
                    }
                }
                catch (Exception ex){
                    resultado = "Erro ao tentar ler o arquivo." + ex.Message;
                    throw;
                }
                finally{
                    ler.Close();
                }


                return resultado;
            }






























    }
}