using Bellatrix.Web.Tests.PageObjects;

namespace Bellatrix.Web.Tests.Steps;

public class CompanySteps
{
    public CompanyPO companyPO = new CompanyPO();

    public void clickFacebookLink()
    {
        companyPO.facebookLink.Click();
    }
}
