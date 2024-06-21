using FluentAssertions;

namespace CodeKatasTests
{
    public class ValidatePalindromeTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Should_ValidatePalindrome_ReturnTrue()
        {
            //Arrange
            var phrase = "Cigar? Toss it in a can. It is so tragic.";

            //Act
            var result = ValidatePalindrome(phrase);

            //Assert
            result.Should().BeTrue();
        }

        [Test]
        public void Should_ValidateNonPalindrome_ReturnTrue()
        {
            //Arrange
            var phrase = "sfdsfdfdfdfdffffffffffff";

            //Act
            var result = ValidatePalindrome(phrase);

            //Assert
            result.Should().BeFalse();
        }

        private bool ValidatePalindrome(string phrase)
        {
            var left = 0;

            var right = phrase.Length - 1;

            while (left < right)
            {
                if (!char.IsLetterOrDigit(phrase[left]))
                {
                    left++;
                    continue;
                }

                if (!char.IsLetterOrDigit(phrase[right]))
                {
                    right--;
                    continue;
                }

                if (char.ToLower(phrase[left++]) != char.ToLower(phrase[right--])) return false;
            }

            return true;
        }
    }
}
