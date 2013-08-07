using System.Collections.Generic;
using Bilbana.BaseClasses;

namespace Bilbana.Editor
{
	public class EditorViewModel : ViewModelBase
	{
		public List<int> Numbers { get; set; }

		public EditorViewModel()
		{
			Numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };
		}
	}
}
