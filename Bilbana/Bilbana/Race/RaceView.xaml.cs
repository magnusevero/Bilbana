using System.Windows;

namespace Bilbana.Race
{
	public partial class RaceView : Window
	{
		public RaceView()
		{
			InitializeComponent();
			DataContext = new RaceViewModel();
		}
	}
}
