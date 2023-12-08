using NUnit.Framework;
using System;

namespace Katas.UnitTests;

[TestFixture]
public class SortingTests
{
    [Test]
    public void GivenInputIsEmptyArray_ThenInputIsReturned()
    {
        var array = Array.Empty<int>();
        Sorting.BubbleSort(array);
        Assert.That(array, Is.Empty);
    }

    [Test]
    public void GivenInputIsSingleElement_ThenInputIsReturned()
    {
        var array = new[] { 1 };
        Sorting.BubbleSort(array);
        Assert.That(array, Is.EqualTo(new[] { 1 }));
    }

    [Test]
    public void GivenInputIsSortedArray_ThenInputIsReturned()
    {
        var array = new[] { 1, 2, 3, 4, 5 };
        Sorting.BubbleSort(array);
        Assert.That(array, Is.EqualTo(new[] { 1, 2, 3, 4, 5 }));
    }

    [Test]
    public void GivenInputIsUnsortedArray_ThenSortedInputIsReturned()
    {
        var array = new[] { 5, 3, 2, 4, 1 };
        Sorting.BubbleSort(array);
        Assert.That(array, Is.EqualTo(new[] { 1, 2, 3, 4, 5 }));
    }

    [Test]
    public void GivenInputIsArrayWithDuplicates_ThenSortedInputIsReturned()
    {
        var array = new[] { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5 };
        Sorting.BubbleSort(array);
        Assert.That(array, Is.EqualTo(new[] { 1, 1, 2, 3, 3, 4, 5, 5, 5, 6, 9 }));
    }
}