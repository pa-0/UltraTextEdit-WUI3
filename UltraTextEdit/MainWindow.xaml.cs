using Microsoft.UI.Xaml;
using UltraTextEdit.Helpers;
using UltraTextEdit.Views;

namespace UltraTextEdit;

public sealed partial class MainWindow : WindowEx
{
    public MainWindow()
    {
        InitializeComponent();
        AppContent.Navigate(typeof(Views.MainPage));

        //Window.SetIcon(Path.Combine(AppContext.BaseDirectory, "Assets/WindowIcon.ico"));
        Title = "AppDisplayName".GetLocalized();
        ExtendsContentIntoTitleBar = true;
        SetTitleBar(AppTitleBar);

    }

}
