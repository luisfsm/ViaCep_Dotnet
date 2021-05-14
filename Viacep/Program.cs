using System;
using System.Net;
using System.Net.Http;

namespace Viacep
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um Cep :");
            string cep = Console.ReadLine();
            string url = $"https://viacep.com.br/ws/" + cep + "/json/";

            using (HttpClient http = new HttpClient()){

                var response = http.GetAsync(url).GetAwaiter().GetResult();
                var bodyResponse = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();

                if (response.StatusCode != HttpStatusCode.OK) {
                    Console.WriteLine($"Entrada de Cep Invalida. Cep Digitado: {0} ",cep);
                    return;
                }
                Console.WriteLine(bodyResponse);

            }
        }
    }
}
