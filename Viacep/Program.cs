using System;

namespace Viacep
{
    class Program
    {
        static void Main(string[] args)
        {
          ConsultaApi.ConsultaApi consultaApi = new ConsultaApi.ConsultaApi();

            Console.WriteLine("Digite um Cep :");
            string cep = Console.ReadLine();

            consultaApi.getViacep(cep);
        }
    }
}
