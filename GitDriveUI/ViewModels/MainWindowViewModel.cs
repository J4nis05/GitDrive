using System;
using System.Windows.Input;
using ReactiveUI;

namespace GitDriveUI.ViewModels;

public class MainWindowViewModel : ViewModelBase
{ 
    private string _greeting = "GitDriveUI\u2122 is made with Avalonia! UwU\u2122";
    private string _username = "Fahrwerk";
    private bool _showSelectFolder;
    private bool _showManageBackups;
    
    public string Greeting
    {
        get { return _greeting; }
        set { _greeting = value; }
    }

    public string Username
    {
        get { return _username; }
        set { _username = value; }
    }
    
    public bool ShowSelectFolder
    {
        get => _showSelectFolder;
        set => this.RaiseAndSetIfChanged(ref _showSelectFolder, value);
    }
    
    public bool ShowManageBackups
    {
        get => _showManageBackups;
        set => this.RaiseAndSetIfChanged(ref _showManageBackups, value);
    }
}

    // private bool _isVisible;
    // public bool IsVisible
    // {
    //     get { return _isVisible; }
    //     set
    //     {
    //         _isVisible = value;
    //         OnPropertyChanged();
    //     }
    // }
    //
    // public ICommand ToggleVisibilityCommand => new RelayCommand(ToggleVisibility);
    // private void ToggleVisibility()
    // {
    //     IsVisible = !IsVisible;
    // }
