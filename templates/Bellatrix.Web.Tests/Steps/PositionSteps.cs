using Bellatrix.Web.Tests.PageObjects;

namespace Bellatrix.Web.Tests.Steps;
public class PositionSteps
{
    public PositionPO positionPO;

    public void clickApplyButton()
    {
        positionPO.applyButton.Click();
    }
}
