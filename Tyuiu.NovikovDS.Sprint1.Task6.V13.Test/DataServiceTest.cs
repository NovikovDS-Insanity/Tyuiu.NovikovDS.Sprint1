using Tyuiu.NovikovDS.Sprint1.Task6.V13.Lib;

namespace Tyuiu.NovikovDS.Sprint1.Task6.V13.Test;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void TestMethod()
    {
        DataService ds = new();
        string k = "abcde";
        var res = ds.CheckWordsAlphabet(k);
        Assert.AreEqual(true, res);
    }
}
