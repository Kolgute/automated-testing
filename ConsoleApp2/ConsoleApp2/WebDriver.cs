using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class WebDriver
    {
        private IWebDriver currentPage;
        public WebDriver(string url,string browser)
        {
            switch (browser)
            {
                case "Chrome": { currentPage = new ChromeDriver() { Url = url}; break;}
                case "FireFox": { currentPage = new FirefoxDriver() { Url = url }; break; }
                default: { Console.WriteLine("Wrong browser name"); break; }
            }          
        }
        public IWebDriver getDriver ()
        {
            return currentPage;
        }
    }
}
