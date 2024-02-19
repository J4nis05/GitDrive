using System;
using System.Windows.Input;

namespace GitDriveUI.ViewModels;

public class MainWindowViewModel : ViewModelBase
{ 
    private string _greeting = "GitDriveUI\u2122 is made with Avalonia! UwU\u2122";
    private string _username = "Fahrwerk";
    
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
    
    
    private bool _isVisible;
    public bool IsVisible
    {
        get { return _isVisible; }
        set
        {
            _isVisible = value;
            OnPropertyChanged();
        }
    }

    public ICommand ToggleVisibilityCommand => new RelayCommand(ToggleVisibility);
    private void ToggleVisibility()
    {
        IsVisible = !IsVisible;
    }
}
