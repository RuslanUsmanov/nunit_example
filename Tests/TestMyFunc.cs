using example;

namespace Tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void TestSum()
    {
        Assert.AreEqual(MyFunc.Sum(1, 5), 6);
    }

    [Test]
    public void TestFail()
    {
        Assert.Fail();
    }
}
