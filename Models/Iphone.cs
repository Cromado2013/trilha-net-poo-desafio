
namespace DesafioPOO.Models
{
    // Certifique-se de que a classe Smartphone está no mesmo namespace ou importada corretamente.
    public class Iphone : Smartphone
    {
        // Construtor da classe Iphone que chama o construtor da classe base Smartphone.
        public Iphone(string numero, string modelo, int armazenamento)
            : base(numero, modelo, "iOS", armazenamento)
        {
        }

        // Método para instalar aplicativos específico para a classe Iphone.
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no iPhone...");
        }
    }
}

















































// namespace DesafioPOO.Models
// {
//     // TODO: Herdar da classe "Smartphone"
//     public class Iphone
//     {
//         public class Iphone : Smartphone
//     {
        
//         public Iphone(string numero, string modelo, int armazenamento)
//             : base(numero, modelo, "Symbian", armazenamento);
        

//         public override void InstalarAplicativo(string nomeApp)
//         {
            
//             Console.WriteLine($"Instalando o aplicativo {nomeApp} no Nokia...");
//         }
//     }
// }

// }
