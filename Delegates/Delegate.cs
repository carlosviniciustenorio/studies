using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace studies.Delegates
{
    public class Delegate
    {
        // static void Main()
        // {
        //     Mensagem1(1);
        //     Mensagem2(2);
        // }

        // static void Mensagem1(int n1){
        //     // string MinhaMensagem(int n1) => $"Mensagem {n1}";
        //     Func<int, string> MinhaMensagem = delegate (int n1) {return $"Mensagem {n1}";};
            
        //     var mensagemCompleta = ObterMensagem(MinhaMensagem, 1);
        //     Console.WriteLine(mensagemCompleta);
        // }
        
        // static void Mensagem2(int n2){
        //     string MinhaMensagem(int n2) => $"Mensagem {n2}";

        //     var mensagemCompleta = ObterMensagem(MinhaMensagem, 2);
        //     Console.WriteLine(mensagemCompleta);
        // }
        
        // public delegate string ObterMensagemEspecifica(Func<int, string> mensagemEspecifica);

        // static string ObterMensagem(Func<int, string> mensagemEspecifica, int n1)
        // {
        //       string mensagem = string.Empty;
        //       mensagem += "Inicio da mensagem\r\n\r\n";
        //       mensagem += mensagemEspecifica(n1);
        //       mensagem += "\r\n\r\n";
        //       mensagem += "----------------------------\r\n";

        //       return mensagem;
        // }
    }
}