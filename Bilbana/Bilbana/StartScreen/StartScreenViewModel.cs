using System.Windows.Input;
using Bilbana.BaseClasses;
using Bilbana.Editor;

namespace Bilbana.StartScreen
{
	public class StartScreenViewModel : ViewModelBase
	{
		public ICommand RunGameCommand { get; set; }
		public ICommand EditTrackCommand { get; set; }

		public StartScreenViewModel()
		{
			RunGameCommand = new RelayCommand(CanRunGame, (param) => RunGame());
			EditTrackCommand = new RelayCommand(CanEditTrack, (param) => EditTrack());
		}

		private bool CanRunGame(object param)
		{
			return true;
		}

		private bool CanEditTrack(object param)
		{
			return true;
			//return param != null && (bool)param;
		}

		private void RunGame()
		{
			int hejs = 12;
			//do nothing
		}

		private void EditTrack()
		{
			var editorView = new EditorView();
			editorView.Show();
		}
	}
}
