



using System;

namespace DesafioPOO.Models
{
   
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, int armazenamento)
            : base(numero, modelo, "Symbian", armazenamento)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no Nokia...");
        }
    }
}
































// namespace DesafioPOO.Models
// {
    
//     public class Nokia : Smartphone
//     {
        
//         public Nokia(string numero, string modelo, int armazenamento)
//             : base(numero, modelo, "Symbian", armazenamento);
        

//         public override void InstalarAplicativo(string nomeApp)
//         {
            
//             Console.WriteLine($"Instalando o aplicativo {nomeApp} no Nokia...");
//         }
//     }
// }
