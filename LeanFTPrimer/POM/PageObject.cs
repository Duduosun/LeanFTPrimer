using HP.LFT.SDK.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeanFTPrimer.POM
{
    class PageObject
    {
        //Repository for methods utilized by Children Classes
        IBrowser browser = BrowserFactory.Launch(BrowserType.InternetExplorer);

        public void clickNameButton() {
            IButton nameClickMe = browser.Describe<IButton>(new ButtonDescription {ButtonType = @"submit", Name = @"Google Search" });
        }
        public void clickXpathButton()
        {
            IButton xpathClickMe = browser.Describe<IButton>(new XPathDescription(@"//FORM[@id=""tsf""]/DIV[2]/DIV[3]/CENTER[1]/INPUT[1]"));
        }

        public void waitForObject() { }
        public void fillObject() { }
    }
}
