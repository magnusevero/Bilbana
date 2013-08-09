using System.Collections.Generic;

namespace Bilbana.Models
{
	public class RaceTrack
	{
		public int WidthInPieces { get; set; }
		public int HeightInPieces { get; set; }
		public string Name { get; set; }

		public List<RacePiece> Pieces { get; set; }
		public RaceTrack(string name, int widthInPieces = 8, int heightInPieces = 8)
		{
			Name = name;
			WidthInPieces = widthInPieces;
			HeightInPieces = heightInPieces;
			Pieces = new List<RacePiece>();
			for (var xCoord = 1; xCoord <= WidthInPieces; xCoord++)
			{
				for (var yCoord = 1; yCoord <= HeightInPieces; yCoord++)
				{
					Pieces.Add(new RacePiece { XCoord = xCoord, YCoord = yCoord });
				}
			}
		}
	}
}