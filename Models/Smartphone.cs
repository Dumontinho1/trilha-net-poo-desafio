namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        // Propriedades conforme o diagrama
        public string Numero { get; set; }
        public string Modelo { get; private set; } // Propriedade com apenas getter público
        public string IMEI { get; private set; } // Propriedade com apenas getter público
        public int Memoria { get; private set; } // Propriedade com apenas getter público

        // Construtor
        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        // Métodos conforme o diagrama
        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        // Método abstrato
        public abstract void InstalarAplicativo(string nomeApp);
    }
}
