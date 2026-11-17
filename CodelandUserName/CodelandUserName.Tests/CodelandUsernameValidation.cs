using FluentAssertions;

namespace CodelandUserName.Tests
{
    [TestClass]
    public sealed class CodelandUsernameValidationTests
    {
        const string valid = "true";

        [TestMethod]
        public void ReturnsTrueWhenUsernameIsWhitespaceOnly()
        {
            // Arrange

            // Act
            var result = CodelandUsername.MainClass.CodelandUsernameValidation(string.Empty);

            // Assert
            result.Should().Be(valid);
        }
    }
}
