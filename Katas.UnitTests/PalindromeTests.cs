using NUnit.Framework;

namespace Katas.UnitTests;

[TestFixture]
public class PalindromeTests
{
    [TestCase("racecar")]
    [TestCase("RacecaR")]
    [TestCase("")]
    [TestCase(" ")]
    [TestCase("1234321")]
    public void GivenInputIsPalindrome_ThenTrueIsReturned(string input)
    {
        var result = Palindromes.IsPalindrome(input);
        Assert.That(result, Is.True);
    }

    [TestCase("no palindrome")]
    [TestCase("racebar")]
    [TestCase("1234322")]
    public void GivenInputIsNotPalindrome_ThenFalseIsReturned(string input)
    {
        var result = Palindromes.IsPalindrome(input);
        Assert.That(result, Is.False);
    }

    [TestCase("#k@a$y%a£k-")]
    [TestCase("Racecar")]
    [TestCase("UFO tofu")]
    [TestCase("Borrow or rob?")]
    [TestCase("Eva, can I see bees in a cave?")]
    [TestCase("A man, a plan, a canal, Panama")]
    public void GivenInputIsComplexPalindrome_ThenTrueIsReturned(string input)
    {
        var result = Palindromes.IsPalindrome(input);
        Assert.That(result, Is.True);
    }
}