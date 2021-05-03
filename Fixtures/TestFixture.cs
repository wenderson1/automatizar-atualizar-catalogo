using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using TestProject1.Helpers;

namespace TestProject1.Fixtures
{
    public class TestFixture //:IDisposable
    {
        public IWebDriver Driver { get; private set; }

        public TestFixture()
        {
            Driver = new ChromeDriver(TestHelper.PastaDoExecutavel);
        }

        //fecha navegador
        /*public void Dispose()
        {
            Driver.Quit();
        }*/
    }
}
