using System.Collections.Generic;
using Bilbana.BaseClasses;
using Bilbana.Models;

namespace Bilbana.Editor
{
	public class EditorViewModel : ViewModelBase, IEditorViewModel
	{
		public List<int> Numbers { get; set; }
		public RaceTrack RaceTrack { get; set; }
		public string DisplayName { get; set; }

		public EditorViewModel()
		{
			DisplayName = "Magnus bana";
			Numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };
			RaceTrack = new RaceTrack(DisplayName);
		}
	}
}
