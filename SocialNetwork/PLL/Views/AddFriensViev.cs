using SocialNetwork.BLL.Exceptions;
using SocialNetwork.BLL.Models;
using SocialNetwork.BLL.Services;
using SocialNetwork.PLL.Helpers;


namespace SocialNetwork.PLL.Views
{
    public class AddingFriendView
    {
        UserService userService;
        public AddingFriendView(UserService userService)
        {
            this.userService = userService;
        }
        public void Show(User user)
        {
            try
            {
                var userAddingFriendData = new UserAddingFriendData();

                Console.WriteLine("Введите почтовый адрес пользователя , которого хотите добавить в друзья ");

                userAddingFriendData.FriendEmail = Console.ReadLine();
                userAddingFriendData.UserId = user.Id;

                this.userService.AddFriend(userAddingFriendData);

                SuccessMessage.Show("Вы успешно добавили друга");
            }

            catch (UserNotFoundException)
            {
                AlertMessage.Show("Нет пользоваетля с данной почтой");
            }

            catch (Exception)
            {
                AlertMessage.Show("Произошла ошибка при добвлении в друзья");
            }

        }
    }
}