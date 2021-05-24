using DecimalToRomanConsoleApp.Models;
using Xunit;

namespace DecimalToRomanTests.Models
{
    public class SuperIntegerTests
    {
        [Fact]
        public void ConvertToRoman_Should_Return_Roman_Number()
        {
            var number = 4;
            const string ExpectedResult = "IV";

            var result = SuperInteger.ConvertToRoman(number);

            Assert.Equal(result, ExpectedResult);
        }
    }
}