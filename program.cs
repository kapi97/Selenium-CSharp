using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace ConsoleAppNowe01
{
    class Program
    {
        static void Main(string[] args)
        {
            //IWebDriver driver = new FirefoxDriver();
            IWebDriver driver = new ChromeDriver();

            driver.Url = "https://facebook.com";

            driver.Manage().Window.Maximize();

            driver.FindElement(By.Id("email")).SendKeys("podaj email");
            driver.FindElement(By.Id("pass")).SendKeys("podaj haslo" + Keys.Enter);

            Thread.Sleep(15000);

            //driver.Url = "https://www.facebook.com/profile.php";
            //driver.Url = "https://www.facebook.com/podaj_swoj_link";
            driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div/div[1]/div/div/div/div[2]/div[1]/div[1]/div/a")).Click();

            Thread.Sleep(15000);

            driver.Url = "https://www.facebook.com/podaj_swoj_link/friends_all";
            //driver.FindElement(By.XPath("/html/body/div[1]/div[3]/div[1]/div/div[2]/div[2]/div[1]/div/div[1]/div/div[3]/div/div[2]/div[3]/ul/li[3]/a")).Click();

            IList<IWebElement> friends = driver.FindElements(By.XPath("//div[@class='fsl fwb fcb']/a"));

            //Console.WriteLine("Total friends: " + friends.Count);

            for (int i = 0; i < friends.Count; ++i)
            {
                Console.WriteLine(friends[i].Text);
            }
            Console.ReadKey();

        }
    }
}
