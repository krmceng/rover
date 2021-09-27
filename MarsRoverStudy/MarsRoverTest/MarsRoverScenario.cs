using MarsRoverStudy;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic; 

namespace MarsRoverTest
{
    [TestClass]
    public class MarsRoverScenario
    {
        [TestMethod]
        public void TestScenarioRobot1()
        {
            var expected = "1 3 N";
            var topPoints = new List<int>() { 5, 5 };
            var actions = "LMLMLMLMM";

            var move = new Move(1, 2, "N");

            var actualLocation =  move.DoAction(topPoints, actions);

            Assert.AreEqual(expected, actualLocation);
        }

        [TestMethod]
        public void TestScenarioRobot2()
        {
            var expected = "5 1 E";
            var topPoints = new List<int>() { 5, 5 };
            var actions = "MMRMMRMRRM";

            var move = new Move(3, 3, "E");

            var actualLocation = move.DoAction(topPoints, actions);

            Assert.AreEqual(expected, actualLocation);
        }
    }


}
