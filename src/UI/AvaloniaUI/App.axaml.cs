using System;
using Avalonia.Controls.ApplicationLifetimes;
using Microsoft.Extensions.DependencyInjection;
using Bootstrap.Data.IoC;
using Avalonia.Markup.Xaml;
using AvaloniaUI.ViewModels;

namespace AvaloniaUI;

public partial class App : Avalonia.Application
{
    public static IServiceProvider Services { get; private set; } = null!;
  public override void Initialize()
  {
    AvaloniaXamlLoader.Load(this);
  }
    public override void OnFrameworkInitializationCompleted()
    {
        var services = new ServiceCollection();
        services.AddBootstrap();
        services.AddTransient<MainWindowViewModel>();

        Services = services.BuildServiceProvider();
        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
        {
            desktop.MainWindow = new MainWindow
            {
                DataContext = Services.GetRequiredService<MainWindowViewModel>()
            };
        }

        base.OnFrameworkInitializationCompleted();
    }
}