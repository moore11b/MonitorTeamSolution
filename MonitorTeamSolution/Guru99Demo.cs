using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MonitorTeamSolution
{
    public class Guru99Demo
    {

       /* private NUnit.Framework.TestContext testContextInstance;
        private IWebDriver driver;
        private string appURL;
        [TestMethod]
        [TestCategory("Chrome")]
        public void TheBingSearchTest()
        {
            driver.Navigate().GoToUrl(appURL + "/");
            driver.FindElement(By.Id("sb_form_q")).SendKeys("Azure Pipelines");
            driver.FindElement(By.Id("sb_form_go")).Click();
            driver.FindElement(By.XPath("//ol[@id='b_results']/li/h2/a/strong[3]")).Click();
            NUnit.Framework.Assert.IsTrue(driver.Title.Contains("Azure Pipelines"), "Verified title of the page");
        }

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public NUnit.Framework.TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        [TestInitialize()]
        public void SetupTest()
        {
            appURL = "https://groliapp.azurewebsites.net/";

            string browser = "Chrome";
            switch (browser)
            {
                case "Chrome":
                    driver = new ChromeDriver();
                    break;
                case "Firefox":
                    driver = new FirefoxDriver();
                    break;
                case "IE":
                    driver = new InternetExplorerDriver();
                    break;
                default:
                    driver = new ChromeDriver();
                    break;
            }

        }

        [TestCleanup()]
        public void MyTestCleanup()
        {
            driver.Quit();
        }
*/
















        
        IWebDriver driver;

        [SetUp]
        public void startBrowser()
        {
            //Literal Path on local machine
            driver = new ChromeDriver(@"C:\LAST SEMESTER\SE2\Project\MonitorTeamSolution\MonitorTeamSolution\lib\chromedriver\chromedriver.exe");
            //relative path. 
            //driver = new ChromeDriver(@"\MonitorTeamSolution\MonitorTeamSolution\lib\chromedriver\chromedriver.exe");

        }

        [Test]
        public void test()
        {
            driver.Url = "localhost:44329";
        }

        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }

    }
}
