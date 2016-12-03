using Microsoft.VisualStudio.TestTools.UnitTesting;
using MefExmaples.Tests;
using System.Collections.Generic;
using System.Linq;

namespace MefEXamples.Tests
{
    [TestClass]
    public class MefPluginsTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            var importer = new ExtensionsLoader();
            importer.ImportPlugins();

            // Act
            var numberOfOps = importer.NumberOfImportedOperations;
            // Assert
            Assert.AreEqual(numberOfOps, 2);
            var ExpectedList = new List<string>() { "Are All EqualAll", "Are  Equal" };
            var resultedList = importer.CallImportedPlugins("Are All Equal", "All");
            Assert.AreEqual(resultedList.Last(), ExpectedList.Last());
        }
    }
}
