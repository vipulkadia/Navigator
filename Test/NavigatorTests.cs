using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Test
{
    [TestClass]
    public class NavigatorTests
    {
        [TestMethod]
        public void TestWithEmptyInstructions()
        {
            string expected = Navigator.Constants.INSTRUCTIONS_NOT_PROVIDED;
            List<string> inputInstruction = new List<string>();
            Navigator.Navigator navigator = new Navigator.Navigator();
            List<string> output = navigator.Navigate(inputInstruction);

            Assert.AreEqual(expected, output[0]);
        }

        [TestMethod]
        public void TestWithOneInstruction()
        {
            List<string> inputInstruction = new List<string>();
            inputInstruction.Add("5 5");
            string expected = Navigator.Constants.INVALID_TOTAL_INSTRUCTIONS;

            Navigator.Navigator navigator = new Navigator.Navigator();
            List<string> output = navigator.Navigate(inputInstruction);

            Assert.AreEqual(expected, output[0]);
        }

        [TestMethod]
        public void TestWithValidInstruction()
        {
            List<string> inputInstruction = new List<string>();
            inputInstruction.Add("5 5");
            inputInstruction.Add("1 2 N");
            inputInstruction.Add("LMLMLMLMM");
            inputInstruction.Add("3 3 E");
            inputInstruction.Add("MMRMMRMRRM");

            List<string> expected = new List<string>();
            expected.Add("1 3 N");
            expected.Add("5 1 E");

            Navigator.Navigator navigator = new Navigator.Navigator();
            List<string> output = navigator.Navigate(inputInstruction);
            CollectionAssert.AreEqual(expected, output);

        }

        [TestMethod]
        public void TestWithInvalidInstruction()
        {
            List<string> inputInstruction = new List<string>();
            inputInstruction.Add("5 5");
            inputInstruction.Add("1 N"); //Invalid instruction
            inputInstruction.Add("LMLMLMLMM");
            inputInstruction.Add("3 E"); //Invalid instruction
            inputInstruction.Add("MMRMMRMRRM");

            List<string> expected = new List<string>();
            expected.Add(Navigator.Constants.INVALID_POSITION_INSTRUCTION);
            expected.Add(Navigator.Constants.INVALID_POSITION_INSTRUCTION);

            Navigator.Navigator navigator = new Navigator.Navigator();
            List<string> output = navigator.Navigate(inputInstruction);
            CollectionAssert.AreEqual(expected, output);

        }

    }
}
