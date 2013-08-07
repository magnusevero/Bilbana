using System.Windows;

namespace Bilbana.Editor
{
	public partial class EditorView : Window
	{
		public EditorView()
		{
			InitializeComponent();
			DataContext = new EditorViewModel();
		}
	}
}
