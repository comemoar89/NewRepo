﻿// <copyright file="LabelControlTestsFirefox.cs" company="Automate The Planet Ltd.">
// Copyright 2024 Automate The Planet Ltd.
// Licensed under the Apache License, Version 2.0 (the "License");
// You may not use this file except in compliance with the License.
// You may obtain a copy of the License at http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </copyright>
// <author>Anton Angelov</author>
// <site>https://bellatrix.solutions/</site>
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bellatrix.Web.Tests.Controls;

[TestClass]
[Browser(BrowserType.Firefox, Lifecycle.ReuseIfStarted)]
[AllureSuite("Label Control")]
public class LabelControlTestsFirefox : MSTest.WebTest
{
    public override void TestInit() => App.Navigation.NavigateToLocalPage(ConfigurationService.GetSection<TestPagesSettings>().LabelPage);

    [TestMethod]
    [TestCategory(Categories.Firefox), TestCategory(Categories.Windows), TestCategory(Categories.OSX)]
    public void ReturnRed_When_Hover_Firefox()
    {
        var labelElement = App.Components.CreateById<Label>("myLabel");

        labelElement.Hover();

        Assert.AreEqual("color: red;", labelElement.GetStyle());
    }

    [TestMethod]
    [TestCategory(Categories.Firefox), TestCategory(Categories.Windows), TestCategory(Categories.OSX)]
    public void ReturnAutomateThePlanet_When_InnerText_Firefox()
    {
        var labelElement = App.Components.CreateById<Label>("myLabel");

        Assert.AreEqual("Hover", labelElement.InnerText);
    }

    [TestMethod]
    [TestCategory(Categories.Firefox), TestCategory(Categories.Windows), TestCategory(Categories.OSX)]
    public void ReturnNull_When_InnerTextNotSet_Firefox()
    {
        var labelElement = App.Components.CreateById<Label>("myLabel2");

        Assert.IsNotNull(labelElement.InnerText);
    }

    [TestMethod]
    [TestCategory(Categories.Firefox), TestCategory(Categories.Windows), TestCategory(Categories.OSX)]
    public void ReturnHover_When_InnerTextSet_Firefox()
    {
        var labelElement = App.Components.CreateById<Label>("myLabel");

        Assert.AreEqual("Hover", labelElement.InnerText);
    }

    [TestMethod]
    [TestCategory(Categories.Firefox), TestCategory(Categories.Windows), TestCategory(Categories.OSX)]
    public void ReturnNull_When_InnerHtmlNotSet_Firefox()
    {
        var labelElement = App.Components.CreateById<Label>("myLabel2");

        Assert.IsNotNull(labelElement.InnerHtml);
    }

    [TestMethod]
    [TestCategory(Categories.Firefox), TestCategory(Categories.Windows), TestCategory(Categories.OSX)]
    public void ReturnButtonHtml_When_InnerHtmlSet_Firefox()
    {
        var labelElement = App.Components.CreateById<Label>("myLabel1");

        Assert.IsTrue(labelElement.InnerHtml.Contains("<button name=\"button\">Click me</button>"));
    }

    [TestMethod]
    [TestCategory(Categories.Firefox), TestCategory(Categories.Windows), TestCategory(Categories.OSX)]
    public void ReturnNull_When_ForNotSet_Firefox()
    {
        var labelElement = App.Components.CreateById<Label>("myLabel2");

        Assert.IsNull(labelElement.For);
    }

    [TestMethod]
    [TestCategory(Categories.Firefox), TestCategory(Categories.Windows), TestCategory(Categories.OSX)]
    public void ReturnLabelFor_When_ForSet_Firefox()
    {
        var labelElement = App.Components.CreateById<Label>("myLabel");

        Assert.AreEqual("myLabel", labelElement.For);
    }
}