﻿using Bellatrix.Playwright.SyncPlaywright;
using Bellatrix.Playwright.WaitStrategies;
using static Microsoft.Playwright.Assertions;

namespace Bellatrix.Playwright.GettingStarted;

// 1. Imagine that you want to wait for an element to have a specific style. First, create a new class and inherit the WaitStrategy class.
public class WaitToHasStyleStrategy : WaitStrategy
{
    private readonly string _elementStyle;

    public WaitToHasStyleStrategy(string elementStyle, int? timeoutInterval = null, int? sleepInterval = null)
        : base(timeoutInterval, sleepInterval)
    {
        _elementStyle = elementStyle;
    }

    public override void WaitUntil<TComponent>(TComponent component)
    {
        WaitUntil(component.WrappedElement);
    }

    public override void WaitUntil(WebElement element)
    {
        // Here, we use the native Playwright assertions
        Expect(element.WrappedLocator).ToHaveCSSAsync("style", _elementStyle, new() { Timeout = TimeoutInterval }).GetAwaiter().GetResult();
    }
}
