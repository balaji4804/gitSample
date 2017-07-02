using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SpecFlw
{
    public class HomePage : TestBase
    {
        private static IWebElement ele = null;

        public static IWebElement SignInLink(IWebDriver dr) {
            Console.WriteLine("Locating Sign In Link");
            ele = dr.FindElement(By.LinkText("Sign in"));
            Console.WriteLine("Sign In Link Located");
            return ele;
        } 
    }
}
