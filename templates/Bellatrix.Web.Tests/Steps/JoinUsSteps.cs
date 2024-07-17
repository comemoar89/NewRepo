using Bellatrix.Web.Tests.PageObjects;

namespace Bellatrix.Web.Tests.Steps;
public class JoinUsSteps
{
    public JoinUsPO joinUsPO;

    public void selectCities()
    {
        joinUsPO.selectLocationDropdown.SelectByText("Sofia");
        joinUsPO.selectLocationDropdown.SelectByText("Skopje");
    }

    public void selectPosition()
    {
        joinUsPO.position.Click();
    }
}
