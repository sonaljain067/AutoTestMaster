using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
namespace Selenium_Automation{
    class Program{
        static void Main(string[] args){
            IWebDriver driver = new ChromeDriver("C:\\Program Files\\BraveSoftware\\Brave-Browser\\Application\\brave.exe");
            driver.Navigate().GoToUrl("https://app.cloudqa.io/home/AutomationPracticeForm");

            //  First name
            try{
                IWebElement field1 = driver.FindElement(By.Id("fname"));
                if(field1.Displayed && field1.Enabled){
                    field1.SendKeys("John");
                }
                else{
                    Console.WriteLine("Error: First name is not visible or enabled. ");
                }
            }
            catch(NoSuchElementException){
                Console.WriteLine("Error: First name not found");
            }
            

            // Last Name
            try{
                IWebElement field2 = driver.FindElement(By.Id("lname"));
                if (field2.Displayed && field2.Enabled){
                    field2.SendKeys("Doe");
                }
                else{
                    Console.WriteLine("Error: Last name is not visible or enabled.");
                }
            }
            catch(NoSuchElementException){
                Console.WriteLine("Error: Last name not found.");
            }   


            // DOB
            try{
                IWebElement field3 = driver.FindElement(By.Id("dob"));
                if (field3.Displayed && field3.Enabled){
                    field3.SendKeys("10-09-1980");
                }
                else{
                    Console.WriteLine("Error: Date of birth is not visible or enabled.");
                }
            }
            catch(NoSuchElementException){
                Console.WriteLine("Error: Date of birth not found.");
            }   

            // Email
            try{
                IWebElement field4 = driver.FindElement(By.Id("email"));
                if (field4.Displayed && field4.Enabled){
                    field4.SendKeys("johndoe@gmail.com");
                }
                else{
                    Console.WriteLine("Error: Email is not visible or enabled.");
                }
            }
            catch(NoSuchElementException){
                Console.WriteLine("Error: Email not found.");
            }   


            // Mobile
            try{
                IWebElement field5 = driver.FindElement(By.Id("mobile"));
                if (field5.Displayed && field5.Enabled){
                    field5.SendKeys("1234567890");
                }
                else{
                    Console.WriteLine("Error: Mobile is not visible or enabled.");
                }
            }
            catch(NoSuchElementException){
                Console.WriteLine("Error: Mobile not found.");
            }   


            // Country
            try{
                IWebElement field6 = driver.FindElement(By.Id("country"));
                if (field6.Displayed && field6.Enabled){
                    field6.SendKeys("USA");
                }
                else{
                    Console.WriteLine("Error: Country is not visible or enabled.");
                }
            }
            catch(NoSuchElementException){
                Console.WriteLine("Error: Country not found.");
            }   


            // Gender 
            try{
                IWebElement field3 = driver.FindElement(By.XPath("//input[@value='Male']"));
                if (field3.Displayed && field3.Enabled){
                    field3.Click();
                }
                else{
                    Console.WriteLine("Error: Gender is not visible or enabled. ");
                }
            }
            catch(NoSuchElementException){
                Console.WriteLine("Error: Gender not found. ");
            }
            

            // State
            try{
                IWebElement field6 = driver.FindElement(By.Id("state"));
                if (field6.Displayed && field6.Enabled){
                    field6.SendKeys("United States");
                }
                else{
                    Console.WriteLine("Error: Country is not visible or enabled.");
                }
            }
            catch(NoSuchElementException){
                Console.WriteLine("Error: Country not found.");
            }   
            System.Threading.Thread.Sleep(15000);
            driver.Quit();
        }
    }
}









