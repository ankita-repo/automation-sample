using NUnit.Framework.Internal;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using log4net;

namespace SeleniumWebdriver.BaseClasses
{
    class BaseClass
    {
        private static ChromeOptions GetChromeOptions()
        {
            ChromeOptions option = new ChromeOptions();
            option.AddArgument("start-maximized");
            //option.AddArgument("--headless");
            //option.AddExtension(@"C:\Users\rahul.rathore\Desktop\Cucumber\extension_3_0_12.crx");
            // Logger.Info(" Using Chrome Options ");
            return option;
        }
    }
}

