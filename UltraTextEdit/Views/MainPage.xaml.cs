using Microsoft.UI.Text;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

using UltraTextEdit.ViewModels;

namespace UltraTextEdit.Views;

public sealed partial class MainPage : Page
{
    public MainViewModel ViewModel
    {
        get;
    }

    public MainPage()
    {
        ViewModel = App.GetService<MainViewModel>();
        InitializeComponent();
        Window window = new Window();
        window.ExtendsContentIntoTitleBar = true;
        window.SetTitleBar(TitleBar);

    }

    private void RichEditBox_TextChanged(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
    {
        editor.Document.GetText(TextGetOptions.UseObjectText, out var textStart);

        //if (textStart == "" || string.IsNullOrWhiteSpace(textStart) || _wasOpen)
        //{
        //    saved = true;
        //}
        //else
        //{
        //    saved = false;
        //}

        //if (!saved) UnsavedTextBlock.Visibility = Visibility.Visible;
        //else UnsavedTextBlock.Visibility = Visibility.Collapsed;
    }

    private void OnKeyboardAcceleratorInvoked(Microsoft.UI.Xaml.Input.KeyboardAccelerator sender, Microsoft.UI.Xaml.Input.KeyboardAcceleratorInvokedEventArgs args)
    {
        switch (sender.Key)
        {
            case Windows.System.VirtualKey.B:
                //editor.FormatSelected(RichEditHelpers.FormattingMode.Bold);
                //BoldButton.IsChecked = editor.Document.Selection.CharacterFormat.Bold == FormatEffect.On;
                args.Handled = true;
                break;
            case Windows.System.VirtualKey.I:
                //editor.FormatSelected(RichEditHelpers.FormattingMode.Italic);
                //ItalicButton.IsChecked = editor.Document.Selection.CharacterFormat.Italic == FormatEffect.On;
                args.Handled = true;
                break;
            case Windows.System.VirtualKey.U:
                //editor.FormatSelected(RichEditHelpers.FormattingMode.Underline);
                //UnderlineButton.IsChecked = editor.Document.Selection.CharacterFormat.Underline == UnderlineType.Single;
                args.Handled = true;
                break;
            case Windows.System.VirtualKey.S:
                //SaveFile(false);
                break;
        }
    }

    private void showinsiderinfo(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
    {
        ToggleThemeTeachingTip1.IsOpen = true;
    }

    private void BoldButton_Click(object sender, RoutedEventArgs e)
    {
        Microsoft.UI.Text.ITextSelection selectedText = editor.Document.Selection;
        if (selectedText != null)
        {
            Microsoft.UI.Text.ITextCharacterFormat charFormatting = selectedText.CharacterFormat;
            charFormatting.Bold = Microsoft.UI.Text.FormatEffect.Toggle;
            selectedText.CharacterFormat = charFormatting;
        }
    }

    private void ItalicButton_Click(object sender, RoutedEventArgs e)
    {
        Microsoft.UI.Text.ITextSelection selectedText = editor.Document.Selection;
        if (selectedText != null)
        {
            Microsoft.UI.Text.ITextCharacterFormat charFormatting = selectedText.CharacterFormat;
            charFormatting.Italic = Microsoft.UI.Text.FormatEffect.Toggle;
            selectedText.CharacterFormat = charFormatting;
        }
    }

    private void UnderlineButton_Click(object sender, RoutedEventArgs e)
    {
        Microsoft.UI.Text.ITextSelection selectedText = editor.Document.Selection;
        if (selectedText != null)
        {
            Microsoft.UI.Text.ITextCharacterFormat charFormatting = selectedText.CharacterFormat;
            if (charFormatting.Underline == Microsoft.UI.Text.UnderlineType.None)
            {
                charFormatting.Underline = Microsoft.UI.Text.UnderlineType.Single;
            }
            else
            {
                charFormatting.Underline = Microsoft.UI.Text.UnderlineType.None;
            }
            selectedText.CharacterFormat = charFormatting;
        }
    }
}
