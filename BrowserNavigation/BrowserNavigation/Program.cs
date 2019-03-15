using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace BrowserNavigation
{
    class Program
    {
        static void Main(string[] args)
        {
            //We shall open Ultimatix and perform click a button, backward, forward and refresh operations
            
            //Create an instance for the webdriver

            IWebDriver driver = new ChromeDriver();

            //open ultimatix using navigate command
            driver.Navigate().GoToUrl("https://auth.ultimatix.net/utxLogin/");


            //to make the browser wait til after the previous action occurs
            System.Threading.Thread.Sleep(1000);


            // to naviagte back
            driver.Navigate().Back();

            System.Threading.Thread.Sleep(2000);


            //forward
            driver.Navigate().Forward();

            System.Threading.Thread.Sleep(2000);


            //to refresh
            driver.Navigate().Refresh();

            System.Threading.Thread.Sleep(1000);

            //to close
           // driver.Close();
            
        }
    }
}
