using AventStack.ExtentReports;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital_Form_builder_Test.Utilities
{
    public class GetScreenShot 
    {
        public static MediaEntityModelProvider CaptureScreenShot(IWebDriver Driver,String screenShotName)
        {
            ITakesScreenshot ts = (ITakesScreenshot)Driver;
            String screenShot = ts.GetScreenshot().AsBase64EncodedString;
            return MediaEntityBuilder.CreateScreenCaptureFromBase64String(screenShot, screenShotName).Build();

        }
        
    }
}
