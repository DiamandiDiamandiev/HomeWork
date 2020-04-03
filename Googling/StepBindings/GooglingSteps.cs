using Googling.WebElements;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace Googling.StepBindings
{
    [Binding]
    public class GooglingSteps : IDisposable

    {
        private ChromeDriver driver = new ChromeDriver();
        [Given(@"I have navigated to google's homepage")]
        public void GivenIHaveNavigatedToGoogleSHomepage()
        {
            SearchForm search = new SearchForm(driver);
            driver.Navigate().GoToUrl(search.homepage);
            driver.Manage().Window.Maximize();
        }
        
        [When(@"I type ""(.*)"" into the search box")]
        public void WhenITypeIntoTheSearchBox(string searchWord)
        {
            SearchForm search = new SearchForm(driver);
            search.EnterSearchWord(searchWord);



        }
        
        [When(@"click on the search button")]
        public void WhenClickOnTheSearchButton()
        {
            SearchForm search = new SearchForm(driver);
            search.ClickSearchButton();
        }
        
        [Then(@"I should see the new page")]
        public void ThenIShouldSeeTheNewPage()
        {
            SearchForm search = new SearchForm(driver);
           Assert.IsTrue(search.SuccessfullSearch());
        }

        public void Dispose()
        {
            if(driver != null)
            {
                driver.Dispose();
                driver = null;
            }
        }
    }
}
