using System;
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

            IWebElement PickUp = driver.FindElement(By.CssSelector("li:nth-child(1) > a > div"));
            PickUp.Click();
            Thread.Sleep(5000);

            IWebElement locations = driver.FindElement(By.Id("input-1"));
            locations.Click();
            locations.SendKeys("35226");
            Thread.Sleep(5000);

            IWebElement FindLocation = driver.FindElement(By.CssSelector(".sc-ksluID"));
            FindLocation.Click();

            Thread.Sleep(5000);

            IWebElement ChooseLocation = driver.FindElement(By.CssSelector("li:nth-child(2) .sc-ksluID > span"));
            ChooseLocation.Click();
            Thread.Sleep(3000);

            IWebElement carryOut = driver.FindElement(By.CssSelector(".sc-jVBfSZ:nth-child(2) .sc-jrsJWt:nth-child(2)"));
            carryOut.Click();
            Thread.Sleep(3000);

            IWebElement meals = driver.FindElement(By.CssSelector("li:nth-child(2) .sc-uOECg"));
            meals.Click();
            Thread.Sleep(3000);

            IWebElement deluxeCombo = driver.FindElement(By.CssSelector("li:nth-child(2) .sc-uOECg"));
            deluxeCombo.Click();
            Thread.Sleep(3000);

            IWebElement chooseSide = driver.FindElement(By.CssSelector(".sc-ksluID"));
            chooseSide.Click();
            Thread.Sleep(3000);

            IWebElement WaffleFries = driver.FindElement(By.CssSelector("li:nth-child(1) > .sc-fFSPTT"));

            WaffleFries.Click();
            Thread.Sleep(3000);

            IWebElement Choosebeverage = driver.FindElement(By.CssSelector(".sc-ksluID"));

            Choosebeverage.Click();
            Thread.Sleep(3000);

            IWebElement lemonade = driver.FindElement(By.CssSelector(".sc-jhKdTJ:nth-child(3) .sc-bMHtUk"));
            lemonade.Click();
            Thread.Sleep(3000);

            IWebElement reviewMeal = driver.FindElement(By.CssSelector(".sc-ksluID"));
            reviewMeal.Click();
            Thread.Sleep(3000);

            IWebElement addOrder = driver.FindElement(By.CssSelector(".sc-ksluID"));
            Actions actions = new Actions(driver);
            actions.MoveToElement(addOrder);
            addOrder.Click();
            Thread.Sleep(3000);

            IWebElement viewBag = driver.FindElement(By.CssSelector(".sc-biHcxt"));
            viewBag.Click();
            Thread.Sleep(3000);

            //.bovdhG

            IWebElement checkout = driver.FindElement(By.CssSelector(".bovdhG"));
            checkout.Click();
            Thread.Sleep(3000);

            IWebElement guest = driver.FindElement(By.CssSelector(".sc-fnVZcZ"));
            guest.Click();
            Thread.Sleep(5000);

            IWebElement firstName = driver.FindElement(By.Id("input-20"));
            firstName.Click();
            firstName.SendKeys(personal.Name);
            Thread.Sleep(3000);

            IWebElement lastName = driver.FindElement(By.CssSelector("#input-21"));
            lastName.Click();
            lastName.SendKeys(personal.LastName);
            Thread.Sleep(3000);

            IWebElement phone = driver.FindElement(By.CssSelector("#input-22"));
            phone.Click();
            phone.SendKeys(personal.Phone);
            Thread.Sleep(3000);

            IWebElement email = driver.FindElement(By.CssSelector("#input-23"));
            email.Click();
            email.SendKeys(personal.Email);
            Thread.Sleep(3000);

            IWebElement emailConfirmed = driver.FindElement(By.CssSelector("#input-24"));
            emailConfirmed.Click();
            emailConfirmed.SendKeys(personal.Email);
            Thread.Sleep(3000);



            driver.Quit();

        }
    }
}
