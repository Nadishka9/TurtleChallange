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
    public class CommandTest
    {
        
        [TestMethod]
        public void ValidatePlaceCommand()
        {
            Command testSetup = new Command();
            Table table = new Table(5, 5);
            testSetup.Navigation = new Navigator(table);
            testSetup.ProcessCommand("PLACE 3,4,WEST");

            Assert.IsNotNull(testSetup.Navigation.Turtle);
        }

        [TestMethod]
        public void ValidateInvalidPlaceCommand()
        {
            Command testSetup = new Command();
            Table table = new Table(5, 5);
            testSetup.Navigation = new Navigator(table);
            testSetup.ProcessCommand("PLACE 5,7,SOUTH");

            Assert.AreSame(testSetup.ErrorInputs, testSetup.Message);
        }

        [TestMethod]
        public void ValidateMoveCommand()
        {
            Command testSetup = new Command();
            Table table = new Table(5, 5);
            testSetup.Navigation = new Navigator(table);
            testSetup.ProcessCommand("PLACE 1,4,EAST");
            testSetup.ProcessCommand("MOVE");

            Turtle expected = new Turtle { x = 2, y = 4, direction = "east" };

            Assert.AreEqual(expected.x, testSetup.Navigation.Turtle.x);
        }

        [TestMethod]
        public void ValidateMoveWallCommand()
        {
            Command testSetup = new Command();
            Table table = new Table(5, 5);
            testSetup.Navigation = new Navigator(table);
            testSetup.ProcessCommand("PLACE 4,4,NORTH");
            testSetup.ProcessCommand("MOVE");

            Turtle expected = new Turtle { x = 4, y = 4, direction = "north" };

            Assert.AreEqual(expected.x, testSetup.Navigation.Turtle.x);
        }

    }
}
