using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
public class HomePage 
{
    private IWebDriver driver;
    [FindsBy(How = How.Id, Using = "NavigateRecharge")]
    private IWebElement NavigateRechargePage;

    public HomePage(WebDriver driver) {
        this.driver = driver;
    }

    public void TopupNokCash() {
        NavigateRechargePage.Click();
        Console.WriteLine("redirected to the ABC top-up page.");
    }
    
}