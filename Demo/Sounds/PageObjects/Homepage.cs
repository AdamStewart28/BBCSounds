using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;


namespace Sounds.PageObjects
{
    public class HomePageLogin
    {
        private readonly IWebDriver driver;

        [FindsBy(How = How.Id, Using = "idcta-username")]
        public IWebElement Login { get; set; }

        public void OpenLogin()
        {
            Login.Click();
        }
    }

    public class EnterCredentials
    {
        private readonly IWebDriver driver;

        [FindsBy(How = How.Id, Using = "user-identifier-input")]
        public IWebElement Username { get; set; }

        [FindsBy(How = How.Id, Using = "password-input")]
        public IWebElement Password { get; set; }

        [FindsBy(How = How.Id, Using = "submit-button")]
        public IWebElement Submit { get; set; }

        public void LogIntoApplication()
        {
            Username.Click();
            Username.SendKeys("adamstewart2804@gmail.com");
            Password.SendKeys("automation!");
            Submit.Click();
        }
    }

    public class ListenLive
    {
        private readonly IWebDriver driver;

        [FindsBy(How = How.CssSelector, Using = "[href*='/sounds/stations']")]
        public IWebElement FirstChannel { get; set; }

        public void OpenFirstChannel()
        {
            FirstChannel.Click();
        }
    }
}
