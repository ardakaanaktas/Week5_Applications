namespace IMDB_Application
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Movies> movies = new List<Movies>();//Movies sınıfından oluşan listemiz. Boyutu belirlenmedi.
            
            bool user_choose = true;//Kullanıcının filme eklemeye devam edip etmeyeceğini belirleyen değişken.


            while (user_choose)
            {
                Movies movie = new Movies();//Movies sınıfından bir nesne oluşturduk. Her movie nesnesi bir filmi temsil edecek.Birbirinden bağımsız türetilmiş olucaklar.

                Console.Write("Film adı giriniz: ");
                movie.movieName = Console.ReadLine();//Kullanıcıdan film adını alıyoruz.

                Console.Write("IMDb Puanı giriniz: ");
                movie.movieRating = Convert.ToDouble(Console.ReadLine());//Kullanıcıdan IMDb puanını alıyoruz.

                movies.Add(movie);//Oluşturduğumuz nesneyi listeye ekliyoruz.

                Console.WriteLine("Film eklemeye devam etmek istiyor musunuz (evet = 1 | hayır = 0) ? ");
                user_choose = Convert.ToBoolean(Convert.ToInt32(Console.ReadLine()));//Kullanıcıdan devam edip etmeyeceğini alıyoruz.
            }

            //Tüm Filmmerli listeledik.
            Console.WriteLine("** Tüm Filmler **");
            foreach (var item in movies)
            {
                Console.WriteLine("Film Adı: " + item.movieName + " IMDb Puanı: " + item.movieRating);//Listedeki filmleri ekrana yazdırıyoruz.
            }
            Console.WriteLine("-----------");

            //IMDb puanı 4.0 ve 9.0 arasında olan filmleri listeledik.
            Console.WriteLine("** IMDb Puanı 4.0 ve 9.0 Arasındaki Filmler **");
            foreach (var item in movies)
            {
                if (item.movieRating >= 4.0 && item.movieRating <= 9.0)
                {
                    Console.WriteLine("Film Adı: " + item.movieName + " IMDb Puanı: " + item.movieRating);//IMDb puanı 4.0 ve 9.0 arasındaki filmleri ekrana yazdırıyoruz.
                }
            }
            Console.WriteLine("-----------");

            //Film adı "A" ile başlayan filmleri listeledik.
            Console.WriteLine("** A ile Başlayan Filmler **");
            foreach (var item in movies)
            {
                if (item.movieName.StartsWith("A")) //StartsWith metodu ile film adının "A" ile başlayıp başlamadığını kontrol ediyoruz.
                {
                    Console.WriteLine("Film Adı: " + item.movieName + " IMDb Puanı: " + item.movieRating);//Film adı "A" ile başlayan filmleri ekrana yazdırıyoruz.
                }
            }
            Console.WriteLine("-----------");


        }
    }
}
