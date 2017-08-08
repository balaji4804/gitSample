using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
//using NUnit.Framework;



namespace SpecFlw
{
    [Binding]
    public class LoginStep : TestBase {

       // HomePage HomePage = new HomePage();

        [Given(@"I go to http://automationpractice\.com/index\.php")]
        public void GivenIGoToHttpAutomationpractice_ComIndex_Php()
        {
            Initialise();
            LaunchApplication();
            HomePage.SignInLink(dr).Click();
            System.Threading.Thread.Sleep(5000);
            CloseApplication();
            
        }

        [Given(@"I search for shirt")]
        public void GivenISearchForShirt()
        {
            Console.WriteLine("good");
        }

        [When(@"I click search button")]
        public void WhenIClickSearchButton()
        {
            Console.WriteLine("search button clicked");
        }

        [Then(@"the result page should show SEARCH Shirt")]
        public void ThenTheResultPageShouldShowSEARCHShirt()
        {
            Console.WriteLine("test end");
            Console.WriteLine("CR001");
            Console.WriteLine("cr001 updated");
            Console.WriteLine("cr003 updated");

        }


    }
}
