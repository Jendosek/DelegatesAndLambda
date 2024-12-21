namespace UnitTests;

[TestClass]
public class UnitTest2
{
    [TestMethod]
    public void TestMethod1()
    {
        Assert.AreEqual(4, DelegatesAndLambda.Prac2.Square(2));
        Assert.AreEqual(9, DelegatesAndLambda.Prac2.Square(3));
    }
}