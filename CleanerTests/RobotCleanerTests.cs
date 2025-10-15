using NUnit.Framework;
using RobotCleaner;

namespace CleanerTests
{
    [TestFixture]
    public class RobotCleanerTests
    {
        [Test]
        public void PerimeterHuggerStrategy_StaysInBounds()
        {
            Map map = new Map(2, 2);
            Robot robot = new Robot(map, new PerimeterHuggerStrategy());

            robot.StartCleaning();

            Assert.That(robot.X >= 0 && robot.X < map.Width, Is.True);
            Assert.That(robot.Y >= 0 && robot.Y < map.Height, Is.True);
        }
    }
}
