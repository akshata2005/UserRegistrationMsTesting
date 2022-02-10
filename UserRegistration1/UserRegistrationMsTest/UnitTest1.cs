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
        [TestMethod]
        public void GivenMobileNumber_WhenValidate_ShouldReturnTrue()
        {
            //Arrange
            ValidateUserRegistration user = new ValidateUserRegistration();
            string mobileNumber = "91 6688342519";
            //Act
            bool result = user.ValidateMobileNo(mobileNumber);
            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void GivenInvalidMobileNumber_ShouldReturnFalse()
        {
            try
            {
                ValidateUserRegistration user = new ValidateUserRegistration();
                user.ValidateMobileNo("918888799769");
            }
            catch (CustomException e)
            {
                Assert.AreEqual("Invalid Mobile Number.", e.Message);
            }
        }
        [TestMethod]
        public void GivenPassword_WhenValidate_ShouldReturnTrue()
        {
            //Arrange
            ValidateUserRegistration user = new ValidateUserRegistration();
            string password = "Welcome@123";
            //Act
            bool result = user.ValidatePassword(password);
            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void GivenInvalidPassword_ShouldReturnFalse()
        {
            try
            {
                ValidateUserRegistration user = new ValidateUserRegistration();
                user.ValidatePassword("@Kfc");
            }
            catch (CustomException e)
            {
                Assert.AreEqual("Invalid Password.", e.Message);
            }
        }

        //Sad Test Cases(Test Cases Fail The Entry)
        [TestMethod]
        public void GivenUserFirstName_WhenValidate_ShouldReturnFalse()
        {
            //Arrange
            ValidateUserRegistration user = new ValidateUserRegistration();
            string firstName = "har";
            //Act
            bool result = user.ValidateFirstName(firstName);
            //Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void GivenUserLastName_WhenValidate_ShouldReturnFalse()
        {
            //Arrange
            ValidateUserRegistration user = new ValidateUserRegistration();
            string lastName = "Pa";
            //Act
            bool result = user.ValidateFirstName(lastName);
            //Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void GivenEmailId_WhenValidate_ShouldReturnFalse()
        {
            //Arrange
            ValidateUserRegistration user = new ValidateUserRegistration();
            string email = "_harshupatil@gmail0301com";
            //Act
            bool result = user.ValidateEmail(email);
            //Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void GivenMobileNumber_WhenValidate_ShouldReturnFalse()
        {
            //Arrange
            ValidateUserRegistration user = new ValidateUserRegistration();
            string mobileNumber = "916688342519";
            //Act
            bool result = user.ValidateMobileNo(mobileNumber);
            //Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void GivenPassword_WhenValidate_ShouldReturnFalse()
        {
            //Arrange
            ValidateUserRegistration user = new ValidateUserRegistration();
            string password = "welcome123";
            //Act
            bool result = user.ValidatePassword(password);
            //Assert
            Assert.IsFalse(result);
        }
    }
}
