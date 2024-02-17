using Spectre.Console;

namespace GitDriveCLI;

public class BackupHandler
{

    public void BackupTypSelection()
    {
        var highlightStyle = new Style().Foreground(Color.PaleVioletRed1);

        var choices = AnsiConsole.Prompt(
            new SelectionPrompt<string>()
                .Title("[MediumPurple1]Select an option.[/]") 
                .PageSize(10)
                .HighlightStyle(highlightStyle)
                .AddChoices(new[] {
                    "[MediumPurple1]Create New Backup[/]",
                    "[MediumPurple1]Load Backup[/]",
                    "[MediumPurple1]Delete Backup[/]"
                    
                }));

        switch (choices)
        {
            case "[MediumPurple1]Create New Backup[/]":
                this.CreateNewBackup();
                break;
            
            case  "[MediumPurple1]Load Backup[/]":
                this.LoadBackup();
                break;
            
            case "[MediumPurple1]Delete Backup[/]":
                this.DeleteBackup();
                break;
        }
    }
    
    public void CreateNewBackup()
    {
        string FilePath = AnsiConsole.Ask<string>("[MediumPurple1]Please Input a File Path[/]?");
        AnsiConsole.MarkupLine("not implementet");
    }
    
    public void LoadBackup()
    {
        AnsiConsole.MarkupLine("not implementet");
    }
    
    public void DeleteBackup()
    {
        string FilePath = AnsiConsole.Ask<string>("[MediumPurple1]Please Input a File Path[/]?");
        AnsiConsole.MarkupLine("not implementet");
    }
    
}