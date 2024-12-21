namespace UnitTests;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestMethod1()
    {
        Assert.AreEqual(1, DelegatesAndLambda.Parc1.IsEven(2));
        Assert.AreEqual(0, DelegatesAndLambda.Parc1.IsEven(3));
    }
}