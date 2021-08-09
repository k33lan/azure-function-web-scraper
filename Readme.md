# Summary

This is a simple Azure Function (v3) to perform a web scrape on a HttpTrigger using .NET 5 & C# with <a href="https://www.nuget.org/packages/HtmlAgilityPack/">HtmlAgilityPack</a>.

You will need to supply your own url and an example is given for a scrape operation.

You'll also need the Azure Functions Core Tools v3+ package to run locally.

<code>npm i -g azure-functions-core-tools@3 --unsafe-perm true</code>

Warning: You should get permission of the site owner before running scrapers against their servers.