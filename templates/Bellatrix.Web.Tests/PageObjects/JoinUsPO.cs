using Bellatrix.Web.NUnit;

namespace Bellatrix.Web.Tests.PageObjects;
public class JoinUsPO : WebTest
{
    public Select selectLocationDropdown => App.Components.CreateByClassContaining<Select>("location");
    public Anchor position => App.Components.CreateByInnerTextContaining<Anchor>("Experienced Automation QA Engineer");
}
