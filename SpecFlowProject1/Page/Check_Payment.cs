using AventStack.ExtentReports.Gherkin.Model;
using Humanizer.Localisation;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SpecFlowProject1.Page
{
    public class Check_Payment
    {
        private IWebDriver driver;


       
        By checkout = By.XPath("(//*[@class='btn esh-basket-checkout'])[2]");
       
        By Payment  = By.XPath("(//*[@class='btn esh-basket-checkout'])[1]");
        By c_order = By.CssSelector("div.container h1");
        public Check_Payment(IWebDriver driver)
        {
            this.driver = driver;
        }

        public Check_Payment check_Payment1()
        {
            ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollTo(0,document.body.scrollHeight)");

            Thread.Sleep(1000);


            driver.FindElement(checkout).Click();
            
            ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollTo(0,document.body.scrollHeight)");

            Thread.Sleep(1000);

            driver.FindElement(Payment).Click();

            string expectedMessage = driver.FindElement(c_order).Text;
            string C_msg = "Thanks for your Order!";
            Assert.AreEqual(expectedMessage, C_msg);

            return new Check_Payment(driver);
        }
    }
}
