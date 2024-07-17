using Bellatrix.Web.NUnit;

namespace Bellatrix.Web.Tests.PageObjects;

public class CompanyPO : WebTest
{
    public Div leadershipSection => App.Components.CreateByInnerTextContaining<Div>("Leadership");
    public Anchor facebookLink => App.Components.CreateByAttributesContaining<Anchor>("href", "facebook.com");
}
