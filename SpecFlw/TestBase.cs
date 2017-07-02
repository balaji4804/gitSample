using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.IE;

namespace SpecFlw
{
    public class TestBase {

        public static IWebDriver dr;

        public static void Initialise() {

         //  dr = new ChromeDriver(@"C:\SeleniumBrowserDrivers\chromedriver_win32");
          dr = new InternetExplorerDriver (@"C:\SeleniumBrowserDrivers\IEDriverServer_x64_3.4.0");

           /*FirefoxOptions Options = new FirefoxOptions();
            Options.BrowserExecutableLocation = @"C:\Program Files (x86)\Mozilla Firefox\firefox.exe";
            dr = new FirefoxDriver(Options);*/

            dr.Manage().Window.Maximize();

        }
        public static void LaunchApplication()
        {

            dr.Url = "http://automationpractice.com/index.php";
            dr.Navigate().GoToUrl("javascript:document.getElementById('overridelink').click()");
        }

        public static void CloseApplication() {

            dr.Close();
        }
    }
}
