using OpenQA.Selenium;
using ProvaIlegra.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaIlegra.Workflows
{
    class MenuPageWF
    {
        private MenuPage MenuPage;            
        private IWebDriver WebDriver;

        public MenuPageWF(IWebDriver WebDriver)
        {
            this.WebDriver = WebDriver;
            this.MenuPage = new MenuPage(WebDriver);
        }

        public void Logoff()
        {
            MenuPage.ClickLogoutButton();
            MenuPage.ValidateLogout();
        }
    }
}
