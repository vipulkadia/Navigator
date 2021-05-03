using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]

    public class ValidatorTests
    {
        [TestMethod]
        public void TestWithEmptyInstructions()
        {
            string expected = Navigator.Constants.INSTRUCTIONS_NOT_PROVIDED;

            List<string> inputInstruction = new List<string>();
            string validationMessage = string.Empty;
            Navigator.Validator validator = new Navigator.Validator();
            bool isValid = validator.ValidateTotalInstructions(inputInstruction, out validationMessage);

            Assert.AreEqual(expected, validationMessage);
        }

        [TestMethod]
        public void TestWithOneInstruction()
        {
            List<string> inputInstruction = new List<string>();
            inputInstruction.Add("5 5");
            string expected = Navigator.Constants.INVALID_TOTAL_INSTRUCTIONS;

            string validationMessage = string.Empty;
            Navigator.Validator validator = new Navigator.Validator();
            bool isValid = validator.ValidateTotalInstructions(inputInstruction, out validationMessage);

            Assert.AreEqual(expected, validationMessage);
        }

        [TestMethod]
        public void TestWithTwoInstruction()
        {
            List<string> inputInstruction = new List<string>();
            inputInstruction.Add("5 5");
            inputInstruction.Add("5 5");
            string expected = Navigator.Constants.INVALID_TOTAL_INSTRUCTIONS;

            string validationMessage = string.Empty;
            Navigator.Validator validator = new Navigator.Validator();
            bool isValid = validator.ValidateTotalInstructions(inputInstruction, out validationMessage);

            Assert.AreEqual(expected, validationMessage);
        }
        [TestMethod]
        public void TestWithValidTotalInstruction()
        {
            List<string> inputInstruction = new List<string>();
            inputInstruction.Add("5 5");
            inputInstruction.Add("5 5");
            inputInstruction.Add("5 5");
            bool expected = true;

            string validationMessage = string.Empty;
            Navigator.Validator validator = new Navigator.Validator();
            bool isValid = validator.ValidateTotalInstructions(inputInstruction, out validationMessage);

            Assert.AreEqual(expected, isValid);
        }
        [TestMethod]
        public void TestWithInvalidTotalInstruction()
        {
            List<string> inputInstruction = new List<string>();
            inputInstruction.Add("5 5");
            inputInstruction.Add("5 5");
            inputInstruction.Add("5 5");
            inputInstruction.Add("5 5");
            string expected = Navigator.Constants.INVALID_TOTAL_INSTRUCTIONS;

            string validationMessage = string.Empty;
            Navigator.Validator validator = new Navigator.Validator();
            bool isValid = validator.ValidateTotalInstructions(inputInstruction, out validationMessage);

            Assert.AreEqual(expected, validationMessage);
        }

        [TestMethod]
        public void TestWithInvalidEmptyPosition()
        {
            string position = string.Empty;
            string expected = Navigator.Constants.INVALID_POSITION_INSTRUCTION;

            string validationMessage = string.Empty;
            Navigator.Validator validator = new Navigator.Validator();
            bool isValid = validator.ValidatePosition(position, out validationMessage);

            Assert.AreEqual(expected, validationMessage);
        }
        [TestMethod]
        public void TestWithInvalidXcoordinate()
        {
            string position = "A 3 N";
            string expected = Navigator.Constants.INVALID_X_COORDINATE;

            string validationMessage = string.Empty;
            Navigator.Validator validator = new Navigator.Validator();
            bool isValid = validator.ValidatePosition(position, out validationMessage);

            Assert.AreEqual(expected, validationMessage);
        }

        [TestMethod]
        public void TestWithInvalidYcoordinate()
        {
            string position = "3 B N";
            string expected = Navigator.Constants.INVALID_Y_COORDINATE;

            string validationMessage = string.Empty;
            Navigator.Validator validator = new Navigator.Validator();
            bool isValid = validator.ValidatePosition(position, out validationMessage);

            Assert.AreEqual(expected, validationMessage);
        }

        [TestMethod]
        public void TestWithInvalidDirection()
        {
            string position = "3 3 Z";
            string expected = Navigator.Constants.INVALID_DIRECTION_VALUE;

            string validationMessage = string.Empty;
            Navigator.Validator validator = new Navigator.Validator();
            bool isValid = validator.ValidatePosition(position, out validationMessage);

            Assert.AreEqual(expected, validationMessage);
        }

        [TestMethod]
        public void TestWithValidPositionInstruction()
        {
            string position = "3 3 N";
            bool expected = true;

            string validationMessage = string.Empty;
            Navigator.Validator validator = new Navigator.Validator();
            bool isValid = validator.ValidatePosition(position, out validationMessage);

            Assert.AreEqual(expected, isValid);
        }

    }
}
