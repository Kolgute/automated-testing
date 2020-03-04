using System;
using NUnit.Framework;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class GoogleTest
    {
        [Test]
        public void TranslateTest()
        {
            StartPage start = new StartPage();
            start.pasteText("переводчик");
            start.submit();
            ResultPage res = new ResultPage();
            res.goToLink();
            TranslatePage translatePage = new TranslatePage("Русский", "Английский");
            translatePage.pasteText("Конь");
            Assert.That(translatePage.outputText(), Is.EqualTo("Horse"));
            
            start.closeDriver();
        }
    }
}
