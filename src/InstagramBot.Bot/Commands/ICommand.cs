using System.Threading.Tasks;
using OpenQA.Selenium;

namespace InstagramBot.Bot.Commands
{
    public interface ICommand
    {
        Task RunAsync(IWebDriver driver);
    }
}