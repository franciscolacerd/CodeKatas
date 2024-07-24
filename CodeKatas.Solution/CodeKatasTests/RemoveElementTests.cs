using FluentAssertions;

namespace CodeKatasTests
{
    public class RemoveElementTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void should_RemoveElement_ReturnNrOfElementsRemaining()
        {
            //arrange
            var nums = new int[] { 0, 1, 2, 2, 3, 0, 4, 2 };
            var val = 2;

            //act

            int result = RemoveElement(nums, val);

            //assert
            result.Should().Be(5);
        }

        private int RemoveElement(int[] nums, int val)
        {
            var count = 0;

            for (var i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                    nums[count++] = nums[i];
            }

            return count;
        }
    }
}