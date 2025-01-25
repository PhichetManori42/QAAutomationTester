using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
public class PaymentPage 
{
    #region Control ID
    private IWebDriver driver;

    [FindsBy(How = How.CssSelector, Using = "Totalvalue")]
    private IWebElement Totalvalue;

    [FindsBy(How = How.Id, Using = "uploadFile")]
    private IWebElement uploadFile;

    [FindsBy(How = How.Id, Using = "uploadButton")]
    private IWebElement uploadButton;

     #endregion
    public PaymentPage(WebDriver driver) {
        this.driver = driver;
    }

    public bool CheckTotalvalue(int amount)
    {
        bool VerifyTotalvalue = false; 
        if(Totalvalue.Text.Equals(amount.ToString()))
        {
            Console.WriteLine("Verify the ID card is correct");
            VerifyTotalvalue = true; 
        }
        else
        {
            Console.WriteLine("Verify the ID card is incorrect");
        }
        
        return VerifyTotalvalue; 
    }

    public void Uploadimage(string filePath)
    {
        uploadFile.SendKeys(filePath);
        uploadButton.Click();
    }

    
}