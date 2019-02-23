using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        private ChromeDriver chrome;
        [TestMethod]
        public void TestMethod1()
        {
            chrome = new ChromeDriver();
            chrome.Navigate().GoToUrl("http://mail.ru");
            chrome.FindElement(By.Id("q")).SendKeys("Зачем нужны автотесты");
            chrome.FindElement(By.Id("q")).SendKeys(Keys.Enter);
            chrome.Quit();

            Console.WriteLine("изменения  Садвокасова Д");
        }
    }
}
