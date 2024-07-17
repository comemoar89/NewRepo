using Bellatrix.Web.Tests.PageObjects;

namespace Bellatrix.Web.Tests.Steps;
public class ContactUsPageSteps
{
    public ContactUsPO contactUsPO = new ContactUsPO();

    public void fillInContactusFormAndSubmit()
    {
        contactUsPO.NameField.SetText("Test name");
        contactUsPO.MessageField.SetText("Test message");
        contactUsPO.EmailField.SetText("Some invalid email.com");
        contactUsPO.SendButton.Click();
    }
}
