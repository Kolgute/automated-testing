using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class TranslatePage : BasePage
    {
        By transleteInput = By.CssSelector("#input-wrap [rows]");
        By languageInput = By.CssSelector(".sl-wrap [aria-label]");
        By transleteOutput = By.CssSelector(".text-wrap [tabindex]");
        By languageOutput = By.CssSelector(".tl-wrap [aria-label]");
        string languageIn, languageOut;

        public TranslatePage(string lIn, string lOut)
        {
            this.languageIn = lIn;
            this.languageOut = lOut;
            var field = getComponent(languageInput);
            field.Click();
            var inputLanguage = getComponent(By.CssSelector("input#sl_list-search-box"));
            inputLanguage.SendKeys(lIn);
            inputLanguage.SendKeys(Keys.Enter);
            field = getComponent(languageOutput);
            field.Click();
            var outputLanguage = getComponent(By.CssSelector("input#tl_list-search-box"));
            outputLanguage.SendKeys(lOut);
            outputLanguage.SendKeys(Keys.Enter);
        }
        public void pasteText(string text)
        {
            var search = getComponent(transleteInput);
            search.Clear();
            search.SendKeys(text);       
        }

        public string outputText()
        {
            var search = getComponent(transleteOutput);
            return search.Text;
        }
    }
}
