using Calculator;
using Xunit;

namespace CalculatorTests
{
    public class CalculatronTest
    {
        private readonly Calculatron _sut;

        public CalculatronTest()
        {
            _sut = new Calculatron();
        }
        
        [Fact]
        public void GivenXY_WhenAdding_ThenReturnSum()
        {
            var x = 3;
            var y = 7;

            var result = _sut.Add(x, y);
            
            Assert.Equal(10, result);
        }
    }
}