// See https://aka.ms/new-console-template for more information
using GitDriveCLI;using Spectre.Console;

BackupHandler backupHandler = new BackupHandler();

AnsiConsole.Write(
    new FigletText("GitDrive")
        .Centered()
        .Color(Color.MediumPurple1));

var highlightStyle = new Style().Foreground(Color.PaleVioletRed1);

var choices = AnsiConsole.Prompt(
    new SelectionPrompt<string>()
        .Title("[MediumPurple1]Select an option.[/]") 
        .PageSize(10)
        .HighlightStyle(highlightStyle)
        .AddChoices(new[] {
            "[MediumPurple1]Manage GitHubAcc.[/]", "[MediumPurple1]Upload Folder[/]",
            "[MediumPurple1]Manage Backup[/]","[indianred1]Exit[/]",
        }));

switch (choices)
{
    case "[MediumPurple1]Manage GitHubAcc.[/]":
        AnsiConsole.MarkupLine("NotImplementet");
        break;
    
    case "[MediumPurple1]Upload Folder[/]":
        AnsiConsole.MarkupLine("NotImplementet");
        break;
    
    case "[MediumPurple1]Manage Backup[/]":
        backupHandler.BackupTypSelection();
        break;
        
        
        
        
}

    


Console.Read();