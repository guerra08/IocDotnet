using IocDotnet;
using Spectre.Console.Cli;

var app = new CommandApp<IocCommand>();
return app.Run(args);