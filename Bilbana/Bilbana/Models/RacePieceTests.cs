using NUnit.Framework;

namespace Bilbana.Models
{
	[TestFixture]
	public class RacePieceTests
	{
		[TestCase]
		public void RacePieceHas1AsXCoordDefault()
		{
			var racePiece = new RacePiece();
			Assert.AreEqual(racePiece.XCoord, 1);
		}

		[TestCase]
		public void RacePieceHas1AsYCoordDefault()
		{
			var racePiece = new RacePiece();
			Assert.AreEqual(racePiece.YCoord, 1);
		}
	}
}