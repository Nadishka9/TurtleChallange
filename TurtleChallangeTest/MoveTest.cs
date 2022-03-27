using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurtleChallange;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace TurtleChallangeTest
{
    [TestClass]
    public class MoveTest
    {
        [TestMethod]
        public void MoveTwoTimesNorth()
        {
            Turtle Turtle = new Turtle { direction = "north" };

            Turtle.Move();
            Turtle.Move();

            Assert.AreEqual(2,Turtle.y);
        }

        [TestMethod]
        public void MoveThreeTimesEasth()
        {
            Turtle Turtle = new Turtle { direction = "east" };

            Turtle.Move();
            Turtle.Move();
            Turtle.Move();

            Assert.AreEqual(3,Turtle.x);
        }

        [TestMethod]
        public void MoveFourTimesSouth()
        {
            Turtle Turtle = new Turtle { direction = "south" };

            Turtle.Move();
            Turtle.Move();
            Turtle.Move();
            Turtle.Move();

            Assert.AreEqual(-4, Turtle.y);
        }

        [TestMethod]
        public void MoveThreeTimesWest()
        {
            Turtle Turtle = new Turtle { direction = "west" };

            Turtle.Move();
            Turtle.Move();
            Turtle.Move();

            Assert.AreEqual(-3, Turtle.x);
        }

        [TestMethod]
        public void MoveFourTimeast()
        {
            Turtle Turtle = new Turtle { direction = "east" };

            Turtle.Move();
            Turtle.Move();
            Turtle.Move();
            Turtle.Move();

            Assert.AreEqual(4, Turtle.x);
        }

        [TestMethod]
        public void WhenFacingNorthTurnRight()
        {
            Turtle Turtle = new Turtle { direction = "north" };

            Turtle.TurnRight();

            Assert.AreEqual("east", Turtle.direction);
        }

        [TestMethod]
        public void WhenFacingNorthTurnLeftt()
        {
            Turtle Turtle = new Turtle { direction = "north" };

            Turtle.TurnLeft();

            Assert.AreEqual("west", Turtle.direction);
        }

        [TestMethod]
        public void WhenFacingEastTurnRight()
        {
            Turtle Turtle = new Turtle { direction = "east" };

            Turtle.TurnRight();

            Assert.AreEqual("south", Turtle.direction);
        }

        [TestMethod]
        public void WhenFacingEastTurnLeft()
        {
            Turtle Turtle = new Turtle { direction = "east" };

            Turtle.TurnLeft();

            Assert.AreEqual("north", Turtle.direction);
        }

        [TestMethod]
        public void WhenFacingSouthTurnRight()
        {
            Turtle Turtle = new Turtle { direction = "south" };

            Turtle.TurnRight();

            Assert.AreEqual("west", Turtle.direction);
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

        [TestMethod]
        public void WhenFacingWestTurnLeft()
        {
            Turtle Turtle = new Turtle { direction = "west" };

            Turtle.TurnLeft();

            Assert.AreEqual("south", Turtle.direction);
        }
    }
}
