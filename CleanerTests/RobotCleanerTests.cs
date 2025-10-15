using NUnit.Framework;
using RobotCleaner;

namespace CleanerTests
{
	[TestFixture]
	public class SpiralStrategyEdgeTests
	{
		[Test]
		public void SpiralStrategy_StaysInBounds()
		{
			var map = new Map(1, 1);
			var strategy = new SpiralStrategy();
			var robot = new Robot(map, strategy);

			robot.X = 0; robot.Y = 0;
			robot.StartCleaning();

			Assert.AreEqual(0, robot.X);
			Assert.AreEqual(0, robot.Y);
		}
	}
}


