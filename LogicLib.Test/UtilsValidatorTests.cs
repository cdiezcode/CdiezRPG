using System;
using LogicLib.Utils;
using Xunit;

namespace LogicLib.Test
{
    public class UtilsValidatorTests
    {
        [Fact]
        public void ValidationPassedIfStringIsIntInDefaultRange()
        {
            bool actualResult = Validator.ValidateStringToIntInRange("1", out int result);
            
            Assert.True(actualResult);
        }
        
        [Fact]
        public void OutResultIsIntInDefaultRange()
        {
            Validator.ValidateStringToIntInRange("1", out int result);
            bool actualResult = result >= 1 && result <= 3;

            Assert.True(actualResult);
        }
        
        [Fact]
        public void ValidationPassedIfStringIsIntInCustomRange()
        {
            bool actualResult = Validator.ValidateStringToIntInRange("5", out int result, 2, 10);

            Assert.True(actualResult);
        }
        
        [Fact]
        public void OutResultIsIntInCustomRange()
        {
            Validator.ValidateStringToIntInRange("3", out int result, 2, 10);
            bool actualResult = result >= 2 && result <= 10;

            Assert.True(actualResult);
        }
        
        [Fact]
        public void ValidationFailedIfStringIsIntNotInDefaultRange()
        {
            bool actualResult = Validator.ValidateStringToIntInRange("12", out int result);
            
            Assert.False(actualResult);
        }
        
        [Fact]
        public void ValidationFailedIfStringIsIntNotInCustomRange()
        {
            bool actualResult = Validator.ValidateStringToIntInRange(
                "543", out int result, 2, 10);

            Assert.False(actualResult);
        }
        
        [Fact]
        public void ValidationFailedIfStringIsNotInt()
        {
            bool actualResult = Validator.ValidateStringToIntInRange(
                "not an integer", out int result);

            Assert.False(actualResult);
        }
    }
}