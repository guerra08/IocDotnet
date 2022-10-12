using Spectre.Console;
using Spectre.Console.Cli;

namespace IocDotnet;

public sealed class IocCommand : Command<IocCommand.Settings>
{
    public sealed class Settings : CommandSettings
    {
        [CommandArgument(0, "<file>")]
        public string File { get; init; }
    }

    public override int Execute(CommandContext context, Settings settings)
    {
        var file = settings.File;
        AnsiConsole.Markup($"Processing file: [bold]{settings.File}[/]\n");
        var fileContents = File.ReadAllText(file).ToCharArray();
        var iocValue = Ioc.Compute(fileContents);
        AnsiConsole.Markup($"Index of coincidence value for file {settings.File}: [bold]{iocValue}[/]\n");
        return 0;
    }
}