using Azure.Storage.Blobs.Specialized;
using studies.Colecoes.Pilha;
using studies.Record;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using static studies.Iterator.Class1;

namespace studies
{
    class Program
    {
        static void Main()
        {
            Mensagem1(1);
            Mensagem2(2);
            Mensagem3(3);
        }

        static void Mensagem1(int n1){
            string MinhaMensagem(int n1) => $"Mensagem {n1}";

            var mensagemCompleta = ObterMensagem(MinhaMensagem, 1);
            Console.WriteLine(mensagemCompleta);
        }
        
        static void Mensagem2(int n2){
            string MinhaMensagem(int n2) => $"Mensagem {n2}";

            var mensagemCompleta = ObterMensagem(MinhaMensagem, 2);
            Console.WriteLine(mensagemCompleta);
        }

        static void Mensagem3(int n3){
            string MinhaMensagem(int n3) => $"Mensagem {n3}";

            var mensagemCompleta = ObterMensagem(MinhaMensagem, n3);
            Console.WriteLine(mensagemCompleta);
        }
        
        public delegate string ObterMensagemEspecifica(int n1);

        static string ObterMensagem(ObterMensagemEspecifica mensagemEspecifica, int n1)
        {
              string mensagem = string.Empty;
              mensagem += "Inicio da mensagem\r\n\r\n";
              mensagem += mensagemEspecifica(n1);
              mensagem += "\r\n\r\n";
              mensagem += "----------------------------\r\n";

              return mensagem;
        }
    }
}