namespace DesafioPOO.Models
{
    // A classe Nokia herda da classe Smartphone
    public class Nokia : Smartphone
    {
        // Construtor que utiliza o construtor da classe base
        public Nokia(string numero, string modelo, string imei, int memoria)
            : base(numero, modelo, imei, memoria)
        {
        }

        // Sobrescrevendo o método abstrato
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo '{nomeApp}' no Nokia...");
        }
    }
}
