namespace _05Stack
{
    internal class Program
    {
        //FİFO (First in first out) ve LİFO (Last in first out) yapısını destekler.
        //Queue yapısına benzer. Fakat Queue'da ilk giren ilk çıkar. Stack'te ise son giren ilk çıkar.
        //Bellek optimizasyonu sağlar.
        static void Main(string[] args)
        {
            //Kuyruk oluşturma 
            Console.WriteLine("** Queue **");

            Queue<string> queue = new Queue<string>();

            //Kuyruğa eleman ekleme
            queue.Enqueue("Arda");
            queue.Enqueue("Büşra");
            queue.Enqueue("Cemre");
            queue.Enqueue("Deniz");
            queue.Enqueue("Emre");
            queue.Enqueue("Semih");

            //Kuyruktan eleman çıkarma. İlk giren ilk çıkar.
            Console.WriteLine(queue.Dequeue()); // İlk giren Arda çıkar.
            Console.WriteLine("--------");

            //Kuyruktan eleman çıkarmadan ilk elamanı görüntüleme yöntemi.
            Console.WriteLine(queue.Peek()); // Arda çıktığı için Büşra olucaktır.
            Console.WriteLine("--------");

            //Kuyruğun eleman sayısını gösterme
            Console.WriteLine(queue.Count); // 5
            Console.WriteLine("--------");

            //Kuyruğun elemanlarını diziye aktarma
            string[] queueArray = queue.ToArray();

            //Kuyruğun elemanlarını ekrana yazdırma
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("--------");

            //Stack oluşturma
            Console.WriteLine("** Stack **");
            Stack<string> stack = new Stack<string>();

            //Stack'e eleman ekleme
            stack.Push("Arda");
            stack.Push("Büşra");
            stack.Push("Cemre");

            //Stack elemanlarını yazdırma
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("--------");


            //Stack'ten eleman çıkarma. Son giren ilk çıkar.
            stack.Pop(); // Cemre çıkar.

            //Stack'ten eleman çıkarmadan ilk elemanı görüntüleme yöntemi.
            Console.WriteLine(stack.Peek()); //Cemre çıktığı için Büşra olucaktır.
            Console.WriteLine("--------");


            //Stack'in eleman sayısını gösterme
            Console.WriteLine("Eleman Sayısı: "+ stack.Count);

            Console.WriteLine("--------");

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

            //LinkedList yapısı oluşturma.
            Console.WriteLine("** Linked List **");
            LinkedList<string> linkedList = new LinkedList<string>();

            //LinkedList'e sondan eleman ekleme
            linkedList.AddLast("Elma");
            linkedList.AddLast("Armut");
            linkedList.AddLast("Muz");

            //LinkedList'te görüntüleme
            foreach (var item in linkedList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("--------");

            //Bu sefer başına ekleme yapalım.
            linkedList.AddFirst("Kivi");

            //Tekrardan yazırdma işlemi yapalım
            foreach (var item in linkedList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("--------");


            //Yenbi integer tipi bulunduran bir linked list oluşturalım.

            LinkedList<int> int_list = new LinkedList<int>();

            //LinkedList'e eleman ekleme
            int_list.AddLast(1);
            int_list.AddLast(2);
            int_list.AddLast(3);


            //LinkedList'te node yöntemi ile görüntüleme. İlk node'u referans alıyoruz. Bu node value, next, prev gibi referansları taşır.
            LinkedListNode<int> node = int_list.First;
            Console.WriteLine(node); //Yazdırıldığında sadece tipi gösterilir. Herhangi bir değer gösterilmez.

            while (node != null) // İlerleme yapılırken eni bir node kalmadığı sürece sonraki node'a geçiş yapılıyor
            {
                Console.WriteLine(node.Value); // Value ile node'un değeri yazdırılır.
                node = node.Next; // Next ile bir sonraki node'a geçiş yapılır.
            }
            Console.WriteLine("--------");


            //LinkedList'te node yöntemi ile sondan başa doğru görüntüleme.
            LinkedListNode<int> last_node = int_list.Last; // Son node'u referans alıyoruz.

            while (last_node != null)
            {
                Console.WriteLine(last_node.Value); // Value ile node'un değeri yazdırılır.
                last_node = last_node.Previous; // Previous ile bir önceki node'a geçiş yapılır.
            }
            Console.WriteLine("--------");

        }
    }
}
