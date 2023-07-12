using Audiator.Services;
using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using Audiator.ViewModels;
using Audiator.Views;

namespace Audiator;

public partial class App : Application
{
    public override void Initialize()
    {
        AvaloniaXamlLoader.Load(this);
    }

    public override void OnFrameworkInitializationCompleted()
    {
        #region DI

        var audioInterface = new AudioPlayer();
        var fileInterface = new FileExplorer();
        var audioScheduleInterface = new AudioScheduler();
        #endregion

        var mainViewModel = new MainViewModel(fileInterface, audioInterface, audioScheduleInterface);

        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
        {
            desktop.MainWindow = new MainWindow
            {
                DataContext = mainViewModel
            };
        }
        else if (ApplicationLifetime is ISingleViewApplicationLifetime singleViewPlatform)
        {
            singleViewPlatform.MainView = new MainView
            {
                DataContext = mainViewModel
            };
        }

        base.OnFrameworkInitializationCompleted();
    }
}