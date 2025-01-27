﻿using Avalonia;
using AvaloniaApplication.Domain;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;

using AvaloniaApplication.ViewModels;
using AvaloniaApplication.Views;

namespace AvaloniaApplication;

public partial class App : Application
{
    public override void Initialize()
    {
        AvaloniaXamlLoader.Load(this);
    }

    public override void OnFrameworkInitializationCompleted()
    {
        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
        {
            desktop.MainWindow = new MainWindow
            {
                DataContext = new MainViewModel(InitServiecs())
            };
        }
        else if (ApplicationLifetime is ISingleViewApplicationLifetime singleViewPlatform)
        {
            singleViewPlatform.MainView = new MainView
            {
                DataContext = new MainViewModel(InitServiecs())
            };
        }

        base.OnFrameworkInitializationCompleted();
    }
    private ServiceProvider InitServiecs()
    {
        ServiceProvider serviceProvider = new ServiceProvider();
        MemoryService memoryService = new MemoryService();
        serviceProvider.RegisterService(memoryService);
        return serviceProvider;
    }
}
