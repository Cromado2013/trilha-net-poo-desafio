using DesafioPOO.Models;

// using System;
// using System.Threading.Tasks;

// namespace SmartphoneTester

    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Smartphone Tester - Iniciando...");

            // Teste de capacidade de resposta
            Console.WriteLine("Teste de Resposta ao Toque...");
            await TestarRespostaAoToque();

            // Teste de conectividade de rede
            Console.WriteLine("Teste de Conectividade de Rede...");
            await TestarConectividadeDeRede();

            Console.WriteLine("Testes Concluídos.");
        }

        static async Task TestarRespostaAoToque()
        {
            // Simular um teste de toque - isso seria interativo em uma interface gráfica
            Console.WriteLine("Simulação: Toque na tela... (Aperte Enter para continuar)");
            Console.ReadLine();
            Console.WriteLine("Resposta ao toque simulada com sucesso.");
            await Task.Delay(500); // Simular um delay
        }

        static async Task TestarConectividadeDeRede()
        {
            // Simular um teste de conectividade de rede
            Console.WriteLine("Verificando conectividade com o Google...");
            bool conectado = await VerificarConectividade("https://www.google.com");

            if (conectado)
            {
                Console.WriteLine("Conectividade de rede verificada com sucesso.");
            }
            else
            {
                Console.WriteLine("Falha na conectividade de rede.");
            }
        }

        static async Task<bool> VerificarConectividade(string url)
        {
            try
            {
                using (var client = new System.Net.Http.HttpClient())
                {
                    var response = await client.GetAsync(url);
                    return response.IsSuccessStatusCode;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
    }

