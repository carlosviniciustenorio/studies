using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studies.Using
{
    internal class UsingExpression
    {
        //Instrução using
        //A instrução using define um limite para o objeto fora do qual, o objeto é destruído automaticamente.
        //A instrução using é encerrada ao final do bloco de instruções "using" ou quando a execução sai do bloco indiretamente,
        //por exemplo - quando uma exceção for lançada.

        //Resumindo: É usada para usar recursos e ter a certeza que estes recursos serão liberados no fim do bloco da instrução using.
        //OBS: Possível somente com objetos que implementem a interface IDisposable ou IAsyncDisposable

        //Você pode instanciar o objeto de recurso e, em seguida, passar a variável para a using instrução,
        //mas essa não é uma prática recomendada. Nesse caso, após o controle sair do bloco using,
        //o objeto permanecerá no escopo, mas provavelmente não terá acesso a seus recursos não gerenciados.
        //Em outras palavras, ele não é mais totalmente inicializado.
        //Se você tentar usar o objeto fora do bloco using, corre o risco de causar o lançamento de uma exceção.
        //Por esse motivo, é melhor instanciar o objeto na using instrução e limitar seu escopo ao using bloco.

        //Forma correta (Instanciando o objeto direto para o using):
        //string manyLines = @"This is line one
        //                        This is line two
        //                        Here is line three
        //                        The penultimate line is line four
        //                        This is the final, fifth line.";

        //    using var reader = new StringReader(manyLines);
        //    string? item;
        //    do
        //    {
        //        item = reader.ReadLine();
        //        Console.WriteLine(item);
        //    } while (item != null);
    }
}
