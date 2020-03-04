using System;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ConsoleApp2
{

    class Program
    {
        static void Main(string[] args)
        {
            StartPage start = new StartPage();
            start.pasteText("переводчик");
            start.submit();
            ResultPage res = new ResultPage();
            res.goToLink();
            TranslatePage translatePage = new TranslatePage("Русский","Английский");
            translatePage.pasteText("Конь");
            translatePage.outputText();
            start.closeDriver();
        }
    }
}
