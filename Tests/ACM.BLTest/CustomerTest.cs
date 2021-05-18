using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.BL;
using System;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            // -- Arrange
            Customer customer = new Customer()
            {
                FirstName = "Jamie",
                LastName = "Kuusisto"
            };

            string expected = "Kuusisto, Jamie";

            // -- Act
            string actual = customer.FullName;

            // -- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameFirstNameEmpty()
        {
            // -- Arrange
            Customer customer = new Customer
            {
                LastName = "Kuusisto"
            };
            string expected = "Kuusisto";

            // -- Act
            string actual = customer.FullName;

            // -- Assert
            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void FullNameLastNameEmpty()
        {
            Customer customer = new Customer
            {
                FirstName = "Jamie"
            };
            string expected = "Jamie";

            // -- Act
            string actual = customer.FullName;

            // -- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StaticTest()
        {
            // -- Arrange
            var c1 = new Customer();
            c1.FirstName = "Bilbo";
            Customer.InstantCount += 1;

            var c2 = new Customer();
            c2.FirstName = "Frodo";
            Customer.InstantCount += 1;

            var c3 = new Customer();
            c3.FirstName = "Rosie";
            Customer.InstantCount += 1;
            
            // -- Act

            // -- Assert
            Assert.AreEqual(3, Customer.InstantCount);
        }

        [TestMethod]
        public void ValidateValid()
        {
            // -- Arrange 
            var customer = new Customer
            {
                LastName = "Baggins",
                EmailAddress = "fbaggins@hobbiton.me"
            };

            var expected = true;

            // -- Act
            var actual = customer.Validate();

            // -- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateMissingLastName()
        {
            // -- Arrange
            var customer = new Customer
            {
                EmailAddress = "fbaggins@hobbiton.me"
            };

            var expected = false;

            // -- Act
            var actual = customer.Validate();

            // -- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateMissingEmailAddress()
        {
            // -- Arrange
            var customer = new Customer
            {
                LastName = "Baggins"
            };

            var expected = false;

            // -- Act
            var actual = customer.Validate();

            // -- Assert
            Assert.AreEqual(expected, actual);
        }
    }
    
}
