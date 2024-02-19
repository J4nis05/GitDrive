using Avalonia.Controls;
using Avalonia.Interactivity;
using System.Diagnostics;
using GitDriveUI.ViewModels;

namespace GitDriveUI.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }
    
    public void ManageAccount()
    {
        
    }

    private void BtnMangeAccount_OnClick(object? sender, RoutedEventArgs e)
    {
        Debug.Print("Hello");
    }
    
    private void BtnSelectFolder_OnClick(object? sender, RoutedEventArgs e)
    {
        BrdFolderSelectSubBorder.IsVisible = true;
    }
    
    private void BtnManageBackups_OnClick(object? sender, RoutedEventArgs e)
    {
        BrdManageBackupsSubBorder.IsVisible.Equals(true);
    }
}