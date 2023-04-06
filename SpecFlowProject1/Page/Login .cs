using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SpecFlowProject1.Page;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace SpecFlowProject1.Pages
{
    public class Login
    {
        private IWebDriver driver;
        By login = By.XPath("//*[@id=\"Input_Email\"]");
        By pass = By.XPath("//*[@id=\"Input_Password\"]");
        By Click_login = By.XPath("/html/body/div/div/div/div/section/form/div[5]/button");
        

        public Login(IWebDriver driver)
        {
            this.driver = driver;
        }

       

        [Then(@"enter the invalid email id '([^']*)'")]
        public void ThenEnterTheEmailId(string text)
        {
            driver.FindElement(login).SendKeys(text);

        }

        [Then(@"enter the invalid password '([^']*)'")]
        public void ThenEnterThePassword(string text)
        {
            driver.FindElement(pass).SendKeys(text);
             driver.FindElement(Click_login).Click();

            
        }
        public Searching_items ClickLogin()
        {
            driver.FindElement(Click_login).Click();

            string email = driver.FindElement(By.XPath("(//img[@class='esh-identity-image'])[1]/parent::section/div")).Text;

            if (email != "LOGIN")
            {
                Console.WriteLine("Valid Login");
            }

            return new Searching_items(driver);
        }










    }


}
