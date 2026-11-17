using FluentAssertions;

namespace CodelandUserName.Tests
{
    [TestClass]
    public sealed class CodelandUsernameValidationTests
    {
        const string invalid = "false";
        const string valid = "true";

        [TestMethod]
        public void ReturnsValidWhenUsernameIsWhitespaceOnly()
        {
            // Arrange

            // Act
            var result = CodelandUsername.MainClass.CodelandUsernameValidation(string.Empty);

            // Assert
            result.Should().Be(valid);
        }

        [TestMethod]
        public void ReturnsInvalidWhenUsernameIsLessThanThreeCharacters()
        {
            // Arrange

            // Act
            var result = CodelandUsername.MainClass.CodelandUsernameValidation("123");

            // Assert
            result.Should().Be(invalid);
        }

        [TestMethod]
        public void ReturnsValidWhenUsernameIsFourCharacters()
        {
            // Arrange

            // Act
            var result = CodelandUsername.MainClass.CodelandUsernameValidation("a234");

            // Assert
            result.Should().Be(valid);
        }

        [TestMethod]
        public void ReturnsInvalidWhenUsernameIsMoreThanTwentyFiveCharacters()
        {
            // Arrange

            // Act
            var result = CodelandUsername.MainClass.CodelandUsernameValidation("01234567890123456789123456");

            // Assert
            result.Should().Be(invalid);
        }

        [TestMethod]
        public void ReturnsValidWhenUsernameIsTwentyFiveCharacters()
        {
            // Arrange

            // Act
            var result = CodelandUsername.MainClass.CodelandUsernameValidation("z123456789012345678912345");

            // Assert
            result.Should().Be(valid);
        }

        [TestMethod]
        public void ReturnsInvalidWhenUsernameDoesNotStartWithALetter()
        {
            // Arrange

            // Act
            var result = CodelandUsername.MainClass.CodelandUsernameValidation("5username");

            // Assert
            result.Should().Be(invalid);
        }

        [TestMethod]
        public void ReturnsInvalidWhenUsernameContainsAnInvalidCharacter()
        {
            // Arrange

            // Act
            var result = CodelandUsername.MainClass.CodelandUsernameValidation("Username$");

            // Assert
            result.Should().Be(invalid);
        }

        [TestMethod]
        public void ReturnsInvalidWhenUsernameEndsWithUnderscore()
        {
            // Arrange

            // Act
            var result = CodelandUsername.MainClass.CodelandUsernameValidation("Username123_");

            // Assert
            result.Should().Be(invalid);
        }
    }
}
