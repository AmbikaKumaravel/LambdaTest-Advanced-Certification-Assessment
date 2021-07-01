using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using SeleniumAdv.PageObjects;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumAdv.TestCases
{
    [TestClass]
    public class SeleniumAdv : BaseTest
    {

        SeleniumAdvPO objAdvPO = new SeleniumAdvPO();

        [TestInitialize()]
        public void TestInitiate()
        {
            //AssignmentObjectsInitiation("DynamicBrowserChrome");
            //StartReport();
            //LaunchBrowser(browser, environment);
        }

        //[TestMethod]
        //public void TestScenarioChrome()
        //{
        //    try
        //    {
        //        waitUntilElementExists(driver, objAdvPO.SeeAllIntegration, 200);
        //        if (IsElementPresent(driver, objAdvPO.CookiesButton))
        //        {
        //            clickWithWait(driver, objAdvPO.CookiesButton);
        //            WaitForJQueryToLoad(driver);
        //        }
        //        //2.Perform an explicit wait till the time all the elements in the DOM are available.
        //        WaitForJQueryToLoad(driver);
        //        //3.Scroll to the WebElement ‘SEE ALL INTEGRATIONS’ using the scrollIntoView() method. You are free to use any of the available web locators(e.g.XPath, CssSelector, etc.)
        //        waitUntilElementExists(driver, objAdvPO.SeeAllIntegration, 90);
        //        ScrollElementIntoView(driver, objAdvPO.SeeAllIntegration);
        //        string IntegrationURL = getAttributeValue(driver, objAdvPO.SeeAllIntegration, "href");
        //        ((IJavaScriptExecutor)driver).ExecuteScript("window.open();");
        //        IList<string> totWindowHandles = new List<string>(driver.WindowHandles);
        //        string window1[] = driver.SwitchTo().Window(driver.WindowHandles[1]);
        //        driver.Navigate().GoToUrl(IntegrationURL);
        //        waitUntilElementExists(driver, objAdvPO.CodelessAutomation, 90);
        //        ScrollElementIntoView(driver, objAdvPO.CodelessAutomation);
        //        clickWithWait(driver, objAdvPO.CodelessAutomation);



        //        // action.ContextClick(ele).SendKeys(Keys.Down).SendKeys(Keys.Down).SendKeys(Keys.Return).Build().Perform();
        //        //context(driver, objAdvPO.SeeAllIntegration);
        //        driver.Close();
        //        driver.Quit();
        //    }
        //    catch (Exception e)
        //    {
        //        string Stepscreenshot = ScreenshotforTestStep(driver, testContextInstance, "Failed step");
        //        extentTest.Fail(e.StackTrace);
        //        Console.Out.WriteLine(e.StackTrace);
        //        throw e;
        //    }


        //}
        [TestMethod]
        public void chrome()
        {
            try
            {
                AssignmentObjectsInitiation("DynamicBrowserChrome");
                StartReport();
                LaunchBrowser(browser, environment);
                waitUntilElementExists(driver, objAdvPO.H2, 100);
                ScrollElementIntoView(driver, objAdvPO.H2);
                waitUntilElementExists(driver, objAdvPO.SAI, 90);
                ScrollElementIntoView(driver, objAdvPO.SAI);
                String URLSAI = getAttributeValue(driver, objAdvPO.SAI, "href");
                ThinkTime(5000);
                ((IJavaScriptExecutor)driver).ExecuteScript("window.open();");
                driver.SwitchTo().Window(driver.WindowHandles[1]);
                driver.Navigate().GoToUrl(URLSAI);
                ScrollElementIntoView(driver, objAdvPO.Codeless);
                driver.FindElement(objAdvPO.Codeless).Click();
                waitUntilElementExists(driver, objAdvPO.Katalon, 90);

                // Adv.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(objAdvPO.learn));
                ScrollElementIntoView(driver, objAdvPO.Katalon);
                waitUntilElementExists(driver, objAdvPO.Katalon, 90);
                ThinkTime(5000);
                clickWithWait(driver, objAdvPO.learn);
                //driver.FindElement(objAdvPO.learn).Click();
                string Title_name = driver.Title;
                if (Title_name == "TestingWhiz Integration | LambdaTest")
                {
                    Assert.IsTrue(Title_name.Contains("TestingWhiz Integration | LambdaTest"));
                    string originalWindowHandle = driver.CurrentWindowHandle;
                    Console.WriteLine("original Window handles are: " + originalWindowHandle);
                    Console.WriteLine("Title of original Page:" + driver.Title);
                    // (driver.WindowHandles[1]).();
                    var newWindowHandle = driver.WindowHandles[1];
                    driver.SwitchTo().Window(driver.WindowHandles[1]).Close();
                    driver.SwitchTo().Window(driver.WindowHandles[0]);
                   // ((IJavaScriptExecutor)driver).ExecuteScript("window.close([1]);");

                    Thread.Sleep(3000);
                    System.Collections.ObjectModel.ReadOnlyCollection<string> windowHandles = driver.WindowHandles;
                    Console.WriteLine("Count the no. of opened windows: " + windowHandles.Count);
                    Assert.IsTrue(!string.IsNullOrEmpty(newWindowHandle));
                    Thread.Sleep(5000);
                   // waitUntilElementExists(driver, objAdvPO.same, 90);
                    driver.Navigate().GoToUrl("https://www.lambdatest.com/blog");
                    waitUntilElementExists(driver, objAdvPO.allow, 90);
                    driver.FindElement(objAdvPO.allow).Click();
                    waitUntilElementExists(driver, objAdvPO.Resources, 90);
                    ScrollElementIntoView(driver, objAdvPO.Resources);
                    ThinkTime(5000);
                    waitUntilElementExists(driver, objAdvPO.community, 90);
                    ThinkTime(5000);
                    clickWithWait(driver,objAdvPO.community);
                    // driver.FindElement(objAdvPO.community).Click();
                    ThinkTime(5000);
                   // string URL_name = driver.Title;
                    if (driver.Title.Contains("LambdaTest Community"))
                    {
                        driver.Close();
                    }
                    else
                    {
                        driver.Navigate().GoToUrl("www.google.com");
                    }
                }
               
               
            }
            catch (Exception e)
            {
               // string Stepscreenshot = ScreenshotforTestStep(driver, testContextInstance, "Failed step");
                extentTest.Fail(e.StackTrace);
                Console.Out.WriteLine(e.StackTrace);
                throw e;
            }
        }


        [TestMethod]
        public void Edge()
        {
            try
            {
                AssignmentObjectsInitiation("DynamicBrowserEdge");
                StartReport();
                LaunchBrowser(browser, environment);
                waitUntilElementExists(driver, objAdvPO.H2, 100);
                ScrollElementIntoView(driver, objAdvPO.H2);
                waitUntilElementExists(driver, objAdvPO.SAI, 90);
                ScrollElementIntoView(driver, objAdvPO.SAI);
                String URLSAI = getAttributeValue(driver, objAdvPO.SAI, "href");
                ThinkTime(5000);
                ((IJavaScriptExecutor)driver).ExecuteScript("window.open();");
                driver.SwitchTo().Window(driver.WindowHandles[1]);
                driver.Navigate().GoToUrl(URLSAI);
                ScrollElementIntoView(driver, objAdvPO.Codeless);
                driver.FindElement(objAdvPO.Codeless).Click();
                waitUntilElementExists(driver, objAdvPO.Katalon, 90);

                // Adv.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(objAdvPO.learn));
                ScrollElementIntoView(driver, objAdvPO.Katalon);
                waitUntilElementExists(driver, objAdvPO.Katalon, 90);
                ThinkTime(5000);
                clickWithWait(driver, objAdvPO.learn);
                //driver.FindElement(objAdvPO.learn).Click();
                string Title_name = driver.Title;
                if (Title_name == "TestingWhiz Integration | LambdaTest")
                {
                    Assert.IsTrue(Title_name.Contains("TestingWhiz Integration | LambdaTest"));
                    string originalWindowHandle = driver.CurrentWindowHandle;
                    Console.WriteLine("original Window handles are: " + originalWindowHandle);
                    Console.WriteLine("Title of original Page:" + driver.Title);
                    // (driver.WindowHandles[1]).();
                    var newWindowHandle = driver.WindowHandles[1];
                    driver.SwitchTo().Window(driver.WindowHandles[1]).Close();
                    driver.SwitchTo().Window(driver.WindowHandles[0]);
                    // ((IJavaScriptExecutor)driver).ExecuteScript("window.close([1]);");

                    Thread.Sleep(3000);
                    System.Collections.ObjectModel.ReadOnlyCollection<string> windowHandles = driver.WindowHandles;
                    Console.WriteLine("Count the no. of opened windows: " + windowHandles.Count);
                    Assert.IsTrue(!string.IsNullOrEmpty(newWindowHandle));
                    Thread.Sleep(5000);
                    // waitUntilElementExists(driver, objAdvPO.same, 90);
                    driver.Navigate().GoToUrl("https://www.lambdatest.com/blog");
                    waitUntilElementExists(driver, objAdvPO.allow, 90);
                    driver.FindElement(objAdvPO.allow).Click();
                    waitUntilElementExists(driver, objAdvPO.Resources, 90);
                    ScrollElementIntoView(driver, objAdvPO.Resources);
                    ThinkTime(5000);
                    waitUntilElementExists(driver, objAdvPO.community, 90);
                    ThinkTime(5000);
                    clickWithWait(driver, objAdvPO.community);
                    // driver.FindElement(objAdvPO.community).Click();
                    ThinkTime(5000);
                    // string URL_name = driver.Title;
                    if (driver.Title.Contains("LambdaTest Community"))
                    {
                        driver.Close();
                    }
                    else
                    {
                        driver.Navigate().GoToUrl("www.google.com");
                    }
                }
            }

            catch (Exception e)
            {
                string Stepscreenshot = ScreenshotforTestStep(driver, testContextInstance, "Failed step");
                extentTest.Fail(e.StackTrace);
                Console.Out.WriteLine(e.StackTrace);
                throw e;
            }
        }


    }

    }