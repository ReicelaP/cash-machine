using CashMachines.Exceptions;
using CashMachines.Models;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CashMachines.Tests
{
    [TestClass]
    public class CashMachineTests
    {
        private User _user;
        private CashMachine _cashMachine;

        [TestInitialize]
        public void Setup()
        {
            _user = new User(123, 0);
            _cashMachine = new CashMachine(_user);
        }

        [TestMethod]
        public void Insert_ValidCash_AccountBalanceUpdatesCorrectly()
        {
            //Arrange
            int[] cash = { 5, 10, 20 };
            
            //Act
            _cashMachine.Insert(cash);

            //Assert
            _user.AccountBalance.Should().Be(35);
        }

        [TestMethod]
        public void Insert_NotValidCash_ThrowsInvalidCashException()
        {
            //Arrange
            int[] cash = { 5, 13, 20 };

            //Act
            Action act = () => _cashMachine.Insert(cash);

            //Assert
            act.Should().Throw<InvalidCashException>()
                .WithMessage("Machine accepts only 5, 10, 20, 50, 100 notes");
        }

        [TestMethod]
        public void Withdraw_InvalidAmount_ThrowsInvalidAmountException()
        {
            //Arrange
            _cashMachine.Insert(new int[] { 100 });

            //Act
            Action act = () => _cashMachine.Withdraw(7);

            //Assert
            act.Should().Throw<InvalidAmountException>()
                .WithMessage("Requested amount 7 is invalid");
        }

        [TestMethod]
        public void Withdraw_SufficientBalance_ReturnExpectedAmount()
        {
            //Arrange
            _cashMachine.Insert(new int[] { 100 });

            //Act
            var result = _cashMachine.Withdraw(20);

            //Assert
            result.Should().Be(20);
            _user.AccountBalance.Should().Be(80);
        }

        [TestMethod]
        public void Withdraw_InsufficientBalance_ThrowsInsufficientBalanceException()
        {
            //Arrange
            _cashMachine.Insert(new int[] { 100 });

            //Act
            Action act = () => _cashMachine.Withdraw(200);

            //Assert
            act.Should().Throw<InsufficientBalanceException>()
                .WithMessage("Account balance is less than 200");
        }
    }
}
