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
    }
}
