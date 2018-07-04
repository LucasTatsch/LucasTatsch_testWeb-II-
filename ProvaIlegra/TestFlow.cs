using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using ProvaIlegra.Workflows;

namespace ProvaIlegra
{
    [TestClass]
    public class TestFlow
    {
        private MenuPageWF MenuPageWF;
        private LoginWF LoginWF;
        private HomePageWF HomePageWF;
        private WishlistWF WishlistWF;
        Actions action;
        
        ChromeDriver ChromeDriver;
        public TestFlow()
        {
            ChromeDriver = new ChromeDriver();
            MenuPageWF = new MenuPageWF(ChromeDriver);
            LoginWF = new LoginWF(ChromeDriver);
            WishlistWF = new WishlistWF(ChromeDriver);
            HomePageWF = new HomePageWF(ChromeDriver);
            action = new Actions(ChromeDriver);
        }

        [TestMethod]
        public void LogoffApplication()
        {
            ChromeDriver.Url = "http://automationpractice.com/index.php?controller=authentication&back=my-account";
            ChromeDriver.Manage().Window.Maximize();
            LoginWF.Login();
            HomePageWF.ValidateWishlistPopulation();
            WishlistWF.ValidateWishlistPopulation();
            action.SendKeys(OpenQA.Selenium.Keys.PageDown).Build().Perform();
            Thread.Sleep(2000);
            MenuPageWF.Logoff();
            Thread.Sleep(1000);
            ChromeDriver.Close();
        }
    }
}
