using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace gittigidiyorTestTrainng.Pages
{
    public class loginPage : BasePage
    {
        public loginPage(IWebDriver _driver) : base(_driver)
        {

        }

        #region Elements

        [FindsBy(How = How.Id, Using = "L-UserNameField")]
        public IWebElement userName { get; set; }

        [FindsBy(How = How.Id, Using = "L-PasswordField")]
        public IWebElement password { get; set; }

        [FindsBy(How = How.Id, Using = "gg-login-enter")]
        public IWebElement loginEnter { get; set; }

        #endregion

        #region Methods
        public void SetText(string user , string pass)
        {
            SendKeys(userName , user );
            SendKeys(password, pass);
        }
        public void ClickLogin()
        {
            Click(loginEnter);
        }

        #endregion
    }
}
