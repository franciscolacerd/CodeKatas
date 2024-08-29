using FluentAssertions;

namespace CodeKatasTests
{
    public class ValidateAnagramTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Should_ValidateAnagram_ReturnTrue()
        {
            //Arrange
            var firstString = "anagram";
            var secondString = "nagaram";

            //Act
            var result = ValidateAnagram(firstString, secondString);

            //Assert
            result.Should().BeTrue();
        }

        [Test]
        public void Should_ValidateAnagram_ReturnFalse()
        {
            //Arrange
            var firstString = "anawqwqwqwqgram";
            var secondString = "nagaram";

            //Act
            var result = ValidateAnagram(firstString, secondString);

            //Assert
            result.Should().BeFalse();
        }

        private bool ValidateAnagram(string firstString, string secondString)
        {
            var firstWordDict = ToDictionary(firstString);

            var secondWordDict = ToDictionary(secondString);

            return !firstWordDict.Except(secondWordDict).Any() &&
                   !secondWordDict.Except(firstWordDict).Any();
        }

        private Dictionary<char, int> ToDictionary(string word)
        {
            var result = new Dictionary<char, int>();

            for (var i = 0; i < word.Length; i++)
            {
                if (result.ContainsKey(word[i]))
                {
                    result[word[i]]++;
                }
                else
                {
                    result.Add(word[i], 1);
                }
            }

            return result;
        }
    }
}
