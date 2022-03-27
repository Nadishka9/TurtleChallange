using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TurtleChallange;

namespace TurtleChallangeTest
{
    [TestClass]
    public class TestTurn
    {
        [TestMethod]
        public void WhenFacingNorthTurnRight()
        {
            Turtle Turtle = new Turtle { direction = "north" };

            Turtle.TurnRight();

            Assert.AreEqual("east", Turtle.direction);

        }

        [TestMethod]
        public void WhenFacingNorthTurnLeft()
        {
            Turtle Turtle = new Turtle { direction = "north" };

            Turtle.TurnLeft();

            Assert.AreEqual("west", Turtle.direction);

        }

        [TestMethod]
        public void WhenFacingEastTurnLeft()
        {
            Turtle Turtle = new Turtle { direction = "east" };

            Turtle.TurnLeft();

            Assert.AreEqual("north", Turtle.direction);

        }

        [TestMethod]
        public void WhenFacingSouthTurnLeft()
        {
            Turtle Turtle = new Turtle { direction = "south" };

            Turtle.TurnLeft();

            Assert.AreEqual("east", Turtle.direction);

        }

        [TestMethod]
        public void WhenFacingWestTurnRight()
        {
            Turtle Turtle = new Turtle { direction = "west" };

            Turtle.TurnRight();

            Assert.AreEqual("north", Turtle.direction);

        }
    }
}