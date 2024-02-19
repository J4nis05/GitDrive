using Avalonia.Controls;
using Avalonia.Interactivity;
using System.Diagnostics;

namespace GitDriveUI.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }
    
    public void ManageAccount(object source, RoutedEventArgs args)
    {
        Debug.WriteLine("Click!");
    }

    public void SelectFolder()
    {
        
    }
}