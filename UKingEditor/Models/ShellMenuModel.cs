using Avalonia.Controls;
using Avalonia.Generics.Dialogs;
using Avalonia.MenuFactory.Attributes;
using Material.Icons;
using UKingEditor.Core.Extensions;
using UKingEditor.ViewModels;
using UKingEditor.ViewModels.Editors;

namespace UKingEditor.Models;

public class ShellMenuModel
{
    //
    // File

    [Menu("Open File", "_File", Icon = MaterialIconKind.FolderOpen, HotKey = "Ctrl + O")]
    public static void OpenFile()
    {
        DockFactory.AddDocument(new TextEditorViewModel(null!));
    }

    [Menu("New File", "_File", Icon = MaterialIconKind.CreateNewFolder, HotKey = "Ctrl + N")]
    public static void NewFile()
    {
        // Handle new file
    }

    [Menu("Save", "_File", Icon = MaterialIconKind.FloppyDisc, HotKey = "Ctrl + S", IsSeparator = true)]
    public static void Save()
    {
        // Handle save
    }

    [Menu("Quit", "_File", Icon = MaterialIconKind.ExitToApp, IsSeparator = true)]
    public static async Task Quit()
    {
        if (DockFactory.Root?.VisibleDockables?.Count > 1) {
            if (await MessageBox.ShowDialog("You may have unsaved changes. Are you sure you wish to exit?", "Warning", DialogButtons.YesNo) != DialogResult.Yes) {
                return;
            }
        }

        Environment.Exit(0);
    }

    //
    // Tools

    [Menu("Settings", "_Tools", Icon = MaterialIconKind.CogBox)]
    public static void Settings()
    {
        DockFactory.AddDocument(new SettingsViewModel());
    }

    // 
    // About

    [Menu("Wiki", "_About", Icon = MaterialIconKind.HelpOutline)]
    public static async Task Help()
    {
        await BrowserExtension.OpenUrl("https://github.com/ArchLeaders/UKingEditor/wiki");
    }

    [Menu("Report Issue", "_About", Icon = MaterialIconKind.Bug, IsSeparator = true)]
    public static async Task ReportIssue()
    {
        await BrowserExtension.OpenUrl("https://github.com/ArchLeaders/UKingEditor/issues/new");
    }
}
