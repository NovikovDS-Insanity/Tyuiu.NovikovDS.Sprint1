using Tyuiu.NovikovDS.Sprint1.Task5.V3.Lib;

namespace Tyuiu.NovikovDS.Sprint1.Task5.V3.Test;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void TestMethod()
    {
        DataService ds = new();
        int k = 9234234;
        var res = ds.Calculate(k);
        Assert.AreEqual(2, res);
    }
}
