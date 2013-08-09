using System;
using System.Linq;
using NUnit.Framework;

namespace Bilbana.Models
{
	[TestFixture]
	public class RaceTrackTests
	{
		private string _trackName;

		[TestCase]
		public void RaceTrackNameIsSetCorrectly()
		{
			_trackName = "Magnus";
			var raceTrack = new RaceTrack(_trackName);
			Assert.AreEqual(raceTrack.Name, _trackName);
		}

		[TestCase]
		public void RaceTrackHasCorrectNumberOfPieces()
		{
			var raceTrack = new RaceTrack("Magnus");
			Assert.AreEqual(raceTrack.Pieces.Count, raceTrack.WidthInPieces * raceTrack.HeightInPieces);
		}

		[TestCase]
		public void AllPiecesHaveDifferentCoordinates()
		{
			var raceTrack = new RaceTrack(_trackName);
			var distinctPieces = raceTrack.Pieces.Select(x => Tuple.Create<int, int>(x.XCoord, x.YCoord));
			Assert.AreEqual(distinctPieces.Distinct().Count(), raceTrack.WidthInPieces * raceTrack.HeightInPieces);
		}

		[TestCase]
		public void LowestXCoordinateIsOne()
		{
			var raceTrack = new RaceTrack(_trackName);
			Assert.AreEqual(raceTrack.Pieces.Min(x => x.XCoord), 1);
		}

		[TestCase]
		public void LowestYCoordinateIsOne()
		{
			var raceTrack = new RaceTrack(_trackName);
			Assert.AreEqual(raceTrack.Pieces.Min(x => x.YCoord), 1);
		}

		[TestCase]
		public void HighestXCoordinateIsSameAsWidthInPieces()
		{
			var raceTrack = new RaceTrack(_trackName);
			Assert.AreEqual(raceTrack.Pieces.Max(x => x.XCoord), raceTrack.WidthInPieces);
		}

		[TestCase]
		public void HighestYCoordinateIsSameAsHeightInPieces()
		{
			var raceTrack = new RaceTrack(_trackName);
			Assert.AreEqual(raceTrack.Pieces.Max(x => x.YCoord), raceTrack.HeightInPieces);
		}
	}
}