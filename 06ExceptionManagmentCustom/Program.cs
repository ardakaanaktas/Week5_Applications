namespace _06ExceptionManagmentCustom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User();

            try
            {
                user.setAge(19);// Hata fırlatılacak
            }
            catch (InvalidAgeException e)//Hata yakalanacak
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
