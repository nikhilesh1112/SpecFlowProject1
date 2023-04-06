using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crossbrowsertesting.Drivers
{
    public class SeleniumDriver
    {
        private IWebDriver driver;

        private readonly ScenarioContext _scenarioContext;

        public SeleniumDriver(ScenarioContext scenarioContext) => _scenarioContext = scenarioContext;

        public IWebDriver Setup()
        {

            var firefoxOptions = new FirefoxOptions();

            driver = new RemoteWebDriver(new Uri("https://localhost:44315/"), firefoxOptions.ToCapabilities());
            _scenarioContext.Set(driver, "webDriver");
            driver.Manage().Window.Maximize();
            return driver;
        }
    }
}
