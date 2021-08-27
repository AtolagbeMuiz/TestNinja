using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestClass]
    public class ReservationTests
    {
        [TestMethod]
        //Naming convention for TestMethod  e.g MethodNameToBeTested_Scenario_ExpectedBehaviour
        public void CanBeCancelledBy_UserIsAdmin_ReturnsTrue()
        {
            //Arrange
            //Initialize te objects
            var reservation = new Reservation();

            //Act
           var result = reservation.CanBeCancelledBy(new User { isAdmin = true });

            //Assert
            Assert.IsTrue(result);
        }


        [TestMethod]
        //Naming convention for TestMethod  e.g MethodNameToBeTested_Scenario_ExpectedBehaviour
        public void CanBeCancelledBy_User_ReturnsTrue()
        {
            //Arrange
            //Initialize te objects
            var user = new User();
            var reservation = new Reservation();
            reservation.MadeBy = user;

            //Act
            var result = reservation.CanBeCancelledBy(user);

            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        //Naming convention for TestMethod  e.g MethodNameToBeTested_Scenario_ExpectedBehaviour
        public void CanBeCancelledBy_NonAuthorizedScenario_ReturnsFalse()
        {
            ////Arrange
            ////Initialize te objects
            //var reservation = new Reservation();
            //var user = new User();
            ////Act
            //if ((reservation.MadeBy != user) || (!user.isAdmin)  )
            //{
            //    var result = reservation.CanBeCancelledBy(user);
            //    //Assert
            //    Assert.IsFalse(result);
            //}

            var reservation = new Reservation();

            var result = reservation.CanBeCancelledBy(new User());

            Assert.IsFalse(result);
        }
    }
}
