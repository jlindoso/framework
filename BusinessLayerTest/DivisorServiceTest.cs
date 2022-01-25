using businesslayer;
using Xunit;

namespace BusinessLayerTest
{
    public class DivisorServiceTest
    {
        public DivisorService _divisorService { get; set; }


        public DivisorServiceTest()
        {
            _divisorService = new DivisorService();
        }

        
        [Theory]
        [InlineData(2)]
        [InlineData(5)]
        [InlineData(7)]

        public void IsPrimeNumber_ReturnTrue(long number)
        {
            Assert.True(_divisorService.IsPrimeNumber(number));
        }

        [Theory]
        [InlineData(20)]
        [InlineData(60)]
        [InlineData(70)]
        public void IsNotPrimeNumber_ReturnFalse(long number)
        {
            Assert.False(_divisorService.IsPrimeNumber(number));
        }


        //input, totalDivisors
        [Theory]
        [InlineData(9, 3)]
        [InlineData(45, 6)]
        [InlineData(10000000000, 121)]
        public void GetTotalOfDivisors_ReturnTrue(long number, long expected)
        {
            Assert.Equal(expected,  _divisorService.GetDivisors(number).DivisorsList.Count);
        }



    }
}