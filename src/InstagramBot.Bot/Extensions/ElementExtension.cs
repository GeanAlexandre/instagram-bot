using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace InstagramBot.Bot.Extensions
{
    public static class ElementExtension
    {
        public static IWebElement WaitLoadAsync(this IWebDriver driver, Func<IWebDriver,IWebElement> getElement)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            return wait.Until(getElement);
        }
    }
}