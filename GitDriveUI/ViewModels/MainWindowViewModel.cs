using System.Windows.Input;
using ReactiveUI;

namespace GitDriveUI.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    public string Greeting { get; set; } = "GitDriveUI\u2122 is made with Avalonia! UwU\u2122";
    public string Username { get; set; } = "Fahrwerk";
}
