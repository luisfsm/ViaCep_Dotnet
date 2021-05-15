using System;
using System.Net.Http;
using Newtonsoft.Json;

namespace Viacep.ConsultaApi
{
    public class ConsultaApi
    {
        public void getViacep(string cep)
        {
            string url = $"https://viacep.com.br/ws/{cep}/json/";
            using (HttpClient http = new HttpClient())
            {
                var response = http.GetAsync(url).GetAwaiter().GetResult();
                

                 if (response.StatusCode != System.Net.HttpStatusCode.OK)
                 {
                     Console.WriteLine($"Cep digitado invalido!! \nO cep digitado foi :{cep}");
                     return;
                 }

                 var bodyResponse = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();

                 ViacepRetorno retornoCep = JsonConvert.DeserializeObject<ViacepRetorno>(bodyResponse);
                 Console.WriteLine($"seu Cep:{retornoCep.cep}\n" +
                                   $"Rua:{retornoCep.logradouro}\n" +
                                   $"Codigo IBGE: {retornoCep.ibge}");
             }         
        }

    }
}
