﻿using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace SeleniumPizza
{
    public class ChickFilaPage
    {
        public ChickFilaPage(ChromeDriver driver)
        {
            this.driver = driver;
        }

        private  readonly ChromeDriver driver;

        private IWebElement cookies => driver.FindElement(By.Id("onetrust-accept-btn-handler"));
        private IWebElement orderFood => driver.FindElement(By.LinkText("Order food"));
        private IWebElement PickUp => driver.FindElement(By.CssSelector("li:nth-child(1) > a > div"));
        private IWebElement locations => driver.FindElement(By.Id("input-1"));
        private IWebElement FindLocation => driver.FindElement(By.CssSelector(".sc-ksluID"));
        private IWebElement ChooseLocation => driver.FindElement(By.CssSelector("li:nth-child(2) .sc-ksluID > span"));
        private IWebElement carryOut => driver.FindElement(By.CssSelector(".sc-jVBfSZ:nth-child(2) .sc-jrsJWt:nth-child(2)"));
        private IWebElement meals => driver.FindElement(By.CssSelector("li:nth-child(2) .sc-uOECg"));
        private IWebElement deluxeCombo => driver.FindElement(By.CssSelector("li:nth-child(2) .sc-uOECg"));
        private IWebElement chooseSide => driver.FindElement(By.CssSelector(".sc-ksluID"));
        private IWebElement WaffleFries => driver.FindElement(By.CssSelector("li:nth-child(1) > .sc-fFSPTT"));
        private IWebElement Choosebeverage => driver.FindElement(By.CssSelector(".sc-ksluID"));
        private IWebElement lemonade => driver.FindElement(By.CssSelector(".sc-jhKdTJ:nth-child(3) .sc-bMHtUk"));
        private IWebElement reviewMeal => driver.FindElement(By.CssSelector(".sc-ksluID"));
        private IWebElement addOrder => driver.FindElement(By.CssSelector(".sc-ksluID"));
        private IWebElement viewBag => driver.FindElement(By.CssSelector(".sc-biHcxt"));
        private IWebElement checkout => driver.FindElement(By.CssSelector(".bovdhG"));
        private IWebElement guest => driver.FindElement(By.CssSelector(".sc-fnVZcZ"));
        private IWebElement firstName => driver.FindElement(By.Id("input-20"));
        private IWebElement lastName => driver.FindElement(By.CssSelector("#input-21"));
        private IWebElement phone => driver.FindElement(By.CssSelector("#input-22"));
        private IWebElement email => driver.FindElement(By.CssSelector("#input-23"));
        private IWebElement emailConfirmed => driver.FindElement(By.CssSelector("#input-24"));


        public void OrderChicken()
        {
            var personal = new PersonalInfo("personalinfo.txt");

            
            driver.Manage().Window.Maximize();

            driver.Navigate().GoToUrl("https://www.chick-fil-a.com/");

            Thread.Sleep(2000);

           
            cookies.Click();
            Thread.Sleep(3000);

            
            orderFood.Click();
            Thread.Sleep(2000);


            PickUp.Click();
            Thread.Sleep(5000);

            
            locations.Click();
            locations.SendKeys("35226");
            Thread.Sleep(5000);

            
            FindLocation.Click();

            Thread.Sleep(5000);

            
            ChooseLocation.Click();
            Thread.Sleep(3000);

            
            carryOut.Click();
            Thread.Sleep(3000);

            
            meals.Click();
            Thread.Sleep(3000);

            
            deluxeCombo.Click();
            Thread.Sleep(3000);

            
            chooseSide.Click();
            Thread.Sleep(3000);

            

            WaffleFries.Click();
            Thread.Sleep(3000);

            

            Choosebeverage.Click();
            Thread.Sleep(3000);

            
            lemonade.Click();
            Thread.Sleep(3000);

            
            reviewMeal.Click();
            Thread.Sleep(3000);

            
            Actions actions = new Actions(driver);
            actions.MoveToElement(addOrder);
            addOrder.Click();
            Thread.Sleep(3000);

            
            viewBag.Click();
            Thread.Sleep(3000);

            //.bovdhG

            
            checkout.Click();
            Thread.Sleep(3000);

           
            guest.Click();
            Thread.Sleep(5000);

           
            firstName.Click();
            firstName.SendKeys(personal.Name);
            Thread.Sleep(3000);

          
            lastName.Click();
            lastName.SendKeys(personal.LastName);
            Thread.Sleep(3000);

            
            phone.Click();
            phone.SendKeys(personal.Phone);
            Thread.Sleep(3000);

            
            email.Click();
            email.SendKeys(personal.Email);
            Thread.Sleep(3000);

           
            emailConfirmed.Click();
            emailConfirmed.SendKeys(personal.Email);
            Thread.Sleep(3000);



            driver.Quit();

        }
    }
}
