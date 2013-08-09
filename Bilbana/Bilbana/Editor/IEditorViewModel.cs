using System.Collections.Generic;
using Bilbana.Models;

namespace Bilbana.Editor
{
	public interface IEditorViewModel
	{
		List<int> Numbers { get; set; }
		RaceTrack RaceTrack { get; set; }
		string DisplayName { get; set; }
	}
}