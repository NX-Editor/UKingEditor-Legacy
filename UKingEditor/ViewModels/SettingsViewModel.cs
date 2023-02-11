using Dock.Model.ReactiveUI.Controls;
using UKingEditor.Views;

namespace UKingEditor.ViewModels;

public class SettingsViewModel : Document
{
    public SettingsViewModel()
    {
        Id = nameof(SettingsViewModel);
        Title = "Settings";
        CanFloat = false;
    }

    public override bool OnClose()
    {
        SettingsView.Live?.ValidateSave();
        SettingsView.Live = null;
        return base.OnClose();
    }
}
