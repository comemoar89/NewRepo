using Bellatrix.Web.Tests.PageObjects;

namespace Bellatrix.Web.Tests.Steps;
public class HomePageSteps
{
    public HomePagePO homePagePO = new HomePagePO();
    
    public void clickContactUsLink()
    {
        homePagePO.contactUsLink.Click();
    }

    public void clickComppanyLink()
    {
        homePagePO.companyTab.Click();
    }

    public void clickCareersLink()
    {
        homePagePO.careersLink.Click();
    }
}
