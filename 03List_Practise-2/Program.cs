namespace _03List_Practise_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kahve ismi giriniz (5 adet)");

            List<string> coffes = new List<string>();//Liste oluşturuldu

            for (int i = 0; i < 5; i++)//5 adet kahve ismi alındı
            {
                Console.Write($"Kahve {i+1} : ");
                coffes.Add(Console.ReadLine()); //Kullanıcıdan alınan kahve isimleri listeye eklendi
            }

            Console.WriteLine("Girilen Kahve isimleri:");

            foreach (var item in coffes)
            {
                Console.WriteLine(item); //Listedeki kahve isimleri ekrana yazdırıldı
            }   
        }
    }
}
