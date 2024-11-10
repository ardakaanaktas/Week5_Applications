namespace _03Lists
{
    //Generic Listeler farklı veri tipleriyle dinamik olarak çalışabilmeyi sağlar. Dizilere göre daha esnek bir yapıya sahiptir.
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();//Boş bir int listesi tanımladık.
            numbers.Add(1);//Listeye eleman ekledik.
            numbers.Add(2);
            numbers.Add(3);

            foreach (var item in numbers)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            numbers.Insert(1, 10);//1. indexe 10 sayısını ekledik.

            bool isnumberExist  = numbers.Contains(10);//Listede 10 sayısı var mı kontrolü yapar. True ya da False döner.

            numbers.Remove(10);//Listeden 10 sayısını sildik.

            numbers.RemoveAt(0);//0. indexdeki elemanı sildik.

            numbers.Clear();//Listeyi temizledik.

            numbers.AddRange(new int[] { 1, 2, 3, 4, 5 });//Dizi elemanlarını listeye ekledik.

            foreach (var item in numbers)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            numbers.Sort();//Listeyi küçükten büyüğe sıralar.

            numbers.Reverse();//Listeyi tersine çevirir.

            foreach (var item in numbers)
            {
                Console.Write(item + " ");
            }
        }
    }
}
