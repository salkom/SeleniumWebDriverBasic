using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumWebDriverBasic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create the reference for the browsers
            IWebDriver driver = new ChromeDriver();

            // Navigate to URL
            driver.Navigate().GoToUrl("https://www.google.com/");
            Thread.Sleep(1000);

            // Identify the Google search text box
            IWebElement textBox = driver.FindElement(By.Name("q"));

            // Enter the value in the google search text box
            textBox.SendKeys("Hello World");
            Thread.Sleep(1000);
            
            // Identify the Google search button  
            IWebElement searchBtn = driver.FindElement(By.Name("btnK"));

            // Click on the Google search button  
            searchBtn.Click();

            // Log the value of the title to the console
            Console.WriteLine(driver.Title);
            Console.ReadKey();

            // Close the browser  
            driver.Close();
        }
    }
}
