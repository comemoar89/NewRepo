﻿// <copyright file="ZephyrExecutionPluginEventArgs.cs" company="Automate The Planet Ltd.">
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
// <author>Miriam Kyoseva</author>
// <site>https://bellatrix.solutions/</site>

using Bellatrix.Plugins.Jira.Zephyr.Data;

namespace Bellatrix.Plugins.Jira.Zephyr.Eventargs;

public class ZephyrExecutionPluginEventArgs : PluginEventArgs
{
    public ZephyrExecutionPluginEventArgs()
    {
    }

    public ZephyrExecutionPluginEventArgs(PluginEventArgs pluginEventArgs, ZephyrTestCase testCase)
        : base(pluginEventArgs.TestOutcome,
            pluginEventArgs.Duration,
            pluginEventArgs.TestName,
            pluginEventArgs.TestMethodMemberInfo,
            pluginEventArgs.TestClassType,
            pluginEventArgs.Arguments,
            pluginEventArgs.ConsoleOutputMessage,
            pluginEventArgs.ConsoleOutputStackTrace,
            pluginEventArgs.Exception,
            pluginEventArgs.Categories,
            pluginEventArgs.Authors,
            pluginEventArgs.Descriptions) => TestCase = testCase;

    public ZephyrTestCase TestCase { get; }
}
