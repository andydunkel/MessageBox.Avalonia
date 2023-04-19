using System.Globalization;
using System.Threading;
using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using Avalonia.Styling;

namespace MessageBox.Avalonia.Example;

public class App : Application
{
    public override void Initialize()
    {
        AvaloniaXamlLoader.Load(this);

        //test code to set different culture
        CultureInfo myCultureInfo = new CultureInfo("fr");
        CultureInfo.DefaultThreadCurrentCulture = myCultureInfo;
        CultureInfo.DefaultThreadCurrentUICulture = myCultureInfo;

        Thread.CurrentThread.CurrentCulture = myCultureInfo;
        Thread.CurrentThread.CurrentUICulture = myCultureInfo;
    }

    public override void OnFrameworkInitializationCompleted()
    {
        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
        {
            desktop.MainWindow = new MainWindow();
        }

        base.OnFrameworkInitializationCompleted();
        Application.Current!.RequestedThemeVariant = ThemeVariant.Light;
    }
}