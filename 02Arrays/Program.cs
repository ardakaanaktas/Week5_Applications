namespace _02Arrays
{
    //Diziler Sistemde sabit boyutlu alan kaplarlar.
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6 };//Dizi tanımlama mothodlarından biri
            int[] numbers_2 = new int[5];//5 elemanlı dizi tanımlama

            string[] fruits = { "Apple", "Banana", "Orange" };//String dizisi tanımlama 
            string[] fruits_2 = new string[] { "Apple", "Banana", "Orange" };// String dizisi tanımlama 

            //Console.WriteLine(fruits[0]);

            //foreach (var item in fruits)
            //{
            //    Console.WriteLine(item);
            //}

            //Rectangle dizi tanımlama
            int[,] matrix = new int[2, 3];

            int[,] matrix_2 = { { 1, 2, 3 }, { 4, 5, 6 } };

            //foreach (var item in matrix_2)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine(matrix_2[1,1]);
            //matrix_2[1, 1] = 10;
            //Console.WriteLine(matrix_2[1,1]);

            //Jagged Array Tanımlama
            int[][] jaggedArray = new int[3][];//3 elemanlı bir dizi tanımladık
            jaggedArray[0] = new int[5] { 1, 2 ,3,4,5};
            jaggedArray[1] = new int[3] { 6, 7, 8 };
            jaggedArray[2] = new int[2] { 9, 10 };

            foreach (var item in jaggedArray)
            {

                foreach (var item2 in item)
                {
                    Console.WriteLine(item2);
                }
            }
        }
    }
}
