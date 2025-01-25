using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
{
    #region Control ID
    private IWebDriver driver;
    [FindsBy(How = How.CssSelector, Using = "Enteramount")]
    private IWebElement Enteramount;

    [FindsBy(How = How.CssSelector, Using = "IdCardUser")]
    private IWebElement IdCardUser;

    [FindsBy(How = How.CssSelector, Using = "NavigateMakepayment")]
    private IWebElement NavigateMakepayment;

    [FindsBy(How = How.CssSelector, Using = "Totalvalue")]
    private IWebElement Totalvalue;

     #endregion
    public RechargePage(WebDriver driver) {
        this.driver = driver;
    }

    public void EnterTopupAmount(int amount) 
    {
        Enteramount.SendKeys(amount.ToString());
        Console.WriteLine("Enter Top-up amount : {0}", amount.ToString());
    }

    public bool CheckIdCardUser(string idCard)
    {
        bool VerifyIdCard = false; 
        if(IdCardUser.Text.Equals(idCard, StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("Verify the ID card is correct");
            VerifyIdCard = true; 
        }
        else
        {
            Console.WriteLine("Verify the ID card is incorrect");
        }
        
        return VerifyIdCard; 
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

    public void Makepayment()
    {
        NavigateMakepayment.Click();
        Console.WriteLine("redirected to the payment page.");
    }


    
}