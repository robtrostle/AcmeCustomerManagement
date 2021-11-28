using System;
using Acme.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Acme.CommonTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void InsertSpacesTestValid()
        {
            //arrange
            var source = "SonicScrewdriver";
            var expected = "Sonic Screwdriver";


            //act 
            var actual = source.InsertSpaces();//Extension method does not need parameter passed in. 

            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void InsertSpacesTestWithExistingSpace()
        {
            //arrange
            var source = "Sonic Screwdriver";
            var expected = "Sonic Screwdriver";


            //act
            var actual = source.InsertSpaces();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
