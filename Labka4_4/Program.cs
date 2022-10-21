namespace Labka4_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string KeyId = "";
            ApplicationLicense applicationLicense;
            Console.WriteLine("Введіть ключ пробного режиму чи платного");
            Console.WriteLine("\nКлюч платного режиму має містити 36 символів.");
            Console.WriteLine("\nКлюч пробного режиму має містити 16 символів.");
            Console.WriteLine("\n:");
            applicationLicense = new ApplicationLicense(Console.ReadLine());
        }
    }
}
