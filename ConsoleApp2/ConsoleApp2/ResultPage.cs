using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class ResultPage : StartPage
    {
        By linkElement = By.CssSelector("a#tw-gtlink");

        public void goToLink()
        {
            var link = getComponent(linkElement);
            link.Click();
        }
    }
}
