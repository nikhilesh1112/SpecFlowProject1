using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V109.Emulation;
using SpecFlowProject1.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject1.Page
{
    public class Searching_items
    {

      private IWebDriver driver;
       

        By brand = By.XPath("//*[@id=\"CatalogModel_BrandFilterApplied\"]");

        By Brand_options = By.XPath("//*[@id=\"CatalogModel_BrandFilterApplied\"]/option[2]");

        By types = By.XPath("//*[@id=\"CatalogModel_TypesFilterApplied\"]");

        By types_option = By.XPath("//*[@id=\"CatalogModel_TypesFilterApplied\"]/option[2]");

        By search = By.XPath("/html/body/div/section[2]/div/form/input");

        //Searching_items2

       By brand1 = By.XPath("//*[@id='CatalogModel_BrandFilterApplied']");

        By Brand_options1 = By.XPath("//*[@value='2']");

        By types1 = By.XPath("//*[@id='CatalogModel_TypesFilterApplied']");

        By types_option1 = By.XPath("(//option[@value='2'])[2]");

        By search1 = By.XPath("//*[@class='esh-catalog-send']");

        //searching_item3

        By brand2 = By.XPath("//*[@id='CatalogModel_BrandFilterApplied']");

        By Brand_options2 = By.XPath("//*[@value='2']");
        
          By types2 = By.XPath("//*[@id='CatalogModel_TypesFilterApplied']");

        By types_option2 = By.XPath("(//option[@value='3'])[2]");

        By search2 = By.XPath("//*[@class='esh-catalog-send']");


       


        public Searching_items(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void  ThenSelectingTheItem()
        {

            driver.FindElement(brand).Click();
           

            driver.FindElement(Brand_options).Click();
            

            driver.FindElement(types).Click();
          

            driver.FindElement(types_option).Click();
           

           
            driver.FindElement(search).Click();
           
            
        }

        public void ThenSelectingTheItem2()
        {

            driver.FindElement(brand1).Click();
            

            driver.FindElement(Brand_options1).Click();
           

            driver.FindElement(types1).Click();
           

            driver.FindElement(types_option1).Click();
           

            driver.FindElement(search1).Click();
         

        }

        public Searching_items ThenSelectingTheItem3()
        {

            driver.FindElement(brand2).Click();
           
            driver.FindElement(Brand_options2).Click();

            driver.FindElement(types2).Click();
           
            driver.FindElement(types_option2).Click();
          
            driver.FindElement(search2).Click();
            return new Searching_items(driver);
        }

        
    }

}
