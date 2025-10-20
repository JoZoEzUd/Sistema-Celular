using DesafioPOO.Models;

 class Program
 {
    static void Main(string[] args )
    {
        Console.WriteLine("Smartphone Nokia:");
        Smartphone Nokia = new Nokia("1199999999", "Nokia Tijolao", "123456789", 32 );
        nokia.Ligar();
        nokia.InstalarAplicativo("WhatsApp");

        Console.WriteLine("\n ---------------------\n");

        Console.WriteLine("Smartphone Iphone:");
        Smartphone Iphone = new Iphone("11888888888", "Iphone 15", "987654321", 25);
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Tekegram");

    }
 }