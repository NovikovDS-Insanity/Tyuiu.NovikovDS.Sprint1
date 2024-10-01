using Tyuiu.NovikovDS.Sprint1.Task3.V5.Lib;

namespace Tyuiu.NovikovDS.Sprint1.Task3.V5.Test;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void TestMethod()
    {
        DataService ds = new();
        double x = 200;
        double y = 3;
        var res = ds.DistanceLength(x, y);
        Assert.AreEqual(600, res);
    }
}
