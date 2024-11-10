namespace _06ExceptionManagment
{
    internal class Program
    {
        //Hata yönetimi için try-catch ve finnaly blokları kullanılır.
        static void Main(string[] args)
        {

            //Hatanın oluşma ihtimali olan bloğu burada try ile oluşturuyoruz.
            try
            {
                //Hata oluşturacak kodlar buraya yazılır.
                int a = 10;
                int b = 0;
                int c = a / b;//Hata oluşturacak kod. Sıfıra bölme hatası oluşacak.
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Sıfıra Bölme Hatası");
            }
            finally //Zorunlu değildir. İşlem tamamlandığında çalışacak kodlar buraya yazılır.
            {
                Console.WriteLine("İşlem tamamlandı.");
            }
        }
    }
}
