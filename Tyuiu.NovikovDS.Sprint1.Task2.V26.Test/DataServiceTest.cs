using Tyuiu.NovikovDS.Sprint1.Task2.V26.Lib;

namespace Tyuiu.NovikovDS.Sprint1.Task2.V26.Test;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void TestMethod()
    {
        DataService ds = new();
        int x = 2;
        int y = 30;
        var res = ds.CalculateMinutesSinceStart(x, y);
        Assert.AreEqual(150, res);
    }
}
