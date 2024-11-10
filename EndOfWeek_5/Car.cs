using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndOfWeek_5
{
    public class Car
    {
        //Propertyleri tanımladık.
        public string productionYear { get; set; }
        public string productionNumber { get; set; }
        public string brand { get; set; }
        public string model { get; set; }
        public string color { get; set; }
        public string doorNumber { get; set; }

        public Car()
        {
            //Constructor oluşturduk.
            Console.WriteLine("Araba üretildi.");
            productionYear = DateTime.Now.Year.ToString(); //Şu anın yıl bilgisi alındı.
            productionNumber = Guid.NewGuid().ToString(); //Guid ile benzersiz bir id oluşturduk.
        }


}
}
