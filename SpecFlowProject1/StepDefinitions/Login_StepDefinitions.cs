using OpenQA.Selenium;
using SpecFlowProject1.Page;
using SpecFlowProject1.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject1.StepDefinitions
{
    internal class Login_StepDefinitions
    {
        private IWebDriver driver;

        private InvalidLogin invalidLogin;
        private Login login;
        public Login_StepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
        }

        [Then(@"Click login")]
        public void ThenClickLogin()
        {
            login = new Login(driver);

            login.ClickLogin();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        [Then(@"Invalid login")]
        public void ThenInvalidLogin()
        {
            invalidLogin = new InvalidLogin(driver);

            invalidLogin.ClickLogin();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

    }
}

