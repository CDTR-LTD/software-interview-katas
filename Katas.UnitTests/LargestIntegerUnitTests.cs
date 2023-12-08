using NUnit.Framework;
using System;

namespace Katas.UnitTests;

[TestFixture]
public class LargestIntegerUnitTests
{
    [Test]
    public void GivenInputIsEmpty_ThenZeroIsReturned()
    {
        var array = Array.Empty<int>();
        var result = LargestInteger.FindLargestInteger(array);
        Assert.That(0, Is.EqualTo(result));
    }

    [Test]
    public void GivenInputIsSingleElement_ThenElementIsReturned()
    {
        var array = new[] { 5 };
        var result = LargestInteger.FindLargestInteger(array);
        Assert.That(5, Is.EqualTo(result));
    }

    [Test]
    public void GivenInputIsMultipleElements_ThenLargestIsReturned()
    {
        var array = new[] { 1, 3, 2 };
        var result = LargestInteger.FindLargestInteger(array);
        Assert.That(3, Is.EqualTo(result));
    }

    [Test]
    public void GivenInputIsNegativeElements_ThenLargestIsReturned()
    {
        var array = new[] { -3, -1, -2 };
        var result = LargestInteger.FindLargestInteger(array);
        Assert.That(-1, Is.EqualTo(result));
    }

    [Test]
    public void GivenInputIsMixedElements_ThenLargestIsReturned()
    {
        var array = new[] { -1, 5, 3, 2, 0 };
        var result = LargestInteger.FindLargestInteger(array);
        Assert.That(5, Is.EqualTo(result));
    }

    [Test]
    public void GivenInputIsAllMinValue_ThenMinValueIsReturned()
    {
        var array = new[] { int.MinValue, int.MinValue, int.MinValue };
        var result = LargestInteger.FindLargestInteger(array);
        Assert.That(int.MinValue, Is.EqualTo(result));
    }
}