using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject1.Page
{

    public class AddToCartcs
    {
        private IWebDriver driver;

       By addtocart = By.XPath("//*[@class='esh-catalog-button']");
        By Continue_shopping = By.XPath("//*[@class='btn esh-basket-checkout text-white']");
        //addToCart2
        By addtocart1 = By.XPath("//*[@class='esh-catalog-button']");
        //AddToCart3

        By addtocart2 =  By.XPath("(//*[@class='esh-catalog-button'])[2]");
        //AddToCart4
        By Catalog = By.CssSelector(".esh-catalog-item.col-md-4");
        By pname = By.CssSelector(".esh-catalog-name");

        By addtocart3 = By.XPath("/html/body/div/div/div[2]/div[10]/form/input[1]");
        //AddToCart5
        By addtocart4 = By.XPath("/html/body/div/div/div[2]/div[8]/form/input[1]");
        By Add = By.XPath("(//*[@class='esh-catalog-button'])");


        public AddToCartcs(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void AddToCart()
        {
            ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollTo(0,document.body.scrollHeight)");
            Thread.Sleep(2000);
            driver.FindElement(addtocart).Click();
            ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollTo(0,document.body.scrollHeight)");
            Thread.Sleep(2000);

            driver.FindElement(Continue_shopping).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            
        }

        public void AddToCart1()
        {
            ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollTo(0,document.body.scrollHeight)");
            Thread.Sleep(2000);
            driver.FindElement(addtocart1).Click();
            Thread.Sleep(1000);
            ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollTo(0,document.body.scrollHeight)");

            Thread.Sleep(1000);

            driver.FindElement(Continue_shopping).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            
        }

        public AddToCartcs AddToCart2()
        {
            ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollTo(0,document.body.scrollHeight)");
            Thread.Sleep(2000);
            driver.FindElement(addtocart2).Click();
            Thread.Sleep(1000);
            ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollTo(0,document.body.scrollHeight)");
            Thread.Sleep(1000);
            driver.FindElement(Continue_shopping).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10); ;
            return new AddToCartcs(driver);
        }

        public Check_Payment AddToCart3()
        {
            string[] expectedProduct = { ".NET BOT BLACK SWEATSHIRT", ".NET BLACK & WHITE MUG", "PRISM WHITE T-SHIRT" };
            string[] productName;

            IList<IWebElement> list = driver.FindElements(By.CssSelector(".esh-catalog-item.col-md-4"));
            IList<IWebElement> name = driver.FindElements(By.CssSelector(".esh-catalog-name"));

            foreach (IWebElement element in list)
            {
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
                if (expectedProduct.Contains(element.FindElement(pname).Text)) ;
                {
                    driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
                    ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollTo(0,200)");
                    Thread.Sleep(1000);
                    //Add to cart
                    element.FindElement(Add).Click();

                    ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollTo(0,document.body.scrollHeight)");
                    Thread.Sleep(1000);
                    driver.FindElement(Continue_shopping).Click();


                }
               
            }

           /* public void AddToCart3()*/
        
            ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollTo(0,document.body.scrollHeight)");
            Thread.Sleep(2000);
            driver.FindElement(addtocart3).Click();
            Thread.Sleep(1000);
            ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollTo(0,document.body.scrollHeight)");
            Thread.Sleep(2000);
            driver.FindElement(Continue_shopping).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
           
        

        /*public void AddToCart4()*/
        
            Thread.Sleep(1000);
            ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollTo(0,1000)");
            Thread.Sleep(2000);
            driver.FindElement(addtocart4).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            return new Check_Payment(driver);
        }


    }

}
