using Bellatrix.Web.NUnit;

namespace Bellatrix.Web.Tests.PageObjects;
public class CareersPO : WebTest
{
    public Button openPositionsButton => App.Components.CreateByInnerTextContaining<Button>("Check our open positions");
}
