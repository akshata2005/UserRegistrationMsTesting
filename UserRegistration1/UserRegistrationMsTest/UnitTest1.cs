using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using UserRegistration1;

namespace UserRegistrationMsTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenUserFirstName_WhenValidate_ShouldReturnTruev()
        {
            //Arrange
            ValidateUserRegistration user = new ValidateUserRegistration();
            string firstName = "Akshata";
            //Act
            bool result = user.ValidateFirstName(firstName);
            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void GivenInvalidFirstName_WhenNameNotStartingWithUpper_ShouldReturnFalse()
        {
            try
            {
                ValidateUserRegistration user = new ValidateUserRegistration();
                bool result = user.ValidateFirstName("akshata");

            }
            catch (CustomException e)
            {
                Assert.AreEqual("Invalid User First Name.", e.Message);
            }
        }
        [TestMethod]
        public void GivenUserLastName_WhenValidate_ShouldReturnTrue()
        {
            //Arrange
            ValidateUserRegistration user = new ValidateUserRegistration();
            string lastName = "Sawant";
            //Act
            bool result = user.ValidateFirstName(lastName);
            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void GivenInvalidLastName_WhenNameNotStartingWithUpper_ShouldReturnFalse()
        {
            try
            {
                ValidateUserRegistration user = new ValidateUserRegistration();
                bool result = user.ValidateFirstName("sawant");

            }
            catch (CustomException e)
            {
                Assert.AreEqual("Invalid User Last Name.", e.Message);
            }
        }
        [TestMethod]
        public void GivenEmailId_WhenValidate_ShouldReturnTrue()
        {
            //Arrange
            ValidateUserRegistration user = new ValidateUserRegistration();
            string email = "akshatasawant1805@gmail.com";
            //Act
            bool result = user.ValidateEmail(email);
            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void GivenInvalidEmail_ShouldReturnFalse()
        {
            try
            {
                ValidateUserRegistration user = new ValidateUserRegistration();
                user.ValidateEmail("abc");
            }
            catch (CustomException e)
            {
                Assert.AreEqual("Invalid Email address.", e.Message);
            }
        }
        [TestMethod]
        public void GivenInvalidEmail2_ShouldReturnFalse()
        {
            try
            {
                ValidateUserRegistration user = new ValidateUserRegistration();
                user.ValidateEmail("12aksh@.gmailcom");
            }
            catch (CustomException e)
            {
                Assert.AreEqual("Invalid Email address.", e.Message);
            }
        }
    }
}
