using DesafioPOO.Models;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Teste com o Nokia:");
        // Instanciando um Nokia
        Nokia nokia = new Nokia("11999999999", "Nokia 3310", "123456789", 64);
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("WhatsApp");

        Console.WriteLine("\nTeste com o iPhone:");
        // Instanciando um iPhone
        Iphone iphone = new Iphone("11988888888", "iPhone 13", "987654321", 256);
        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Instagram");
    }
}
