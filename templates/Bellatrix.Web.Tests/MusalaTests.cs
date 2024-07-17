using NUnit.Framework;
using Bellatrix.Web.NUnit;
using Bellatrix.Web.Tests.PageObjects;
using Bellatrix.Web.Tests.Steps;

namespace Bellatrix.Web.Tests;

[TestFixture]
////[Browser(BrowserType.Chrome, Lifecycle.ReuseIfStarted)]
public class MusalaTests : WebTest
{
    public ContactUsPageSteps contactUsPageSteps;
    public HomePageSteps homePageSteps;
    public CompanySteps companySteps;
    public FacebookSteps facebookSteps;
    public CareersSteps careersSteps;
    public JoinUsSteps joinUsSteps;
    public PositionPO positionPO;
    public PositionSteps positionSteps;

    public MusalaTests()
    {
        contactUsPageSteps = new ContactUsPageSteps();
        homePageSteps = new HomePageSteps();
        companySteps = new CompanySteps();
        facebookSteps = new FacebookSteps();
        joinUsSteps = new JoinUsSteps();
        positionPO = new PositionPO();
        positionSteps = new PositionSteps();
    }

    public override void TestInit() => App.Navigation.Navigate("http://www.musala.com");

    [Test]
    public void FillContactFormWithInvalidEmail()
    {
       homePageSteps.clickContactUsLink();
       contactUsPageSteps.fillInContactusFormAndSubmit();
       //var errorMessage = App.Components.CreateByInnerTextContaining<Div>("The e-mail address entered is invalid.");
       //Assert.IsTrue(errorMessage.IsVisible)*/;
    }

    [Test]
    public void VerifyMusalaWebsite()
    {

        homePageSteps.clickComppanyLink();
        Assert.Equals("http://www.musala.com/company/", App.Browser.Url);

        var leadershipSection = App.Components.CreateByInnerTextContaining<Div>("Leadership");
        //Assert.IsTrue(leadershipSection.IsVisible);

        companySteps.clickFacebookLink();
        Assert.Equals("https://www.facebook.com/MusalaSoft?fref=ts", App.Browser.Url);

        var profilePicture = App.Components.CreateByAttributesContaining<Image>("src", "MusalaSoft");
        // Assert.IsTrue(profilePicture.IsVisible);
    }

    [Test]
    public void ApplyForJobWithNegativeData()
    {
        homePageSteps.clickCareersLink();

        careersSteps.clickOpenPositionsButton();

        App.Navigation.WaitForPartialUrl("http://www.musala.com/careers/join-us/");

        joinUsSteps.selectCities();
        joinUsSteps.selectPosition();

        Assert.Multiple(() =>
        {
            Assert.That(positionPO.generalDescription.IsVisible);
            Assert.That(positionPO.requirements.IsVisible);
            Assert.That(positionPO.responsibilities.IsVisible);
            Assert.That(positionPO.whatWeOffer.IsVisible);
        });

       
        Assert.That(positionPO.applyButton.IsVisible);
        positionSteps.clickApplyButton();

        // Negative Data Testing
        // Add negative data scenarios here

        //var cvUpload = App.Components.CreateByClass<Inpput>("cv-upload");
        //cvUpload.Upload("path_to_cv_document.pdf");

        var sendButton = App.Components.CreateByInnerTextContaining<Button>("Send");
        sendButton.Click();

        // Verify error messages
        // Add verification of error messages here
    }

    [Test]
    public void Test_CareersPage_OpenPositionsByCity()
    {
        homePageSteps.clickCareersLink();

        careersSteps.clickOpenPositionsButton();

        joinUsSteps.selectCities();

        var positionsByCity = App.Components.CreateAllByClassContaining<Div>("position");
        foreach (var position in positionsByCity)
        {
            TestContext.WriteLine(position.InnerText);
        }
    }
}