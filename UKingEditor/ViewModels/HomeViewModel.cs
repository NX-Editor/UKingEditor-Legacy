using Dock.Model.ReactiveUI.Controls;
using UKingEditor.Core.Extensions;

namespace UKingEditor.ViewModels;

public class HomeViewModel : Document
{
    public HomeViewModel()
    {
        Title = "Home";
        CanFloat = false;
        CanClose = false;
        CanPin = false;
    }

    public static async Task VersionLink()
    {
        await BrowserExtension.OpenUrl("https://github.com/ArchLeaders/UKingEditor/releases/");
    }
}
