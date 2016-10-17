﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Container.Tests
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void Given_EmptyString_Return_ErrorMessage()
        {
            string blankInput = "";
            string expectedResult = "File is Empty";
            var arrageContainers = new ContainerSystem.ArrangeContainers();

            string validationResult = arrageContainers.ReadContainerFile(blankInput);
            Assert.AreEqual(expectedResult, validationResult);
        }
        [TestMethod]
        public void Given_TooManyCharacters_Return_ErrorMessage()
        {
            string tooManyCharacters = "ABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZ";
            string expectedResult = "File is Too Large";
            var arrageContainers = new ContainerSystem.ArrangeContainers();

            string validationResult = arrageContainers.ReadContainerFile(tooManyCharacters);
            Assert.AreEqual(expectedResult, validationResult);
        }
        [TestMethod]
        public void Given_InputWithoutEnd_Return_ErrorMessage()
        {
            string noEndKeyword = "ABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNO";
            string expectedResult = "File is Invalid";
            var arrageContainers = new ContainerSystem.ArrangeContainers();

            string validationResult = arrageContainers.ReadContainerFile(noEndKeyword);
            Assert.AreEqual(expectedResult, validationResult);
        }
        [TestMethod]
        public void Given_InputWithNumber_Return_ErrorMessage()
        {
            string numericInput = "1ABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNO";
            string expectedResult = "File is Invalid";
            var arrageContainers = new ContainerSystem.ArrangeContainers();

            string validationResult = arrageContainers.ReadContainerFile(numericInput);
            Assert.AreEqual(expectedResult, validationResult);
        }

        [TestMethod]
        public void Given_InputWithSpecialCharacter_Return_ErrorMessage()
        {
            string numericInput = "!ABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNO";
            string expectedResult = "File is Invalid";
            var arrageContainers = new ContainerSystem.ArrangeContainers();

            string validationResult = arrageContainers.ReadContainerFile(numericInput);
            Assert.AreEqual(expectedResult, validationResult);
        }

        [TestMethod]
        public void Given_InputWithMultipleTestCases_Return_Count()
        {
            string multipleLines = "ABCDEFGHIJKLMNOPQRSTUVWYZABCD\nSEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNO";
            string expectedResult = "File is Invalid";
            var arrageContainers = new ContainerSystem.ArrangeContainers();

            string validationResult = arrageContainers.ReadContainerFile(multipleLines);
            Assert.AreEqual(expectedResult, validationResult);
        }

        [TestMethod]
        public void Given_TestCase_Return_NumberOfStacks()
        {
            string input = "ABC";
            int expectedResult = 3;
            var arrangeContainers = new ContainerSystem.ArrangeContainers();

            int numberOfStacksResult = arrangeContainers.NumberOfStacks(input);
            Assert.AreEqual(expectedResult, numberOfStacksResult);
        }

        //[TestMethod]
        //public void Given_ValidInput_Return_SuccessMessage()
        //{
        //    string validInput = "ABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOPQRSTUVWYZABCDEFGHIJKLMNOEND";
        //    string expectedResult = "";
        //    var arrageContainers = new ContainerSystem.ArrangeContainers();

        //    string validationResult = arrageContainers.ReadContainerFile(validInput);
        //    Assert.AreEqual(expectedResult, validationResult);
        //}

        [TestMethod]
        public void Given_CharGreaterThanPreviousChar_Return_False()
        {
            char current = 'B';
            char previous = 'A';
            bool expectedResult = false;
            var arrageContainers = new ContainerSystem.ArrangeContainers();

            bool orderOfCharResult = arrageContainers.CheckPreviousCharLessThanCurrent(previous, current);
            Assert.AreEqual(expectedResult, orderOfCharResult);
        }

        [TestMethod]
        public void Given_CharLessThanPreviousChar_Return_True()
        {
            char current = 'B';
            char previous = 'C';
            bool expectedResult = true;
            var arrageContainers = new ContainerSystem.ArrangeContainers();

            bool orderOfCharResult = arrageContainers.CheckPreviousCharLessThanCurrent(previous, current);
            Assert.AreEqual(expectedResult, orderOfCharResult);
        }
    }
}