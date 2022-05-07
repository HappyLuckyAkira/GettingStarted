using GettingStarted;
using Kamishibai;
using Microsoft.Extensions.Hosting;

var builder = KamishibaiApplication<App,MainWindow>.CreateBuilder();

builder.Services.AddPresentation<MainWindow, MainViewModel>();
builder.Services.AddPresentation<FirstPage, FirstViewModel>();


var app = builder.Build();
app.RunAsync();

