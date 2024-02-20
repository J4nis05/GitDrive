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

// Elements:
// 
// 
// StackPanel: Structure Root           MainStack
// 
// Border: Top Title Bar                BrdTitleBarBorder
// TextBlock: Top Title Bar             TxtTileBarText
// 
// Border: Account Bar                  BrdAccountBarBorder
// Grid: Account Bar                    GrdAccountBarGrid
// Border: Profile Picture              BrdAccountBarPictureBorder
// Image: Profile Picture               ImgAccountBarPicture
// TextBlock: Username                  TxtAccountBarUsername
// Button: Manage Account               BtnAccountBarManageAccount
// 
// Border: Main Section                 BrdMainBorder
// Grid: Main Section                   GrdMainGrid
// Button: Select Folder                BtnSelectFolder
// Button: Manage Backups               BtnManageBackups
// 
// Border: (Sub) Select Folder          BrdFolderSelectSubBorder
// Grid: (Sub) Select Folder            GrdFolderSelectGrid
// Border: (Sub) Manage Backups         BrdManageBackupsSubBorder
// Grid: (Sub) Manage Backups           GrdManageBackupsGrid
// 
// Button: Log Out                      BtnLogOut
// TextBlock: Log Out Button            TxtLogOutButton
// Button: Change Account               BtnChangeAccount
// TextBlock: Change Account Button     TxtChangeAccountButton
// Button: Purge Account                BtnPurgeAccount
// TextBlock: Purge Account Button      TxtPurgeAccountButton
// 
// TextBlock: Bottom Text               BottomText
