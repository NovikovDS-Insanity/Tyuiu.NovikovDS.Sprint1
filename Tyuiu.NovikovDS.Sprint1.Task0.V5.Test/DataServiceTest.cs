using Tyuiu.NovikovDS.Sprint1.Task0.V5.Lib;

namespace Tyuiu.NovikovDS.Sprint1.Task0.V5.Test;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void TestMethod()
    {
        DataService ds = new();
        var res = ds.Calculate();
        Assert.AreEqual(12, res);
    }
}
