namespace _04Dictionary
{
    internal class Program
    {
        // Dictionary tanımlama -> Key: int, Value: string yapısı bulunmaktadır.
        //Listlere göre daha hızlı çalışmaktadır.
        static void Main(string[] args)
        {
            Dictionary<int, string> students = new Dictionary<int, string>();

            // Öğrenci ekleme -> Key : Öğrenci numarası (unique), Value : Öğrenci adı
            students.Add(706, "Arda");
            students.Add(707, "Büşra");
            students.Add(708, "Cemre");
            students.Add(709, "Deniz");
            students.Add(710, "Emre");

            // Öğrenci listeleme
            foreach (var student in students)
            {
                Console.WriteLine($"Öğrenci Numarası: {student.Key} - Öğrenci Adı: {student.Value}"); // Key ve Value değerlerini ekrana yazdırma
            }

            students.Remove(708); // Öğrenci silme (Cemre)

            Console.WriteLine("Öğrenci silindikten sonra");

            foreach (var student in students)
            {
                Console.WriteLine($"Öğrenci Numarası: {student.Key} - Öğrenci Adı: {student.Value}"); // Key ve Value değerlerini ekrana yazdırma
            }

            //Dictionary içerisinde var olan bir key'e ait value değerini değiştirme işlemi
            //students[709] = "Derya"; -> Değişimi yapıcaktır.

            //Var olan bir indexe yeni bir öğrenci eklemek istenirse add methodu exception fırlatıcaktır.
            //students.Add(709, "Derya"); -> Hata fırlatır.

            //Bu durumdan kaçınmak için daha önceden o key var olup olmadığı sorgulamasıdır.
            if (students.ContainsKey(709))
            {
                students[709] = "Derya";
            }
            else
            {
                students.Add(709, "Derya");
            }

            Console.WriteLine("Öğrenci adı değiştirildikten sonra");

            foreach (var student in students)
            {
                Console.WriteLine($"Öğrenci Numarası: {student.Key} - Öğrenci Adı: {student.Value}"); // Key ve Value değerlerini ekrana yazdırma
            }

            //Dictionary içerisinde key verisinde göre silme işlemi
            students.Remove(709);

            Console.WriteLine("709 numaralı öğrenci ayrıldı.");
            foreach (var student in students)
            {
                Console.WriteLine($"Öğrenci Numarası: {student.Key} - Öğrenci Adı: {student.Value}"); // Key ve Value değerlerini ekrana yazdırma
            }

            //KeyValuePair methodu ile yazdırma işlemi
            Console.WriteLine("KeyValuePair ile yazdırma işlemi");
            foreach (KeyValuePair<int, string> student in students)
            {
                Console.WriteLine($"Öğrenci Numarası: {student.Key} - Öğrenci Adı: {student.Value}"); // Key ve Value değerlerini ekrana yazdırma
            }

        }
    }
}
