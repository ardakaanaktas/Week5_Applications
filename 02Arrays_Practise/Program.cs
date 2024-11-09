namespace _02Arrays_Practise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 - 10 adet tam sayı verisi alacak bir dizi tanımlayınız.
            int[] numbers = new int[10];

            //2 - Bu dizinin elemanlarını bir for döngüsü ile doldurup, foreach döngüsü ile tekrar ekrana yazınız.
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i + 1;//indexin 1 fazlasını atayarak dizi elemanlarını doldurduk.
            }

            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-----------------------");
            //3 - Bu diziye kullanıcıdan alınan yeni bir değeri ekleyiniz (11. eleman olarak)
            Console.WriteLine("Enter a number to add to the array: ");
            int newNumber = Convert.ToInt32(Console.ReadLine());
            Array.Resize(ref numbers, numbers.Length + 1);//Eleman sayısını 1 arttırdık.
            numbers[numbers.Length - 1] = newNumber;//11. elemeanı son indexe atadık.

            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }

            //4 - Bu diziyi büyükten küçüğe ekrana yazdırınız.
            Console.WriteLine("-----------------------");
            Array.Sort(numbers); //Dizi elemanlarını küçükten büyüğe sıraladık.
            Array.Reverse(numbers); //Dizi elemanlarını büyükten küçüğe sıraladık.

            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
        }
    }
}
