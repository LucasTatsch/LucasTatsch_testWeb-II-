using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaIlegra.Pages
{
    class WishlistPage
    {
        private IWebDriver WebDriver;

        public WishlistPage(IWebDriver WebDriver)
        {
            this.WebDriver = WebDriver;
        }

        public IWebElement GetNameHyperText()
        {
            return WebDriver.FindElement(By.XPath("//tr[@id='wishlist_4437']/td/a[contains(text(),'My wishlist')]"));
        }

        public void ClickNameHyperText()
        {
            GetNameHyperText().Click();
        }

        public IWebElement ObtainProductName()
        {
            return WebDriver.FindElement(By.Id("s_title"));
        }
        public void ValidateItemOnWishlist()
        {
            if (!ObtainProductName().Enabled)
            {
                Assert.Fail("Your Wishlist is empty");
            }
            else
            {
                Console.WriteLine("Your Wishlist has an Item" + ObtainProductName().GetAttribute("text"));
            }
        }
    }
}
