using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;

namespace gittigidiyorTestTrainng.Pages
{
    public class shoppingPage : BasePage
    {
        public shoppingPage(IWebDriver _driver) : base(_driver)
        {

        }

        #region Elements
        [FindsBy(How = How.XPath, Using = "//*[@id='header_wrapper']/div[6]/div[6]")]
        public IWebElement horizontalMenu { get; set; }

        [FindsBy(How = How.CssSelector, Using = "a[href = '//www.gittigidiyor.com/balik-akvaryum/balik-yemi']")]
        public IWebElement fishFeedButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#filter-spec-2-1~.checkmark")]
        public IWebElement brineCheck { get; set; }

        [FindsBy(How = How.Id, Using = "search-page-tab-free-shipping")]
        public IWebElement freeCargoCheck { get; set; }

        [FindsBy(How = How.ClassName, Using = "img-cont")]
        public IWebElement firstProduct { get; set; }
        
        [FindsBy(How = How.Id, Using = "add-to-basket")]
        public IWebElement addToBasket { get; set; }

        [FindsBy(How = How.ClassName, Using = "btn-pay")]
        public IWebElement completeShopping { get; set; }

        #endregion

        #region Methods

        public void hoverMenu()
        {
            HoverElement(horizontalMenu);
        }

        public void clickFishFeed()
        {
            Click(fishFeedButton);
        }

        public void clickBrineCheckBox()
        {
            ScrollTo(brineCheck);
            Click(brineCheck);
           
        }

        public void clickFreeCargoCheckBox()
        {
            Click(freeCargoCheck);
        }

        public void clickFirstProduct()
        {
            Click(firstProduct);
        }

        public void clickAddToBasket()
        {
            ScrollTo(addToBasket);
            Click(addToBasket);
        }

        public void clickCompleteShopping()
        {
            Click(completeShopping);
        }

        #endregion
    }
}


