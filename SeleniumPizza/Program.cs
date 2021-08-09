using System;
using System.IO;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using SeleniumPizza;
using Xunit;

namespace SeleniumChickfila
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //create new driver and set the start url
            var driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.chick-fil-a.com/");


            //create new instance of the chick fila page
            var chickPage = new ChickFilaPage(driver);


            //page object method that orders a chicken sandwhich
            chickPage.OrderChicken();



            driver.Quit();
            driver.Close();

            
        }
    }
}
