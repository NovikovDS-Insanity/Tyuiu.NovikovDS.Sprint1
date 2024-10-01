using Tyuiu.NovikovDS.Sprint1.Task4.V17.Lib;

namespace Tyuiu.NovikovDS.Sprint1.Task4.V17.Test;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void TestMethod()
    {
        DataService ds = new();
        double x = 9;
        double y = 1;
        var res = ds.Calculate(x, y);
        Assert.AreEqual(0.5, res);
    }
}
