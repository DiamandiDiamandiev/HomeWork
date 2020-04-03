using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Googling.WebElements
{
     public class SearchForm
    {
        public readonly string homepage = "https://www.google.bg/?hl=bg";

        private IWebDriver driver;

        //public readonly string searchedWord = "Endava";

        readonly By searchWordField = By.CssSelector(".a4bIc > input[role='combobox']");
        readonly By searchButton = By.CssSelector(".FPdoLc [value='Google Търсене']");
        readonly By successfullSearch = By.CssSelector(".zloOqf");

        public SearchForm(IWebDriver driver)
        {
            this.driver = driver;
        }
        public  void EnterSearchWord(string searchWord)
        {
            driver.FindElement(searchWordField).Clear();
            driver.FindElement(searchWordField).SendKeys(searchWord);
        }

        public void ClickSearchButton()
        {
            driver.FindElement(searchButton).Click();
        }

        public bool SuccessfullSearch()
        {
            return driver.FindElement(successfullSearch).Displayed;
        }

    }
}
