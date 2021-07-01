using SeleniumAdv.TestCases;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumAdv.PageObjects
{
  public  class SeleniumAdvPO : BaseTest
    {


        public By CookiesButton              = By.XPath("//a[contains(text(),'I ACCEPT')]");
       // public By SeeAllIntegration        = By.XPath("//a[contains(text(),'See All Integrations ')]");
        public By SeeAllIntegration          = By.XPath("//a[@class='seeintbtn']");
        public By CodelessAutomation         = By.XPath("//a[contains(text(),'Codeless Automation')]");
        public By CookiesClose               = By.XPath("//span[contains(@class,'cookie__bar__close')]");

        
        //xpath for accept
        public By accept = By.XPath("//a[@class = 'cbtn btn_accept_ck']");

        //xpath for see all integration
        public By H2 = By.XPath("//h2[contains(text(),'Seamless Collaboration')]");
        
        public By SAI = By.XPath("//a[text() = 'See All Integrations']");

        //xpath for codeless automation
        public By Codeless = By.XPath("//a[text() = 'Codeless Automation']");

        //xpath for Testing Whiz learn more
        public By learn = By.XPath("//h3[contains(text(),'Testing Whiz')]//following-sibling::a");
        public By Katalon = By.XPath("//h3[contains(text(),'Katalon Studio')]//following-sibling::a");
        //xpath for search
        public By search = By.XPath("//input[@class = 'search-field']");

        //xpath for community
        public By community = By.XPath("//h6[contains(text(),'Resources')]//following::a[text() ='Community']");
        public By Resources = By.XPath("//h6[contains(text(),'Resources')]");

        //xpath for same page
        public By same = By.XPath("//a[@class ='nav-link']");

        //xpath for allow
        public By allow = By.XPath("//button[@id = 'onesignal-slidedown-allow-button']");



        





    }
}
