using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaIlegra.Pages
{
    class ProductPage
    {
        private IWebDriver WebDriver;

        public ProductPage(IWebDriver WebDriver)
        {
            this.WebDriver = WebDriver;
        }

        public IWebElement GetAddToWishlistButton()
        {
            return WebDriver.FindElement(By.Id("wishlist_button"));
        }

        public void ClickAddToWishlistButton()
        {
            GetAddToWishlistButton().Click();
        }

        public IWebElement ValidateAddWarning()
        {
            return WebDriver.FindElement(By.ClassName("fancybox-error")); 
        }

    }
}
