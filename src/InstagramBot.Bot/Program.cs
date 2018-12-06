using System;
using InstagramBot.Bot.Commands;
using OpenQA.Selenium.Chrome;

namespace InstagramBot.Bot
{
    class Program
    {
        static void Main(string[] args)
        {
            var driver = new ChromeDriver(@"C:\Users\geana\dev\InstagramBot\src\InstagramBot.Bot\Drivers");
                
            new LoginCommand(Console.ReadLine(), Console.ReadLine()).RunAsync(driver).GetAwaiter().GetResult();
            new TurnOffNotificationsCommand().RunAsync(driver).GetAwaiter().GetResult();
        }
    }
}
