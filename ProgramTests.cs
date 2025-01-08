using NUnit.Framework;

/// <summary>
/// Test suite for testing the IsPalindrome method in the Program class.
/// </summary>
[TestFixture]
public class ProgramTests
{
    /// <summary>
    /// Tests if IsPalindrome correctly identifies a simple palindrome string.
    /// </summary>
    [Test]
    public void IsPalindrome_SimplePalindrome_ReturnsTrue()
    {
        // Arrange
        string input = "radar";

        // Act
        bool result = Program.IsPalindrome(input);

        // Assert
        Assert.IsTrue(result);
    }

    /// <summary>
    /// Tests if IsPalindrome correctly identifies a complex palindrome string
    /// with special characters and spaces.
    /// </summary>
    [Test]
    public void IsPalindrome_ComplexPalindromeWithSpecialCharacters_ReturnsTrue()
    {
        // Arrange
        string input = "A man, a plan, a canal: Panama!";

        // Act
        bool result = Program.IsPalindrome(input);

        // Assert
        Assert.IsTrue(result);
    }

    /// <summary>
    /// Tests if IsPalindrome correctly identifies a non-palindrome string.
    /// </summary>
    [Test]
    public void IsPalindrome_NotPalindrome_ReturnsFalse()
    {
        // Arrange
        string input = "hello";

        // Act
        bool result = Program.IsPalindrome(input);

        // Assert
        Assert.IsFalse(result);
    }

    /// <summary>
    /// Tests if IsPalindrome correctly handles an empty string as a palindrome.
    /// </summary>
    [Test]
    public void IsPalindrome_EmptyString_ReturnsTrue()
    {
        // Arrange
        string input = "";

        // Act
        bool result = Program.IsPalindrome(input);

        // Assert
        Assert.IsTrue(result);
    }

    /// <summary>
    /// Tests if IsPalindrome correctly identifies a single character string as a palindrome.
    /// </summary>
    [Test]
    public void IsPalindrome_SingleCharacter_ReturnsTrue()
    {
        // Arrange
        string input = "a";

        // Act
        bool result = Program.IsPalindrome(input);

        // Assert
        Assert.IsTrue(result);
    }

    /// <summary>
    /// Tests if IsPalindrome correctly handles a string consisting only of special characters.
    /// </summary>
    [Test]
    public void IsPalindrome_StringWithOnlySpecialCharacters_ReturnsTrue()
    {
        // Arrange
        string input = "!!!";

        // Act
        bool result = Program.IsPalindrome(input);

        // Assert
        Assert.IsTrue(result);
    }

    /// <summary>
    /// Tests if IsPalindrome correctly identifies a palindrome string with mixed case letters.
    /// </summary>
    [Test]
    public void IsPalindrome_PalindromeWithMixedCase_ReturnsTrue()
    {
        // Arrange
        string input = "RaceCar";

        // Act
        bool result = Program.IsPalindrome(input);

        // Assert
        Assert.IsTrue(result);
    }

    /// <summary>
    /// Tests if IsPalindrome correctly identifies a long palindrome string.
    /// </summary>
    [Test]
    public void IsPalindrome_LongPalindrome_ReturnsTrue()
    {
        // Arrange
        string input = "Able was I ere I saw Elba";

        // Act
        bool result = Program.IsPalindrome(input);

        // Assert
        Assert.IsTrue(result);
    }

    /// <summary>
    /// Tests if IsPalindrome correctly identifies a long non-palindrome string.
    /// </summary>
    [Test]
    public void IsPalindrome_LongNonPalindrome_ReturnsFalse()
    {
        // Arrange
        string input = "This is not a palindrome";

        // Act
        bool result = Program.IsPalindrome(input);

        // Assert
        Assert.IsFalse(result);
    }
}
