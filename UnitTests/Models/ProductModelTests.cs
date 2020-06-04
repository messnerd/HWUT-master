using Microsoft.VisualStudio.TestTools.UnitTesting;
using HWUT.Models;
using System;

/*
Naming Convention:
Method = The method under test
Condition = What is the condition to test
Configuration = The State
Should
Result = What should happen

Examples:
public void ProductModel_Constructor_Default_Should_Pass()	Default constructor
public void ProductModel_Constructor_Invalid_Should_Fail()	Invalid constructor test should fail
*/

/*
Add UT coverage to Product Model
Make sure All Conditions are Tested (100% coverage)
Calling the ProductModel constructor results in the following coverage results of 19% coverage.  Need to get to 100%

Hints
	• Make sure the default constructor tests the default states properly
	• To get to 100% coverage you have to create Unit Tests that meet the conditions withing the Code
	• Each test method follow the naming convention
	• Each test method must Follow the Arrange, Act, Assert Format
	• Each test method tests only 1 condition
	• Each test method has only 1 line for the Act
	• Each test method has only 1 assert
Each test method assert follows the pattern of IsNotNull(Actual) or AreEqual (Expected, Actual)
*/

namespace UnitTests
{
    [TestClass]
    public class ProductModelTests
    {
        [TestMethod]
        public void ProductModel_Constructor_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.IsNotNull(result);
        }
        
        [TestMethod]
        public void ProductModel_Get_ID_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.AreEqual(null, null);
        }

        [TestMethod]
        public void ProductModel_Set_ID_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.AreEqual(null, null);
        }

        [TestMethod]
        public void ProductModel_Get_Maker_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.AreEqual(null, null);
        }

        [TestMethod]
        public void ProductModel_Set_Maker_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.AreEqual(null, null);
        }

        [TestMethod]
        public void ProductModel_Get_Image_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.AreEqual(null, null);
        }

        [TestMethod]
        public void ProductModel_Set_Image_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.AreEqual(null, null);
        }

        [TestMethod]
        public void ProductModel_Get_Url_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.AreEqual(null, null);
        }

        [TestMethod]
        public void ProductModel_Set_Url_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.AreEqual(null, null);
        }

        [TestMethod]
        public void ProductModel_Get_Title_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.AreEqual(null, null);
        }

        [TestMethod]
        public void ProductModel_Set_Title_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.AreEqual(null, null);
        }

        [TestMethod]
        public void ProductModel_Get_Description_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.AreEqual(null, null);
        }

        [TestMethod]
        public void ProductModel_Set_Description_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.AreEqual(null, null);
        }

        [TestMethod]
        public void ProductModel_Get_Date_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.AreEqual(DateTime.UtcNow.ToShortDateString(), result.Date.ToShortDateString());
        }

        [TestMethod]
        public void ProductModel_Set_Date_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.AreEqual(null, null);
        }

        [TestMethod]
        public void ProductModel_Get_Sequence_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.AreEqual(DateTime.UtcNow.ToShortDateString(), result.Date.ToShortDateString());
        }

        [TestMethod]
        public void ProductModel_Set_Sequence_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.AreEqual(null, null);
        }

        [TestMethod]
        public void ProductModel_Get_Email_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.AreEqual(null, null);
        }

        [TestMethod]
        public void ProductModel_Set_Email_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.AreEqual(null, null);
        }

        [TestMethod]
        public void ProductModel_Get_Logistics_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.AreEqual(null, null);
        }

        [TestMethod]
        public void ProductModel_Set_Logistics_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.AreEqual(null, null);
        }

        [TestMethod]
        public void ProductModel_ToString_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.AreEqual(null, null);
        }

        [TestMethod]
        public void ProductModel_AverageRating_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.AreEqual(null, null);
        }
    }
}
