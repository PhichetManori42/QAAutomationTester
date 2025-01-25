using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestPayment
{
    public class Test
    {
        private ChromeDriver? driver;
        private HomePage? homepage;
        private RechargePage? rechargePage;
        private PaymentPage? paymentPage;
        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            homepage = new HomePage(driver);
            rechargePage = new RechargePage(driver);
            paymentPage = new PaymentPage(driver);
        }

        [Test]
        public void TestStorm()
        {
            homepage?.TopupNokCash();
            rechargePage?.CheckIdCardUser("IdCard");
            rechargePage?.EnterTopupAmount(105);
            rechargePage?.CheckTotalvalue(105);
            rechargePage?.Makepayment();
            paymentPage?.CheckTotalvalue(105);
            paymentPage?.Uploadimage("filePath");


        }
        
        [TearDown]
        public void TearDown()
        {
            driver?.Quit();
        }
    }
}