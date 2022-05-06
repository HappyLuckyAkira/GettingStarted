using GettingStarted;
using Kamishibai;
using Microsoft.Extensions.Hosting;

var builder = KamishibaiApplication<App,MainWindow>.CreateBuilder();

var app = builder.Build();
app.RunAsync();
