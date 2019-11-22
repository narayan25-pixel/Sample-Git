using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest2
    {


        [TestMethod]
        public void TestMethod1()
        {
            IWebDriver myD;
            myD = new ChromeDriver("C:\\SeleniumJar");
            myD.Url = "https://www.google.com/";
            string search = "DXC Technologies";
            myD.FindElement(By.Name("q")).SendKeys(search);
            Thread.Sleep(8000);
            myD.FindElement(By.ClassName("gNO89b")).Click();
            string Title = myD.Title.ToString();
            Console.WriteLine(Title);
            string stat=myD.FindElement(By.XPath("/html/body/div[7]/div[3]/div[7]/div[1]/div/div/div/div")).Text;
            Console.WriteLine(stat);
            Thread.Sleep(5000);
            myD.Close();
            Console.WriteLine("Executed succefully");
            if ((Title.Contains(search)))
            {
                Console.WriteLine("PASS");
            }
            else
            {
                Console.WriteLine("FAIL");
            }


        }
        

    }
}
