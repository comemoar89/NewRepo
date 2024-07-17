using Bellatrix.Web.NUnit;

namespace Bellatrix.Web.Tests.PageObjects;
public class ContactUsPO : WebTest
{
    public TextField MessageField => App.Components.CreateById<TextField>("message");
    public TextField NameField => App.Components.CreateById<TextField>("name");
    public TextField EmailField => App.Components.CreateById<TextField>("email");
    public Button SendButton => App.Components.CreateByClass<Button>("wpcf7-submit");
}
