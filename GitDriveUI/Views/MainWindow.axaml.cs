using System;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using System.Diagnostics;
using GitDriveUI.ViewModels;

namespace GitDriveUI.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void BtnMangeAccount_OnClick(object? sender, RoutedEventArgs e)
    {
        BrdMainBorder.IsVisible = !BrdMainBorder.IsVisible;
    }
    
    private void BtnSelectFolder_OnClick(object? sender, RoutedEventArgs e)
    {
        if (BrdManageBackupsSubBorder.IsVisible)
        {
            BrdManageBackupsSubBorder.IsVisible = false;
        }
        
        BrdFolderSelectSubBorder.IsVisible = !BrdFolderSelectSubBorder.IsVisible;
    }
    
    private void BtnManageBackups_OnClick(object? sender, RoutedEventArgs e)
    {
        if (BrdFolderSelectSubBorder.IsVisible)
        {
            BrdFolderSelectSubBorder.IsVisible = false;
        }
        
        BrdManageBackupsSubBorder.IsVisible = !BrdManageBackupsSubBorder.IsVisible;
    }

    private void BtnLogOut_OnClick(object? sender, RoutedEventArgs e)
    {
        Console.Out.Write("Hello");
    }

    private void BtnChangeAccount_OnClick(object? sender, RoutedEventArgs e)
    {
        Console.Out.Write("Hello");
    }

    private void BtnPurgeAccount_OnClick(object? sender, RoutedEventArgs e)
    {
        Console.Out.Write("Hello");
    }
}