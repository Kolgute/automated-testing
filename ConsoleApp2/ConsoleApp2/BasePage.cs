using OpenQA.Selenium;

namespace ConsoleApp2
{
    public class BasePage
    {
        private static WebDriver driver = new WebDriver("https://google.com","Chrome");
        private IWebDriver _page;
        public BasePage()
        {
            _page = driver.getDriver();
        }
        public IWebElement getComponent(By locator)
        {
            return _page.FindElement(locator);
        }
        public void closeDriver()
        {
            _page.Quit();
        }
    }
}
