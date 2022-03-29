using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pts8mo_uprj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WebDriver driver = new ChromeDriver("C:\\Users\\Krisko Yotov\\source\\repos\\pts8mo uprj\\pts8mo uprj\\bin\\Debug");
            driver.Url = "http://demo.guru99.com/test/login.html";
            WebElement email = (WebElement)driver.FindElement(By.Id("email"));
            WebElement password = (WebElement)driver.FindElement(By.Id("passwd"));
           
            email.SendKeys("abcd@gmail.com");
            password.SendKeys("abcdefghlkjl");

            WebElement login = (WebElement)driver.FindElement(By.Id("SubmitLogin"));


            email.SendKeys("abcd@gmail.com");
            password.SendKeys("abcdefghlkjl");
            login.Click();

        }
    }
}
