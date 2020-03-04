using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{

    public class StartPage : BasePage
    {
        By inputSearch = By.Name("q");

        public void pasteText(string text)
        {
            var search = getComponent(inputSearch);
            search.Clear();
            search.SendKeys(text);
        }
        public void submit()
        {
            var submit = getComponent(inputSearch);
            submit.Submit();
        }
    }
}
