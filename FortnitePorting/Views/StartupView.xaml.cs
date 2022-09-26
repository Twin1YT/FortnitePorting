﻿using System.Windows;
using FortnitePorting.Runtime;
using FortnitePorting.ViewModels;

namespace FortnitePorting.Views;

public partial class StartupView
{
    public StartupView()
    {
        InitializeComponent();
        AppVM.StartupVM = new StartupViewModel();
        DataContext = AppVM.StartupVM;
        
        AppVM.StartupVM.CheckForInstallation();
    }

    private void OnClickContinue(object sender, RoutedEventArgs e)
    {
        Close();
    }
    
    private void OnClickInstallation(object sender, RoutedEventArgs e)
    {
        if (AppHelper.TrySelectFolder(out var path))
        {
            AppVM.StartupVM.ArchivePath = path;
        }
    }
}