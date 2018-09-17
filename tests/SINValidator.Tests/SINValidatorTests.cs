using Xunit;

namespace SINValidator.Tests
{
    public class SINValidatorTests
    {
        //Dois returner true
        [Theory]
        [InlineData(346232051)]
        [InlineData(242793008)]
        [InlineData(500003231)]
        public void SinValid(int number)
        {
            //Fake SIN, mais vrai matematique
            var result = new SIN(number).Validate();
            Assert.True(result);
        }

        //Dois returner false
        [Theory]
        [InlineData(143001859)]
        [InlineData(111111111)]
        [InlineData(999999999)]
        [InlineData(1)]
        [InlineData(123)]
        public void SinInvalid(int number)
        {
            //Fake SIN, mais faux matematique
            var result = new SIN(number).Validate();
            Assert.False(result);
        }
    }
}
