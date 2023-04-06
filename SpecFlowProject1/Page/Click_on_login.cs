using OpenQA.Selenium;
using SpecFlowProject1.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject1.Page
{
    public class Click_on_login
    {
        private IWebDriver driver;
        By application_login = By.XPath("/html/body/div/header/div/article/section[2]/div/section/div/a");
      
        public Click_on_login(IWebDriver driver)
        {
            this.driver = driver;
        }
        public Click_on_login Thenclickonloginpage()
        {

            driver.FindElement(application_login).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            return new Click_on_login(driver);
        }

       
    }
}
