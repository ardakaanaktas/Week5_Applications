namespace EndOfWeek_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
        Start:
            Console.WriteLine("Araba üretimi yapıcak mısınız ? E/H");
            char choose = Console.ReadKey().KeyChar;
            Console.WriteLine();
            List<Car> cars = new List<Car>();
            if (choose == 'e'|| choose == 'E')
            {
                AddCar:
                Car car = new Car();
                DoorCount:
                Console.Write("Kapı sayısı giriniz: ");
                var doorNumber = Console.ReadLine();
                if (doorNumber == "2" || doorNumber == "4")
                {
                    car.doorNumber = doorNumber;
                }
                else
                {
                    Console.WriteLine("Kapı sayısı 2 veya 4 olmalıdır.");
                    goto DoorCount;//Kapı sayısı 2 veya 4 değilse kullanıcıdan tekrar kapı sayısını alıyoruz.
                }
                //Diğer Propertlerini kullanıcıdan alıyoruz.
                Console.Write("Marka giriniz: ");
                car.brand = Console.ReadLine();

                Console.Write("Model giriniz: ");
                car.model = Console.ReadLine();

                Console.Write("Renk giriniz: ");
                car.color = Console.ReadLine();

                cars.Add(car); //Oluşturulan araba nesnesini listeye ekliyoruz.
                Console.WriteLine("Başka araç üretmek ister misiniz ? E/H");
                choose = Console.ReadKey().KeyChar;
                if (choose == 'e' || choose == 'E')//Eğer kullanıcı başka araç üretmek isterse AddCar'a gidiyor.
                {
                    goto AddCar;
                }
            }
            else if (choose == 'h' || choose == 'H')//Eğer kullanıcı araç üretmek istemezse program sonlanıyor
            {
                Console.WriteLine("İyi günler dileriz.");
                goto End;
            }
            else
            {
                Console.WriteLine("Hatalı giriş yaptınız.");//Kullanıcı yanlış bir tuşa bastıysa başa dönüyor.
                goto Start;
            }

        End:
            Console.WriteLine("Üretilen araçlar: ");//Üretilen araçların bilgilerini yazdırıyoruz.
            foreach (var item in cars)
            {
                Console.WriteLine("Üretim yılı: " + item.productionYear);
                Console.WriteLine("Seri numarası: " + item.productionNumber);
                Console.WriteLine("Marka: " + item.brand);
                Console.WriteLine("Model: " + item.model);
                Console.WriteLine("Renk: " + item.color);
                Console.WriteLine("Kapı sayısı: " + item.doorNumber);
                Console.WriteLine("-------------------------------------------------");
            }
            Console.WriteLine("Program sonlandı.");

        }
    }
}
