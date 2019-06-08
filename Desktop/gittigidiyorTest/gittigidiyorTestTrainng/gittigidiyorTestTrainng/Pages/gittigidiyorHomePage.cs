using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace gittigidiyorTestTrainng.Pages
{
    public class gittigidiyorHomePage : BasePage
    {
        public gittigidiyorHomePage(IWebDriver _driver) : base(_driver)
        {
        }

        #region Elements

        [FindsBy(How = How.ClassName, Using = "profile-icon-title")]
        public IWebElement loginHover { get; set; }

        [FindsBy(How = How.Id, Using = "SignIn")]

        #endregion

        #region Methods
        public IWebElement loginbutton { get; set; }

        public void ClickLogin()
        {
            HoverElement(loginHover);
            Click(loginbutton);
        }
        #endregion
    }
}
