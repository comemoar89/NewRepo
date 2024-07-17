using Bellatrix.Web.NUnit;

namespace Bellatrix.Web.Tests.PageObjects;
public class FacebookPO : WebTest
{
   public Image profilePicture => App.Components.CreateByAttributesContaining<Image>("src", "MusalaSoft");
}
