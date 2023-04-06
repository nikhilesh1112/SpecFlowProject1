using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System.ComponentModel;
using System.Formats.Asn1;
using System.Security.Policy;
using TechTalk.SpecFlow;
using SpecFlowProject1.Page;
using static System.Net.Mime.MediaTypeNames;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities.ObjectModel;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities.Serialization;
using static System.Collections.Specialized.BitVector32;
using SpecFlowProject1.Pages;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chromium;
using AventStack.ExtentReports.Gherkin.Model;


namespace SpecFlowProject1.StepDefinitions
{
    [Binding]

    public class Checkout_Payment
    {

        private IWebDriver driver;

        public Checkout_Payment(IWebDriver driver)
        {
            this.driver = driver;
        }
        private HomePage homePage;
        private Click_on_login click_On_Login;
        private InvalidLogin invalidLogin;
        private Login login;
        private Searching_items searching_items;
        private AddToCartcs addToCartcs;
        private Check_Payment check_Payment;



        [Given(@"open the browser")]
        public void GivenOpenTheBrowser()
        {
            /*driver = new ChromeDriver();
            driver.Manage().Window.Maximize();*/
        }

        [When(@"open the website page")]
        public void Whenopenthewebsitepage()
        {

            homePage = new HomePage(driver);
            homePage.Whenopenthewebsitepage();
        }


        [Then(@"click on login page")]
        public void Thenclickonloginpage()
        {
            click_On_Login = new Click_on_login(driver);
            click_On_Login.Thenclickonloginpage();
        }

        [Then(@"enter the invalid email id '([^']*)'")]

        public void ThenEnterTheInvalidEmailId(string text)
        {


            invalidLogin = new InvalidLogin(driver);
            invalidLogin.ThenEnterTheInvalidEmailId(text);

        }

        [Then(@"enter the invalid password '([^']*)'")]
        public void ThenEnterTheInvalidPassword(string text)
        {
            invalidLogin = new InvalidLogin(driver);
            invalidLogin.ThenEnterTheInvalidPassword(text);
            
        }



        [Then(@"enter the email id '([^']*)'")]
        public void ThenEnterTheEmailId(string text)
        {
            login = new Login(driver);
            login.ThenEnterTheEmailId(text);

        }

        [Then(@"enter the password '([^']*)'")]
        public void ThenEnterThePassword(string text)
        {
            login = new Login(driver);
            login.ThenEnterThePassword(text);
            
        }

        [Then(@"searching items")]
        public void ThenSearchingItems()
        {
            searching_items = new Searching_items(driver);
            searching_items.ThenSelectingTheItem();
            
        }

        [Then(@"AddToCart")]
        public void AddToCart()
        {

            addToCartcs = new AddToCartcs(driver);
            addToCartcs.AddToCart();

            searching_items.ThenSelectingTheItem2();
           
            addToCartcs.AddToCart1();

            searching_items.ThenSelectingTheItem3();

            addToCartcs.AddToCart2();
            addToCartcs.AddToCart3();
           /* addToCartcs.AddToCart4(); */  
            
            check_Payment =new Check_Payment(driver);
            check_Payment.check_Payment1();
            driver.Quit();  
           
        }


    }
}