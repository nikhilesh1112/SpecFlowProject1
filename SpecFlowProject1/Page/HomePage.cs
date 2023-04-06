using OpenQA.Selenium;
using SpecFlowProject1.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject1.Page
{
    public class HomePage
    {
        private IWebDriver driver;
        public HomePage (IWebDriver driver)
        {
            this.driver = driver;
            
        }
        public HomePage Whenopenthewebsitepage()
        {
       
            driver.Url = "https://localhost:44315/";

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

             return new HomePage(driver);

        }
        }
   }

