using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06ExceptionManagmentCustom
{
    public class User
    {
        public void setAge(int age)
        {
            if (age < 0)
            {
                throw new InvalidAgeException("Age can not be less than 0");
            }
            throw new Exception("Genel bir hata alındı.");
        }
    }

    public class  InvalidAgeException :Exception
    {
        public InvalidAgeException(string message) : base(message) //Exception Ana sınıfına geçirmemizi sağladı.
        {

        }
    }
}
