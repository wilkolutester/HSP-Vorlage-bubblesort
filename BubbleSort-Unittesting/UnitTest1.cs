using System;
using System.Collections.Generic;
using System.Linq;
using BubbleSort;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BubbleSort_Unittesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Teste4Elemente()
        {
            // Arrange
            Program prg = new Program();

            // Act 
            var result = prg.bubbleSort(new List<int>() { 3, 1, 6, 4 });

            // Assert
            Assert.IsTrue(Enumerable.SequenceEqual(new List<int>() { 1, 3, 4, 6 }, result));              
        }

        [TestMethod]
        public void Teste6Elemente()
        {
            // Arrange
            Program prg = new Program();

            // Act 
            var result = prg.bubbleSort(new List<int>() { 3, 1, 6, 4, 1, 9 });

            // Assert
            Assert.IsTrue(Enumerable.SequenceEqual(new List<int>() { 1, 1, 3, 4, 6, 9 }, result));
        }

    }
}
