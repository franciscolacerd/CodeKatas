using FluentAssertions;

namespace CodeKatasTests
{
    public class RemoveDuplicatesFromSortedArrayTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Should_RemoveDuplicatesFromSortedArray_ReturnNumberUniqueElements()
        {
            //Arrange
            var numbers = new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };

            //Act

            var result = RemoveDuplicatesFromSortedArray(numbers);

            //Assert
            result.Should().Be(5);
        }

        private int RemoveDuplicatesFromSortedArray(int[] numbers)
        {
            var j = 0;
            var dic = new HashSet<int>();

            for (var i = 0; i < numbers.Length; i++)
            {
                if (!dic.Contains(numbers[i]))
                {
                    dic.Add(numbers[i]);
                    numbers[j] = numbers[i];
                    j++;
                }
            }

            return j;
        }
    }
}