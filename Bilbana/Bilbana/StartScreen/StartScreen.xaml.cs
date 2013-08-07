using System.Windows;

namespace Bilbana.StartScreen
{
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
			DataContext = new StartScreenViewModel();
		}
	}
}
