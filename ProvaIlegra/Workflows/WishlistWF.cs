using OpenQA.Selenium;
using ProvaIlegra.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProvaIlegra.Workflows
{
    class WishlistWF
    {
        private WishlistPage WishlistPage;            
        private IWebDriver WebDriver;

        public WishlistWF(IWebDriver WebDriver)
        {
            this.WebDriver = WebDriver;
            this.WishlistPage = new WishlistPage(WebDriver);
        }

        public void ValidateWishlistPopulation()
        {
            WishlistPage.ClickNameHyperText();
            Thread.Sleep(2000);
            WishlistPage.ValidateItemOnWishlist();
        }
    }
}
