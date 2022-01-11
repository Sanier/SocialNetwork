using System;
using System.Collections.Generic;
using System.Linq;
using SocialNetwork.BLL.Models;

namespace SocialNetwork.PLL.Views
{
    public class UserIncomingMessageView
    {
        public void Show(IEnumerable<Message> incomingMessage)
        {
            Console.WriteLine("Входящие сообщения: ");

            if (incomingMessage.Count() == 0)
            {
                Console.WriteLine("Вам никто не пишет. Смиритесь");
                Console.WriteLine("");
                return;
            }

            incomingMessage.ToList().ForEach(message =>
            {
                Console.WriteLine("От кого: {0}. Текст сообщения: {1}", message.SenderEmail, message.Content);
                Console.WriteLine("");
            });
        }
    }
}
