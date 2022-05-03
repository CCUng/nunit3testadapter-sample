using Lib;
using NUnit.Framework;

namespace Test;

public class Tests
{
    [Test]
    public void Test1()
    {
        var sut = new Class1();
        Assert.AreEqual(8, sut.Sum(3, 5));
    }
}