using System;
using System.Collections.Generic;
using System.Linq;
using SocialNetwork.BLL.Models;

namespace SocialNetwork.PLL.Views
{
    public class UserFriendView
    {
        public void Show(IEnumerable<User> friends)
        {
            Console.WriteLine("Мои друзья: ");

            if (friends.Count() == 0)
            {
                Console.WriteLine("Вы одиноки");
                Console.WriteLine("");
                return;
            }

            friends.ToList().ForEach(friends =>
            {
                Console.WriteLine("Почтовый адрес друга {0}. Имя друга {1}. Фамилия друга {2}", friends.Email, friends.FirstName, friends.LastName);
                Console.WriteLine("");
            });
        }
    }
}
