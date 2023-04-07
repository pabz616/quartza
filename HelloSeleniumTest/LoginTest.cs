namespace HelloSeleniumTest;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

//NEED TO LEARN C#
[TestClass]
public class SeleniumValidLoginTest{
    IWebDriver driver = null;

    [TestMethod]
    public void SeleniumValidLoginTest(){
        driver = new ChromeDriver();
        driver.Navigate().GoToUrl("http://travel.agileway.net");
        driver.FindElement(By.Name("username")).SendKeys("agileway");
        driver.FindElement(By.Name("password")).SendKeys("testwise");
        driver.FindElement(By.Name("password")).Submit();
        Assert.IsTrue(driver.PageSource.Contains("Signed in!"));
        driver.Quit();
    }
}