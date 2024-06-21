using FluentAssertions;

namespace CodeKatasTests
{
    public class MergeSortedArrayTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Should_MergeSortedArray_1_ReturnArray()
        {
            //Arrange
            var nums1 = new int[] { 1, 2, 3, 0, 0, 0 };
            var nums2 = new int[] { 2, 5, 6 };

            int m = 3;
            int n = 3;

            //Act
            var result = MergeSortedArray(nums1, m, nums2, n);

            //Assert
            result.Should().Equal(new int[] { 1, 2, 2, 3, 5, 6 });
        }

        [Test]
        public void Should_MergeSortedArray_2_ReturnArray()
        {
            //Arrange
            var nums1 = new int[] { 2, 11, 322, 0, 0, 0, 0 };
            var nums2 = new int[] { 5, 22, 66, 345 };

            int m = 3;
            int n = 4;

            //Act
            var result = MergeSortedArray(nums1, m, nums2, n);

            //Assert
            result.Should().Equal(new int[] { 2, 5, 11, 22, 66, 322, 345 });
        }

        private int[] MergeSortedArray(int[] nums1, int m, int[] nums2, int n)
        {
            var index1 = m -1;
            var index2 = n - 1;
            var totalIndex = (m + n) - 1;

            while (index2 >= 0)
            {
                if (index1 >= 0 && nums1[index1] > nums2[index2])
                    nums1[totalIndex--] = nums1[index1--];
                else
                    nums1[totalIndex--] = nums2[index2--];
            }

            return nums1;
        }
    }
}
