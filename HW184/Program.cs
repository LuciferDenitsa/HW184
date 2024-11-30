using HW184.Commands;
using HW184.Interfaces;
using HW184.Receivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;

namespace HW184
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите ссылку url нужного видеоролика");
            string url = Console.ReadLine();

            User user = new User();
            Ireceiver getDescription = new GetDescription(url);
            user.SetCommand(new GetDescriptionCommand(getDescription));
            user.RunCommand();

            Ireceiver download = new DownloadVideo(url);
            user.SetCommand(new DownloadCommand(download));
            user.RunCommand();

            Console.ReadKey();

        }
    }
}