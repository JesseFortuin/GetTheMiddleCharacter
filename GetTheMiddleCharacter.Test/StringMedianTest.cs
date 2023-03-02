using GetTheMiddleCharacter.BL;

namespace GetTheMiddleCharacter.Test
{
    public class StringMedianTest
    {
        [Theory]
        [InlineData("Test", "es")]
        [InlineData("Testing", "t")]
        [InlineData("Middle", "dd")]
        [InlineData("A", "A")]

        public void GetMiddleTest(string input, string expected)
        {
            //arrange
            StringMedian median = new StringMedian();

            //act
            string actual = median.GetMiddle(input);

            //assert
            Assert.Equal(expected, actual);
        }
    }
}