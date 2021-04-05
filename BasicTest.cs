using System.Linq;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;

namespace SeleniumExampleTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestUrl()
        {
            var driver = new ChromeDriver();
            driver.Url = "http://google.ru";
            Assert.IsTrue(driver.Url.Contains("google"),"Что-то пошло не так");
            driver.Close();
        }
    }
}