using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace studies.HTTP
{
    // HttpClient destina-se a ser instanciado uma vez e reutilizado durante toda a vida útil de um aplicativo.
    // No .NET Core e no .NET 5+, o HttpClient agrupa conexões dentro da instância do manipulador e reutiliza uma conexão entre várias solicitações. 
    // Se você criar uma instância de uma classe HttpClient para cada solicitação, 
    // o número de soquetes disponíveis em cargas pesadas será esgotado. 
    // Esse esgotamento resultará em SocketException erros.
    
    
    // static readonly HttpClient client = new HttpClient();
    
    //     static async Task Main()
    //     {
    //         try	
    //         {
    //             HttpResponseMessage response = await client.GetAsync("http://www.contoso.com/");
    //             response.EnsureSuccessStatusCode();
    //             string responseBody = await response.Content.ReadAsStringAsync();
    //             // Above three lines can be replaced with new helper method below
    //             // string responseBody = await client.GetStringAsync(uri);

    //             Console.WriteLine(responseBody);
    //         }
    //         catch(HttpRequestException e)
    //         {
    //             Console.WriteLine("\nException Caught!");	
    //             Console.WriteLine("Message :{0} ",e.Message);
    //         }
    //     }
}