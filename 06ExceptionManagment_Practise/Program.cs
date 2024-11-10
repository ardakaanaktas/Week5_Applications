namespace _06ExceptionManagment_Practise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Karesi alınacak sayıyı giriniz:");

            try
            {
                int number = Convert.ToInt32(Console.ReadLine());
                int result = number * number;
                Console.Write("Sonuç: "+result);
            }
            catch (Exception e)
            {
                Console.WriteLine("Geçersiz giriş! Lütfen bir sayı giriniz.");
            }
        }
    }
}
