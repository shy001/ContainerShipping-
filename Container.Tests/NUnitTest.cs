using System;
using System.Text;
using System.Collections.Generic;
using NUnit.Framework;
using ContainerSystem;

namespace Container.Tests
{
    /// <summary>
    /// Summary description for NUnitTest
    /// </summary>
    [TestFixture]
    public class NUnitTest
    {
        private ArrangeContainers arrangeContainerClass;
        public NUnitTest()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        //public TestContext TestContext
        //{
        //    get
        //    {
        //        return testContextInstance;
        //    }
        //    set
        //    {
        //        testContextInstance = value;
        //    }
        //}

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [SetUp]
        public void SetupConnection()
        {
            arrangeContainerClass = new ArrangeContainers();
        }

        [Test]
        [TestCase("", "File is Empty")]
        [TestCase("ABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZBCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZBCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZBCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZBCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZBCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZBCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZBCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZ", "File is Too Large")]
        [TestCase("ABC", "File is Invalid")]
        [TestCase("123", "File is Invalid")]
        
        public void ReadFile_Return_ErrorMessage(string input, string expectedResult)
        {
            //Arrange

            //Act
            var actualResult = arrangeContainerClass.ReadContainerFile(input);   
            //Assert
            Assert.AreEqual(expectedResult,actualResult);
        }

        [Test]
        [TestCase("A", 1)]
        [TestCase("CBACBACBACBACBA", 3)]
        [TestCase("CCCCBBBBAAAA", 1)]
        [TestCase("ACMICPC", 4)]
        [TestCase("ACMIMCPCD", 5)]
        public void Run_LoadStacks_Return_NumberOfStacks(string input, int expectedResult)
        {
            //Arrange

            //Act
            var actualResult = arrangeContainerClass.LoadStacks(0,input);
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
