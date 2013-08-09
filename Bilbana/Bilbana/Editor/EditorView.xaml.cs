using System.Windows;
using System.Windows.Controls;

namespace Bilbana.Editor
{
	public partial class EditorView : Window
	{
		public EditorView()
		{
			InitializeComponent();
			IEditorViewModel editorViewModel = new EditorViewModel();
			DataContext = editorViewModel;


			for (var column = 0; column < editorViewModel.RaceTrack.WidthInPieces; column++)
			{
				RaceGrid.ColumnDefinitions.Add(new ColumnDefinition());				
			}

			for (var row = 0; row< editorViewModel.RaceTrack.HeightInPieces; row++)
			{
				RaceGrid.RowDefinitions.Add(new RowDefinition());
			}
		}
	}
}
