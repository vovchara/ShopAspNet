using Shop.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Shop.Tests
{
    public class MathUtilTest
    {
        [Fact]
        public void FactorialShouldReturnCorrectForFive()
        {
            //Arrange
            //Act
            var result = MathUtil.Factorial(5);

            //Assert
            Assert.Equal(120, result);
        }

        [Fact]
        public void FactorialShouldReturnCorrectForOne()
        {
            //Arrange
            //Act
            var result = MathUtil.Factorial(1);

            //Assert
            Assert.Equal(1, result);
        }
    }
}
