using System.Windows.Input;
using Bilbana.BaseClasses;
using Bilbana.Editor;
using Bilbana.Race;


namespace Bilbana.StartScreen
{
	public class StartScreenViewModel : ViewModelBase
	{
		private EditorView _editorView;
		private RaceView _raceView;

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
			if (_raceView == null)
				_raceView = new RaceView();
			_raceView.Show();
		}

		private void EditTrack()
		{
			if (_editorView == null)
				_editorView = new EditorView();
			_editorView.Show();
		}
	}
}
