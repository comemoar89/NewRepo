using Bellatrix.Web.Tests.PageObjects;

namespace Bellatrix.Web.Tests.Steps;
public class CareersSteps
{
    public CareersPO careersPO;

    public void clickOpenPositionsButton()
    {
        careersPO.openPositionsButton.Click();
    }
}
