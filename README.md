# HyperUI
A UI framework for Razor Server. Coming soon.

## Quick Start
Injects static assets into the application.

``` csharp
//Program.css
using HyperUI;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();
app.UseHyperUI();  //This
```
