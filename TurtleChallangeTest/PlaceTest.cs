using Microsoft.VisualStudio.TestTools.UnitTesting;
using TurtleChallange;
using System;

namespace TurtleChallangeTest
{
    [TestClass]
    public class PlaceTest
    {
        [TestMethod]
        public void ValidatePlacing()
        {
            Table table = new Table(5, 5);
            Assert.IsTrue(table.IsValidLocation(0,0), "(0, 0) is False" );
            Assert.IsTrue(table.IsValidLocation(0, 1), "(0, 1) is False");
            Assert.IsTrue(table.IsValidLocation(2, 2), "(2, 2) is False");
            Assert.IsTrue(table.IsValidLocation(4, 4), "(4, 4) is False");
            Assert.IsFalse(table.IsValidLocation(4, 5), "(4, 5) is True");
            Assert.IsFalse(table.IsValidLocation(-1, -2), "(-1, -2) is True");
        }
    }
}