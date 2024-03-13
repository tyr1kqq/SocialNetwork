using SocialNetwork.BLL.Models;
using SocialNetwork.BLL.Services;

namespace SocialNetwork
{
    internal class Program
    {

        public static UserService userService = new UserService();
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Добро пожаловать в социальную сеть.");
                Console.WriteLine("Для регистрации введите имя пользователя:");

                string firstName = Console.ReadLine();

                Console.Write("Фамилия: ");
                string lastName = Console.ReadLine();

                Console.Write("пароль: ");
                string password = Console.ReadLine();

                Console.Write("почтовый адресс: ");
                string email = Console.ReadLine();

                UserRegistrationData userRegistrationData = new UserRegistrationData()
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Password = password,
                    Email = email,
                };

                try
                {
                    userService.Register(userRegistrationData);
                    Console.WriteLine("Регистрация произошла успешно.");
                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine("Введите корректное значение.");
                }
                catch (Exception)
                {
                    Console.WriteLine("Произошла ошибка при регистрации.");
                }

                Console.ReadLine();
            
            }
           
        }
    }
}
    