using NUnit.Framework;

namespace Katas.UnitTests;

[TestFixture]
public class PalindromeTests
{
    [TestCase("racecar")]
    [TestCase("Racecar")]
    [TestCase("A man, a plan, a canal, Panama")]
    [TestCase("")]
    [TestCase(" ")]
    [TestCase("1234321")]
    public void GivenInputIsPalindrome_ThenTrueIsReturned(string input)
    {
        var result = Palindromes.IsPalindrome(input);
        Assert.That(result, Is.True);
    }

    [TestCase("no palindrome")]
    [TestCase("1234322")]
    public void GivenInputIsNotPalindrome_ThenFalseIsReturned(string input)
    {
        var result = Palindromes.IsPalindrome(input);
        Assert.That(result, Is.False);
    }
}