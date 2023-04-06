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

        [Then(@"enter the invalid email id '([^']*)'")]

        public void ThenEnterTheInvalidEmailId(string SendKeys)
        {

            invalidLogin = new InvalidLogin(driver);
            invalidLogin.ThenEnterTheInvalidEmailId(SendKeys);

        }

        [Then(@"enter the invalid password '([^']*)'")]
        public void ThenEnterTheInvalidPassword(string SendKeys)
        {
            invalidLogin = new InvalidLogin(driver);
            invalidLogin.ThenEnterTheInvalidPassword(SendKeys);
            
        }

        [Then(@"enter the email id '([^']*)'")]
        public void ThenEnterTheEmailId(string SendKeys2)
        {
            login = new Login(driver);
            login.ThenEnterTheEmailId(SendKeys2);
            
        }

        [Then(@"enter the password '([^']*)'")]
        public void ThenEnterThePassword(string SendKeys1)
        {
            login = new Login(driver);
            login.ThenEnterThePassword(SendKeys1);
            driver.Quit();
        }
    }
}
