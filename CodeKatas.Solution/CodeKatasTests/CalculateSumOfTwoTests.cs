using FluentAssertions;

namespace CodeKatasTests
{
    public class CalculateSumOfTwoTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Should_CalculateSumOfTwo_Target_11_ReturnTrue()
        {
            //Arrange
            var target = 11;

            var numbers = new int[] { 1, 2, 9, 0, -1 };

            //Act

            var result = CalculateSumOfTwo(target, numbers);

            //Assert
            result[0].Should().Be(1);
            result[1].Should().Be(2);
        }

        [Test]
        public void Should_CalculateSumOfTwo_Target_99_ReturnTrue()
        {
            //Arrange
            var target = 99;

            var numbers = new int[] { 1, 2, 9, 0, -1, 1, 97 };

            //Act

            var result = CalculateSumOfTwo(target, numbers);

            //Assert
            result[0].Should().Be(1);
            result[1].Should().Be(6);
        }

        [Test]
        public void Should_CalculateSumOfTwo_Target_32_ReturnTrue()
        {
            //Arrange
            var target = 32;

            var numbers = new int[] { 2, 1, 1, 1, 1, 1, 0, -1 };

            //Act
            var result = CalculateSumOfTwo(target, numbers);

            //Assert
            result.Should().BeEmpty();
        }

        private int[] CalculateSumOfTwo(int target, int[] numbers)
        {
            var dict = new Dictionary<int, int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                var complement = target - numbers[i];

                if (dict.ContainsKey(complement))
                {
                    return new int[] { dict[complement], i };
                }
                else
                {
                    if (!dict.ContainsKey(numbers[i]))
                    {
                        dict.Add(numbers[i], i);
                    }
                }
            }

            return new int[0];
        }
    }
}