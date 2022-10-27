using CashMachines.Exceptions;
using CashMachines.Models;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CashMachines.Tests
{
    [TestClass]
    public class UserTests
    {
        private User _user;

        [TestMethod]
        public void UserCreation_IdAndAccountBalanceSetCorrectly()
        {
            //Arrange
            _user = new User(123, 0);

            //Assert
            _user.Id.Should().Be(123);
            _user.AccountBalance.Should().Be(0);
        }

        public void UserCreation_NegativeAccountBalance_ThrowsInvalidBalanceException()
        {
            //Act
            Action act = () => new User(123, -1000);

            //Assert
            act.Should().Throw<InvalidBalanceException>()
                .WithMessage("Amount should be greater than 0");
        }
    }
}
