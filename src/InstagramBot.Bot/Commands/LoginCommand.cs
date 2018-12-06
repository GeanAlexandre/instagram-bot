using System.Threading.Tasks;
using OpenQA.Selenium;

namespace InstagramBot.Bot.Commands
{
    public class LoginCommand : ICommand
    {
        private string Username { get; }
        private string Password { get; }
        
        public LoginCommand(string username, string password)
        {
            Username = username;
            Password = password;
        }
        
        public Task RunAsync(IWebDriver driver)
        {
            driver.Navigate().GoToUrl("https://www.instagram.com/accounts/login/?hl=en&source=auth_switcher");
            driver.FindElement(By.Name("username")).SendKeys(Username);
            driver.FindElement(By.Name("password")).SendKeys(Password);
            driver.FindElement(By.XPath( "//*[contains(text(), 'Log in')]")).Submit();
            return Task.CompletedTask;
        }
    }
}