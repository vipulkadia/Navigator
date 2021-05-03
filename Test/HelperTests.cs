using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]

    public class HelperTests
    {
        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void TestWithEmptyPosition()
        {
            string position = string.Empty;
            Navigator.Position positionObj = Navigator.Helper.SetPosition(position);

        }

        [TestMethod]
        public void TestWithValidPosition()
        {
            string position = "3 4 N";
            Navigator.Position expected = new Navigator.Position();
            expected.x = 3;
            expected.y = 4;
            expected.direction = Navigator.Direction.N;

            Navigator.Position positionObj = Navigator.Helper.SetPosition(position);

            Assert.AreEqual(expected.x, positionObj.x);
            Assert.AreEqual(expected.y, positionObj.y);
            Assert.AreEqual(expected.direction, positionObj.direction);
        }

    }
}
