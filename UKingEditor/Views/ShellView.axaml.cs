using Avalonia.Controls;

namespace UKingEditor.Views;

public partial class ShellView : Window
{
    public ShellView()
    {
        InitializeComponent();
        DataContext = Shell;
    }
}
