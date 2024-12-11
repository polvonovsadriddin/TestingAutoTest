using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
namespace SeleniumProjectTest
{
    [TestFixture]
    public class Tests
    {
        IWebDriver wepDriver = new ChromeDriver();

        [TestCase]
        public void ButtonVisible()
        {
            wepDriver.Url = "https://karofilm.ru/";
            IWebElement button = wepDriver.FindElement(By.XPath(""));
            Assert.AreEqual(false, button.Displayed);
        }

        [TestCase]
        public void ToLogin()
        {
            wepDriver.Url = "https://karofilm.ru/";
            IWebElement login = wepDriver.FindElement(By.XPath("/html/body/app-root/div[1]/karo-header/header/nav/ul/li[1]/a"));
            login.Click();
        }
        [TestCase]
        public void SearchFilm()
        {
            wepDriver.Url = "https://karofilm.ru/";
            IWebElement poisk = wepDriver.FindElement(By.XPath("/html/body/app-root/div[1]/div/app-page/app-block-builder/app-builder-page-filter/div/builder-search/div/input"));
            poisk.SendKeys("Дикий Алмаз");
        }
        [TestCase]
        public void Egree()
        {
            wepDriver.Url = "https://karofilm.ru/";
            IWebElement theatre = wepDriver.FindElement(By.XPath("/html/body/app-root/div[1]/karo-header/header/nav/div[2]/app-smart-menu/ul/li[2]/a"));
            theatre.Click();
        }
        [TestCase]
        public void Autoriz()
        {
            wepDriver.Url = "https://karofilm.ru/";
            IWebElement ButForEnter = wepDriver.FindElement(By.XPath("//*[@id=\"Vector\"]"));
            IWebElement email = wepDriver.FindElement(By.XPath("//*[@id=\"login-json-form-id\"]"));
            IWebElement password = wepDriver.FindElement(By.XPath("//*[@id=\"password-json-form-id\"]"));
            IWebElement enterbut = wepDriver.FindElement(By.XPath("/html/body/app-root/div[1]/app-modal/div/div[2]/ng-component/app-login/app-json-form/form/div[5]/button"));
            ButForEnter.Click();
            email.SendKeys("sadriddinpolvonov01@gmail.com");
            password.SendKeys("2005yilman");
            enterbut.Click();
        }
    }
}