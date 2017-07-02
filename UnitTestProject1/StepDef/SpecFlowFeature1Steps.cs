using System;
using TechTalk.SpecFlow;

namespace UnitTestProject1.StepDef
{
    [Binding]
    public class SpecFlowFeature1Steps
    {
        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int p0)
        {
            Console.WriteLine("good bad");
            Console.WriteLine("good bad --- 1");
        }
        
        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            Console.WriteLine("good bad");
            Console.WriteLine("good bad --- 1");
        }
        
        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int p0)
        {
            Console.WriteLine("good bad");
            Console.WriteLine("good bad --- 1");
        }
    }
}
