using Microsoft.UI.Xaml;
using UltraTextEdit.Helpers;

namespace UltraTextEdit;

public sealed partial class MainWindow : WindowEx
{
    public MainWindow()
    {
        InitializeComponent();

        //Window.SetIcon(Path.Combine(AppContext.BaseDirectory, "Assets/WindowIcon.ico"));
        Content = null;
        Title = "AppDisplayName".GetLocalized();
        ExtendsContentIntoTitleBar = true;
        SetTitleBar(TitleBar);

    }

    private void showinsiderinfo(object sender, RoutedEventArgs e)
    {
        ToggleThemeTeachingTip1.IsOpen = true;
    }
}
