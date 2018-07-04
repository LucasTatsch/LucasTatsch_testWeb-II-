using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaIlegra.Workflows
{
    class LoginWF
    {
        private LoginPage LoginPage;
        private IWebDriver WebDriver;

        public LoginWF(IWebDriver WebDriver)
        {
            this.WebDriver = WebDriver;
            this.LoginPage = new LoginPage(WebDriver);
        }
        
        public void Login()
        {
            LoginPage.SetUsernameText("lucas_test@test.com");
            LoginPage.SetPasswordText("test123");
            LoginPage.ClickLoginButton();
            LoginPage.ValidateLogin();
        }
    }
         
}