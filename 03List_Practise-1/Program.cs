namespace _03List_Practise_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            list.Add("Bülent Ersoy");
            list.Add("Ajda Pekkan");
            list.Add("Ebru Gündeş");
            list.Add("Hadise");
            list.Add("Hande Yener");
            list.Add("Tarkan");
            list.Add("Funda Arar");
            list.Add("Demet Akalın");

            Console.WriteLine("** Davetliler **");

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
