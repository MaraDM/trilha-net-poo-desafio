namespace DesafioPOO.Models
{
    //Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) 
        : base (numero,modelo,imei,memoria){

            Console.WriteLine($"Numero:{numero}");
            Console.WriteLine($"Modelo:{modelo}");
            Console.WriteLine($"IMEI:{imei}");
            Console.WriteLine($"Memoria:{memoria}");

        }
        
        //Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp){

            Console.WriteLine($"Instalando {nomeApp} no Iphone...");

        }

    }
}