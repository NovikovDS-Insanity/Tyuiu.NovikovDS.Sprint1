using Tyuiu.NovikovDS.Sprint1.Task1.V5.Lib;

namespace Tyuiu.NovikovDS.Sprint1.Task1.V5.Test;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void TestMethod()
    {
        DataService ds = new();
        double x = 1.0;
        double y = 3.0;
        var res = ds.Calculate(x, y);
        Assert.AreEqual(2, res);
    }
}
