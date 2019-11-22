using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod3()
        {

            string firstLink = "Calculators & Resources";
            string secondLink = "Calculators";
            string thirdLink = "Budget Calculator";
            IWebDriver driver;

            FirefoxDriverService service = FirefoxDriverService.CreateDefaultService(@"C:\SeleniumJar", "geckodriver.exe");
            service.FirefoxBinaryPath = @"C:\Program Files\Mozilla Firefox\firefox.exe";
            driver = new FirefoxDriver(service);

//driver = new ChromeDriver("C:\\SeleniumJar");
            driver.Url = "http://www.youcandealwithit.com/";
            IWebElement vCert = driver.FindElement(By.XPath("/html/body/div[1]/ul[2]/li[1]/a"));
            Actions act = new Actions(driver);
            act.MoveToElement(vCert).Build().Perform();
            driver.FindElement(By.LinkText(firstLink)).Click();
            string firstTitle = driver.Title.ToString();
            Thread.Sleep(2000);
            driver.FindElement(By.LinkText(secondLink)).Click();
            string secondTitle = driver.Title.ToString();
            Thread.Sleep(2000);
            driver.FindElement(By.LinkText(thirdLink)).Click();
            string thirdTitle = driver.Title.ToString();
            string food = "3000";
            string clothing = "2000";
            string shelter = "5000";
            string monthlyPay = "1000";
            string monthlyOther = "2000";

            driver.FindElement(By.Id("food")).Clear();
            Thread.Sleep(1000);
            driver.FindElement(By.Id("food")).SendKeys(food);
            Thread.Sleep(1000);
            driver.FindElement(By.Id("clothing")).SendKeys(clothing);
            Thread.Sleep(1000);
            driver.FindElement(By.Id("shelter")).SendKeys(shelter);
            Thread.Sleep(1000);
            driver.FindElement(By.Id("monthlyPay")).SendKeys(monthlyPay);
            Thread.Sleep(1000);
            driver.FindElement(By.Id("monthlyOther")).SendKeys(monthlyOther);
            double monthlyExpenses=Convert.ToDouble(driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div/div[5]/div[2]/input")).GetAttribute("value"));
            double monthlypay1 = Convert.ToDouble(driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div/div[4]/div[1]/input")).GetAttribute("value"));
            Console.WriteLine(monthlyExpenses);
            if (monthlypay1 >= monthlyExpenses)
            {
                Console.WriteLine("Warren BuFFet");
            }
            else
            {
                Console.WriteLine("VM");
            }
        }
    }
}
