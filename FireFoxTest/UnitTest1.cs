using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace FireFoxTest
{
    [TestClass]
    public class UnitTest1
    {
        private FirefoxDriverService service = null;
        private IWebDriver driver = null;
        [TestMethod]
        public void TestMethod1()
        {
            driver.Navigate().GoToUrl("http://www.google.com");
        }

        [TestInitialize]
        public void Setup()
        {
            //change the paths to fit your local paths
            service = FirefoxDriverService.CreateDefaultService(@"C:\Users\antwan.maddox\source\repos\UnitTestProject1\Drivers\");
            service.FirefoxBinaryPath = @"C:\Program Files\Mozilla Firefox\firefox.exe";
            driver = new FirefoxDriver(service);
            driver.Manage().Window.Maximize();

        }

        [TestCleanup]
        public void Teardown()
        {
            driver.Quit();
        }
    }
}
