using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace gittigidiyorTestTrainng.Pages
{
    public class addressPage : BasePage
    {
        public addressPage(IWebDriver _driver) : base(_driver)
        {
        }

        #region Elements
        [FindsBy(How = How.Name, Using = "Name")]
        public IWebElement name { get; set; }

        [FindsBy(How = How.Name, Using = "SurName")]
        public IWebElement surname { get; set; }

        [FindsBy(How = How.Name, Using = "City")]
        public IWebElement city { get; set; }

        [FindsBy(How = How.Name, Using = "District")]
        public IWebElement district { get; set; }

        [FindsBy(How = How.Name, Using = "Address")]
        public IWebElement address { get; set; }

        [FindsBy(How = How.Name, Using = "phone-number")]
        public IWebElement phone { get; set; }

        [FindsBy(How = How.ClassName, Using = "post-address")]
        public IWebElement saveAndCont { get; set; }

        [FindsBy(How = How.Id, Using = "P-PayViaCredit")]
        public IWebElement payViaCredit { get; set; }

        #endregion

        #region Methods

        public void setNameText(string nameText)
        {
            SendKeys(name, nameText);
        }

        public void setSurameText(string surnameText)
        {
            SendKeys(surname, surnameText);
        }

        public void selectCity(string cityText)
        {
            SelectOptionByValue(city, cityText);
            Wait(10);

        }

        public void selectDistrict(string districtText)
        {
            SelectOptionByText(district, districtText);
        }

        public void setAddressText(string addressText)
        {
            SendKeys(address, addressText);
        }

        public void setPhone(string phoneText)
        {
            SendKeys(phone, phoneText);
        }

        public void clickContinue()
        {
            Click(saveAndCont);
        }

        public void clickPayViCredit()
        {
            Click(payViaCredit);
        }

        #endregion
    }
}
