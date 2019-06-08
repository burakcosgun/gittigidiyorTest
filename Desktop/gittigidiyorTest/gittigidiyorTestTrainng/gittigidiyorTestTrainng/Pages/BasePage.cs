using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;

namespace gittigidiyorTestTrainng.Pages
{
    public class BasePage
    {
        private IWebDriver _driver;

        public BasePage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }

        public void Click(IWebElement webel)
        {

            GetScriptExecutor().ExecuteScript("arguments[0].setAttribute('style','background: yellow; border: 2px solid red;');", webel);
            UntilElementClickable(webel);
            webel.Click();
        }

        public void SendKeys(IWebElement webel, string text)
        {
            webel.Clear();
            webel.SendKeys(text);
        }

        public void HoverElement(IWebElement webel)
        {
            Actions hoverAction = new Actions(_driver);
            hoverAction.MoveToElement(webel).Build().Perform();
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(3));
        }

        public void UntilElementClickable(IWebElement webel)
        {
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(20));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(webel));
        }

        public void Wait(int second)
        {
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(second));
        }

        public IJavaScriptExecutor GetScriptExecutor()
        {
            return (IJavaScriptExecutor)_driver;
        }

        public void ScrollTo(IWebElement webel)
        {
            string jsStmt = String.Format("window.scrollTo({0},{1})", webel.Location.X, webel.Location.Y);
            GetScriptExecutor().ExecuteScript(jsStmt, true);
        }

        public void SelectOptionByValue(IWebElement webel, string value)
        {
            SelectElement selectElement = new SelectElement(webel);
            selectElement.SelectByValue(value);
        }

        public void SelectOptionByText(IWebElement webel, string value)
        {
            SelectElement selectElement = new SelectElement(webel);
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(20));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.TextToBePresentInElement(webel, value));
            selectElement.SelectByText(value);


        }

    }
}
