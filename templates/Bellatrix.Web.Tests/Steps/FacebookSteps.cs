using Bellatrix.Web.Tests.PageObjects;

namespace Bellatrix.Web.Tests.Steps;
public class FacebookSteps
{
    public FacebookPO facebookPO = new FacebookPO();

    public void clickFacebookLink()
    {
        facebookPO.profilePicture.Click();
    }
}
