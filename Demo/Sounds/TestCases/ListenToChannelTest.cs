using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using Sounds.PageObjects;
using System;

namespace Sounds.TestCases
{
    public class ListenToChannelTest
    {
        private IWebDriver driver;

        [Test]
        public void Test()
        {
            var LogIn = new LoginTest();
            LogIn.Test();
            var FirstChannel = new ListenLive();
            WebDriverWait RadioWait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement RadioWating = RadioWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.ClassName("radio-main")));
            PageFactory.InitElements(driver, FirstChannel);
            FirstChannel.OpenFirstChannel();
        }
    }
}
