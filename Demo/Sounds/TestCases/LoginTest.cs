using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using Sounds.PageObjects;
using System;

namespace Sounds.TestCases
{
    public class LoginTest
    {
        [Test]
        public void Test()
        {
            // Opening the browser to the specified server
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.bbc.co.uk/sounds");

            // Clicking sign in link 
            var OpenSignin = new HomePageLogin();
            PageFactory.InitElements(driver, OpenSignin);
            OpenSignin.OpenLogin();

            // Entering credentials and signing in
            WebDriverWait EnterCredentialsWait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement EnterLoginCredentials = EnterCredentialsWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("username")));
            var LoggingIn = new EnterCredentials();
            PageFactory.InitElements(driver, LoggingIn);
            LoggingIn.LogIntoApplication();

            // Checking the user has signed in 
            var ValidateYourAccount = driver.FindElement(By.Id("idcta-username"));
            Assert.IsTrue(ValidateYourAccount.Text.Contains("Your account"));
            
        }
    }
}
