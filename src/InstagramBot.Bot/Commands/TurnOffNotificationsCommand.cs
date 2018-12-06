using System.Threading.Tasks;
using InstagramBot.Bot.Extensions;
using OpenQA.Selenium;

namespace InstagramBot.Bot.Commands
{
    public class TurnOffNotificationsCommand : ICommand
    {
        public Task RunAsync(IWebDriver driver)
        {
            var element = driver.WaitLoadAsync(d => d.FindElement(By.XPath("//*[contains(text(), 'Not Now')]")));
            return element == null ? Task.CompletedTask : Task.Run(() => element.Click());
        }
    }
}