using System;
using Xunit;

namespace web.core.tests
{
    public class DomainTests
    {
        [Fact]
        public void WhenThatShouldDoThat()
        {
            //Arrange
            var objectUnderTest = new Domain();

            //Act
            var result = objectUnderTest.Method1();

            //Assert

            Assert.False(result);

        }

        [Fact]
        public void WhenThatShouldNotDoThat()
        {
            //Arrange
            var objectUnderTest = new Domain();

            //Act
            var result = objectUnderTest.Method1();

            //Assert

            Assert.True(result);

        }
    }
}
