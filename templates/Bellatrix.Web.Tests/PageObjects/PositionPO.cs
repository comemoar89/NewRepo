using Bellatrix.Web.NUnit;

namespace Bellatrix.Web.Tests.PageObjects;
public class PositionPO : WebTest
{ 
    public Div generalDescription => App.Components.CreateByInnerTextContaining<Div>("General Description");
    public Div requirements => App.Components.CreateByInnerTextContaining<Div>("Requirements");
    public Div responsibilities => App.Components.CreateByInnerTextContaining<Div>("Responsibilities");
    public Div whatWeOffer => App.Components.CreateByInnerTextContaining<Div>("What we offer");
    public Button applyButton => App.Components.CreateByInnerTextContaining<Button>("Apply");
}
