using Dock.Model.ReactiveUI.Controls;
using UKingEditor.Core.EditorInterfaces;

namespace UKingEditor.ViewModels.Editors;

public class TextEditorViewModel : Document
{
    private readonly ITextEditor _editor;

	public TextEditorViewModel(ITextEditor editor)
	{
        Title = "EDITOR";
        Id = "Idk";

        _editor = editor;
	}
}
