using System;

namespace GitDriveUI.ViewModels;

public class MainWindowViewModel : ViewModelBase
{ 
    private string _greeting = "GitDriveUI is made with Avalonia! UwU";
    private string _username = "Fahrwerk";
    
    public string Greeting
    {
        get
        {
            return _greeting;
        }
        set
        {
            _greeting = value;
        }
    }

    public string Username
    {
        get
        {
            return _username;
        }
    }
}