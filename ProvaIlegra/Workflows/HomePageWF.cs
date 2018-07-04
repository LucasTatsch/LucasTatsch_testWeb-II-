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
    class HomePageWF
    {
        private HomePage HomePage;            
        private IWebDriver WebDriver;

        public HomePageWF(IWebDriver WebDriver)
        {
            this.WebDriver = WebDriver;
            this.HomePage = new HomePage(WebDriver);
        }

        public void ValidateWishlistPopulation()
        {
            HomePage.ClickWishlistButton();
            Thread.Sleep(2000);
            HomePage.ValidateWishlistPageLoad();
        }

    }
}
