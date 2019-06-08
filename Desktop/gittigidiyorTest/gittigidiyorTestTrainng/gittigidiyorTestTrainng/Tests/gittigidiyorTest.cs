using gittigidiyorTestTrainng.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.IO;
using System.Threading;
using TechTalk.SpecFlow;

namespace gittigidiyorTest
{
    [Binding, Scope(Tag = "mytag")]
    public class BaseTest
    {
        public IWebDriver _driver;
        public const string MAAIN_PAGE_URL = "https://www.gittigidiyor.com/";
        public gittigidiyorHomePage gittigidiyorHomePage;
        public loginPage loginPage;
        public shoppingPage shoppingPage;
        public addressPage addressPage;

        #region Before Scenario
        [BeforeScenario]
        public void Before()
        {
            string driverPath = Path.Combine(@"C:\Users\Halil Coşgun\Desktop\vs Projects\gittigidiyorTestTrainng\gittigidiyorTestTrainng\Driver");

            #region Chrome Options
            ChromeOptions chromeOptions = new ChromeOptions();
            chromeOptions.AddArgument("start-maximized");
            chromeOptions.AddArguments("start-maximized");
            chromeOptions.AddArguments("test-type");
            chromeOptions.AddArguments("disable-popup-blocking");
            chromeOptions.AddArguments("ignore-certificate-errors");
            chromeOptions.AddArguments("disable-translate");
            chromeOptions.AddArguments("disable-automatic-password-saving");
            chromeOptions.AddArguments("allow-silent-push");
            chromeOptions.AddArguments("disable-infobars");
            #endregion

            _driver = new ChromeDriver(driverPath, chromeOptions);

            gittigidiyorHomePage = new gittigidiyorHomePage(_driver);
            loginPage = new loginPage(_driver);
            shoppingPage = new shoppingPage(_driver);
            addressPage = new addressPage(_driver);
        }
        #endregion

        #region StepDefinitions

        [StepDefinition(@"gittigidiyor ana sayfa açılır")]
        public void openMainPage()
        {
            _driver.Navigate().GoToUrl(MAAIN_PAGE_URL);
            Assert.AreEqual(_driver.Url, "https://www.gittigidiyor.com/", "hata alındı");
            Console.Write("success");

        }

        [StepDefinition(@"giriş yap butonuna tıklanır")]
        public void clickLoginButton()
        {
            gittigidiyorHomePage.ClickLogin();

        }

        [StepDefinition(@"kulanıcı adı veya E-Posta adresi alanına '(.*)' şifre alanına '(.*)' yazılır")]
        public void fillLoginFields(string username, string password)
        {
            loginPage.SetText(username, password);

        }

        [StepDefinition(@"login sayfasındaki giriş yap butonuna tıklanır")]
        public void clickLoginPageLoginButton()
        {
            loginPage.ClickLogin();

        }

        [StepDefinition(@"süpermarket kategorisi seçilir")]
        public void selectSuperMarket()
        {
            shoppingPage.hoverMenu();

        }

        [StepDefinition(@"süpermarket kategorisinden balık yemi tıklanır")]
        public void clickFishFeed()
        {
            shoppingPage.clickFishFeed();

        }

        [StepDefinition(@"yan bardan akvaryum türü tuzlu su seçilir")]
        public void selectBrine()
        {
            shoppingPage.clickBrineCheckBox();

        }

        [StepDefinition(@"üstteki bardan ücretsiz kargo seçeneği işaretlenir")]
        public void selectFreeCargo()
        {
            shoppingPage.clickFreeCargoCheckBox();

        }

        [StepDefinition(@"ilk ürünün üzerine tıklanır")]
        public void selectFirstProduct()
        {
            shoppingPage.clickFirstProduct();

        }

        [StepDefinition(@"sepete ekle butonuna tıklanır")]
        public void addToBasket()
        {
            shoppingPage.clickAddToBasket();

        }

        [StepDefinition(@"alışverişi tamamla butonu tıklanır")]
        public void completeShopping()
        {
            shoppingPage.clickCompleteShopping();

        }

        [StepDefinition(@"adres bilgileri sayfasında ad alanına '(.*)' yazılır")]
        public void setTextName(string name)
        {
            addressPage.setNameText(name);

        }

        [StepDefinition(@"adres bilgileri sayfasında soyad alanına '(.*)' yazılır")]
        public void setTextSurname(string surname)
        {
            addressPage.setSurameText(surname);

        }

        [StepDefinition(@"adres bilgileri sayfasında şehir '(.*)' seçilir")]
        public void setCity(string city)
        {
            addressPage.selectCity(city);

        }

        [StepDefinition(@"adres bilgileri sayfasında ilçe '(.*)' seçilir")]
        public void setDistrict(string district)
        {
            addressPage.selectDistrict(district);

        }

        [StepDefinition(@"adres bilgileri sayfasında adres alanına '(.*)' yazılır")]
        public void setAddress(string address)
        {
            addressPage.setAddressText(address);

        }

        [StepDefinition(@"adres bilgileri sayfasında telefon-1 alanına '(.*)' yazılır")]
        public void setPhoneNumber(string phone)
        {
            addressPage.setPhone(phone);

        }

        [StepDefinition(@"devam et butonuna tıklanır")]
        public void clickCont()
        {
            addressPage.clickContinue();

        }

        [StepDefinition(@"ödeme türü kredili seçilir")]
        public void clickPayViaCredit()
        {
            addressPage.clickPayViCredit();

        }
        #endregion

        #region After Scenario

        [AfterScenario]
        public void After()
        {
            Thread.Sleep(TimeSpan.FromSeconds(5));
            _driver.Close();
        }
        #endregion
    }
}
