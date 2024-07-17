using Bellatrix.Web.NUnit;

namespace Bellatrix.Web.Tests.PageObjects;
public class HomePagePO : WebTest
{   
    public Anchor contactUsLink => App.Components.CreateByLinkText<Anchor>("Company");
    public Anchor companyTab => App.Components.CreateByLinkText<Anchor>("Company");
    public Anchor careersLink => App.Components.CreateByLinkText<Anchor>("Careers");
    
}
