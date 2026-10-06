namespace Program
{
    public class Program
    {
        static void Main(string[] args)
        {
            Szerviz szerviz = new Szerviz();

            Jarmu auto1 = new VersenyAuto("Fiat", 26, 1550,100, 69);
            Console.WriteLine(auto1.InformaciotAd());
        }
    }
}
