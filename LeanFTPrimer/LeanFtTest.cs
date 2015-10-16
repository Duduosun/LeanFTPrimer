using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HP.LFT.SDK.Web;

namespace LeanFTPrimer
{
    [TestClass]
    public class LeanFtTest : UnitTestClassBase<LeanFtTest>
    {
        //IBrowser browser = BrowserFactory.Launch(BrowserType.InternetExplorer);

        [ClassInitialize]
        public static void ClassInitialize(TestContext context)
        {
            GlobalSetup(context);
            
        }

        [TestInitialize]
        public void TestInitialize()
        {
            
        }

        [TestMethod]
        [Priority(0)]
        public void TestMethod1()
        {
            IBrowser browser = BrowserFactory.Launch(BrowserType.InternetExplorer);
            browser.Navigate("www.salmon.com");
            browser.Sync();
            browser.Close();
            //browser.CloseAllTabs();
        }

        [TestMethod]
        [Priority(1)]
        public void TestMethod2()
        {
            IBrowser browser = BrowserFactory.Launch(BrowserType.InternetExplorer);
            browser.Navigate("www.google.com");
            browser.Describe<IEditField>(new XPathDescription(@"//INPUT[@id=""lst-ib""]")).SetValue("LeanFT");
            browser.Describe<IButton>(new XPathDescription(@"//FORM[@id=""tsf""]/DIV[2]/DIV[3]/CENTER[1]/INPUT[1]")).Click();           
            browser.Sync();           
        }
            
        [TestCleanup]
        public void TestCleanup()
        {
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            GlobalTearDown();
        }
    }
}