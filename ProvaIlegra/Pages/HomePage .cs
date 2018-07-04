using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaIlegra.Pages
{
    class HomePage
    {
        private IWebDriver WebDriver;

        public HomePage(IWebDriver WebDriver)
        {
            this.WebDriver = WebDriver;
        }

        public IWebElement GetOrdersButton()
        {
            return WebDriver.FindElement(By.ClassName("icon-list-ol"));
        }

        public void ClickOrdersButton()
        {
            GetOrdersButton().Click();
        }

        public IWebElement GetCreditSlipsButton()
        {
            return WebDriver.FindElement(By.ClassName("icon-ban-circle"));
        }

        public void ClickCreditSlipsButton()
        {
            GetCreditSlipsButton().Click();
        }

        public IWebElement GetMyAddressesButton()
        {
            return WebDriver.FindElement(By.ClassName("icon-building"));
        }

        public void ClickMyAddressesButton()
        {
            GetMyAddressesButton().Click();
        }

        public IWebElement GetPersonalInfoButton()
        {
            return WebDriver.FindElement(By.ClassName("icon-user"));
        }

        public void ClickPersonalInfoButton()
        {
            GetPersonalInfoButton().Click();
        }

        public IWebElement GetWishlistButton()
        {
            return WebDriver.FindElement(By.ClassName("icon-heart"));
        }

        public void ClickWishlistButton()
        {
            GetWishlistButton().Click();
        }

        public void ValidateWishlistPageLoad()
        {
            if (!WebDriver.Url.Contains("mywishlist"))
            {
                Assert.Fail("Something went wrong, please validate the Wishlist button functionality.");
            }
            else
            {
                Console.WriteLine("Wishlist Page accessed successfully");
            }
        }
    }
}
