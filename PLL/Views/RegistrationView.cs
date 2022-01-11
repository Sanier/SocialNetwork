using System;
using SocialNetwork.BLL.Models;
using SocialNetwork.BLL.Services;
using SocialNetwork.PLL.Helpers;

namespace SocialNetwork.PLL.Views
{
    public class RegistrationView
    {
        UserService userService;

        public RegistrationView(UserService userService)
        {
            this.userService = userService;
        }

        public void Show()
        {
            var userRegistrationData = new UserRegistrationData();

            Console.WriteLine("Для создания нового профиля введите ваше имя: ");
            userRegistrationData.FirstName = Console.ReadLine();

            Console.WriteLine("Ваша фамилия: ");
            userRegistrationData.LastName = Console.ReadLine();

            Console.WriteLine("Пароль (не менее 8 символов): ");
            userRegistrationData.Password = Console.ReadLine();

            Console.WriteLine("Почтовый адрес: ");
            userRegistrationData.Email = Console.ReadLine();

            try
            {
                this.userService.Register(userRegistrationData);

                SuccessMessage.Show("Ваш профиль успешно создан. Теперь вы можете войти в систему под своими учетными данными");
            }

            catch (ArgumentNullException)
            {
                AlertMessage.Show("Введите корректное значение!");
            }

            catch (Exception)
            {
                AlertMessage.Show("Произошла ошибка при регистрации");
            }
        }
    }
}
