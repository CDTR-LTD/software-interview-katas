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
        Assert.That(result, Is.EqualTo(0));
    }

    [Test]
    public void GivenInputIsSingleElement_ThenElementIsReturned()
    {
        var array = new[] { 5 };
        var result = LargestInteger.FindLargestInteger(array);
        Assert.That(result, Is.EqualTo(5));
    }

    [Test]
    public void GivenInputIsMultipleElements_ThenLargestIsReturned()
    {
        var array = new[] { 1, 3, 2 };
        var result = LargestInteger.FindLargestInteger(array);
        Assert.That(result, Is.EqualTo(3));
    }

    [Test]
    public void GivenInputIsNegativeElements_ThenLargestIsReturned()
    {
        var array = new[] { -3, -1, -2 };
        var result = LargestInteger.FindLargestInteger(array);
        Assert.That(result, Is.EqualTo(-1));
    }

    [Test]
    public void GivenInputIsMixedElements_ThenLargestIsReturned()
    {
        var array = new[] { -1, 5, 3, 2, 0 };
        var result = LargestInteger.FindLargestInteger(array);
        Assert.That(result, Is.EqualTo(5));
    }

    [Test]
    public void GivenFirstElementIsLargest_ThenLargestIsReturned()
    {
        var array = new[] { 10, 5, 3, 2, 0, -int.MaxValue };
        var result = LargestInteger.FindLargestInteger(array);
        Assert.That(result, Is.EqualTo(10));
    }

    [Test]
    public void GivenInputIsAllMinValue_ThenMinValueIsReturned()
    {
        var array = new[] { int.MinValue, int.MinValue, int.MinValue };
        var result = LargestInteger.FindLargestInteger(array);
        Assert.That(result, Is.EqualTo(int.MinValue));
    }
}