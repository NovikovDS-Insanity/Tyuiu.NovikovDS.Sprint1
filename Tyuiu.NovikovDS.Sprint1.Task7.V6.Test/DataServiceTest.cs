using Tyuiu.NovikovDS.Sprint1.Task7.V6.Lib;

namespace Tyuiu.NovikovDS.Sprint1.Task7.V6.Test;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void TestMethod()
    {
        DataService ds = new();
        double x = 1, y = 1;
        var res = ds.Calculate(x, y);
        Assert.AreEqual(-10, res);
    }
}
